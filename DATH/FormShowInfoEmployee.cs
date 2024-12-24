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
    public partial class FormShowInfoEmployee : Form
    {
        public FormShowInfoEmployee()
        {
            InitializeComponent();
        }

        void LoadInfo()
        {
            txtHoTen.Text = Const.NewEmploy.Name;
            txtGioiTinh.Text = Const.NewEmploy.Sex;
            dtpkNgaySinh.Value = Const.NewEmploy.BirthDay;
            txtMaNhanVien.Text = Const.NewEmploy.EmployeeCode.ToString();
            txtPhongBan.Text = Const.NewEmploy.Department;
            txtTrangThai.Text = Const.NewEmploy.Contract;
            txtChucVu.Text= Const.NewEmploy.Position.ToString();
            


        }
        private void FormShowInfoEmployee_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }
    }
}
