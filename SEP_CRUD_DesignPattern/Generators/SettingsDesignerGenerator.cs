using SEP_CRUD_DesignPattern.Templates.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_CRUD_DesignPattern.Generators
{
    class SettingsDesignerGenerator : FileGenerator
    {
        public SettingsDesignerGenerator(string relativePath)
        {
            this.Name = "Settings";
            this.RelativePath = relativePath;
        }
        public override string GetFileName()
        {
            return this.Name + ".Designer.cs";
        }

        public override string GetSourceCode()
        {
            return new SettingsDesignerTemplate().TransformText();
        }
    }
}
