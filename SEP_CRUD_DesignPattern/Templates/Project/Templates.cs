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
            var files = generator.GetFiles();
            for (int i = 0; i < files.Count; i++) 
            {
                string path = FormatPath(files[i].GetFullRelativePath());
                if (files[i] is FormGenerator)
                {
                    items.Add($"<Compile Include=\"{path}\"><SubType>Form</SubType></Compile>");
                }
                else if(files[i] is FormDesignerGenerator)
                {
                    items.Add("<Compile Include=\""+ path +"\"><DependentUpon>"+ (files[i] as FormDesignerGenerator).FormOwner.GetFileName() +"</DependentUpon></Compile>");
                }
                else if(files[i] is ProgramGenerator)
                {
                    items.Add($"<Compile Include=\"{path}\" />");
                }
            }
            //
            return items;
        }
        private string FormatPath(string path)
        {
            path = path.Replace("/", "\\");
            return path;
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

    partial class ProgramTemplate
    {
        ProgramGenerator generator;
        public ProgramTemplate(ProgramGenerator g)
        {
            this.generator = g;
        }
    }
}
