using System;
using System.Collections.Generic;
using SEP_CRUD_DesignPattern.Generators.Models;

namespace SEP_CRUD_DesignPattern.Templates.Models
{
    partial class ModelTemplate
    {
        private ModelGenerator generator;
        public ModelTemplate(ModelGenerator g)
        {
            this.generator = g;
        }
    }

    partial class ModelDaoTemplate
    {
        private ModelDaoGenerator generator;
        public ModelDaoTemplate(ModelDaoGenerator g)
        {
            this.generator = g;
        }
    }

    partial class DatabaseLoaderTemplate
    {
        private DatabaseLoaderGenerator generator;
        public DatabaseLoaderTemplate(DatabaseLoaderGenerator g)
        {
            this.generator = g;
        }
    }
}
