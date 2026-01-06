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
        private bool isConnected = false;

        public MainForm()
        {
            InitializeComponent();
            LoadConnectionSettings();
        }

        private void LoadConnectionSettings()
        {
            textServer.Text = Properties.Settings.Default.ServerName;
            checkAuth.Checked = Properties.Settings.Default.UseIntegratedAuth;
            textUser.Text = Properties.Settings.Default.Username;
            textPW.Text = Properties.Settings.Default.Password;
        }

        private void SaveConnectionSettings()
        {
            Properties.Settings.Default.ServerName = textServer.Text;
            Properties.Settings.Default.UseIntegratedAuth = checkAuth.Checked;
            Properties.Settings.Default.Username = textUser.Text;
            Properties.Settings.Default.Password = textPW.Text;
            Properties.Settings.Default.Save();
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

                    isConnected = true;
                    UpdateControlStates();
                    SaveConnectionSettings();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    isConnected = false;
                    UpdateControlStates();
                }
                finally
                {
                    Cursor = Cursors.Default;
                    Enabled = true;
                }
            }

            return databaseNames;
        }

        private void UpdateControlStates()
        {
            textNewDB.Enabled = isConnected;
            btnCreateDB.Enabled = isConnected;
            btnDropDB.Enabled = isConnected;
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

        private void BtnCreateDB_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textNewDB.Text))
            {
                try
                {
                    Enabled = false;
                    Cursor = Cursors.WaitCursor;

                    var createCommand = $"CREATE DATABASE [{textNewDB.Text}]";
                    var connection = new SqlConnection();
                    using (SqlCommand command = new SqlCommand(createCommand, connection))
                    {
                        var security = $"False;User ID={textUser.Text};Password={textPW.Text}";
                        security = checkAuth.Checked ? "True" : security;
                        connection.ConnectionString = $@"Data Source={textServer.Text};Integrated Security={security}";
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    textNewDB.Text = "";
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

        private void ListDB_DoubleClick(object sender, EventArgs e)
        {
            if (listDB.SelectedIndex >= 0)
            {
                var security = $"False;User ID={textUser.Text};Password={textPW.Text}";
                security = checkAuth.Checked ? "True" : security;
                var connString = $@"Data Source={textServer.Text};Initial Catalog={listDB.SelectedItem};Integrated Security={security}";

                TablesForm tablesForm = new TablesForm(connString, listDB.SelectedItem.ToString());
                tablesForm.ShowDialog();
            }
        }
        private void BackupSelectedDatabase()
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "SQL Backup (*.bak)|*.bak";
                sfd.FileName = $"{listDB.SelectedItem}.bak";

                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    Enabled = false;
                    Cursor = Cursors.WaitCursor;

                    var security = $"False;User ID={textUser.Text};Password={textPW.Text}";
                    security = checkAuth.Checked ? "True" : security;

                    using (SqlConnection connection = new SqlConnection(
                        $@"Data Source={textServer.Text};Integrated Security={security}"))
                    using (SqlCommand command = new SqlCommand(
                        $"BACKUP DATABASE [{listDB.SelectedItem}] TO DISK = @path WITH INIT", connection))
                    {
                        command.Parameters.AddWithValue("@path", sfd.FileName);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Backup completed successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Backup failed: " + ex.Message);
                }
                finally
                {
                    Cursor = Cursors.Default;
                    Enabled = true;
                }
            }
        }


        private void BtnBackup_Click(object sender, EventArgs e)
        {
            if (listDB.SelectedIndex < 0)
            {
                MessageBox.Show("Select a database first.");
                return;
            }
            BackupSelectedDatabase();
        }
    }
}