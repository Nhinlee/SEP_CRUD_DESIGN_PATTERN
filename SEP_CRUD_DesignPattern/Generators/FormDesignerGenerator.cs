using SEP_CRUD_DesignPattern.Generators.Bases;
using SEP_CRUD_DesignPattern.Templates.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_CRUD_DesignPattern.Generators
{
    public class FormDesignerGenerator : FileGenerator
    {
        public FormGenerator FormOwner { get; private set; }
        public string Namespace { get; private set; }
        public FormDesignerGenerator(FormGenerator owner)
        {
            this.FormOwner = owner;
            this.Name = owner.Name;
            this.Namespace = owner.Namespace;
            this.RelativePath = owner.RelativePath;
        }
        public override string GetFileName()
        {
            return this.Name + ".Designer.cs";
        }

        public override string GetSourceCode()
        {
            return new FormDesignerTemplate(this).TransformText();
        }
    }
}
