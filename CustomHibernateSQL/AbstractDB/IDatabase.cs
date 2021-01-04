using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomHibernateSQL.AbstractDB
{
    interface IDatabase
    {
        // Main Methods
        IList GetAll(Type type);
        int Update(object obj);
        int Insert(object obj);
        int Delete(object obj);
    }
}
