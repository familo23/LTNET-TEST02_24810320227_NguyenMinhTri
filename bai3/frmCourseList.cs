using System;
using System.Drawing;
using System.Windows.Forms;

namespace bai3
{
    public partial class FrmCourseList : Form
    {
        private Label lblTitle = null!;
        private DataGridView dgvCourses = null!;

        public FrmCourseList()
        {
            InitializeComponentCustom();
            LoadDataSample();
        }

        private void InitializeComponentCustom()
        {
            this.lblTitle = new Label();
            this.dgvCourses = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.SuspendLayout();

            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(640, 380);
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Danh Mục Môn Học";

            this.lblTitle.Dock = DockStyle.Top;
            this.lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTitle.Location = new Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(640, 45);
            this.lblTitle.Text = "DANH MỤC MÔN HỌC";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            this.dgvCourses.AllowUserToAddRows = false;
            this.dgvCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourses.BackgroundColor = Color.WhiteSmoke;
            this.dgvCourses.Dock = DockStyle.Fill;
            this.dgvCourses.Location = new Point(0, 45);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.ReadOnly = true;
            this.dgvCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourses.Size = new Size(640, 335);

            this.Controls.Add(this.dgvCourses);
            this.Controls.Add(this.lblTitle);

            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.ResumeLayout(false);
        }

        private void LoadDataSample()
        {
            dgvCourses.Columns.Clear();
            dgvCourses.Columns.Add("CourseId", "Mã Môn");
            dgvCourses.Columns.Add("CourseName", "Tên Môn Học");
            dgvCourses.Columns.Add("Credits", "Số Tín Chỉ");

            dgvCourses.Rows.Add("TH001", "Lập trình C# Windows Forms", "3");
            dgvCourses.Rows.Add("TH002", "Cơ sở dữ liệu", "3");
            dgvCourses.Rows.Add("TH003", "Phân tích thiết kế hệ thống", "4");
        }
    }
}