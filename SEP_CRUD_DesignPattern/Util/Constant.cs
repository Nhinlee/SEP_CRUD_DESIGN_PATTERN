using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_CRUD_DesignPattern.Util
{
    public class Constant
    {
        public const string LoadTablesNameSQLQuery = @"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND
    OBJECTPROPERTY(OBJECT_ID(QUOTENAME(TABLE_SCHEMA) +
        N'.' +
        QUOTENAME(TABLE_NAME)), 'IsMSShipped') = 0";

        public static string LoadTableInfoSqlQuery(string tableName)
        {
            return @"SELECT c.name, t.name, t.name +
   CASE WHEN t.name IN ('char', 'varchar','nchar','nvarchar') THEN '('+

             CASE WHEN c.max_length=-1 THEN 'MAX'

                  ELSE CONVERT(VARCHAR(4),

                               CASE WHEN t.name IN ('nchar','nvarchar')

                               THEN  c.max_length/2 ELSE c.max_length END )

                  END +')'

          WHEN t.name IN ('decimal','numeric')

                  THEN '('+ CONVERT(VARCHAR(4),c.precision)+','

                          + CONVERT(VARCHAR(4),c.Scale)+')'

                  ELSE '' END as ""DDL name"",

   c.max_length,
   c.precision ,
   c.scale ,
   c.is_nullable,
   ISNULL(i.is_primary_key, 0)
FROM
   sys.columns c
INNER JOIN
   sys.types t ON c.user_type_id = t.user_type_id
LEFT OUTER JOIN
   sys.index_columns ic ON ic.object_id = c.object_id AND ic.column_id = c.column_id
LEFT OUTER JOIN
   sys.indexes i ON ic.object_id = i.object_id AND ic.index_id = i.index_id
WHERE
   c.object_id = OBJECT_ID('" + tableName + "')";
        }

        public string AssemblyInfoName
        {
            get
            {
                return "AssemblyInfo.cs";
            }
        }
        public string SettingsDesignerName
        {
            get
            {
                return "Settings.Designer.cs";
            }
        }
        public string SettingsName
        {
            get
            {
                return "Settings.settings";
            }
        }
    }
}
