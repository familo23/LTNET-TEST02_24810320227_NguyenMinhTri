using System;
using System.Windows.Forms;

namespace bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            menuLogout.Click += (s, e) => MessageBox.Show("Đã đăng xuất thành công!", "Thông báo");
            menuChangePass.Click += (s, e) => MessageBox.Show("Chức năng đổi mật khẩu", "Thông báo");
            menuExit.Click += (s, e) => Application.Exit();

            menuStudents.Click += (s, e) => OpenMdiChild<FrmStudentList>();
            menuCourses.Click += (s, e) => OpenMdiChild<FrmCourseList>();
            menuClasses.Click += (s, e) => MessageBox.Show("Chức năng Quản lý Lớp học", "Thông báo");

            menuCascade.Click += (s, e) => LayoutMdi(MdiLayout.Cascade);
            menuTileHorizontal.Click += (s, e) => LayoutMdi(MdiLayout.TileHorizontal);
            menuTileVertical.Click += (s, e) => LayoutMdi(MdiLayout.TileVertical);
            menuCloseAll.Click += (s, e) => CloseAllMdiChildren();
        }

        private void OpenMdiChild<T>() where T : Form, new()
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is T)
                {
                 
                    child.Activate();
                    return;
                }
            }

            T newChild = new()
            {
                MdiParent = this
            };
            newChild.Show();
        }

        private void CloseAllMdiChildren()
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
        }
    }
}