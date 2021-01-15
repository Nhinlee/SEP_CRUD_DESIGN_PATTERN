using SEP_CRUD_DesignPattern.Generators.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEP_CRUD_DesignPattern.Templates.Forms
{
    partial class LoginFormDesignerTemplate
    {
        private LoginFormDesignerGenerator generator;
        public LoginFormDesignerTemplate(LoginFormDesignerGenerator g)
        {
            generator = g;
        }
    }

    partial class LoginFormTemplate
    {
        private LoginFormGenerator generator;
        public LoginFormTemplate(LoginFormGenerator g)
        {
            generator = g;
        }
    }

    partial class ViewListTableFormDesignerTemplate
    {
        private ViewListTableFormDesignerGenerator generator;
        public ViewListTableFormDesignerTemplate(ViewListTableFormDesignerGenerator g)
        {
            this.generator = g;
        }
    }

    partial class ViewListTableFormTemplate
    {
        private ViewListTableFormGenerator generator;
        public ViewListTableFormTemplate(ViewListTableFormGenerator g)
        {
            this.generator = g;
        }
    }

    partial class ViewTableFormTemplate
    {
        private ViewTableFormGenerator generator;
        public ViewTableFormTemplate(ViewTableFormGenerator g)
        {
            this.generator = g;
        }
    }

    partial class ViewTableFormDesignerTemplate
    {
        private ViewTableFormDesignerGenerator generator;
        public ViewTableFormDesignerTemplate(ViewTableFormDesignerGenerator g)
        {
            this.generator = g;
        }
    }

    partial class ViewConcreteTableFormTemplate
    {
        private ViewConcreteTableFormGenerator generator;
        public ViewConcreteTableFormTemplate(ViewConcreteTableFormGenerator g)
        {
            this.generator = g;
        }
    }

    partial class ViewConcreteTableFormDesignerTemplate
    {
        private ViewConcreteTableFormDesignerGenerator generator;
        public ViewConcreteTableFormDesignerTemplate(ViewConcreteTableFormDesignerGenerator g)
        {
            this.generator = g;
        }
    }

    partial class EditFormDesignerTemplate
    {
        private EditFormDesignerGenerator generator;
        public EditFormDesignerTemplate(EditFormDesignerGenerator g)
        {
            this.generator = g;
        }
    }

    partial class EditFormTemplate
    {
        private EditFormGenerator generator;
        public EditFormTemplate(EditFormGenerator g)
        {
            this.generator = g;
        }
    }

    partial class FormTypeTemplate
    {
        private EnumFormTypeGenerator generator;
        public FormTypeTemplate(EnumFormTypeGenerator g)
        {
            this.generator = g;
        }
    }
}
