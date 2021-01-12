using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_CRUD_DesignPattern.DB
{
    public abstract class DatabaseProperty
    {
        public string DatabaseName { get; set; }
        public string Name { get; set; }

    }
}
