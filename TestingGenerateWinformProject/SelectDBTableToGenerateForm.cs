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

namespace TestingGenerateWinformProject
{
    public partial class SelectDBTableToGenerateForm : Form
    {
        private string connectionString;
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

        private void OnLoginSuccessHandler(object sender, string connectionString)
        {
            this.connectionString = connectionString;
            var sqlQuery = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";
            var table = new DataTable();

            var connection = new SqlConnection(connectionString);
            connection.Open();
            var sqlCommand = new SqlCommand(sqlQuery, connection);
            var adapter = new SqlDataAdapter(sqlCommand);
            adapter.Fill(table);

            listBoxDBTable.DataSource = table;
            listBoxDBTable.DisplayMember = "TABLE_NAME";

            connection.Close();
        }
    }
}
