using SEP_CRUD_DesignPattern.Generators.Bases;
using SEP_CRUD_DesignPattern.Generators.Helpers;
using SEP_CRUD_DesignPattern.Templates.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_CRUD_DesignPattern.Generators.Forms
{
    public class ViewListTableFormGenerator : FormGenerator
    {
        public ViewListTableFormGenerator()
        {
            this.Name = "ViewListTableForm";
            this.RelativePath = NamespaceHelper.forms;
            this.Namespace = NamespaceHelper.Instance.FormsNamespace;
        }
        public override string GetSourceCode()
        {
            return new ViewListTableFormTemplate(this).TransformText();
        }
    }
}
