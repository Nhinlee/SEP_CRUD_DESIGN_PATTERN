using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_CRUD_DesignPattern.Generators.Bases
{
    public abstract class FormDesignerGenerator : ClassGenerator
    {
        public FormGenerator FormOwner { get; protected set; }

        public override string GetFileName()
        {
            return this.Name + ".Designer.cs";
        }
    }
}
