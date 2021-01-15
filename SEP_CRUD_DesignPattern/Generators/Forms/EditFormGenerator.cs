using SEP_CRUD_DesignPattern.DB;
using SEP_CRUD_DesignPattern.Generators.Bases;
using SEP_CRUD_DesignPattern.Generators.Helpers;
using SEP_CRUD_DesignPattern.Templates.Forms;
using System;

namespace SEP_CRUD_DesignPattern.Generators.Forms
{
    public class EditFormGenerator : FormGenerator
    {
        public Table Table { get; private set; }
        public EditFormGenerator(Table table)
        {
            this.Name = $"Edit{table.Name}Form";
            this.RelativePath = NamespaceHelper.forms;
            this.Namespace = NamespaceHelper.Instance.FormsNamespace;
            this.Table = table;
        }
        public override string GetSourceCode()
        {
            return new EditFormTemplate(this).TransformText();
        }
    }
}
