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
    public class LoginFormGenerator : FormGenerator
    {
        public LoginFormGenerator()
        {
            this.Name = "LoginForm";
            this.RelativePath = NamespaceHelper.forms;
            this.Namespace = NamespaceHelper.Instance.FormsNamespace;
        }
        public override string GetSourceCode()
        {
            return new LoginFormTemplate(this).TransformText();
        }
    }
}
