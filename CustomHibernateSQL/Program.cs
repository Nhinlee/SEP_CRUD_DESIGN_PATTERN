using CustomHibernateSQL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingHibernateSQL;

namespace CustomHibernateSQL
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
        }
    }
}
