using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SEP_CRUD_DesignPattern.Util;

namespace SEP_CRUD_DesignPattern.DB
{
    public class DatabaseLoader
    {
        // Singleton
        private static DatabaseLoader _instance = new DatabaseLoader();
        private DatabaseLoader() { }
        public static DatabaseLoader Instance { get => _instance ; }
        // -------------------------------------------------------------
        
        // Private Fields
        private SqlConnection connection;
        private SqlCommand command;

        // Properties
        public SqlConnectionStringBuilder ConnectionStringBuilder{ get; set; }

        public string DataSource { get => ConnectionStringBuilder.DataSource; }
        public string InitalCatalog { get => ConnectionStringBuilder.InitialCatalog; }
        public string UserID { get => ConnectionStringBuilder.UserID;}
        public string Password { get => ConnectionStringBuilder.Password;}

        public string ConnectionString
        {
            get
            {
                return ConnectionStringBuilder.ConnectionString;
            }
        }

        // Public Methods
        public void LoadData(DatabaseHolder db)
        {
            // Load Table
            db.tables = LoadAllTable();
            // Load Column
            foreach (var table in db.tables)
            {
                LoadAllColumn(table);
            }
        }

        

        // Private Methods
        private List<Table> LoadAllTable()
        {
            List<Table> tables = new List<Table>();
            List<string> tableNames = LoadAllDBTableName();
            foreach (var tableName in tableNames)
            {
                Table t = new Table();
                t.DatabaseName = tableName;
                t.Name = NameConvention.TableName(tableName);
                tables.Add(t);
            }
            return tables;
        }

        private List<string> LoadAllDBTableName()
        {
            try
            {
                // Prepare 
                OpenConnection();
                List<string> rs = new List<string>();
                command = new SqlCommand(Constant.LoadTablesNameSQLQuery, connection);
                command.CommandType = System.Data.CommandType.Text;

                // Execute
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    string name = "";
                    while (reader.Read())
                    {
                        try
                        {
                            name = reader.GetString(0);
                        }
                        catch (Exception)
                        {
                            name = "";
                        }
                        if (name != null && name.Length != 0) rs.Add(name);
                    }
                }

                // Result
                return rs;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                CloseConnection();
            }
        }

        private void LoadAllColumn(Table table)
        {
            try
            {
                // Prepare 
                OpenConnection();
                command = new SqlCommand(Constant.LoadTableInfoSqlQuery(table.DatabaseName), connection);
                command.CommandType = System.Data.CommandType.Text;

                // Execute
                table.Clear();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Column col = new Column();
                        // Get column name
                        col.DatabaseName = reader.GetString(0);
                        col.Name = NameConvention.ColumnName(col.DatabaseName);
                        // Get column type
                        col.DatabaseType = reader.GetString(1);
                        col.Type = ConvertType.Instance.Convert(col.DatabaseType);
                        // Set primary key
                        col.IsPrimaryKey = (!reader.IsDBNull(7)) ? reader.GetBoolean(7) : false;
                        table.Columns.Add(col);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                CloseConnection();
            }
        }

        private void OpenConnection()
        {
            try
            {
                connection = new SqlConnection(ConnectionString);
                connection.Open();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        private void CloseConnection()
        {
            try
            {
                connection.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
