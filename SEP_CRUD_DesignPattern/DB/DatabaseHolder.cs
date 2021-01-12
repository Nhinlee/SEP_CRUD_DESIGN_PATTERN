using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_CRUD_DesignPattern.DB
{
    public class DatabaseHolder
    {
        // Singleton
        private static DatabaseHolder _instance = new DatabaseHolder();
        private DatabaseHolder() { }
        public static DatabaseHolder Instance { get => _instance; }
        // -------------------------------------------------------------

        public List<Table> tables = new List<Table>();

        public void LoadData()
        {
            DatabaseLoader.Instance.LoadData(this);
        }
    }
}
