using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Windows.Forms;
using SEP_CRUD_DesignPattern.DB;
using SEP_CRUD_DesignPattern.Generators;
using SEP_CRUD_DesignPattern.Generators.Models;
using SEP_CRUD_DesignPattern.Generators.Helpers;
using SEP_CRUD_DesignPattern.Generators.Forms;
using System.IO;

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
            LoginFormGenerator loginForm = new LoginFormGenerator();
            LoginFormDesignerGenerator loginFormDesigner = new LoginFormDesignerGenerator(loginForm);

            ViewListTableFormGenerator viewListTableForm = new ViewListTableFormGenerator();
            ViewListTableFormDesignerGenerator viewListTableFormDesigner = new ViewListTableFormDesignerGenerator(viewListTableForm);

            ViewTableFormGenerator viewTableForm = new ViewTableFormGenerator();
            ViewTableFormDesignerGenerator viewTableFormDesigner = new ViewTableFormDesignerGenerator(viewTableForm);

            // Generate Class
            DatabaseLoaderGenerator dbLoader = new DatabaseLoaderGenerator(tables, DatabaseLoader.Instance.ConnectionStringBuilder);
            ProgramGenerator program = new ProgramGenerator(loginForm);

            // Generate Model
            foreach (var table in tables)
            {
                ModelGenerator modelGen = new ModelGenerator(table);
                ModelDaoGenerator modelDaoGen = new ModelDaoGenerator(table);

                project1.Add(modelGen);
                project1.Add(modelDaoGen);
            }

            //-------------------------------------------------------------------------------------------------
            // Add to project and solution
            project1.Add(dbLoader);
            project1.Add(program);

            project1.Add(loginForm);
            project1.Add(loginFormDesigner);

            project1.Add(viewListTableForm);
            project1.Add(viewListTableFormDesigner);

            project1.Add(viewTableForm);
            project1.Add(viewTableFormDesigner);

            solution.Add(project1);
            solution.ExportToFile(projectInfo.Path);
            // Copy Custom Hibernate SQL to Generated Project
            CopyHibernateSQLToProject(projectInfo.SolutionPath, project1.Name);

            Close();
        }

        private void CopyHibernateSQLToProject(string solutionPath, string projectName)
        {
            // TODO: Refactor this hard code
            string fileName = "CustomHibernateSQL.dll";
            string srcPath = Path.Combine("orm", fileName);
            string destPath = Path.Combine(solutionPath, projectName, "orm");
            string destFilePath = Path.Combine(destPath, fileName);

            Directory.CreateDirectory(destPath);
            File.Create(destFilePath).Dispose();

            File.Copy(srcPath, destFilePath, true);
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
