using SEP_CRUD_DesignPattern.Templates.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_CRUD_DesignPattern.Generators
{
    public class FormGenerator : FileGenerator
    {
        public string Namespace { get; private set; }
        public FormGenerator(string name, string nameSpace, string relativePath)
        {
            this.Name = name;
            this.Namespace = nameSpace;
            this.RelativePath = relativePath;
        }
        public override string GetFileName()
        {
            return Name + ".cs";
        }
        public override string GetSourceCode()
        {
            return new FormTemplate(this).TransformText();
        }
    }
}
