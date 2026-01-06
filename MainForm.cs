using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Douha_DBMS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnGetDBs_Click(object sender, EventArgs e)
        {
            ReloadDBs();
        }

        private void ReloadDBs()
        {
            listDB.DataSource = GetDatabaseNames();
            listDB.ClearSelected();
        }

        public List<string> GetDatabaseNames()
        {
            List<string> databaseNames = new List<string>();

            using (SqlConnection connection = new SqlConnection())
            {
                try
                {
                    Enabled = false;
                    Cursor = Cursors.WaitCursor;
                    var security = $"False;User ID={textUser.Text};Password={textPW.Text}";
                    security = checkAuth.Checked ? "True" : security;
                    connection.ConnectionString = $@"Data Source={textServer.Text};Integrated Security={security}";
                    connection.Open();

                    DataTable databasesSchema = connection.GetSchema("Databases");

                    foreach (DataRow row in databasesSchema.Rows)
                    {
                        string databaseName = row.Field<string>("database_name");
                        string[] systemDatabases = { "master", "tempdb", "model", "msdb" };
                        if (!systemDatabases.Contains(databaseName.ToLower()))
                        {
                            databaseNames.Add(databaseName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    Cursor = Cursors.Default;
                    Enabled = true;
                }
            }

            return databaseNames;
        }

        private void CheckAuth_CheckedChanged(object sender, EventArgs e)
        {
            textUser.Enabled = !checkAuth.Checked;
            textPW.Enabled = !checkAuth.Checked;
            textUser.Text = "";
            textUser.Focus();
            textPW.Text = "";
        }

        private void BtnDropDB_Click(object sender, EventArgs e)
        {
            if (listDB.SelectedIndex >= 0)
            {
                try
                {
                    Enabled = false;
                    Cursor = Cursors.WaitCursor;
                    if (MessageBox.Show($"Drop '{listDB.SelectedItem}' ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        var dropCommand = $"DROP DATABASE [{listDB.SelectedItem}]";
                        var connection = new SqlConnection();
                        using (SqlCommand command = new SqlCommand(dropCommand, connection))
                        {
                            var security = $"False;User ID={textUser.Text};Password={textPW.Text}";
                            security = checkAuth.Checked ? "True" : security;
                            connection.ConnectionString = $@"Data Source={textServer.Text};Integrated Security={security}";
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    ReloadDBs();
                    Cursor = Cursors.Default;
                    Enabled = true;
                }
            }
        }
    }
}
