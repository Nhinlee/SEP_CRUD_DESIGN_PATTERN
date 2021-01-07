using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_CRUD_DesignPattern.Generators
{
    public abstract class Generator
    {
        public string Name { get; protected set; }
        public abstract string GetFileName();
        public abstract string GetSourceCode();
    }
}
