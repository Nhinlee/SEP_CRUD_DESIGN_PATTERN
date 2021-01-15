using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SEP_CRUD_DesignPattern
{
    public partial class LoginDBForm : Form
    {
        //Server name: DESKTOP-1RVEUQ2
        public EventHandler<SqlConnectionStringBuilder> OnLoginSuccess;

        public LoginDBForm()
        {
            InitializeComponent();

            // Setup binding source for UI controller component
            bindingSourceLoginDB.DataSource = new SqlConnectionStringBuilder();
            tbServerName.DataBindings.Add("Text", bindingSourceLoginDB, "DataSource");
            tbUserName.DataBindings.Add("Text", bindingSourceLoginDB, "UserID");
            tbPassword.DataBindings.Add("Text", bindingSourceLoginDB, "Password");
            cbSelectDB.DataBindings.Add("Text", bindingSourceLoginDB, "InitialCatalog");

            // Testing purpose
            var source = (bindingSourceLoginDB.Current as SqlConnectionStringBuilder);
            source.DataSource = "DESKTOP-1RVEUQ2";
            source.UserID = "nhinlee";
            source.Password = ".";
        }

        //-------------------------Event Handlers---------------------------------------------//

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            // Get connection string builder
            var connectionString = GetConnectionString();
            // Create background worker
            var bgWorker = new BackgroundWorker();
            bgWorker.DoWork += BGWorker_TestDBConnection;
            bgWorker.RunWorkerCompleted += BGWorker_TestDBConnectionCompleted;
            bgWorker.RunWorkerAsync(connectionString);
        }

        private void cbSelectDB_DropDown(object sender, EventArgs e)
        {
            // Get databases name from server
            var table = GetDBNameTable();
            cbSelectDB.DataSource = table;
            cbSelectDB.DisplayMember = "name";
            cbSelectDB.SelectedIndex = -1;
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
            // 
            if(cbSelectDB.Text == "" || cbSelectDB.SelectedIndex < 0)
            {
                MessageBox.Show("Pls choose DB");
                return;
            }

            // Close if success
            MessageBox.Show("Login Succeed :)))");
            OnLoginSuccess?.Invoke(this, (bindingSourceLoginDB.Current as SqlConnectionStringBuilder));
            this.Close();
        }

        //--------------------------Private Methods-------------------------------------------//
        private string GetConnectionString()
        {
            return (bindingSourceLoginDB.Current as SqlConnectionStringBuilder).ConnectionString;
        }
        private void BGWorker_TestDBConnectionCompleted(object sender, RunWorkerCompletedEventArgs arg)
        {
            try
            {
                bool isConnected = (bool)arg.Result;
                if (isConnected)
                {
                    MessageBox.Show("Connect Succeed");
                }
                else
                {
                    MessageBox.Show("Connect Failed!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void BGWorker_TestDBConnection(object sender, DoWorkEventArgs arg)
        {
            var connectionString = arg.Argument as string;
            
            // return result
            arg.Result = TestDBConnection(connectionString);
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

        private DataTable GetDBNameTable()
        {
            // Init Fields
            var tableDBName = new DataTable();
            var connectionString = GetConnectionString();
            var sqlQuery = "SELECT name FROM master.dbo.sysdatabases";
            // Test Connection
            if (!TestDBConnection(connectionString))
            {
                MessageBox.Show("Connection Failed");
                return null;
            }
            // Connect DB & Execute sql query
            var connection = new SqlConnection(connectionString);
            connection.Open();
            var sqlCommand = new SqlCommand(sqlQuery, connection);
            var adapter = new SqlDataAdapter(sqlCommand);
            adapter.Fill(tableDBName);
            // Return datatable
            return tableDBName;
        }

        
    }
}
