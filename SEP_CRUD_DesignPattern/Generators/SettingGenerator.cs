using SEP_CRUD_DesignPattern.Templates.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_CRUD_DesignPattern.Generators
{
    class SettingGenerator : Generator
    {
        public SettingGenerator()
        {
            this.Name = "Settings";
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
