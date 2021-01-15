using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SEP_CRUD_DesignPattern
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            
            // Add Event Handler
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);

            // Setup binding source for UI controller component
            bindingSourceLoginDB.DataSource = new SqlConnectionStringBuilder();
            tbServerName.DataBindings.Add("Text", bindingSourceLoginDB, "DataSource");
            tbUserName.DataBindings.Add("Text", bindingSourceLoginDB, "UserID");
            tbPassword.DataBindings.Add("Text", bindingSourceLoginDB, "Password");

            // Testing purpose
            var source = (bindingSourceLoginDB.Current as SqlConnectionStringBuilder);
            source.DataSource = "DESKTOP-1RVEUQ2";
            source.UserID = "nhinlee";
            source.Password = ".";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Get connection string
            var connectionString = GetConnectionString();
            // Test connection
            if (!TestDBConnection(connectionString))
            {
                MessageBox.Show("Connection Failed");
                return;
            }
            
            // Close if success
            MessageBox.Show("Login Succeed :)))");
            this.Close();
        }

        private bool TestDBConnection(string connectionString)
        {
            bool isConnected = false;
            // try connect to db
            try
            {
                var connection = new SqlConnection(connectionString);
                connection.Open();
                isConnected = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return isConnected;
        }

        private string GetConnectionString()
        {
            return (bindingSourceLoginDB.Current as SqlConnectionStringBuilder).ConnectionString;
        }
    }
}
