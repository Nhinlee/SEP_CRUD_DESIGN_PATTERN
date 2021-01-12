using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_CRUD_DesignPattern.DB
{
    public class NameConvention
    {
        public static string TableName(string databaseName)
        {
            // TODO: Table Name Convention
            return databaseName;
        }

        public static string ColumnName(string databaseName)
        {
            // TODO: Column Name Convention
            return databaseName;
        }
    }
}
