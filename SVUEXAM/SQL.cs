using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVUEXAM
{
    internal class SQL
    {
        // Connection string - update as needed
        public static readonly string connectionString = @"Data Source=SQL8020.site4now.net;Initial Catalog=db_aac5dd_svuexam;User Id=db_aac5dd_svuexam_admin;Password=Youns@#$123;";
        public static readonly string LocalDbConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\DRLocalDB.mdf';Integrated Security=True;";

        // Method to open and return a new SqlConnection
        public static SqlConnection GetConnection(bool Local)
        {
            if (Local)
            {
                return new SqlConnection(LocalDbConnectionString);
            }
            else
            {
                return new SqlConnection(connectionString);
            }
        }

        // General method to execute a non-query (INSERT, UPDATE, DELETE)
        public static int ExecuteNonQuery(string query, bool Local, params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection connection = GetConnection(Local))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        connection.Open();
                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error executing non-query: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Indicates an error occurred
            }
        }

        // General method to fetch data using SELECT queries
        public static async Task<DataTable> ExecuteQueryAsync(string query, bool Local, params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection connection = GetConnection(Local))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable resultTable = new DataTable();
                            await Task.Run(() => adapter.Fill(resultTable));
                            return resultTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error executing query: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // Indicates an error occurred
            }
        }


        // Simplified method for inserting data
        public static int Insert(string tableName, bool Local, SqlParameter[] parameters)
        {
            try
            {
                string columns = string.Join(", ", parameters.Select(p => p.ParameterName.TrimStart('@')));
                string values = string.Join(", ", parameters.Select(p => $"@{p.ParameterName.TrimStart('@')}"));

                string query = $"INSERT INTO {tableName} ({columns}) VALUES ({values})";
                return ExecuteNonQuery(query, Local, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Indicates an error occurred
            }
        }

        // Simplified method for updating data
        public static int Update(string tableName, SqlParameter[] parameters, string whereClause, bool Local)
        {
            try
            {
                string setClause = string.Join(", ", parameters.Select(p => $"{p.ParameterName.TrimStart('@')} = @{p.ParameterName.TrimStart('@')}"));
                string query = $"UPDATE {tableName} SET {setClause} WHERE {whereClause}";

                return ExecuteNonQuery(query, Local, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Indicates an error occurred
            }
        }

        // Simplified method for deleting data
        public static int Delete(string tableName, string whereClause, bool Local, params SqlParameter[] parameters)
        {
            try
            {
                string query = $"DELETE FROM {tableName} WHERE {whereClause}";
                return ExecuteNonQuery(query, Local, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Indicates an error occurred
            }
        }
    }
}
