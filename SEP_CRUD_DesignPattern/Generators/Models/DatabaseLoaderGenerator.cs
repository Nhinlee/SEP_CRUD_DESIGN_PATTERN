using SEP_CRUD_DesignPattern.DB;
using SEP_CRUD_DesignPattern.Generators.Bases;
using SEP_CRUD_DesignPattern.Generators.Helpers;
using SEP_CRUD_DesignPattern.Templates.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SEP_CRUD_DesignPattern.Generators.Models
{
    public class DatabaseLoaderGenerator : ClassGenerator
    {
        public List<Table> Tables { get; }
        public SqlConnectionStringBuilder Builder { get; }
        public DatabaseLoaderGenerator(List<Table> tables, SqlConnectionStringBuilder builder)
        {
            this.Name = "DatabaseLoader";
            this.Namespace = NamespaceHelper.Instance.ModelsNamespace;
            this.RelativePath = NamespaceHelper.models;
            this.Tables = tables;
            this.Builder = builder;
        }
        public override string GetSourceCode()
        {
            return new DatabaseLoaderTemplate(this).TransformText();
        }
    }
}
