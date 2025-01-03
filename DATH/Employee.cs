﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATH
{
    public class Employee
    {
        private string name;
        private DateTime birthDay;
        private string sex;


        private int employeeCode;
        private string department;
        private string position;
        private string contract;

        public string Name { get => name; set => name = value; }
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }
        public string Sex { get => sex; set => sex = value; }
        public int EmployeeCode { get => employeeCode; set => employeeCode = value; }
        public string Department { get => department; set => department = value; }
        public string Position { get => position; set => position = value; }
        public string Contract { get => contract; set => contract = value; }

        public Employee(string name, DateTime birthDay, string sex, int employeeCode, string department, string position, string contract)
        {
            this.name = name;
            this.birthDay = birthDay;
            this.sex = sex;

            this.employeeCode = employeeCode;
            this.department = department;
            this.position = position;
            this.contract = contract;

        }

        public Employee()
        {

        }

    }
}
