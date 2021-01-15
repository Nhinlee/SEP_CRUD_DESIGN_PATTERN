using CustomHibernateSQL.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestingHibernateSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            // Insert 
            Employee e = new Employee();
            e.Id = "E006";
            e.Name = "Nhin Lee";
            e.BirthDate = new DateTime(1999, 2, 25);
            e.Position = "Manager";
            e.Salary = 123123;
            EmployeesDAO.Instance().Insert(e);

            // Get All
            List<Employee> employees = EmployeesDAO.Instance().GetAll();
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
            //ID: E001      , Name: Le Chi Nhin, BirthDate: 10/1/1999 12:00:00 AM, Position: Leader, Salary: 10000
            
        }
    }
}
