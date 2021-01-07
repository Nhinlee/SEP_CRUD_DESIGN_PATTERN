using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEP_CRUD_DesignPattern.Generators;

namespace SEP_CRUD_DesignPattern.Templates.Properties
{
    partial class AssemblyInfoTemplate
    {
        ProjectGenerator generator;
        public AssemblyInfoTemplate(ProjectGenerator p)
        {
            this.generator = p;
        }
    }
}
