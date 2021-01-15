using SEP_CRUD_DesignPattern.DB;
using SEP_CRUD_DesignPattern.Generators.Bases;
using System;
using SEP_CRUD_DesignPattern.Generators.Helpers;
using SEP_CRUD_DesignPattern.Templates.Models;

namespace SEP_CRUD_DesignPattern.Generators.Models
{
    public class ModelGenerator : ClassGenerator
    {
        public Table Table { get; }
        public ModelGenerator(Table table)
        {
            this.Table = table;
            this.Name = table.Name;
            this.Namespace = NamespaceHelper.Instance.ModelsNamespace;
            this.RelativePath = NamespaceHelper.models;
        }

        public override string GetSourceCode()
        {
            return new ModelTemplate(this).TransformText();
        }
    }
}
