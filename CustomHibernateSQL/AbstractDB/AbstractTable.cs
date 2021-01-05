using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomHibernateSQL.AbstractDB
{
    abstract class AbstractTable
    {
        public string TableName { get; protected set; }
        public string Schema { get; protected set; }
        public Type Type { get; protected set; }
        public List<AbstractColumn> Columns { get; set; } = new List<AbstractColumn>();

        public abstract int Delete(object obj);
        public abstract IList GetAll();
        public abstract int Update(object obj);
        public abstract int Insert(object obj);
    }
}
