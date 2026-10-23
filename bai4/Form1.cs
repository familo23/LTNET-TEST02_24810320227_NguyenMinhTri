using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai4
{
    public partial class Form1 : Form
    {
        private readonly BindingList<WarehouseReportModel> reportList;
        private readonly BindingSource bindingSource;
        private CancellationTokenSource? cts;

        public Form1()
        {
            InitializeComponent();

            reportList = new BindingList<WarehouseReportModel>();
            bindingSource = new BindingSource { DataSource = reportList };

            SetupDataGridView();

            btnAnalytics.Click += BtnAnalytics_Click;
            btnCancel.Click += BtnCancel_Click;

            this.Load += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            if (cboWarehouse.Items.Count > 0) cboWarehouse.SelectedIndex = 0;
        }

        private void SetupDataGridView()
        {
            dgvReportData.AutoGenerateColumns = false;
            dgvReportData.Columns.Clear();

            dgvReportData.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ItemCode", HeaderText = "Mã Sản Phẩm", Width = 110 });
            dgvReportData.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ItemName", HeaderText = "Tên Sản Phẩm", Width = 210 });
            dgvReportData.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "WarehouseName", HeaderText = "Kho Hàng", Width = 130 });
            dgvReportData.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StockQuantity", HeaderText = "Tồn Kho", Width = 90, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" } });
            dgvReportData.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "UnitPrice", HeaderText = "Đơn Giá", Width = 120, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" } });
            dgvReportData.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TotalValue", HeaderText = "Tổng Giá Trị", Width = 150, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" } });

            dgvReportData.DataSource = bindingSource;
        }

        private async void BtnAnalytics_Click(object? sender, EventArgs e)
        {
            btnAnalytics.Enabled = false;
            btnCancel.Enabled = true;
            pgbStatus.Value = 0;
            lblPercent.Text = "0%";
            reportList.Clear();

            cts = new CancellationTokenSource();
            string selectedWarehouse = cboWarehouse.SelectedItem?.ToString() ?? "Kho Tổng";

            IProgress<int> progress = new Progress<int>(percent =>
            {
                pgbStatus.Value = percent;
                lblPercent.Text = $"{percent}%";
            });

            try
            {
                var results = await Task.Run(() => GenerateReportData(selectedWarehouse, progress, cts.Token), cts.Token);

                foreach (var item in results)
                {
                    reportList.Add(item);
                }

                MessageBox.Show("Tổng hợp báo cáo kho hàng hoàn tất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OperationCanceledException)
            {
                pgbStatus.Value = 0;
                lblPercent.Text = "Đã hủy!";
                MessageBox.Show("Tiến trình quét dữ liệu đã bị hủy bỏ theo yêu cầu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải báo cáo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnAnalytics.Enabled = true;
                btnCancel.Enabled = false;
                cts.Dispose();
                cts = null;
            }
        }

        private static BindingList<WarehouseReportModel> GenerateReportData(string warehouse, IProgress<int> progress, CancellationToken cancellationToken)
        {
            BindingList<WarehouseReportModel> list = new BindingList<WarehouseReportModel>();
            int totalSteps = 100;

            for (int i = 1; i <= totalSteps; i++)
            {
                cancellationToken.ThrowIfCancellationRequested();

                Thread.Sleep(45);

                progress.Report(i);
            }

            for (int i = 1; i <= 20; i++)
            {
                list.Add(new WarehouseReportModel
                {
                    ItemCode = $"SP{i:D4}",
                    ItemName = $"Sản phẩm thử nghiệm {i}",
                    WarehouseName = warehouse,
                    StockQuantity = i * 15,
                    UnitPrice = i * 120000m
                });
            }

            return list;
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            cts?.Cancel();
        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}