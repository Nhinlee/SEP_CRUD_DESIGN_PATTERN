using CustomHibernateSQL.AbstractDB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomHibernateSQL.SQLServer
{
    class SQLDatabase: IDatabase
    {
        public int Delete(object obj)
        {
            return 1;
        }

        public IList GetAll(Type type)
        {
            return new List<int>();
        }

        public int Insert(object obj)
        {
            return 1;
        }

        public int Update(object obj)
        {
            return 1;
        }
    }
}
