using CustomHibernateSQL.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CustomHibernateSQL.SQLServer;
namespace CustomHibernateSQL.TableFactory
{
    class SQLTableFactory
    {
        public static SQLTable BuildSQLTable(Type type)
        {
            // Get Table Attributes -> SQL Table object
            TableAttribute tableAttr = (TableAttribute)type.GetCustomAttributes(typeof(TableAttribute), false)[0];
            SQLTable table = new SQLTable(tableAttr.TableName, tableAttr.Schema, type);


            // Get Field Attributes -> DB Field Name
            var members = new List<PropertyInfo>();
            members.AddRange(type.GetProperties());
            foreach (var member in members)
            {
                ColumnAttribute columnAttr = (ColumnAttribute)member.GetCustomAttributes(typeof(ColumnAttribute), false)[0];
                SQLColumn col = new SQLColumn(columnAttr.FieldName, member, columnAttr.Flag);
                table.Columns.Add(col);
            }

            return table;
        }
    }
}
