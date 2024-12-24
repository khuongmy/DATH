using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATH
{
    public class ListDepartment
    {
        private List<Department> listDepartment;


        public List<Department> ListDepartment
        {
            get => listDepartment;
            set => listDepartment = value;
        }

       


        private static ListDepartment instance;
        public static ListDepartment Instance
        {
            get
            {
                if (instance == null)
                    instance = new ListDepartment();
                return instance;
            }
            set => instance = value;
        }

        private ListDepartment()
        {
            listDepartment = new List<Department>();
            listDepartment.Add(new Department("Phong nhan su"));
            listDepartment.Add(new Department("Phong IT"));
            listDepartment.Add(new Department("Phong ke toan"));
            listDepartment.Add(new Department("Phong van tai"));
            listDepartment.Add(new Department("Phong Marketing"));

        }
    }
}
