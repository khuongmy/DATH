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
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            cboGioiTinh.DataSource = Const.listGioiTinh;
            cboPhongBan.DataSource = Const.ListDepartment;
            cboTrangThai.DataSource = Const.listTrangThai;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string name=txtHoTen.Text;
            DateTime ngaySinh = dtpkNgaySinh.Value;
            string gioiTinh= cboGioiTinh.Text;

            int maNhanVien=Convert.ToInt32(txtMaNhanVien.Text);
            string phongBan = cboPhongBan.Text;
            string trangThai = cboTrangThai.Text;


            Const.NewEmployee = new Employee(name, ngaySinh, gioiTinh, maNhanVien, phongBan, trangThai);
            this.Close();

        }
    }
}
