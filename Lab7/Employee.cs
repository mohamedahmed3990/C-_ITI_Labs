using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public struct Employee
    {
        int id;
        string name;
        decimal salary;
        HireDate hireDate;
        Securitylevel securityLevel;
        Gender gender;


        public int Id   
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public Securitylevel SecurityLevel
        {
            get { return securityLevel; }
            set { securityLevel = value; }
        }
        public HireDate HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }


        public Employee(int _id, string _name, decimal _salary, HireDate _hireDate, Gender _gender, Securitylevel _securitylevel)
        {
            id = _id;
            name = _name;
            salary = _salary;
            hireDate = _hireDate;
            securityLevel = _securitylevel;
            gender = _gender;
        }




        public override string ToString()
        {
            return $"Id: {id}\nName: {name}\nSalary {salary:C}\nHireDate : {hireDate}\nSecurity Level: {securityLevel}\nGender: {gender}";
        }







    }
}
