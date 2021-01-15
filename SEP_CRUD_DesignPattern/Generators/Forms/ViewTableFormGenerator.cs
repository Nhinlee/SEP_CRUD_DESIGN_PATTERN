using SEP_CRUD_DesignPattern.Generators.Bases;
using SEP_CRUD_DesignPattern.Generators.Helpers;
using SEP_CRUD_DesignPattern.Templates.Forms;
using System;
using System.Collections.Generic;

namespace SEP_CRUD_DesignPattern.Generators.Forms
{
    public class ViewTableFormGenerator : FormGenerator
    {
        public ViewTableFormGenerator()
        {
            this.Name = "ViewTableForm";
            this.RelativePath = NamespaceHelper.forms;
            this.Namespace = NamespaceHelper.Instance.FormsNamespace;
        }
        public override string GetSourceCode()
        {
            return new ViewTableFormTemplate(this).TransformText();
        }
    }
}
