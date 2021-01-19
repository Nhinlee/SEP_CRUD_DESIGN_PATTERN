using CustomHibernateSQL.AbstractDB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomHibernateSQL.AbstractDB;
using CustomHibernateSQL.TableFactory;

namespace CustomHibernateSQL.MySQL
{
    class MySQLDatabase : IDatabase
    {
        public int Delete(object obj)
        {
            Type type = obj.GetType();
            AbstractTable table = GetTable(type);
            return table.Delete(obj);
        }

        public IList GetAll(Type type)
        {
            AbstractTable table = GetTable(type);
            return table.GetAll();
        }

        public int Insert(object obj)
        {
            Type type = obj.GetType();
            AbstractTable table = GetTable(type);
            return table.Insert(obj);
        }

        public int Update(object obj)
        {
            Type type = obj.GetType();
            AbstractTable table = GetTable(type);
            return table.Update(obj);
        }

        private AbstractTable GetTable(Type type)
        {
            return SQLTableFactory.BuildSQLTable(type);
        }
    }
}
