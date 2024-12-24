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
    public partial class FormMain : Form
    {
        public bool isThoat = true;
        public event EventHandler Logout;
        int index = -1;
        public FormMain()
        {
            InitializeComponent();
        }

        private void frmChuongTrinhChinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat)
                Application.Exit(); 
        }

        private void frmChuongTrinhChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isThoat)
            {
                if (MessageBox.Show("Ban muon thoat chuong trinh", "Canh bao", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            btnAddNew.Enabled = btnEdit.Enabled = btnDelete.Enabled = false;
            Deccenttralization();
            LoadListEmployee();

        }


        void LoadListEmployee()
        {
            dgvEmployee.Rows.Clear();
            foreach (var item in ListEmployee.Instance.ListEmploy)
            {
                dgvEmployee.Rows.Add(item.Name, item.BirthDay.ToShortDateString(), item.Sex, item.EmployeeCode, item.Department, item.Contract, item.Position);
            }
        }
        //Phan quyen
        void Deccenttralization()
        {
            if (Const.AccountType == false)
            {
                tsmiUser.Enabled = tsmiEmployee.Enabled = tsmiDepartment.Enabled = false;

            }
        }

        private void tsmiEmployee_Click(object sender, EventArgs e)
        {
           btnShow.Enabled=btnAddNew.Enabled = btnEdit.Enabled = btnDelete.Enabled = true;
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Const.AccountType==false)
                 MessageBox.Show("Ban khong phai la Admin", "Canh bao");
          
        }

        private void tsmiUser_Click(object sender, EventArgs e)
        {
            FormUsers f = new FormUsers();
            f.ShowDialog();
        }

        private void tsmiDepartment_Click(object sender, EventArgs e)
        {
            FormDepartment f = new FormDepartment();
            f.ShowDialog();
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index=e.RowIndex;

            if (index < 0 || index >= ListEmployee.Instance.ListEmploy.Count)
                return;

            Const.NewEmploy = new Employee();


            Const.NewEmploy.Name = ListEmployee.Instance.ListEmploy[index].Name;
            Const.NewEmploy.BirthDay = ListEmployee.Instance.ListEmploy[index].BirthDay;
            Const.NewEmploy.Sex = ListEmployee.Instance.ListEmploy[index].Sex;
      

            Const.NewEmploy.EmployeeCode = ListEmployee.Instance.ListEmploy[index].EmployeeCode;
            Const.NewEmploy.Department = ListEmployee.Instance.ListEmploy[index].Department;
            Const.NewEmploy.Position = ListEmployee.Instance.ListEmploy[index].Position;
            Const.NewEmploy.Contract = ListEmployee.Instance.ListEmploy[index].Contract;
            

        }
        //checkInput
        private void btnAddNew_Click(object sender, EventArgs e)
        {

            Const.NewEmploy = null;
            FormEmployee f= new FormEmployee();
            f.FormClosed += F_FormClosed;
            f.ShowDialog();
        }
        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            ListEmployee.Instance.ListEmploy.Add(Const.NewEmploy);
            LoadListEmployee();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ///Form
        }
    }
}
