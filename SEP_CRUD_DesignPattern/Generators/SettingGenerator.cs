using SEP_CRUD_DesignPattern.Generators.Bases;
using SEP_CRUD_DesignPattern.Templates.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_CRUD_DesignPattern.Generators
{
    class SettingGenerator : FileGenerator
    {
        public SettingGenerator(string relativePath)
        {
            this.Name = "Settings";
            this.RelativePath = relativePath;
        }
        public override string GetFileName()
        {
            return this.Name + ".settings";
        }

        public override string GetSourceCode()
        {
            return new SettingTemplate().TransformText();
        }
    }
}
