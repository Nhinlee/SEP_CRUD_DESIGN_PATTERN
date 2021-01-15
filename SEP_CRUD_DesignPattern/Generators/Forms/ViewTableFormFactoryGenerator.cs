using SEP_CRUD_DesignPattern.DB;
using SEP_CRUD_DesignPattern.Generators.Bases;
using SEP_CRUD_DesignPattern.Generators.Helpers;
using System;
using System.Collections.Generic;
using SEP_CRUD_DesignPattern.Templates.Forms;


namespace SEP_CRUD_DesignPattern.Generators.Forms
{
    public class ViewTableFormFactoryGenerator : ClassGenerator
    {
        public List<Table> Tables { get; private set; }

        public ViewTableFormFactoryGenerator(List<Table> table)
        {
            this.Tables = table;
            // TODO: refactor this hard code;
            this.Name = "ViewTableFormFactory";
            this.RelativePath = NamespaceHelper.forms;
            this.Namespace = NamespaceHelper.Instance.FormsNamespace;
        }
        public override string GetSourceCode()
        {
            return new ViewTableFormFactoryTemplate(this).TransformText();
        }
    }
}
