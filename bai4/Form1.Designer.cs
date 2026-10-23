using System.Drawing;
using System.Windows.Forms;

namespace bai4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null!;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            gbCriteria = new GroupBox();
            lblWarehouse = new Label();
            cboWarehouse = new ComboBox();
            lblFromDate = new Label();
            dtpFromDate = new DateTimePicker();
            lblToDate = new Label();
            dtpToDate = new DateTimePicker();
            btnAnalytics = new Button();
            btnCancel = new Button();
            gbStatus = new GroupBox();
            pgbStatus = new ProgressBar();
            lblPercent = new Label();
            dgvReportData = new DataGridView();
            gbCriteria.SuspendLayout();
            gbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportData).BeginInit();
            SuspendLayout();
            // 
            // gbCriteria
            // 
            gbCriteria.Controls.Add(lblWarehouse);
            gbCriteria.Controls.Add(cboWarehouse);
            gbCriteria.Controls.Add(lblFromDate);
            gbCriteria.Controls.Add(dtpFromDate);
            gbCriteria.Controls.Add(lblToDate);
            gbCriteria.Controls.Add(dtpToDate);
            gbCriteria.Controls.Add(btnAnalytics);
            gbCriteria.Controls.Add(btnCancel);
            gbCriteria.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            gbCriteria.Location = new Point(12, 12);
            gbCriteria.Name = "gbCriteria";
            gbCriteria.Size = new Size(856, 100);
            gbCriteria.TabIndex = 0;
            gbCriteria.TabStop = false;
            gbCriteria.Text = "Tiêu Chí Báo Cáo";
            // 
            // lblWarehouse
            // 
            lblWarehouse.AutoSize = true;
            lblWarehouse.Font = new Font("Segoe UI", 9F);
            lblWarehouse.Location = new Point(15, 32);
            lblWarehouse.Name = "lblWarehouse";
            lblWarehouse.Size = new Size(78, 20);
            lblWarehouse.TabIndex = 0;
            lblWarehouse.Text = "Kho Hàng:";
            // 
            // cboWarehouse
            // 
            cboWarehouse.DropDownStyle = ComboBoxStyle.DropDownList;
            cboWarehouse.Font = new Font("Segoe UI", 9F);
            cboWarehouse.FormattingEnabled = true;
            cboWarehouse.Items.AddRange(new object[] { "Kho Tổng", "Kho Miền Bắc", "Kho Miền Nam", "Kho Linh Kiện" });
            cboWarehouse.Location = new Point(94, 26);
            cboWarehouse.Name = "cboWarehouse";
            cboWarehouse.Size = new Size(150, 28);
            cboWarehouse.TabIndex = 1;
            // 
            // lblFromDate
            // 
            lblFromDate.AutoSize = true;
            lblFromDate.Font = new Font("Segoe UI", 9F);
            lblFromDate.Location = new Point(250, 32);
            lblFromDate.Name = "lblFromDate";
            lblFromDate.Size = new Size(68, 20);
            lblFromDate.TabIndex = 2;
            lblFromDate.Text = "Từ Ngày:";
            // 
            // dtpFromDate
            // 
            dtpFromDate.Font = new Font("Segoe UI", 9F);
            dtpFromDate.Format = DateTimePickerFormat.Short;
            dtpFromDate.Location = new Point(319, 27);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(130, 27);
            dtpFromDate.TabIndex = 3;
            // 
            // lblToDate
            // 
            lblToDate.AutoSize = true;
            lblToDate.Font = new Font("Segoe UI", 9F);
            lblToDate.Location = new Point(455, 32);
            lblToDate.Name = "lblToDate";
            lblToDate.Size = new Size(78, 20);
            lblToDate.TabIndex = 4;
            lblToDate.Text = "Đến Ngày:";
            // 
            // dtpToDate
            // 
            dtpToDate.Font = new Font("Segoe UI", 9F);
            dtpToDate.Format = DateTimePickerFormat.Short;
            dtpToDate.Location = new Point(534, 29);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(130, 27);
            dtpToDate.TabIndex = 5;
            dtpToDate.ValueChanged += dtpToDate_ValueChanged;
            // 
            // btnAnalytics
            // 
            btnAnalytics.BackColor = Color.LightSkyBlue;
            btnAnalytics.FlatStyle = FlatStyle.Flat;
            btnAnalytics.Font = new Font("Segoe UI", 9F);
            btnAnalytics.Location = new Point(670, 24);
            btnAnalytics.Name = "btnAnalytics";
            btnAnalytics.Size = new Size(165, 30);
            btnAnalytics.TabIndex = 6;
            btnAnalytics.Text = "Thống Kê Kho";
            btnAnalytics.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.Location = new Point(670, 58);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(165, 28);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Hủy Tác Vụ";
            // 
            // gbStatus
            // 
            gbStatus.Controls.Add(pgbStatus);
            gbStatus.Controls.Add(lblPercent);
            gbStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            gbStatus.Location = new Point(12, 120);
            gbStatus.Name = "gbStatus";
            gbStatus.Size = new Size(856, 70);
            gbStatus.TabIndex = 1;
            gbStatus.TabStop = false;
            gbStatus.Text = "Trạng Thái Tiến Trình Xử Lý";
            // 
            // pgbStatus
            // 
            pgbStatus.Location = new Point(15, 28);
            pgbStatus.Name = "pgbStatus";
            pgbStatus.Size = new Size(760, 25);
            pgbStatus.TabIndex = 0;
            // 
            // lblPercent
            // 
            lblPercent.AutoSize = true;
            lblPercent.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPercent.Location = new Point(785, 31);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(33, 21);
            lblPercent.TabIndex = 1;
            lblPercent.Text = "0%";
            // 
            // dgvReportData
            // 
            dgvReportData.AllowUserToAddRows = false;
            dgvReportData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportData.BackgroundColor = Color.WhiteSmoke;
            dgvReportData.ColumnHeadersHeight = 29;
            dgvReportData.Font = new Font("Segoe UI", 9F);
            dgvReportData.Location = new Point(12, 200);
            dgvReportData.Name = "dgvReportData";
            dgvReportData.ReadOnly = true;
            dgvReportData.RowHeadersWidth = 51;
            dgvReportData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReportData.Size = new Size(856, 405);
            dgvReportData.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 620);
            Controls.Add(gbCriteria);
            Controls.Add(gbStatus);
            Controls.Add(dgvReportData);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BẢNG ĐIỀU KHIỂN TỔNG HỢP BÁO CÁO KHO HÀNG";
            gbCriteria.ResumeLayout(false);
            gbCriteria.PerformLayout();
            gbStatus.ResumeLayout(false);
            gbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbCriteria = null!;
        private Label lblWarehouse = null!;
        private ComboBox cboWarehouse = null!;
        private Label lblFromDate = null!;
        private DateTimePicker dtpFromDate = null!;
        private Label lblToDate = null!;
        private DateTimePicker dtpToDate = null!;
        private Button btnAnalytics = null!;
        private Button btnCancel = null!;

        private GroupBox gbStatus = null!;
        private ProgressBar pgbStatus = null!;
        private Label lblPercent = null!;

        private DataGridView dgvReportData = null!;
    }
}