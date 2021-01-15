using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_CRUD_DesignPattern.Generators.Bases
{
    public abstract class ClassGenerator : FileGenerator
    {
        public string Namespace { get; set; }

        public override string GetFileName()
        {
            return this.Name + ".cs";
        }
    }
}
