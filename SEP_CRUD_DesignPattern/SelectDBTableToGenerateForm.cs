using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using SEP_CRUD_DesignPattern.DB;
using SEP_CRUD_DesignPattern.Generators;
using SEP_CRUD_DesignPattern.Generators.Models;
using SEP_CRUD_DesignPattern.Generators.Helpers;

namespace SEP_CRUD_DesignPattern
{
    public partial class SelectDBTableToGenerateForm : Form
    {
        public SelectDBTableToGenerateForm()
        {
            InitializeComponent();
        }

        private void SelectDBTableToGenerateForm_Shown(object sender, EventArgs e)
        {
            var loginForm = new LoginDBForm();
            loginForm.OnLoginSuccess += OnLoginSuccessHandler;
            loginForm.ShowDialog();
        }

        private void OnLoginSuccessHandler(object sender, SqlConnectionStringBuilder builder)
        {
            // Set Connection String Builder for Database Loader
            DatabaseLoader.Instance.ConnectionStringBuilder = builder;

            // Load data from database to generate purpose
            DatabaseHolder.Instance.LoadData();

            // Set data for listbox
            listBoxDBTable.DataSource = DatabaseHolder.Instance.tables;
            listBoxDBTable.DisplayMember = "DatabaseName";

            // Binding Source
            bindingSourceProjectInfo.DataSource = new ProjectInfo()
            {
                ProjectName = "GeneratedProject",
                SolutionName = "GeneratedSolution",
                Path = folderBrowserDialog.SelectedPath
            };
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                (bindingSourceProjectInfo.DataSource as ProjectInfo).Path
                    = folderBrowserDialog.SelectedPath.Replace("\\","/");
                tbLocation.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStartGenerate_Click(object sender, EventArgs e)
        {
            // DESKTOP-1RVEUQ2
            // Get list table is selected to generate
            List<Table> tables = listBoxDBTable.SelectedItems.Cast<Table>().ToList();

            // Get project information to generate
            ProjectInfo projectInfo = bindingSourceProjectInfo.Current as ProjectInfo;
            if (!projectInfo.IsOKToGenerate()) return;

            // Start Generate Project
            SolutionGenerator solution = new SolutionGenerator(projectInfo.SolutionName);
            ProjectGenerator project1 = new ProjectGenerator(projectInfo.ProjectName);
            NamespaceHelper.Instance.ProjectNamespace = project1.Name;

            // Generate Form
            FormGenerator form1 = new FormGenerator("generateForm", project1.Name, "");
            FormDesignerGenerator form1Designer = new FormDesignerGenerator(form1);
            // Generate Program
            ProgramGenerator program = new ProgramGenerator(project1.Name, form1);
            // Generate Model
            foreach (var table in tables)
            {
                ModelGenerator modelGen = new ModelGenerator(table);
                ModelDaoGenerator modelDaoGen = new ModelDaoGenerator(table);

                project1.Add(modelGen);
                project1.Add(modelDaoGen);
            }
            // Add to project and solution
            project1.Add(form1);
            project1.Add(form1Designer);
            project1.Add(program);
            solution.Add(project1);

            solution.ExportToFile(projectInfo.Path);
            Close();
        }
    }

    public class ProjectInfo
    {
        public string ProjectName { get; set; }
        public string SolutionName { get; set; }
        public string Path { get; set; }
        public string SolutionPath { get => System.IO.Path.Combine(Path,SolutionName); }

        public bool IsOKToGenerate()
        {
            return ProjectName != "" && SolutionName != "" && Path != "";
        }
    }
}
