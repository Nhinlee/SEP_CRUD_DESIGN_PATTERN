using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEP_CRUD_DesignPattern.Generators.Bases;
using SEP_CRUD_DesignPattern.Generators.Helpers;
using SEP_CRUD_DesignPattern.Templates.Forms;

namespace SEP_CRUD_DesignPattern.Generators.Forms
{
    public class ViewListTableFormDesignerGenerator : FormDesignerGenerator
    {
        public ViewListTableFormDesignerGenerator(FormGenerator formOwner)
        {
            this.Name = "ViewListTableForm";
            this.RelativePath = NamespaceHelper.forms;
            this.Namespace = NamespaceHelper.Instance.FormsNamespace;
            this.FormOwner = formOwner;
        }
        public override string GetSourceCode()
        {
            return new ViewListTableFormDesignerTemplate(this).TransformText();
        }
    }
}
