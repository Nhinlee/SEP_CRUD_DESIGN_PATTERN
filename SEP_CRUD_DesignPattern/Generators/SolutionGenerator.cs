using SEP_CRUD_DesignPattern.Templates.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_CRUD_DesignPattern.Generators
{
    public class SolutionGenerator : Generator
    {
        List<ProjectGenerator> projectGenerators;
        public string Guid { get; } 
        public SolutionGenerator(string name)
        {
            this.Name = name;
            this.Guid = System.Guid.NewGuid().ToString().ToUpper();
            projectGenerators = new List<ProjectGenerator>();
        }
        public void AddProject(ProjectGenerator pg)
        {
            this.projectGenerators.Add(pg);
        }
        public void RemoveProject(ProjectGenerator pg)
        {
            this.projectGenerators.Remove(pg);
        }
        public List<ProjectGenerator> GetProjects()
        {
            return projectGenerators;
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
