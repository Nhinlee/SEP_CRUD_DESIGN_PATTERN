using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomHibernateSQL.Attributes
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property,
        AllowMultiple = false, Inherited = true)]
    public class ColumnAttribute : Attribute
    {
        public ColumnAttribute(string fieldName, FieldFlags flag = FieldFlags.NORMAL)
        {
            this.FieldName = fieldName;
            this.Flag = flag;
        }

        // Field name mapping in database
        public string FieldName { get; set; }
        // Flag to consider this is primary key or not
        public FieldFlags Flag { get; set; }
    }

    public enum FieldFlags
    {
        PRIMARY_KEY = 0,
        NORMAL = 1,
    }
}
