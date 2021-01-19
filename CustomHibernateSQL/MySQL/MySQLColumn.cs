using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CustomHibernateSQL.AbstractDB;
using CustomHibernateSQL.Attributes;

namespace CustomHibernateSQL.MySQL
{
    class MySQLColumn : AbstractColumn
    {
        public MySQLColumn(string columnName, PropertyInfo property, FieldFlags flag = FieldFlags.NORMAL)
        {
            this.ColumnName = columnName;
            this.Property = property;
            this.Flag = flag;
        }

        public override object GetValue(object obj)
        {
            try
            {
                return Property.GetValue(obj);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public override void SetValue(object target, object value)
        {
            //do sth
        }
    }
}
