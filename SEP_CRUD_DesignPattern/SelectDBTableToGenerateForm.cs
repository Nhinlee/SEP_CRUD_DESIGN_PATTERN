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
            // TODO: Refactor this code (group generator ->>>>>>)
            // DESKTOP-1RVEUQ2
            // Get list table is selected to generate
            var tables = listBoxDBTable.SelectedItems.Cast<Table>().ToList();

            // Get project information to generate
            var projectInfo = bindingSourceProjectInfo.Current as ProjectInfo;
            if (!projectInfo.IsOKToGenerate()) return;

            // Start Generate Project
            var solution = new SolutionGenerator(projectInfo.SolutionName);
            var project1 = new ProjectGenerator(projectInfo.ProjectName);
            NamespaceHelper.Instance.ProjectNamespace = project1.Name;

            // Generate Form
            var loginForm = new LoginFormGenerator();
            var loginFormDesigner = new LoginFormDesignerGenerator(loginForm);

            var viewListTableForm = new ViewListTableFormGenerator();
            var viewListTableFormDesigner = new ViewListTableFormDesignerGenerator(viewListTableForm);

            var viewTableForm = new ViewTableFormGenerator();
            var viewTableFormDesigner = new ViewTableFormDesignerGenerator(viewTableForm);

            // Generate Essential Class
            var dbLoader = new DatabaseLoaderGenerator(tables, DatabaseLoader.Instance.ConnectionStringBuilder);
            var enumFormType = new EnumFormTypeGenerator();
            var program = new ProgramGenerator(viewListTableForm);

            // Generate Model
            foreach (var table in tables)
            {
                // Generate Model
                var modelGen = new ModelGenerator(table);
                var modelDaoGen = new ModelDaoGenerator(table);

                // Generate View Table Form
                var viewConcreteTableForm = new ViewConcreteTableFormGenerator(table, viewTableForm);
                var viewConreteTableFormDesigner = new ViewConcreteTableFormDesignerGenerator(table.Name, viewConcreteTableForm);

                // Generate Edit Form
                var editForm = new EditFormGenerator(table);
                var editFormDesigner = new EditFormDesignerGenerator(table, editForm);

                project1.Add(modelGen);
                project1.Add(modelDaoGen);
                project1.Add(viewConcreteTableForm);
                project1.Add(viewConreteTableFormDesigner);
                project1.Add(editForm);
                project1.Add(editFormDesigner);
            }

            //-------------------------------------------------------------------------------------------------
            // Add to project and solution
            project1.Add(dbLoader);
            project1.Add(enumFormType);
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
