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
    public class ViewConcreteTableFormDesignerGenerator : FormDesignerGenerator
    {
        public ViewConcreteTableFormDesignerGenerator(string tableName, FormGenerator formOwner)
        {
            this.Name = $"View{tableName}TableForm";
            this.Namespace = NamespaceHelper.Instance.FormsNamespace;
            this.RelativePath = NamespaceHelper.forms;
            //
            this.FormOwner = formOwner;
        }
        public override string GetSourceCode()
        {
            return new ViewConcreteTableFormDesignerTemplate(this).TransformText();
        }
    }
}
