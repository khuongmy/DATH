using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATH
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
            if (KiemTraDangNhap(txtUser.Text, txtPassWord.Text))
            {
                FormMain f = new FormMain();
                f.Show();
                this.Hide();
                f.Logout += F_Logout;
            }
            else
            {
                MessageBox.Show("Sai ten tai khoan hoac mat khau", "Loi");
                txtUser.Focus();
                return;
            }

        }
        private void F_Logout(object sender, EventArgs e)
        {
            (sender as FormMain).isThoat = false;
            (sender as FormMain).Close();
            this.Show();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        bool KiemTraDangNhap(string userName, string passWord)
        {
            for (int i = 0; i < ListUser.Instance.ListAccountUser.Count; i++)
            {
                if (userName == ListUser.Instance.ListAccountUser[i].UserName && passWord == ListUser.Instance.ListAccountUser[i].PassWord)
                {
                    Const.AccountType = ListUser.Instance.ListAccountUser[i].AccountType;
                    return true;
                }
            }
            return false;
        }

        private void ckbShowPassWord_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowPassWord.Checked)
                txtPassWord.UseSystemPasswordChar = false;
            if (ckbShowPassWord.Checked)
                txtPassWord.UseSystemPasswordChar = true;
        }
    }
}
