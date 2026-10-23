using System.Drawing;
using System.Windows.Forms;

namespace bai2
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
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuOpenCsv = new ToolStripMenuItem();
            menuSaveCsv = new ToolStripMenuItem();
            menuExit = new ToolStripMenuItem();
            menuTask = new ToolStripMenuItem();
            menuAdd = new ToolStripMenuItem();
            menuDelete = new ToolStripMenuItem();
            toolStrip = new ToolStrip();
            tsOpen = new ToolStripButton();
            tsSave = new ToolStripButton();
            tsAdd = new ToolStripButton();
            statusStrip = new StatusStrip();
            lblTotalEmployees = new ToolStripStatusLabel();
            lblTotalSalary = new ToolStripStatusLabel();
            lblCurrentTime = new ToolStripStatusLabel();
            gbDetail = new GroupBox();
            picAvatar = new PictureBox();
            btnSelectAvatar = new Button();
            lblEmployeeId = new Label();
            txtEmployeeId = new TextBox();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblPosition = new Label();
            cboPosition = new ComboBox();
            lblBaseSalary = new Label();
            txtBaseSalary = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            dgvEmployees = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            menuStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            gbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { menuFile, menuTask });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(900, 28);
            menuStrip.TabIndex = 0;
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuOpenCsv, menuSaveCsv, menuExit });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(46, 24);
            menuFile.Text = "File";
            // 
            // menuOpenCsv
            // 
            menuOpenCsv.Name = "menuOpenCsv";
            menuOpenCsv.Size = new Size(171, 26);
            menuOpenCsv.Text = "Mở file CSV";
            // 
            // menuSaveCsv
            // 
            menuSaveCsv.Name = "menuSaveCsv";
            menuSaveCsv.Size = new Size(171, 26);
            menuSaveCsv.Text = "Lưu file CSV";
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(171, 26);
            menuExit.Text = "Thoát";
            // 
            // menuTask
            // 
            menuTask.DropDownItems.AddRange(new ToolStripItem[] { menuAdd, menuDelete });
            menuTask.Name = "menuTask";
            menuTask.Size = new Size(63, 24);
            menuTask.Text = "Tác vụ";
            // 
            // menuAdd
            // 
            menuAdd.Name = "menuAdd";
            menuAdd.Size = new Size(129, 26);
            menuAdd.Text = "Thêm";
            // 
            // menuDelete
            // 
            menuDelete.Name = "menuDelete";
            menuDelete.Size = new Size(129, 26);
            menuDelete.Text = "Xóa";
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { tsOpen, tsSave, tsAdd });
            toolStrip.Location = new Point(0, 28);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(900, 27);
            toolStrip.TabIndex = 1;
            // 
            // tsOpen
            // 
            tsOpen.Name = "tsOpen";
            tsOpen.Size = new Size(92, 24);
            tsOpen.Text = "Mở File CSV";
            // 
            // tsSave
            // 
            tsSave.Name = "tsSave";
            tsSave.Size = new Size(94, 24);
            tsSave.Text = "Lưu File CSV";
            // 
            // tsAdd
            // 
            tsAdd.Name = "tsAdd";
            tsAdd.Size = new Size(80, 24);
            tsAdd.Text = "Thêm Mới";
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblTotalEmployees, lblTotalSalary, lblCurrentTime });
            statusStrip.Location = new Point(0, 614);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(900, 26);
            statusStrip.TabIndex = 2;
            // 
            // lblTotalEmployees
            // 
            lblTotalEmployees.Name = "lblTotalEmployees";
            lblTotalEmployees.Size = new Size(145, 20);
            lblTotalEmployees.Text = "Tổng nhân viên: 0  |  ";
            // 
            // lblTotalSalary
            // 
            lblTotalSalary.Name = "lblTotalSalary";
            lblTotalSalary.Size = new Size(184, 20);
            lblTotalSalary.Text = "Tổng quỹ lương: 0 VNĐ  |  ";
            // 
            // lblCurrentTime
            // 
            lblCurrentTime.Name = "lblCurrentTime";
            lblCurrentTime.Size = new Size(143, 20);
            lblCurrentTime.Text = "00:00:00 01/01/2026";
            // 
            // gbDetail
            // 
            gbDetail.Controls.Add(picAvatar);
            gbDetail.Controls.Add(btnSelectAvatar);
            gbDetail.Controls.Add(lblEmployeeId);
            gbDetail.Controls.Add(txtEmployeeId);
            gbDetail.Controls.Add(lblFullName);
            gbDetail.Controls.Add(txtFullName);
            gbDetail.Controls.Add(lblPosition);
            gbDetail.Controls.Add(cboPosition);
            gbDetail.Controls.Add(lblBaseSalary);
            gbDetail.Controls.Add(txtBaseSalary);
            gbDetail.Controls.Add(btnAdd);
            gbDetail.Controls.Add(btnDelete);
            gbDetail.Controls.Add(btnRefresh);
            gbDetail.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            gbDetail.Location = new Point(12, 55);
            gbDetail.Name = "gbDetail";
            gbDetail.Size = new Size(876, 195);
            gbDetail.TabIndex = 3;
            gbDetail.TabStop = false;
            gbDetail.Text = "Chi Tiết Nhân Viên";
            // 
            // picAvatar
            // 
            picAvatar.BorderStyle = BorderStyle.FixedSingle;
            picAvatar.Location = new Point(15, 25);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(120, 125);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 0;
            picAvatar.TabStop = false;
            // 
            // btnSelectAvatar
            // 
            btnSelectAvatar.Font = new Font("Segoe UI", 8.5F);
            btnSelectAvatar.Location = new Point(15, 156);
            btnSelectAvatar.Name = "btnSelectAvatar";
            btnSelectAvatar.Size = new Size(120, 26);
            btnSelectAvatar.TabIndex = 1;
            btnSelectAvatar.Text = "Chọn ảnh";
            // 
            // lblEmployeeId
            // 
            lblEmployeeId.AutoSize = true;
            lblEmployeeId.Font = new Font("Segoe UI", 9F);
            lblEmployeeId.Location = new Point(155, 30);
            lblEmployeeId.Name = "lblEmployeeId";
            lblEmployeeId.Size = new Size(57, 20);
            lblEmployeeId.TabIndex = 2;
            lblEmployeeId.Text = "Mã NV:";
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.BackColor = Color.LightGray;
            txtEmployeeId.Font = new Font("Segoe UI", 9F);
            txtEmployeeId.Location = new Point(235, 27);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.ReadOnly = true;
            txtEmployeeId.Size = new Size(150, 27);
            txtEmployeeId.TabIndex = 3;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 9F);
            lblFullName.Location = new Point(415, 30);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(78, 20);
            lblFullName.TabIndex = 4;
            lblFullName.Text = "Họ và Tên:";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 9F);
            txtFullName.Location = new Point(505, 27);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(345, 27);
            txtFullName.TabIndex = 5;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI", 9F);
            lblPosition.Location = new Point(155, 75);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(66, 20);
            lblPosition.TabIndex = 6;
            lblPosition.Text = "Chức Vụ:";
            // 
            // cboPosition
            // 
            cboPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPosition.Font = new Font("Segoe UI", 9F);
            cboPosition.FormattingEnabled = true;
            cboPosition.Items.AddRange(new object[] { "Nhân viên", "Trưởng phòng", "Phó phòng", "Giám đốc" });
            cboPosition.Location = new Point(235, 72);
            cboPosition.Name = "cboPosition";
            cboPosition.Size = new Size(150, 28);
            cboPosition.TabIndex = 7;
            // 
            // lblBaseSalary
            // 
            lblBaseSalary.AutoSize = true;
            lblBaseSalary.Font = new Font("Segoe UI", 9F);
            lblBaseSalary.Location = new Point(415, 75);
            lblBaseSalary.Name = "lblBaseSalary";
            lblBaseSalary.Size = new Size(76, 20);
            lblBaseSalary.TabIndex = 8;
            lblBaseSalary.Text = "Lương CB:";
            // 
            // txtBaseSalary
            // 
            txtBaseSalary.Font = new Font("Segoe UI", 9F);
            txtBaseSalary.Location = new Point(505, 72);
            txtBaseSalary.Name = "txtBaseSalary";
            txtBaseSalary.Size = new Size(345, 27);
            txtBaseSalary.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightSkyBlue;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F);
            btnAdd.Location = new Point(201, 144);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 32);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Thêm Mới";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F);
            btnDelete.Location = new Point(384, 138);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 44);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Xóa";
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 9F);
            btnRefresh.Location = new Point(505, 138);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 44);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Làm Mới";
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.BackgroundColor = Color.WhiteSmoke;
            dgvEmployees.ColumnHeadersHeight = 29;
            dgvEmployees.Font = new Font("Segoe UI", 9F);
            dgvEmployees.Location = new Point(12, 260);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.Size = new Size(876, 350);
            dgvEmployees.TabIndex = 4;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 640);
            Controls.Add(gbDetail);
            Controls.Add(dgvEmployees);
            Controls.Add(statusStrip);
            Controls.Add(toolStrip);
            Controls.Add(menuStrip);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ HỒ SƠ NHÂN SỰ & THÔNG TIN LƯƠNG";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            gbDetail.ResumeLayout(false);
            gbDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip = null!;
        private ToolStripMenuItem menuFile = null!;
        private ToolStripMenuItem menuOpenCsv = null!;
        private ToolStripMenuItem menuSaveCsv = null!;
        private ToolStripMenuItem menuExit = null!;
        private ToolStripMenuItem menuTask = null!;
        private ToolStripMenuItem menuAdd = null!;
        private ToolStripMenuItem menuDelete = null!;

        private ToolStrip toolStrip = null!;
        private ToolStripButton tsOpen = null!;
        private ToolStripButton tsSave = null!;
        private ToolStripButton tsAdd = null!;

        private StatusStrip statusStrip = null!;
        private ToolStripStatusLabel lblTotalEmployees = null!;
        private ToolStripStatusLabel lblTotalSalary = null!;
        private ToolStripStatusLabel lblCurrentTime = null!;

        private GroupBox gbDetail = null!;
        private PictureBox picAvatar = null!;
        private Button btnSelectAvatar = null!;
        private Label lblEmployeeId = null!;
        private TextBox txtEmployeeId = null!;
        private Label lblFullName = null!;
        private TextBox txtFullName = null!;
        private Label lblPosition = null!;
        private ComboBox cboPosition = null!;
        private Label lblBaseSalary = null!;
        private TextBox txtBaseSalary = null!;

        private Button btnAdd = null!;
        private Button btnDelete = null!;
        private Button btnRefresh = null!;

        private DataGridView dgvEmployees = null!;
        private ErrorProvider errorProvider1 = null!;
    }
}