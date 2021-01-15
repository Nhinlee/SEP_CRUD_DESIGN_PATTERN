using SEP_CRUD_DesignPattern.DB;
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
    public class ViewConcreteTableFormGenerator : FormGenerator
    {
        public Table Table { get; private set; }
        public FormGenerator BaseForm { get; private set; }

        public ViewConcreteTableFormGenerator(Table table, FormGenerator baseForm)
        {
            this.Name = $"View{table.Name}TableForm";
            this.Namespace = NamespaceHelper.Instance.FormsNamespace;
            this.RelativePath = NamespaceHelper.forms;
            //
            this.Table = table;
            this.BaseForm = baseForm;
        }
        public override string GetSourceCode()
        {
            return new ViewConcreteTableFormTemplate(this).TransformText();
        }
    }
}
