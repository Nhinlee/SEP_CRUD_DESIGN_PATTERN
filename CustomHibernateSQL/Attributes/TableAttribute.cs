using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomHibernateSQL.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class TableAttribute : Attribute
    {
        public TableAttribute(string tableName, string schema)
        {
            this.TableName = tableName;
            this.Schema = schema;
        }

        public string TableName { get; set; }
        public string Schema { get; set; }

    }
}
