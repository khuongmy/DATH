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
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
        }

        int index = -1;
        List<string> listAccountType = new List<string>() { "Quan li ", "Nhan vien" };

        void LoadListUser()
        {
            dgvUser.DataSource = null;
            dgvUser.DataSource = ListUser.Instance.ListAccountUser;

        }
        private void FormUsers_Load(object sender, EventArgs e)
        {
            cboLoaiTaiKhoan.DataSource=listAccountType;
            LoadListUser();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string userName=txtTenTaiKhoan.Text;
            string password=txtMatKhau.Text;
            bool accountType=false;

            switch (cboLoaiTaiKhoan.Text)
            {
                case "Quan li":
                   accountType = true;
                    break;
                case "Nhan vien":
                    accountType=false;
                    break;
            }
            
            ListUser.Instance.ListAccountUser.Add(new User(userName, password, accountType));

            LoadListUser() ;
            
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            index= e.RowIndex;
            if (index < 0)
                return;
            txtTenTaiKhoan.Text = dgvUser.Rows[index].Cells[0].ToString();
            txtMatKhau.Text = dgvUser.Rows[index].Cells[1].ToString();

            switch(ListUser.Instance.ListAccountUser[index].AccountType) 
            {
                case true: cboLoaiTaiKhoan.Text = "Quan li";
                    break;
                case false: cboLoaiTaiKhoan.Text = "Nhan vien";
                    break;
            }

            //txtTenTaiKhoan.Text = ListUser.Instance.ListAccountUser[index].UserName;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Vui long chon 1 ban ghi");
                 return;
            }

              
            string userName = txtTenTaiKhoan.Text;
            string password = txtMatKhau.Text;
            bool accountType = false;

            switch (cboLoaiTaiKhoan.Text)
            {
                case "Quan li":
                    accountType = true;
                    break;
                case "Nhan vien":
                    accountType = false;
                    break;
            }

            ListUser.Instance.ListAccountUser[index].UserName=userName;
            ListUser.Instance.ListAccountUser[index].PassWord=password;
            ListUser.Instance.ListAccountUser[index].AccountType=accountType;

            LoadListUser();
            

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Vui long chon 1 ban ghi");
                return;
            }
            ListUser.Instance.ListAccountUser.RemoveAt(index);
            LoadListUser();
        }
    }
}
