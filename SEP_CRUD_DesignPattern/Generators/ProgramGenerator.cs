using SEP_CRUD_DesignPattern.Templates.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_CRUD_DesignPattern.Generators
{
    public class ProgramGenerator : FileGenerator
    {
        public string Namespace { get; private set; }
        public FormGenerator StartForm { get; private set; }
        public ProgramGenerator(string nameSpace, FormGenerator startForm)
        {
            this.Name = "Program";
            this.Namespace = nameSpace;
            this.StartForm = startForm;
        }
        public override string GetFileName()
        {
            return this.Name + ".cs";
        }

        public override string GetSourceCode()
        {
            return new ProgramTemplate(this).TransformText();
        }
    }
}
