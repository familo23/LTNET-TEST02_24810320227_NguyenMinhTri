using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai5
{
    public partial class Form1 : Form
    {
        private readonly BindingList<IoTLogModel> logList;
        private readonly BindingSource bindingSource;

        private CancellationTokenSource? cts;
        private int cycleCount = 0;

        public Form1()
        {
            InitializeComponent();

            logList = new BindingList<IoTLogModel>();
            bindingSource = new BindingSource { DataSource = logList };

            SetupDataGridView();

            btnStart.Click += BtnStart_Click;
            btnStop.Click += BtnStop_Click;

            this.FormClosing += Form1_FormClosing;
        }

        private void SetupDataGridView()
        {
            dgvLogs.AutoGenerateColumns = false;
            dgvLogs.Columns.Clear();

            dgvLogs.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Timestamp", HeaderText = "Thời Gian", Width = 180 });
            dgvLogs.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Temperature", HeaderText = "Nhiệt Độ (°C)", Width = 150, DefaultCellStyle = new DataGridViewCellStyle { Format = "N1" } });
            dgvLogs.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Trạng Thái Cảnh Báo", Width = 250 });

            dgvLogs.DataSource = bindingSource;
        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;

            cycleCount = 0;
            lblConnectionStatus.Text = "Trạng thái: Đang kết nối...  |  ";
            lblCycleCount.Text = "Số chu kỳ nhận: 0";

            cts = new CancellationTokenSource();
            var token = cts.Token;

            Task.Run(() => SensorTaskLoop(token), token);
        }

        private void BtnStop_Click(object? sender, EventArgs e)
        {
            StopMonitoring();
        }

        private void StopMonitoring()
        {
            if (cts != null && !cts.IsCancellationRequested)
            {
                cts.Cancel();
            }

            btnStart.Enabled = true;
            btnStop.Enabled = false;
            lblConnectionStatus.Text = "Trạng thái: Đã dừng  |  ";
        }

        private void SensorTaskLoop(CancellationToken token)
        {
            Random rand = new Random();

            try
            {
                while (!token.IsCancellationRequested)
                {
                    double temp = Math.Round(30.0 + (rand.NextDouble() * 12.0), 1);
                    cycleCount++;

                    if (this.InvokeRequired)
                    {
                        this.Invoke(new Action(() => UpdateUI(temp, cycleCount)));
                    }
                    else
                    {
                        UpdateUI(temp, cycleCount);
                    }

                    Thread.Sleep(2000);
                }
            }
            catch (OperationCanceledException)
            {
            }
        }

      
        private void UpdateUI(double temp, int cycles)
        {
            lblTemperature.Text = $"{temp:F1} °C";

            if (temp > 37.0)
            {
                lblTemperature.ForeColor = Color.Red;
            }
            else
            {
                lblTemperature.ForeColor = Color.Green;
            }

            lblConnectionStatus.Text = "Trạng thái: Đang hoạt động  |  ";
            lblCycleCount.Text = $"Số chu kỳ nhận: {cycles}";

            string statusMsg = temp > 37.0 ? "CẢNH BÁO: Vượt ngưỡng!" : "Bình thường";
            logList.Insert(0, new IoTLogModel
            {
                Timestamp = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy"),
                Temperature = temp,
                Status = statusMsg
            });
        }

        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            StopMonitoring();
        }
    }
}