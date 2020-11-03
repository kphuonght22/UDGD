using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemBanh
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            QuanLyTiemBanhDB context = new QuanLyTiemBanhDB();
           
            if (cbxStaff.Checked)
            {
                Account db = context.Accounts.FirstOrDefault(p => p.UserName == tbxUserName.Text);
                if (db != null && db.PassWord == tbxPassWord.Text)
                {
                    MessageBox.Show("Đăng nhập thành công!!!");
                    fStaffManager f1 = new fStaffManager();
                    this.Hide();
                    f1.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu / tài khoản!!!");
                }
            }
            if (cbxAdmin.Checked)
            {
                fAdminManager f2 = new fAdminManager();
                this.Hide();
                f2.ShowDialog();
                this.Show();
            }
            if (!cbxAdmin.Checked && !cbxStaff.Checked)
            {
                MessageBox.Show("Chọn đối tượng truy cập!");
            }
        }
        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo!!!" ,MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void cbxStaff_CheckedChanged(object sender, EventArgs e)
        {
            cbxAdmin.Checked = false;
        }

        private void cbxAdmin_CheckedChanged(object sender, EventArgs e)
        {
            cbxStaff.Checked = false;
        }
    }
}
