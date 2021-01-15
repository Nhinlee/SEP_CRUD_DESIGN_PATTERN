using SEP_CRUD_DesignPattern.DB;
using SEP_CRUD_DesignPattern.Generators.Bases;
using SEP_CRUD_DesignPattern.Generators.Helpers;
using SEP_CRUD_DesignPattern.Templates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_CRUD_DesignPattern.Generators.Models
{
    public class ModelDaoGenerator : ClassGenerator
    {
        public Table Table { get; }
        public ModelDaoGenerator(Table table)
        {
            this.Table = table;
            // TODO: Refactor this hard code
            this.Name = table.Name + "DAO";
            this.Namespace = NamespaceHelper.Instance.ModelsNamespace;
            this.RelativePath = NamespaceHelper.models;
        }
        public override string GetSourceCode()
        {
            return new ModelDaoTemplate(this).TransformText();
        }
    }
}
