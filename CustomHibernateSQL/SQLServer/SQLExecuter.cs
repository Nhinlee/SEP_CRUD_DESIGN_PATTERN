using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomHibernateSQL.SQLServer
{
    class SQLExecuter
    {
        private string connectionString;
        private SqlConnection connection;
        private SqlTransaction transaction;
        private SqlCommand command;

        public SQLExecuter()
        {
            connectionString = SQLConfig.Instance().ConnectionString;
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
        }
        public void ExecuteReader(string sqlQuery, Action<Dictionary<string, object>> ResultCallback)
        {
            try
            {
                OpenConnection();
                command.CommandText = sqlQuery;
                command.Connection = this.connection;
                command.Transaction = this.transaction;

                SqlDataReader reader = command.ExecuteReader();

                int count = reader.FieldCount;
                while (reader.Read())
                {
                    Dictionary<string, object> row = new Dictionary<string, object>();
                    for (int i = 0; i < count; i++)
                    {
                        row.Add(reader.GetName(i), reader.GetValue(i));
                    }
                    ResultCallback(row);
                }

                CloseConnection();
            }
            catch (Exception e)
            {
                CloseConnection();
                throw e;
            }
        }

        public int ExcuteNonQuery(string sqlQuery, object[] parameters)
        {
            try
            {
                BeginTransaction();

                command.CommandText = sqlQuery;
                command.Connection = this.connection;
                command.Transaction = this.transaction;
                SetupCommandParameter(command, parameters);

                int count = command.ExecuteNonQuery();
                Commit();

                return count;
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

        private void SetupCommandParameter(SqlCommand command, object[] parameters)
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                parameters[i] = parameters[i] ?? DBNull.Value;
                command.Parameters.AddWithValue($"@p{i}", parameters[i]);
            }
        }

        private void Commit()
        {
            if (transaction != null)
            {
                transaction.Commit();
                transaction = null;
            }
        }

        private void BeginTransaction()
        {
            OpenConnection();
            this.transaction = connection.BeginTransaction();
        }

        private void OpenConnection()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        private void CloseConnection()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }

    }
}
