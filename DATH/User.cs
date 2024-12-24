using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATH
{
    internal class User
    {

        private string userName;
        private string passWord;


        public string UserName
        {
            get => userName;
            set => userName = value;
        }
        public string PassWord
        {
            get => passWord;
            set => passWord = value;
        }

        //bool true(admin) or false(nhan vien)

        private bool accountType;
        public bool AccountType
        {
            get => accountType;
            set => accountType = value;
        }

        //public enum LoaiTK
        //{
        //    giamdoc,
        //    quanly,
        //    nhanvien
        //}

        //private string tenHienThi;
        //public string TenHienThi
        //{
        //    get
        //    {
        //        switch (LoaiTaiKhoan)
        //        {
        //            case LoaiTK.giamdoc:
        //                TenHienThi = "Giam doc";
        //                break;
        //            case LoaiTK.quanly:
        //                TenHienThi = "Quan Li";
        //                break;
        //            default:
        //                TenHienThi = "Nhan vien";
        //                break;
        //        }

        //        return tenHienThi;
        //    }
        //    set => tenHienThi = value;
        //}

        public User(string userName, string passWord, bool accountType)
        {
            this.userName = userName;
            this.passWord = passWord;
            this.accountType = accountType;
           

        }

    }
}

