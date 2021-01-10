using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomHibernateSQL.AbstractDB;
using CustomHibernateSQL.Attributes;

namespace CustomHibernateSQL.SQLServer
{
    class SQLTable : AbstractTable
    {
        private SQLExecuter executer = new SQLExecuter();
        public SQLTable(string tableName, string schema, Type type)
        {
            this.TableName = tableName;
            this.Schema = schema;
            this.Type = type;
        }

        public override int Delete(object obj)
        {
            // Build SQL Query -------------------------------------------
            StringBuilder sqlQuery = new StringBuilder();

            sqlQuery.Append($"DELETE FROM [{Schema}].[{TableName}] WHERE ");
            List<AbstractColumn> keyColumns = new List<AbstractColumn>();
            foreach (var col in Columns)
            {
                if (col.Flag == FieldFlags.PRIMARY_KEY)
                {
                    keyColumns.Add(col);
                }
            }
            for (int i = 0; i < keyColumns.Count; i++)
            {
                sqlQuery.Append($"[{keyColumns[i].ColumnName}]=@p{i} AND ");
            }
            sqlQuery.Remove(sqlQuery.Length - 5, 5);

            // Setup Params-----------------------------------------------
            object[] parameters = new object[keyColumns.Count];
            for (int i = 0; i < keyColumns.Count; i++)
            {
                parameters[i] = keyColumns[i].GetValue(obj);
            }
            // Execute SQL Query
            return ExecuteNonQuery(sqlQuery.ToString(), parameters);
        }

        public override IList GetAll()
        {
            // Build SQL Query
            StringBuilder sqlQuery = new StringBuilder();

            sqlQuery.Append("SELECT ");
            foreach (AbstractColumn col in Columns)
            {
                sqlQuery.Append($"[{col.ColumnName}],");
            }
            sqlQuery.Remove(sqlQuery.Length - 1, 1);
            sqlQuery.Append($" FROM [{Schema}].[{TableName}]");

            // Execute SQL Query
            try
            {
                IList rs = new List<object>();
                executer.ExecuteReader(sqlQuery.ToString(), (row) =>
                {
                    var newObject = Activator.CreateInstance(Type);
                    foreach (SQLColumn col in Columns)
                    {
                        var value = row[col.ColumnName];
                        col.SetValue(newObject, value);
                    }
                    rs.Add(newObject);
                });

                return rs;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public override int Insert(object obj)
        {
            // Build SQL Query -------------------------------------------
            StringBuilder sqlQuery = new StringBuilder();

            int count = Columns.Count;
            string[] names = new string[count];
            string[] places = new string[count];
            for (int i = 0; i < count; i++)
            {
                var col = Columns[i];
                names[i] = $"[{col.ColumnName}]";
                places[i] = $"@p{i}";
            }
            sqlQuery.Append($"INSERT INTO [{Schema}].[{TableName}] ({string.Join(",", names)}) VALUES({string.Join(",", places)})");

            // Setup Params-----------------------------------------------
            object[] parameters = new object[count];
            for (int i = 0; i < count; i++)
            {
                parameters[i] = Columns[i].GetValue(obj);
            }

            // Execute SQL Query
            return ExecuteNonQuery(sqlQuery.ToString(), parameters);
        }

        public override int Update(object obj)
        {
            // Build SQL Query -------------------------------------------
            StringBuilder sqlQuery = new StringBuilder();

            sqlQuery.Append($"UPDATE [{Schema}].[{TableName}] SET ");

            int paramIndex = 0;
            List<AbstractColumn> keyColumns = new List<AbstractColumn>();
            List<AbstractColumn> nonKeyColumns = new List<AbstractColumn>();
            foreach (var col in Columns)
            {
                if (col.Flag == FieldFlags.PRIMARY_KEY)
                {
                    keyColumns.Add(col);
                }
                else
                {
                    nonKeyColumns.Add(col);
                }
            }
            // SET
            foreach (var col in nonKeyColumns)
            {
                sqlQuery.Append($"[{col.ColumnName}]=@p{paramIndex++},");
            }
            sqlQuery.Remove(sqlQuery.Length - 1, 1);
            // WHERE
            sqlQuery.Append(" WHERE ");
            foreach (var col in keyColumns)
            {
                sqlQuery.Append($"[{col.ColumnName}]=@p{paramIndex++} AND ");
            }
            sqlQuery.Remove(sqlQuery.Length - 5, 5);
            //--------------------------------------------------------------
            // Setup Params:
            object[] parameters = new object[Columns.Count];
            paramIndex = 0;
            foreach (var col in nonKeyColumns)
            {
                parameters[paramIndex++] = col.GetValue(obj);
            }
            foreach (var col in keyColumns)
            {
                parameters[paramIndex++] = col.GetValue(obj);
            }
            //-------------------------------------------------------------
            // Execute SQL Query
            return ExecuteNonQuery(sqlQuery.ToString(), parameters);
        }

        private int ExecuteNonQuery(string sqlQuery, object[] parameters)
        {
            try
            {
                int res = executer.ExcuteNonQuery(sqlQuery.ToString(), parameters);
                return res;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
