using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomHibernateSQL.Config
{
    class SQLConfig
    {
        private static SQLConfig _instance = new SQLConfig();
        public static SQLConfig Instance() => _instance;
        private SQLConfig()
        {

        }

        public string ConnectionString { get; set; } = "Data Source=ZEPHYS\\SQLEXPRESS;Initial Catalog=test;User ID=ngoc;Password=.";
    }
}
