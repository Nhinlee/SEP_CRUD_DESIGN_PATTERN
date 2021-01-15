using System;
using System.Collections.Generic;
using SEP_CRUD_DesignPattern.Generators.Bases;
using SEP_CRUD_DesignPattern.Generators.Helpers;
using SEP_CRUD_DesignPattern.Templates.Forms;

namespace SEP_CRUD_DesignPattern.Generators.Forms
{
    public class ViewTableFormDesignerGenerator : FormDesignerGenerator
    {
        public ViewTableFormDesignerGenerator(FormGenerator formOwner)
        {
            this.Name = "ViewTableForm";
            this.RelativePath = NamespaceHelper.forms;
            this.Namespace = NamespaceHelper.Instance.FormsNamespace;
            this.FormOwner = formOwner;
        }
        public override string GetSourceCode()
        {
            return new ViewTableFormDesignerTemplate(this).TransformText();
        }
    }
}
