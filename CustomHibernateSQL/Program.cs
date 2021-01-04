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
            Employee e = new Employee();
            Console.WriteLine(EmployeesDAO.Instance().Insert(e));
        }
    }
}
