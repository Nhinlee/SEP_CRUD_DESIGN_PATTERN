using SEP_CRUD_DesignPattern.Generators.Bases;
using SEP_CRUD_DesignPattern.Generators.Helpers;
using SEP_CRUD_DesignPattern.Templates.Forms;

namespace SEP_CRUD_DesignPattern.Generators.Forms
{
    public class EnumFormTypeGenerator : ClassGenerator
    {
        public EnumFormTypeGenerator()
        {
            // TODO: Refactor this hard code
            this.Name = "EditFormType";
            this.Namespace = NamespaceHelper.Instance.FormsNamespace;
            this.RelativePath = NamespaceHelper.forms;
        }
        public override string GetSourceCode()
        {
            return new FormTypeTemplate(this).TransformText();
        }
    }
}
