using SEP_CRUD_DesignPattern.Templates.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_CRUD_DesignPattern.Generators
{
    class AssemblyInfoGenerator : FileGenerator
    {
        ProjectGenerator projectGenerator;
        public AssemblyInfoGenerator(ProjectGenerator p, string relativePath)
        {
            this.Name = "AssemblyInfo";
            this.RelativePath = relativePath;
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
