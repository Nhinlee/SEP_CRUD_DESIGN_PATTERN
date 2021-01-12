using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEP_CRUD_DesignPattern.Generators;
using SEP_CRUD_DesignPattern.Templates.Properties;
using SEP_CRUD_DesignPattern.Util;

namespace SEP_CRUD_DesignPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SolutionGenerator solution = new SolutionGenerator("FormGeneratorSolution");

            ProjectGenerator project1 = new ProjectGenerator("Project1");
            // Form creation
            FormGenerator form1 = new FormGenerator("generateForm", project1.Name, "");
            FormDesignerGenerator form1Designer = new FormDesignerGenerator(form1);
            // Program creation
            ProgramGenerator program = new ProgramGenerator(project1.Name, form1);
            // Add to project and solution
            project1.Add(form1);
            project1.Add(form1Designer);
            project1.Add(program);
            solution.Add(project1);

            solution.ExportToFile("Output");
        }
    }
}
