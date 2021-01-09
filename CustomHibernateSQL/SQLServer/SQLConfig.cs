using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomHibernateSQL.SQLServer
{
    class SQLConfig
    {
        private static SQLConfig _instance = new SQLConfig();
        public static SQLConfig Instance() => _instance;
        private SQLConfig()
        {

        }

        public string ConnectionString { get; set; } = "Data Source=DESKTOP-1RVEUQ2;Initial Catalog=Testing;User ID=nhinlee;Password=.";
    }
}
