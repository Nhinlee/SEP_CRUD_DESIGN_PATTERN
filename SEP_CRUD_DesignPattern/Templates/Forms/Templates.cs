using SEP_CRUD_DesignPattern.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_CRUD_DesignPattern.Templates.Forms
{
    partial class FormTemplate
    {
        FormGenerator generator;
        public FormTemplate(FormGenerator f)
        {
            generator = f;
        }
    }

    partial class FormDesignerTemplate
    {

        FormDesignerGenerator generator;
        public FormDesignerTemplate(FormDesignerGenerator f)
        {
            this.generator = f;
        }
    }
}
