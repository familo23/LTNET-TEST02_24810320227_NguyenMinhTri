using System.Drawing;
using System.Windows.Forms;

namespace bai3
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
            this.components = new System.ComponentModel.Container();

            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuChangePass = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();

            this.menuManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCourses = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClasses = new System.Windows.Forms.ToolStripMenuItem();

            this.menuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCloseAll = new System.Windows.Forms.ToolStripMenuItem();

            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();

            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();

            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 650);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG QUẢN LÝ TRƯỜNG HỌC & ĐÀO TẠO";

            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSystem,
            this.menuManage,
            this.menuWindow});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(980, 24);
            this.menuStrip.TabIndex = 0;

            // 
            // menuSystem
            // 
            this.menuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLogout,
            this.menuChangePass,
            new System.Windows.Forms.ToolStripSeparator(),
            this.menuExit});
            this.menuSystem.Text = "Hệ thống";

            this.menuLogout.Text = "Đăng xuất";
            this.menuChangePass.Text = "Đổi mật khẩu";
            this.menuExit.Text = "Thoát";

            // 
            // menuManage
            // 
            this.menuManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStudents,
            this.menuCourses,
            this.menuClasses});
            this.menuManage.Text = "Quản lý";

            this.menuStudents.Text = "Danh sách Sinh viên";
            this.menuCourses.Text = "Danh mục Môn học";
            this.menuClasses.Text = "Danh mục Lớp học";

            // 
            // menuWindow
            // 
            this.menuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCascade,
            this.menuTileHorizontal,
            this.menuTileVertical,
            new System.Windows.Forms.ToolStripSeparator(),
            this.menuCloseAll});
            this.menuWindow.Text = "Cửa sổ";

            this.menuCascade.Text = "Xếp tầng (Cascade)";
            this.menuTileHorizontal.Text = "Xếp ngang (Tile Horizontal)";
            this.menuTileVertical.Text = "Xếp dọc (Tile Vertical)";
            this.menuCloseAll.Text = "Đóng tất cả";

            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUser,
            this.progressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 628);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(980, 22);
            this.statusStrip.TabIndex = 1;

            // 
            // lblUser
            // 
            this.lblUser.Text = "Cán bộ quản lý: Admin  |  ";

            // 
            // progressBar
            // 
            this.progressBar.Size = new System.Drawing.Size(150, 16);
            this.progressBar.Value = 100;

            // 
            // Add Controls
            // 
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);

            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip = null!;
        private ToolStripMenuItem menuSystem = null!;
        private ToolStripMenuItem menuLogout = null!;
        private ToolStripMenuItem menuChangePass = null!;
        private ToolStripMenuItem menuExit = null!;

        private ToolStripMenuItem menuManage = null!;
        private ToolStripMenuItem menuStudents = null!;
        private ToolStripMenuItem menuCourses = null!;
        private ToolStripMenuItem menuClasses = null!;

        private ToolStripMenuItem menuWindow = null!;
        private ToolStripMenuItem menuCascade = null!;
        private ToolStripMenuItem menuTileHorizontal = null!;
        private ToolStripMenuItem menuTileVertical = null!;
        private ToolStripMenuItem menuCloseAll = null!;

        private StatusStrip statusStrip = null!;
        private ToolStripStatusLabel lblUser = null!;
        private ToolStripProgressBar progressBar = null!;
    }
}