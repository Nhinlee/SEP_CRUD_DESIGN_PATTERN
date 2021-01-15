using SEP_CRUD_DesignPattern.Generators.Bases;
using SEP_CRUD_DesignPattern.Generators.Helpers;
using SEP_CRUD_DesignPattern.Templates.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_CRUD_DesignPattern.Generators
{
    public class ProgramGenerator : ClassGenerator
    {
        public ClassGenerator StartForm { get; private set; }
        public ProgramGenerator(FormGenerator startForm)
        {
            this.Name = "Program";
            this.Namespace = NamespaceHelper.Instance.ProjectNamespace;
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
