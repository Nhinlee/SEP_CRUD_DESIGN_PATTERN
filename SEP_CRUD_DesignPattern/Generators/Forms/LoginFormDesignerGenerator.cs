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
    public class LoginFormDesignerGenerator : FormDesignerGenerator
    {
        public LoginFormDesignerGenerator(FormGenerator formOwner)
        {
            this.Name = "LoginForm";
            this.RelativePath = NamespaceHelper.forms;
            this.Namespace = NamespaceHelper.Instance.FormsNamespace;
            this.FormOwner = formOwner;
        }
        public override string GetSourceCode()
        {
            return new LoginFormDesignerTemplate(this).TransformText();
        }
    }
}
