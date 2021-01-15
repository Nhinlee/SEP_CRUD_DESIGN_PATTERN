using CustomHibernateSQL.DAO;

namespace TestingHibernateSQL
{
    class EmployeesDAO : BaseDAO<Employee>
    {
        private static EmployeesDAO _instance = new EmployeesDAO();

        public static EmployeesDAO Instance()
        {
            return _instance;
        }
        private EmployeesDAO()
        {

        }
    }
}
