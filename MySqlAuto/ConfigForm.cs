using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.Win32;
using System.Text; // Add this using directive at the top of your file


namespace MySqlDumpApp
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDump_Click(object sender, EventArgs e)
        {
            string server = txtDumpServer.Text;
            string username = txtDumpUsername.Text;
            string password = txtDumpPassword.Text;
            string port = txtDumpPort.Text;
            string database = txtDumpDatabase.Text;

            string dumpFilePath = $"{database}_dump.sql"; // Output file for the dump

            // Create the MySQL connection string
            string connectionString = $"Server={server};Port={port};Database={database};Uid={username};Pwd={password};";

            try
            {
                // Verify the connection
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    lblDumpMessage.Text = "Connection successful!";

                    // Prepare the mysqldump command for backup
                    string mysqldumpPath = FindMysqldumpPath(); // Ensure this is in your PATH
                    string arguments = $"-h {server} -P {port} -u {username} -p{password} {database} > \"{dumpFilePath}\"";

                    // Start the mysqldump process
                    ProcessStartInfo processInfo = new ProcessStartInfo
                    {
                        FileName = mysqldumpPath,
                        Arguments = arguments,
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    using (Process process = Process.Start(processInfo))
                    {
                        process.WaitForExit();
                        lblDumpMessage.Text = "Database dump completed successfully!";
                    }
                }
            }
            catch (Exception ex)
            {
                lblDumpMessage.Text = $"An error occurred: {ex.Message}";
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnloadDb_Click(object sender, EventArgs e)
        {
            string connectionString = $"Server={txtBackupServer.Text};Port={txtBackupPort.Text};Uid={txtBackupUsername.Text};Pwd={txtBackupPassword.Text};";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand("SHOW DATABASES;", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        comboBoxDatabases.Items.Clear();
                        while (reader.Read())
                        {
                            comboBoxDatabases.Items.Add(reader[0].ToString());
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDatabase = comboBoxDatabases.SelectedItem.ToString();
            LoadDatabaseObjects(selectedDatabase);
        }


        /// <summary>
        /// /// Load tables and stored procedures for the selected database
        /// </summary>
        /// <param name="database"></param>
        private void LoadDatabaseObjects(string database)
        {
            string connectionString = $"Server={txtBackupServer.Text};Port={txtBackupPort.Text};Database={database};Uid={txtBackupUsername.Text};Pwd={txtBackupPassword.Text};";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Load Tables
                using (var command = new MySqlCommand("SHOW TABLES;", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        checkedListBoxTables.Items.Clear();
                        while (reader.Read())
                        {
                            checkedListBoxTables.Items.Add(reader[0].ToString());
                        }
                    }
                }

                // Load Stored Procedures
                using (var command = new MySqlCommand("SHOW PROCEDURE STATUS WHERE Db = @database;", connection))
                {
                    command.Parameters.AddWithValue("@database", database);
                    using (var reader = command.ExecuteReader())
                    {
                        checkedListBoxSPs.Items.Clear();
                        while (reader.Read())
                        {
                            checkedListBoxSPs.Items.Add(reader["Name"].ToString());
                        }
                    }
                }
            }
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBackup_Click(object sender, EventArgs e)
        {
            
            string server = txtBackupServer.Text;
            string username = txtBackupUsername.Text;
            string password = txtBackupPassword.Text;
            string port = txtBackupPort.Text;
            string database = txtBackupDatabase.Text;

            // Create the MySQL connection string
            string connectionString = $"Server={server};Port={port};Database={database};Uid={username};Pwd={password};";

            try
            {
                // Verify the connection
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    lblBackupMessage.Text = "Connection successful!";

                    // Find the path to mysqldump.exe
                    string mysqldumpPath = FindMysqldumpPath();
                    if (string.IsNullOrEmpty(mysqldumpPath))
                    {
                        lblBackupMessage.Text = "mysqldump.exe not found. Please ensure MySQL is installed.";
                        return;
                    }

                    // Check if any tables are selected
                    if (checkedListBoxTables.CheckedItems.Count > 0)
                    {
                        // Prepare a string of selected tables
                        StringBuilder selectedTables = new StringBuilder();
                        foreach (var item in checkedListBoxTables.CheckedItems)
                        {
                            selectedTables.Append($"{item} ");
                        }

                        // Call the BackupDatabase method
                        BackupDatabase(server, username, password, database, selectedTables.ToString().Trim());
                    }
                    else
                    {
                        // If no tables are selected, inform the user and exit
                        lblBackupMessage.Text = "No tables selected for backup.";
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                lblBackupMessage.Text = $"An error occurred: {ex.Message}";
            }
        }



        /// <summary>
        /// Handles the click event for the Restore button.
        /// </summary>
        /// <param name="server"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="database"></param>
        /// <param name="tables"></param>

        public void BackupDatabase(string server, string username, string password, string database, string tables)
        {
            // Create the backup file name with the current date
            string backupFile = txtBackupFilePath.Text;

            // Find the path to mysqldump.exe and ensure it's quoted
            string mysqldumpPath = FindMysqldumpPath();
            if (string.IsNullOrEmpty(mysqldumpPath))
            {
                lblBackupMessage.Text = "mysqldump.exe not found. Please ensure MySQL is installed.";
                return;
            }

            // Construct the mysqldump command with quotes around the path
            string command = $"\"{mysqldumpPath}\" -h {server} -u {username} -p{password} {database} {tables} > \"{backupFile}\"";

            // Start the process
            ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", command)
            {
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(processInfo))
            {
                // Capture the output and error messages
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                process.WaitForExit();

                // Check the exit code for success or failure
                if (process.ExitCode != 0)
                {
                    lblBackupMessage.Text = $"Backup failed: {error}";
                }
                else
                {
                    lblBackupMessage.Text = "Database backup completed successfully!";
                }
            }
        }


        /// <summary>
        /// / Find the path to mysqldump.exe from the registry
        /// </summary>
        /// <returns></returns>
        private string FindMysqldumpPath()
        {
            string[] registryPaths = new string[]
            {
        @"SOFTWARE\WOW6432Node\MySQL AB\MySQL Server 5.5",
       @"SOFTWARE\WOW6432Node\MySQL AB\MySQL Server 8.1" // For 32-bit applications on 64-bit OS
            };

            foreach (var registryKey in registryPaths)
            {
                try
                {
                    using (RegistryKey key = Registry.LocalMachine.OpenSubKey(registryKey))
                    {
                        if (key != null)
                        {

                            object installPath = key.GetValue("Location");
                            if (installPath != null)
                            {
                                return Path.Combine(installPath.ToString(), "bin", "mysqldump.exe");
                            }

                        }
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("You do not have permission to access the registry. Please run the application as an administrator.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while accessing the registry: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return null; // Return null if not found
        }


        /// <summary>
        /// Handles the click event for the Restore button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRestore_Click(object sender, EventArgs e)
        {
            string server = txtRestoreServer.Text;
            string username = txtRestoreUsername.Text;
            string password = txtRestorePassword.Text;
            string port = txtRestorePort.Text;
            string database = txtRestoreDatabase.Text;
            string restoreFilePath = txtRestoreFilePath.Text; // Path to the file to restore

            // Create the MySQL connection string
            string connectionString = $"Server={server};Port={port};Database={database};Uid={username};Pwd={password};";

            try
            {
                // Verify the connection
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    lblRestoreMessage.Text = "Connection successful!";

                    // Prepare the mysql command for restore
                    string mysqlPath = "mysql"; // Ensure this is in your PATH
                    string arguments = $"-h {server} -P {port} -u {username} -p{password} {database} < \"{restoreFilePath}\"";

                    // Start the mysql process for restoring
                    ProcessStartInfo processInfo = new ProcessStartInfo
                    {
                        FileName = mysqlPath,
                        Arguments = arguments,
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    using (Process process = Process.Start(processInfo))
                    {
                        process.WaitForExit();
                        lblRestoreMessage.Text = "Database restore completed successfully!";
                    }
                }
            }
            catch (Exception ex)
            {
                lblRestoreMessage.Text = $"An error occurred: {ex.Message}";
            }
        }

       
    }
}