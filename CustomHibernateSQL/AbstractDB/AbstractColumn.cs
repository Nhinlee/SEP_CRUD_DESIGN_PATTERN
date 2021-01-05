using CustomHibernateSQL.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomHibernateSQL.AbstractDB
{
    abstract class AbstractColumn
    {
        public string ColumnName { get; protected set; }
        public PropertyInfo Property { get; protected set; }
        public FieldFlags Flag { get; protected set; }
        public abstract void SetValue(object target, object value);
        public abstract object GetValue(object obj);
    }
}
