using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomHibernateSQL.AbstractDB;
using CustomHibernateSQL.Attributes;

namespace CustomHibernateSQL.MySQL
{
    class MySQLTable : AbstractTable
    {
        public MySQLTable(string tableName, string schema, Type type)
        {
            this.TableName = tableName;
            this.Schema = schema;
            this.Type = type;
        }

        public override int Delete(object obj)
        {
            return 1;
        }

        public override IList GetAll()
        {
            return new List<string>();
        }

        public override int Update(object obj)
        {
            return 1;
        }

        public override int Insert(object obj)
        {
            return 1;
        }
    }
}
