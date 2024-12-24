using System.Text.RegularExpressions;

namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Array of Employee
            //Employee[] employees = new Employee[3];
            //HireDate[] date = new HireDate[3];

            //for (int i = 0; i < employees.Length; i++)
            //{

            //    employees[i] = new Employee();
            //    date[i] = new HireDate();

            //    Console.WriteLine($"Employee {i + 1}\n*****************");
            //    Console.Write("Please enter Id: ");
            //    employees[i].Id = int.Parse(Console.ReadLine());


            //    bool flag = false;
            //    do
            //    {
            //        Console.Write("Please enter Name: ");
            //        var name = Console.ReadLine();
            //        var pattern = "[a-zA-Z]";
            //        if (Regex.IsMatch(name, pattern) && name != null)
            //        {
            //            employees[i].Name = name;
            //            flag = true;
            //        }

            //    } while (!flag);


            //    Console.Write("please enter Salary: ");
            //    employees[i].Salary = int.Parse(Console.ReadLine());

            //    Console.Write("Please enter HireDate (Day):");
            //    date[i].Day = int.Parse(Console.ReadLine());

            //    Console.Write("please enter Hire (Month)");
            //    date[i].Month = int.Parse(Console.ReadLine());

            //    Console.Write("please enter Hire (Year)");
            //    date[i].Year = int.Parse(Console.ReadLine());

            //    employees[i].HireDate = date[i];

            //    Console.Write("Please enter gender: ");
            //    var gender = Console.ReadLine().ToLower();

            //    switch (gender)
            //    {
            //        case "male":
            //            employees[i].Gender = Gender.Male;
            //            break;

            //        case "female":
            //            employees[i].Gender = Gender.Female;
            //            break;
            //    }

            //    Console.Write("please enter security level: ");
            //    var security = Console.ReadLine().ToLower();

            //    switch (security)
            //    {
            //        case "guest":
            //            employees[i].SecurityLevel = Securitylevel.guest;
            //            break;
            //        case "Developer":
            //            employees[i].SecurityLevel = Securitylevel.Developer;
            //            break;
            //        case "secretary":
            //            employees[i].SecurityLevel = Securitylevel.secretary;
            //            break;
            //        case "DBA":
            //            employees[i].SecurityLevel = Securitylevel.DBA;
            //            break;
            //    }

            //}

            //for (int i = 0; i < employees.Length; i++)
            //{
            //    Console.WriteLine($"\nEmployee{i + 1}\n******************");
            //    Console.WriteLine(employees[i].ToString());
            //}
            #endregion

            #region One Employee
            //Employee employee = new Employee();
            //HireDate date = new HireDate();

            //Console.Write("Please enter Id: ");
            //employee.Id = int.Parse(Console.ReadLine());


            //bool flag = false;
            //do
            //{
            //    Console.Write("Please enter Name:");
            //    var name = Console.ReadLine();
            //    var pattern = "[a-zA-Z]";
            //    if (Regex.IsMatch(name, pattern) && name != null)
            //    {
            //        employee.Name = name;
            //        flag = true;
            //    }

            //} while (!flag);


            //Console.Write("please enter Salary: ");
            //employee.Salary = int.Parse(Console.ReadLine());

            //Console.Write("Please enter HireDate (Day):");
            //date.Day = int.Parse(Console.ReadLine());

            //Console.Write("please enter Hire (Month)");
            //date.Month = int.Parse(Console.ReadLine());

            //Console.Write("please enter Hire (Year)");
            //date.Year = int.Parse(Console.ReadLine());

            //employee.HireDate = date;

            //Console.Write("Please enter gender: ");
            //var gender = Console.ReadLine().ToLower();

            //switch (gender)
            //{
            //    case "male":
            //        employee.Gender = Gender.Male;
            //        break;

            //    case "female":
            //        employee.Gender = Gender.Female;
            //        break;
            //}

            //Console.Write("please enter security level: ");
            //var security = Console.ReadLine().ToLower();

            //switch (security)
            //{
            //    case "guest":
            //        employee.SecurityLevel = Securitylevel.guest;
            //        break;
            //    case "developer":
            //        employee.SecurityLevel = Securitylevel.Developer;
            //        break;
            //    case "secretary":
            //        employee.SecurityLevel = Securitylevel.secretary;
            //        break;
            //    case "dba":
            //        employee.SecurityLevel = Securitylevel.DBA;
            //        break;
            //}


            //Console.WriteLine("\n***********************************");

            //Console.WriteLine(employee);

            #endregion
        }
    }
}
