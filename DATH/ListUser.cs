using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATH
{
    internal class ListUser
    {
        private List<User> listAccountUser;


        public List<User> ListAccountUser
        {
            get => listAccountUser;
            set => listAccountUser = value;
        }
        private static ListUser instance;
        public static ListUser Instance
        {
            get
            {
                if (instance == null)
                    instance = new ListUser();
                return instance;
            }
            set => instance = value;
        }

       private ListUser()
        {
            listAccountUser = new List<User>();
            listAccountUser.Add(new User("KTTM", "123456",true));
            listAccountUser.Add(new User("KTTT", "456789",false));
           
        }

    }
}
