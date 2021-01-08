using SEP_CRUD_DesignPattern.Templates.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_CRUD_DesignPattern.Generators
{
    public class ProjectGenerator : GroupGenerator<FileGenerator>
    {
        private const string typeGuid = "FAE04EC0-301F-11D3-BF4B-00C04F79EFBC";
        public string Guid { get; private set; }
        public string TypeGuid { get { return typeGuid; } }
        public ProjectGenerator(string name)
        {
            this.Name = name;
            this.RelativePath = "";
            this.Guid = System.Guid.NewGuid().ToString().ToUpper();

            string propertiesFolderStr = "Properties";
            this.files.Add(new SettingGenerator(propertiesFolderStr));
            this.files.Add(new SettingsDesignerGenerator(propertiesFolderStr));
            this.files.Add(new AssemblyInfoGenerator(this, propertiesFolderStr));
        }
        
        public override string GetSourceCode()
        {
            return new ProjectTemplate(this).TransformText();
        }

        public override string GetFileName()
        {
            return this.Name + ".csproj";
        }
    }
}
