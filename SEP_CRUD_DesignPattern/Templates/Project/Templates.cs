using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEP_CRUD_DesignPattern.Generators;

namespace SEP_CRUD_DesignPattern.Templates.Project  
{
    partial class ProjectTemplate
    {
        ProjectGenerator generator;

        public ProjectTemplate(ProjectGenerator generator)
        {
            this.generator = generator;
        }

        private List<string> GetCompileItems()
        {   
            List<string> items = new List<string>();
            // TODO:

            //
            return items;
        }
    }

    partial class SolutionTemplate
    {
        SolutionGenerator generator;
        public SolutionTemplate(SolutionGenerator g)
        {
            this.generator = g;
        }
    }
}
