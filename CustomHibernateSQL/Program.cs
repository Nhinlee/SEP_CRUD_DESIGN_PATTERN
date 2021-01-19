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
            e.Id = "E00612";
            e.Name = "Nhin Lee";
            e.BirthDate = new DateTime(1999, 2, 25);
            e.Position = "Manager";
            e.Salary = 123123;
            //EmployeesDAO.Instance("SQL").Insert(e);
            EmployeesDAO.Instance("SQL").Delete(e);

            // Get All
            List<Employee> employees = EmployeesDAO.Instance("SQL").GetAll();
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine("END");
        }
    }
}
