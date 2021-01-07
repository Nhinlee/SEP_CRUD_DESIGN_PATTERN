using SEP_CRUD_DesignPattern.Templates.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_CRUD_DesignPattern.Generators
{
    class AssemblyInfoGenerator : Generator
    {
        ProjectGenerator projectGenerator;
        public AssemblyInfoGenerator(ProjectGenerator p)
        {
            this.Name = "AssemblyInfo";
            this.projectGenerator = p;
        }
        public override string GetFileName()
        {
            return this.Name + ".cs";
        }

        public override string GetSourceCode()
        {
            return new AssemblyInfoTemplate(projectGenerator).TransformText();
        }
    }
}
