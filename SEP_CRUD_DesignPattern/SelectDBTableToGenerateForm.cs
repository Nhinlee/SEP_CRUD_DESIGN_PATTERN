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

        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                tbLocation.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStartGenerate_Click(object sender, EventArgs e)
        {

        }
    }
}
