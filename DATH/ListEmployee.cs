using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATH
{
    public class ListEmployee
    {

        private static ListEmployee instance;
        public static ListEmployee Instance
        {
            get
            {
                if (Instance == null)
                    Instance = new ListEmployee();
                return Instance;
            }
            set => Instance = value;
        }



        private List<Employee> listEmploy;
        public List<Employee> ListEmploy { get => listEmploy; set => listEmploy = value; }

        private ListEmployee()
        {
            ListEmploy = new List<Employee>();
            ListEmploy.Add(new Employee("  Nguyễn Hoa", new DateTime(1999, 10, 24), "Nữ", 1, "Phòng IT", "Truong phong", "Đang công tác"));
            ListEmploy.Add(new Employee("  Vũ Thị Thủy", new DateTime(1993, 5, 1), "Nữ", 2, "Phong kế toán", "Nhan vien", "Dang cong tac"));
            //ListEmploy.Add(new Employee("  Nguyễn Hoàng Khôi", new DateTime(1978, 1, 24), "Nam", "Q8", 052302228136, 3, "Phong IT", "Nhan vien", 10000000, "Dang cong tac", 550000));
            //ListEmploy.Add(new Employee("  Lê Minh Vũ", new DateTime(1999, 2, 19), "Nam", "Q8", 052989727692, 4, "Phong IT", "Nhan vien", 10000000, "Dang cong tac", 700000));
            //ListEmploy.Add(new Employee("  Nguyễn Ngọc Khánh", new DateTime(1998, 11, 15), "Nữ", "Q8", 052873016723, 5, "Phong tai chinh", "Nhan vien", 10000000, "Dang cong tac", 650000));
            //ListEmploy.Add(new Employee("  Nguyễn Đình Dũng", new DateTime(1989, 12, 4), "Nam", "Q8", 055482079162, 6, "Phong van tai ", "Nhan vien", 10000000, "Dang cong tac", 800000));
            //ListEmploy.Add(new Employee("  Nguyễn Ngọc Mai", new DateTime(1998, 1, 11), "Nu", "Q8", 052879351072, 7, "Phong Marketing", "Nhan vien", 10000000, "Dang cong tac", 700000));


        }

    }
        
}