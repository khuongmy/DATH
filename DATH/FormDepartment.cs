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
    public partial class FormDepartment : Form
    {
        int index = -1;

        public FormDepartment()
        {
            InitializeComponent();
        }

        void LoadListDepartment()
        {
            lbDepartment.DataSource = null;
            lbDepartment.DataSource = ListDepartment.Instance.ListDepartment;
            lbDepartment.DisplayMember = "Name";

        }
        private void frmPhongBan_Load(object sender, EventArgs e)
        {
           LoadListDepartment();
        }

        private void lbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = lbDepartment.SelectedIndex;

            if (index < 0)
                return;

            txtDepartmentName.Text = ListDepartment.Instance.ListDepartment[index].Name;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string departmentName=txtDepartmentName.Text;
            Const.ListDepartment.Add(departmentName);
            LoadListDepartment();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string departmentName = txtDepartmentName.Text;

            Const.ListDepartment[index] = departmentName;

            LoadListDepartment();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Const.ListDepartment.RemoveAt(index);
            LoadListDepartment() ;  
        }
    }
}
