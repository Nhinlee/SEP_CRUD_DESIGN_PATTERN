using CustomHibernateSQL.AbstractDB;
using CustomHibernateSQL.SQLServer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomHibernateSQL.DAO
{
    public abstract class BaseDAO<T>
    {
        private IDatabase db = new SQLDatabase();
        private Type type = typeof(T);
        public List<T> GetAll()
        {
            return db.GetAll(type).Cast<T>().ToList();
        }

        public int Update(T obj)
        {
            return db.Update(obj);
        }

        public int Delete(T obj)
        {
            return db.Delete(obj);
        }

        public int Insert(T obj)
        {
            return db.Insert(obj);
        }
    }
}
