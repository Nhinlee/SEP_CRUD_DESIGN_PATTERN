using CustomHibernateSQL.DAO;

namespace TestingHibernateSQL
{
    class EmployeesDAO : BaseDAO<Employee>
    {
        private static EmployeesDAO _instance = null;

        public static EmployeesDAO Instance(string DBType)
        {
            if(_instance==null){
                _instance = new EmployeesDAO(DBType);
            }
            return _instance;
        }
        private EmployeesDAO(string v)
        {
            setDatabase(v);
        }
    }
}
