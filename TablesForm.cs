using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Douha_DBMS
{
    public partial class TablesForm : Form
    {
        private string connectionString;
        private string databaseName;

        public TablesForm(string connString, string dbName)
        {
            InitializeComponent();
            connectionString = connString;
            databaseName = dbName;
            this.Text = $"Tables - {dbName}";
            LoadTables();
        }

        private void LoadTables()
        {
            List<string> tableNames = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    Cursor = Cursors.WaitCursor;
                    connection.Open();

                    string query = @"SELECT TABLE_NAME 
                                   FROM INFORMATION_SCHEMA.TABLES 
                                   WHERE TABLE_TYPE = 'BASE TABLE' 
                                   ORDER BY TABLE_NAME";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tableNames.Add(reader.GetString(0));
                            }
                        }
                    }

                    listTables.DataSource = tableNames;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    Cursor = Cursors.Default;
                }
            }
        }
    }
}