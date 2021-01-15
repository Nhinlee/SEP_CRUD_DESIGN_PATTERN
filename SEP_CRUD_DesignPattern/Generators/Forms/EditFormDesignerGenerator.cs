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
    public class EditFormDesignerGenerator : FormDesignerGenerator
    {
        public Table Table { get; private set; }
        public EditFormDesignerGenerator(Table table, FormGenerator formOwner)
        {
            this.Name = $"Edit{table.Name}Form";
            this.RelativePath = NamespaceHelper.forms;
            this.Namespace = NamespaceHelper.Instance.FormsNamespace;
            this.Table = table;
            this.FormOwner = formOwner;
        }
        public override string GetSourceCode()
        {
            return new EditFormDesignerTemplate(this).TransformText();
        }
    }
}
