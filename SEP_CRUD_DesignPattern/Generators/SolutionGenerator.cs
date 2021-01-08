using SEP_CRUD_DesignPattern.Templates.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_CRUD_DesignPattern.Generators
{
    public class SolutionGenerator : GroupGenerator<ProjectGenerator>
    {
        public string Guid { get; } 
        public SolutionGenerator(string name)
        {
            this.Name = name;
            this.RelativePath = "";
            this.Guid = System.Guid.NewGuid().ToString().ToUpper();
        }
        public List<ProjectGenerator> GetProjects()
        {
            return files;
        }
        public override string GetSourceCode()
        {
            return new SolutionTemplate(this).TransformText();
        }

        public override string GetFileName()
        {
            return this.Name + ".sln";
        }
    }
}
