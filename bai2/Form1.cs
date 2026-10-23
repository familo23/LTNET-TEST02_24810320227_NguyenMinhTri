using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bai2
{
    public partial class Form1 : Form
    {
        private readonly BindingList<EmployeeModel> employeeList;
        private readonly BindingSource bindingSource;
        private readonly System.Windows.Forms.Timer timerClock;

        public Form1()
        {
            InitializeComponent();

            employeeList = new BindingList<EmployeeModel>();
            bindingSource = new BindingSource { DataSource = employeeList };

            SetupDataGridView();

            // Đăng ký sự kiện
            employeeList.ListChanged += (s, e) => UpdateStatusStrip();
            bindingSource.CurrentChanged += BindingSource_CurrentChanged;

            btnAdd.Click += BtnAdd_Click;
            btnDelete.Click += BtnDelete_Click;
            btnRefresh.Click += BtnRefresh_Click;
            btnSelectAvatar.Click += BtnSelectAvatar_Click;

            menuOpenCsv.Click += BtnOpenCsv_Click;
            menuSaveCsv.Click += BtnSaveCsv_Click;
            menuExit.Click += (s, e) => Application.Exit();
            menuAdd.Click += BtnAdd_Click;
            menuDelete.Click += BtnDelete_Click;

            tsOpen.Click += BtnOpenCsv_Click;
            tsSave.Click += BtnSaveCsv_Click;
            tsAdd.Click += BtnAdd_Click;

            // Timer Đồng Hồ Real-time
            timerClock = new System.Windows.Forms.Timer { Interval = 1000 };
            timerClock.Tick += (s, e) => lblCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
            timerClock.Start();

            this.Load += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            if (cboPosition.Items.Count > 0) cboPosition.SelectedIndex = 0;
            GenerateNewEmployeeId();
            UpdateStatusStrip();
        }

        private void SetupDataGridView()
        {
            dgvEmployees.AutoGenerateColumns = false;
            dgvEmployees.Columns.Clear();

            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "EmployeeId", HeaderText = "Mã NV", Width = 90 });
            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FullName", HeaderText = "Họ và Tên", Width = 200 });
            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Position", HeaderText = "Chức Vụ", Width = 130 });
            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "BaseSalary", HeaderText = "Lương CB", Width = 130, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" } });
            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "AvatarPath", HeaderText = "Đường Dẫn Ảnh", Width = 250 });

            dgvEmployees.DataSource = bindingSource;
        }

        private void GenerateNewEmployeeId()
        {
            int nextId = employeeList.Count + 1;
            txtEmployeeId.Text = $"NV{nextId:D3}";
        }

        private void UpdateStatusStrip()
        {
            int totalEmployees = employeeList.Count;
            decimal totalSalary = employeeList.Sum(e => e.BaseSalary);

            lblTotalEmployees.Text = $"Tổng nhân viên: {totalEmployees}  |  ";
            lblTotalSalary.Text = $"Tổng quỹ lương: {totalSalary:N0} VNĐ  |  ";
        }

        private void BtnSelectAvatar_Click(object? sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Chọn ảnh chân dung nhân viên",
                Filter = "File Ảnh (*.jpg; *.png)|*.jpg;*.png"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picAvatar.ImageLocation = ofd.FileName;
                picAvatar.Tag = ofd.FileName;
            }
        }

        private void BtnSaveCsv_Click(object? sender, EventArgs e)
        {
            using SaveFileDialog sfd = new SaveFileDialog
            {
                Title = "Xuất danh sách nhân sự ra file CSV",
                Filter = "CSV File (*.csv)|*.csv",
                FileName = "DanhSachNhanSu.csv"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using StreamWriter writer = new StreamWriter(sfd.FileName, false, Encoding.UTF8);
                    writer.WriteLine("EmployeeId,FullName,Position,BaseSalary,AvatarPath");

                    foreach (var emp in employeeList)
                    {
                        writer.WriteLine(emp.ToCsvLine());
                    }
                    MessageBox.Show("Xuất file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi ghi file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnOpenCsv_Click(object? sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Chọn file CSV nhân sự để nhập",
                Filter = "CSV File (*.csv)|*.csv"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    employeeList.Clear();
                    var lines = File.ReadAllLines(ofd.FileName, Encoding.UTF8);

                    for (int i = 1; i < lines.Length; i++)
                    {
                        if (string.IsNullOrWhiteSpace(lines[i])) continue;
                        var emp = EmployeeModel.FromCsvLine(lines[i]);
                        if (emp != null)
                        {
                            employeeList.Add(emp);
                        }
                    }
                    MessageBox.Show("Mở file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi đọc file CSV: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateData()
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                errorProvider1.SetError(txtFullName, "Tên nhân viên không được để trống!");
                isValid = false;
            }

            if (!decimal.TryParse(txtBaseSalary.Text.Trim(), out decimal salary) || salary <= 0)
            {
                errorProvider1.SetError(txtBaseSalary, "Lương cơ bản phải là số lớn hơn 0!");
                isValid = false;
            }

            return isValid;
        }

        private void BindingSource_CurrentChanged(object? sender, EventArgs e)
        {
            if (bindingSource.Current is EmployeeModel emp)
            {
                txtEmployeeId.Text = emp.EmployeeId;
                txtFullName.Text = emp.FullName;
                cboPosition.SelectedItem = emp.Position;
                txtBaseSalary.Text = emp.BaseSalary.ToString("G0");

                if (!string.IsNullOrEmpty(emp.AvatarPath) && File.Exists(emp.AvatarPath))
                {
                    picAvatar.ImageLocation = emp.AvatarPath;
                    picAvatar.Tag = emp.AvatarPath;
                }
                else
                {
                    picAvatar.Image = null;
                    picAvatar.Tag = null;
                }
            }
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            if (!ValidateData()) return;

            var newEmp = new EmployeeModel
            {
                EmployeeId = txtEmployeeId.Text,
                FullName = txtFullName.Text.Trim(),
                Position = cboPosition.SelectedItem?.ToString() ?? "Nhân viên",
                BaseSalary = decimal.Parse(txtBaseSalary.Text.Trim()),
                AvatarPath = picAvatar.Tag?.ToString() ?? string.Empty
            };

            employeeList.Add(newEmp);
            BtnRefresh_Click(this, EventArgs.Empty);
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (bindingSource.Current == null) return;

            DialogResult confirm = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa nhân viên này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                bindingSource.RemoveCurrent();
                BtnRefresh_Click(this, EventArgs.Empty);
            }
        }

        private void BtnRefresh_Click(object? sender, EventArgs e)
        {
            errorProvider1.Clear();
            txtFullName.Clear();
            if (cboPosition.Items.Count > 0) cboPosition.SelectedIndex = 0;
            txtBaseSalary.Clear();
            picAvatar.Image = null;
            picAvatar.Tag = null;
            GenerateNewEmployeeId();
            txtFullName.Focus();
        }
    }
}