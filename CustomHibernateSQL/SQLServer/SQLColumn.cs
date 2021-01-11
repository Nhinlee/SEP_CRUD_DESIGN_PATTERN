using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CustomHibernateSQL.AbstractDB;
using CustomHibernateSQL.Attributes;

namespace CustomHibernateSQL.SQLServer
{
    class SQLColumn : AbstractColumn
    {
        public SQLColumn(string columnName, PropertyInfo property, FieldFlags flag = FieldFlags.NORMAL)
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
            // Check Type of value
            if (value != null && !Property.PropertyType.IsAssignableFrom(value.GetType()))
                value = Convert.ChangeType(value, Property.PropertyType);
            // Set value to target object
            try
            {
                Property.SetValue(target, value);
            }
            catch (TargetInvocationException e)
            {
                throw e;
            }
        }
    }
}
