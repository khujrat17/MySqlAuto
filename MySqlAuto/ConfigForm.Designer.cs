using System;
using System.Windows.Forms;

namespace MySqlDumpApp
{
    partial class ConfigForm
    {
        #region Windows Form Designer generated code

        private System.ComponentModel.IContainer components = null;
        private TabControl tabControl;
        private TabPage tabDump;
        private TabPage tabBackup;
        private TabPage tabRestore;
        private TextBox txtDumpServer;
        private TextBox txtDumpUsername;
        private TextBox txtDumpPassword;
        private TextBox txtDumpPort;
        private TextBox txtDumpDatabase;
        private Button btnDump;

        private Label lblDumpMessage;
        private TextBox txtBackupServer;
        private TextBox txtBackupUsername;
        private TextBox txtBackupPassword;
        private TextBox txtBackupPort;
        private TextBox txtBackupDatabase;
        private TextBox txtBackupFilePath;
        private Button btnBackup;
        private Button btnloadDb;
        private Label lblBackupMessage;
        private TextBox txtRestoreServer;
        private TextBox txtRestoreUsername;
        private TextBox txtRestorePassword;
        private TextBox txtRestorePort;
        private TextBox txtRestoreDatabase;
        private TextBox txtRestoreFilePath;
        private Button btnRestore;
        private Label lblRestoreMessage;
        private Label lblDumpServer;
        private Label lblDumpUsername;
        private Label lblDumpPassword;
        private Label lblDumpPort;
        private Label lblDumpDatabase;
        private Label lblBackupServer;
        private Label lblBackupUsername;
        private Label lblBackupPassword;
        private Label lblBackupPort;
        private Label lblBackupDatabase;
        private Label lblBackupFilePath;
        private Label lblRestoreServer;
        private Label lblRestoreUsername;
        private Label lblRestorePassword;
        private Label lblRestorePort;
        private Label lblRestoreDatabase;
        private Label lblRestoreFilePath;
        private Label lblDump;
        private Label lblBackup;
        private Label lblRestore;
        private ComboBox comboBoxDatabases;


        private CheckedListBox checkedListBoxTables;
        private CheckedListBox checkedListBoxSPs;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabDump = new System.Windows.Forms.TabPage();
            this.lblDumpServer = new System.Windows.Forms.Label();
            this.lblDumpUsername = new System.Windows.Forms.Label();
            this.lblDumpPassword = new System.Windows.Forms.Label();
            this.lblDumpPort = new System.Windows.Forms.Label();
            this.lblDumpDatabase = new System.Windows.Forms.Label();
            this.txtDumpServer = new System.Windows.Forms.TextBox();
            this.txtDumpUsername = new System.Windows.Forms.TextBox();
            this.txtDumpPassword = new System.Windows.Forms.TextBox();
            this.txtDumpPort = new System.Windows.Forms.TextBox();
            this.txtDumpDatabase = new System.Windows.Forms.TextBox();
            this.btnDump = new System.Windows.Forms.Button();
            this.lblDumpMessage = new System.Windows.Forms.Label();
            this.lblDump = new System.Windows.Forms.Label();
            this.tabBackup = new System.Windows.Forms.TabPage();
            this.btnloadDb = new System.Windows.Forms.Button();
            this.lblBackupServer = new System.Windows.Forms.Label();
            this.lblBackupUsername = new System.Windows.Forms.Label();
            this.lblBackupPassword = new System.Windows.Forms.Label();
            this.lblBackupPort = new System.Windows.Forms.Label();
            this.lblBackupDatabase = new System.Windows.Forms.Label();
            this.lblBackupFilePath = new System.Windows.Forms.Label();
            this.txtBackupServer = new System.Windows.Forms.TextBox();
            this.txtBackupUsername = new System.Windows.Forms.TextBox();
            this.txtBackupPassword = new System.Windows.Forms.TextBox();
            this.txtBackupPort = new System.Windows.Forms.TextBox();
            this.txtBackupDatabase = new System.Windows.Forms.TextBox();
            this.txtBackupFilePath = new System.Windows.Forms.TextBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.lblBackupMessage = new System.Windows.Forms.Label();
            this.lblBackup = new System.Windows.Forms.Label();
            this.checkedListBoxTables = new System.Windows.Forms.CheckedListBox();
            this.comboBoxDatabases = new System.Windows.Forms.ComboBox();
            this.checkedListBoxSPs = new System.Windows.Forms.CheckedListBox();
            this.tabRestore = new System.Windows.Forms.TabPage();
            this.lblRestoreServer = new System.Windows.Forms.Label();
            this.lblRestoreUsername = new System.Windows.Forms.Label();
            this.lblRestorePassword = new System.Windows.Forms.Label();
            this.lblRestorePort = new System.Windows.Forms.Label();
            this.lblRestoreDatabase = new System.Windows.Forms.Label();
            this.lblRestoreFilePath = new System.Windows.Forms.Label();
            this.txtRestoreServer = new System.Windows.Forms.TextBox();
            this.txtRestoreUsername = new System.Windows.Forms.TextBox();
            this.txtRestorePassword = new System.Windows.Forms.TextBox();
            this.txtRestorePort = new System.Windows.Forms.TextBox();
            this.txtRestoreDatabase = new System.Windows.Forms.TextBox();
            this.txtRestoreFilePath = new System.Windows.Forms.TextBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.lblRestoreMessage = new System.Windows.Forms.Label();
            this.lblRestore = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabDump.SuspendLayout();
            this.tabBackup.SuspendLayout();
            this.tabRestore.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDump);
            this.tabControl.Controls.Add(this.tabBackup);
            this.tabControl.Controls.Add(this.tabRestore);
            this.tabControl.Location = new System.Drawing.Point(12, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(881, 410);
            this.tabControl.TabIndex = 0;
            // 
            // tabDump
            // 
            this.tabDump.Controls.Add(this.lblDumpServer);
            this.tabDump.Controls.Add(this.lblDumpUsername);
            this.tabDump.Controls.Add(this.lblDumpPassword);
            this.tabDump.Controls.Add(this.lblDumpPort);
            this.tabDump.Controls.Add(this.lblDumpDatabase);
            this.tabDump.Controls.Add(this.txtDumpServer);
            this.tabDump.Controls.Add(this.txtDumpUsername);
            this.tabDump.Controls.Add(this.txtDumpPassword);
            this.tabDump.Controls.Add(this.txtDumpPort);
            this.tabDump.Controls.Add(this.txtDumpDatabase);
            this.tabDump.Controls.Add(this.btnDump);
            this.tabDump.Controls.Add(this.lblDumpMessage);
            this.tabDump.Controls.Add(this.lblDump);
            this.tabDump.Location = new System.Drawing.Point(4, 22);
            this.tabDump.Name = "tabDump";
            this.tabDump.Padding = new System.Windows.Forms.Padding(3);
            this.tabDump.Size = new System.Drawing.Size(873, 384);
            this.tabDump.TabIndex = 0;
            this.tabDump.Text = "Database Dump";
            this.tabDump.UseVisualStyleBackColor = true;
            // 
            // lblDumpServer
            // 
            this.lblDumpServer.AutoSize = true;
            this.lblDumpServer.Location = new System.Drawing.Point(20, 15);
            this.lblDumpServer.Name = "lblDumpServer";
            this.lblDumpServer.Size = new System.Drawing.Size(72, 13);
            this.lblDumpServer.TabIndex = 0;
            this.lblDumpServer.Text = "Server Name:";
            // 
            // lblDumpUsername
            // 
            this.lblDumpUsername.AutoSize = true;
            this.lblDumpUsername.Location = new System.Drawing.Point(20, 55);
            this.lblDumpUsername.Name = "lblDumpUsername";
            this.lblDumpUsername.Size = new System.Drawing.Size(58, 13);
            this.lblDumpUsername.TabIndex = 1;
            this.lblDumpUsername.Text = "Username:";
            // 
            // lblDumpPassword
            // 
            this.lblDumpPassword.AutoSize = true;
            this.lblDumpPassword.Location = new System.Drawing.Point(20, 103);
            this.lblDumpPassword.Name = "lblDumpPassword";
            this.lblDumpPassword.Size = new System.Drawing.Size(56, 13);
            this.lblDumpPassword.TabIndex = 2;
            this.lblDumpPassword.Text = "Password:";
            // 
            // lblDumpPort
            // 
            this.lblDumpPort.AutoSize = true;
            this.lblDumpPort.Location = new System.Drawing.Point(20, 153);
            this.lblDumpPort.Name = "lblDumpPort";
            this.lblDumpPort.Size = new System.Drawing.Size(29, 13);
            this.lblDumpPort.TabIndex = 3;
            this.lblDumpPort.Text = "Port:";
            // 
            // lblDumpDatabase
            // 
            this.lblDumpDatabase.AutoSize = true;
            this.lblDumpDatabase.Location = new System.Drawing.Point(20, 203);
            this.lblDumpDatabase.Name = "lblDumpDatabase";
            this.lblDumpDatabase.Size = new System.Drawing.Size(87, 13);
            this.lblDumpDatabase.TabIndex = 4;
            this.lblDumpDatabase.Text = "Database Name:";
            // 
            // txtDumpServer
            // 
            this.txtDumpServer.Location = new System.Drawing.Point(143, 15);
            this.txtDumpServer.Name = "txtDumpServer";
            this.txtDumpServer.Size = new System.Drawing.Size(200, 20);
            this.txtDumpServer.TabIndex = 0;
            // 
            // txtDumpUsername
            // 
            this.txtDumpUsername.Location = new System.Drawing.Point(143, 52);
            this.txtDumpUsername.Name = "txtDumpUsername";
            this.txtDumpUsername.Size = new System.Drawing.Size(200, 20);
            this.txtDumpUsername.TabIndex = 1;
            // 
            // txtDumpPassword
            // 
            this.txtDumpPassword.Location = new System.Drawing.Point(143, 103);
            this.txtDumpPassword.Name = "txtDumpPassword";
            this.txtDumpPassword.PasswordChar = '*';
            this.txtDumpPassword.Size = new System.Drawing.Size(200, 20);
            this.txtDumpPassword.TabIndex = 2;
            // 
            // txtDumpPort
            // 
            this.txtDumpPort.Location = new System.Drawing.Point(143, 153);
            this.txtDumpPort.Name = "txtDumpPort";
            this.txtDumpPort.Size = new System.Drawing.Size(200, 20);
            this.txtDumpPort.TabIndex = 3;
            // 
            // txtDumpDatabase
            // 
            this.txtDumpDatabase.Location = new System.Drawing.Point(143, 203);
            this.txtDumpDatabase.Name = "txtDumpDatabase";
            this.txtDumpDatabase.Size = new System.Drawing.Size(200, 20);
            this.txtDumpDatabase.TabIndex = 4;
            // 
            // btnDump
            // 
            this.btnDump.BackColor = System.Drawing.Color.LightGreen;
            this.btnDump.Location = new System.Drawing.Point(184, 229);
            this.btnDump.Name = "btnDump";
            this.btnDump.Size = new System.Drawing.Size(100, 30);
            this.btnDump.TabIndex = 5;
            this.btnDump.Text = "Take Dump";
            this.btnDump.UseVisualStyleBackColor = false;
            this.btnDump.Click += new System.EventHandler(this.btnDump_Click);
            // 
            // lblDumpMessage
            // 
            this.lblDumpMessage.AutoSize = true;
            this.lblDumpMessage.ForeColor = System.Drawing.Color.Red;
            this.lblDumpMessage.Location = new System.Drawing.Point(20, 260);
            this.lblDumpMessage.Name = "lblDumpMessage";
            this.lblDumpMessage.Size = new System.Drawing.Size(0, 13);
            this.lblDumpMessage.TabIndex = 6;
            // 
            // lblDump
            // 
            this.lblDump.AutoSize = true;
            this.lblDump.ForeColor = System.Drawing.Color.Black;
            this.lblDump.Location = new System.Drawing.Point(20, 243);
            this.lblDump.Name = "lblDump";
            this.lblDump.Size = new System.Drawing.Size(95, 13);
            this.lblDump.TabIndex = 7;
            this.lblDump.Text = "Click to take dump";
            // 
            // tabBackup
            // 
            this.tabBackup.Controls.Add(this.btnloadDb);
            this.tabBackup.Controls.Add(this.lblBackupServer);
            this.tabBackup.Controls.Add(this.lblBackupUsername);
            this.tabBackup.Controls.Add(this.lblBackupPassword);
            this.tabBackup.Controls.Add(this.lblBackupPort);
            this.tabBackup.Controls.Add(this.lblBackupDatabase);
            this.tabBackup.Controls.Add(this.lblBackupFilePath);
            this.tabBackup.Controls.Add(this.txtBackupServer);
            this.tabBackup.Controls.Add(this.txtBackupUsername);
            this.tabBackup.Controls.Add(this.txtBackupPassword);
            this.tabBackup.Controls.Add(this.txtBackupPort);
            this.tabBackup.Controls.Add(this.txtBackupDatabase);
            this.tabBackup.Controls.Add(this.txtBackupFilePath);
            this.tabBackup.Controls.Add(this.btnBackup);
            this.tabBackup.Controls.Add(this.lblBackupMessage);
            this.tabBackup.Controls.Add(this.lblBackup);
            this.tabBackup.Controls.Add(this.checkedListBoxTables);
            this.tabBackup.Controls.Add(this.comboBoxDatabases);
            this.tabBackup.Controls.Add(this.checkedListBoxSPs);
            this.tabBackup.Location = new System.Drawing.Point(4, 22);
            this.tabBackup.Name = "tabBackup";
            this.tabBackup.Padding = new System.Windows.Forms.Padding(3);
            this.tabBackup.Size = new System.Drawing.Size(873, 384);
            this.tabBackup.TabIndex = 1;
            this.tabBackup.Text = "Database Backup";
            this.tabBackup.UseVisualStyleBackColor = true;
            // 
            // btnloadDb
            // 
            this.btnloadDb.BackColor = System.Drawing.Color.Coral;
            this.btnloadDb.Location = new System.Drawing.Point(156, 274);
            this.btnloadDb.Name = "btnloadDb";
            this.btnloadDb.Size = new System.Drawing.Size(100, 30);
            this.btnloadDb.TabIndex = 6;
            this.btnloadDb.Text = "Load DB";
            this.btnloadDb.UseVisualStyleBackColor = false;
            this.btnloadDb.Click += new System.EventHandler(this.btnloadDb_Click);
            // 
            // lblBackupServer
            // 
            this.lblBackupServer.AutoSize = true;
            this.lblBackupServer.Location = new System.Drawing.Point(26, 20);
            this.lblBackupServer.Name = "lblBackupServer";
            this.lblBackupServer.Size = new System.Drawing.Size(72, 13);
            this.lblBackupServer.TabIndex = 0;
            this.lblBackupServer.Text = "Server Name:";
            // 
            // lblBackupUsername
            // 
            this.lblBackupUsername.AutoSize = true;
            this.lblBackupUsername.Location = new System.Drawing.Point(26, 49);
            this.lblBackupUsername.Name = "lblBackupUsername";
            this.lblBackupUsername.Size = new System.Drawing.Size(58, 13);
            this.lblBackupUsername.TabIndex = 1;
            this.lblBackupUsername.Text = "Username:";
            // 
            // lblBackupPassword
            // 
            this.lblBackupPassword.AutoSize = true;
            this.lblBackupPassword.Location = new System.Drawing.Point(26, 88);
            this.lblBackupPassword.Name = "lblBackupPassword";
            this.lblBackupPassword.Size = new System.Drawing.Size(56, 13);
            this.lblBackupPassword.TabIndex = 2;
            this.lblBackupPassword.Text = "Password:";
            // 
            // lblBackupPort
            // 
            this.lblBackupPort.AutoSize = true;
            this.lblBackupPort.Location = new System.Drawing.Point(26, 133);
            this.lblBackupPort.Name = "lblBackupPort";
            this.lblBackupPort.Size = new System.Drawing.Size(29, 13);
            this.lblBackupPort.TabIndex = 3;
            this.lblBackupPort.Text = "Port:";
            // 
            // lblBackupDatabase
            // 
            this.lblBackupDatabase.AutoSize = true;
            this.lblBackupDatabase.Location = new System.Drawing.Point(26, 185);
            this.lblBackupDatabase.Name = "lblBackupDatabase";
            this.lblBackupDatabase.Size = new System.Drawing.Size(87, 13);
            this.lblBackupDatabase.TabIndex = 4;
            this.lblBackupDatabase.Text = "Database Name:";
            // 
            // lblBackupFilePath
            // 
            this.lblBackupFilePath.AutoSize = true;
            this.lblBackupFilePath.Location = new System.Drawing.Point(26, 235);
            this.lblBackupFilePath.Name = "lblBackupFilePath";
            this.lblBackupFilePath.Size = new System.Drawing.Size(51, 13);
            this.lblBackupFilePath.TabIndex = 5;
            this.lblBackupFilePath.Text = "File Path:";
            // 
            // txtBackupServer
            // 
            this.txtBackupServer.Location = new System.Drawing.Point(172, 20);
            this.txtBackupServer.Name = "txtBackupServer";
            this.txtBackupServer.Size = new System.Drawing.Size(200, 20);
            this.txtBackupServer.TabIndex = 0;
            // 
            // txtBackupUsername
            // 
            this.txtBackupUsername.Location = new System.Drawing.Point(172, 49);
            this.txtBackupUsername.Name = "txtBackupUsername";
            this.txtBackupUsername.Size = new System.Drawing.Size(200, 20);
            this.txtBackupUsername.TabIndex = 1;
            // 
            // txtBackupPassword
            // 
            this.txtBackupPassword.Location = new System.Drawing.Point(172, 88);
            this.txtBackupPassword.Name = "txtBackupPassword";
            this.txtBackupPassword.PasswordChar = '*';
            this.txtBackupPassword.Size = new System.Drawing.Size(200, 20);
            this.txtBackupPassword.TabIndex = 2;
            // 
            // txtBackupPort
            // 
            this.txtBackupPort.Location = new System.Drawing.Point(172, 133);
            this.txtBackupPort.Name = "txtBackupPort";
            this.txtBackupPort.Size = new System.Drawing.Size(200, 20);
            this.txtBackupPort.TabIndex = 3;
            // 
            // txtBackupDatabase
            // 
            this.txtBackupDatabase.Location = new System.Drawing.Point(172, 178);
            this.txtBackupDatabase.Name = "txtBackupDatabase";
            this.txtBackupDatabase.Size = new System.Drawing.Size(200, 20);
            this.txtBackupDatabase.TabIndex = 4;
            // 
            // txtBackupFilePath
            // 
            this.txtBackupFilePath.Location = new System.Drawing.Point(172, 218);
            this.txtBackupFilePath.Name = "txtBackupFilePath";
            this.txtBackupFilePath.Size = new System.Drawing.Size(200, 20);
            this.txtBackupFilePath.TabIndex = 5;
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.LightBlue;
            this.btnBackup.Location = new System.Drawing.Point(272, 274);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(100, 30);
            this.btnBackup.TabIndex = 6;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // lblBackupMessage
            // 
            this.lblBackupMessage.AutoSize = true;
            this.lblBackupMessage.ForeColor = System.Drawing.Color.Red;
            this.lblBackupMessage.Location = new System.Drawing.Point(20, 300);
            this.lblBackupMessage.Name = "lblBackupMessage";
            this.lblBackupMessage.Size = new System.Drawing.Size(0, 13);
            this.lblBackupMessage.TabIndex = 7;
            // 
            // lblBackup
            // 
            this.lblBackup.AutoSize = true;
            this.lblBackup.ForeColor = System.Drawing.Color.Black;
            this.lblBackup.Location = new System.Drawing.Point(26, 283);
            this.lblBackup.Name = "lblBackup";
            this.lblBackup.Size = new System.Drawing.Size(99, 13);
            this.lblBackup.TabIndex = 8;
            this.lblBackup.Text = "Click to backup DB";
            // 
            // checkedListBoxTables
            // 
            this.checkedListBoxTables.FormattingEnabled = true;
            this.checkedListBoxTables.Location = new System.Drawing.Point(398, 68);
            this.checkedListBoxTables.Name = "checkedListBoxTables";
            this.checkedListBoxTables.Size = new System.Drawing.Size(226, 184);
            this.checkedListBoxTables.TabIndex = 7;
            // 
            // comboBoxDatabases
            // 
            this.comboBoxDatabases.Location = new System.Drawing.Point(489, 27);
            this.comboBoxDatabases.Name = "comboBoxDatabases";
            this.comboBoxDatabases.Size = new System.Drawing.Size(200, 21);
            this.comboBoxDatabases.TabIndex = 6;
            this.comboBoxDatabases.SelectedIndexChanged += new System.EventHandler(this.comboBoxDatabases_SelectedIndexChanged);
            // 
            // checkedListBoxSPs
            // 
            this.checkedListBoxSPs.FormattingEnabled = true;
            this.checkedListBoxSPs.Location = new System.Drawing.Point(641, 64);
            this.checkedListBoxSPs.Name = "checkedListBoxSPs";
            this.checkedListBoxSPs.Size = new System.Drawing.Size(226, 184);
            this.checkedListBoxSPs.TabIndex = 8;
            // 
            // tabRestore
            // 
            this.tabRestore.Controls.Add(this.lblRestoreServer);
            this.tabRestore.Controls.Add(this.lblRestoreUsername);
            this.tabRestore.Controls.Add(this.lblRestorePassword);
            this.tabRestore.Controls.Add(this.lblRestorePort);
            this.tabRestore.Controls.Add(this.lblRestoreDatabase);
            this.tabRestore.Controls.Add(this.lblRestoreFilePath);
            this.tabRestore.Controls.Add(this.txtRestoreServer);
            this.tabRestore.Controls.Add(this.txtRestoreUsername);
            this.tabRestore.Controls.Add(this.txtRestorePassword);
            this.tabRestore.Controls.Add(this.txtRestorePort);
            this.tabRestore.Controls.Add(this.txtRestoreDatabase);
            this.tabRestore.Controls.Add(this.txtRestoreFilePath);
            this.tabRestore.Controls.Add(this.btnRestore);
            this.tabRestore.Controls.Add(this.lblRestoreMessage);
            this.tabRestore.Controls.Add(this.lblRestore);
            this.tabRestore.Location = new System.Drawing.Point(4, 22);
            this.tabRestore.Name = "tabRestore";
            this.tabRestore.Padding = new System.Windows.Forms.Padding(3);
            this.tabRestore.Size = new System.Drawing.Size(873, 384);
            this.tabRestore.TabIndex = 2;
            this.tabRestore.Text = "Database Restore";
            this.tabRestore.UseVisualStyleBackColor = true;
            // 
            // lblRestoreServer
            // 
            this.lblRestoreServer.AutoSize = true;
            this.lblRestoreServer.Location = new System.Drawing.Point(20, 20);
            this.lblRestoreServer.Name = "lblRestoreServer";
            this.lblRestoreServer.Size = new System.Drawing.Size(72, 13);
            this.lblRestoreServer.TabIndex = 0;
            this.lblRestoreServer.Text = "Server Name:";
            // 
            // lblRestoreUsername
            // 
            this.lblRestoreUsername.AutoSize = true;
            this.lblRestoreUsername.Location = new System.Drawing.Point(20, 59);
            this.lblRestoreUsername.Name = "lblRestoreUsername";
            this.lblRestoreUsername.Size = new System.Drawing.Size(58, 13);
            this.lblRestoreUsername.TabIndex = 1;
            this.lblRestoreUsername.Text = "Username:";
            // 
            // lblRestorePassword
            // 
            this.lblRestorePassword.AutoSize = true;
            this.lblRestorePassword.Location = new System.Drawing.Point(20, 99);
            this.lblRestorePassword.Name = "lblRestorePassword";
            this.lblRestorePassword.Size = new System.Drawing.Size(56, 13);
            this.lblRestorePassword.TabIndex = 2;
            this.lblRestorePassword.Text = "Password:";
            // 
            // lblRestorePort
            // 
            this.lblRestorePort.AutoSize = true;
            this.lblRestorePort.Location = new System.Drawing.Point(20, 138);
            this.lblRestorePort.Name = "lblRestorePort";
            this.lblRestorePort.Size = new System.Drawing.Size(29, 13);
            this.lblRestorePort.TabIndex = 3;
            this.lblRestorePort.Text = "Port:";
            // 
            // lblRestoreDatabase
            // 
            this.lblRestoreDatabase.AutoSize = true;
            this.lblRestoreDatabase.Location = new System.Drawing.Point(20, 176);
            this.lblRestoreDatabase.Name = "lblRestoreDatabase";
            this.lblRestoreDatabase.Size = new System.Drawing.Size(87, 13);
            this.lblRestoreDatabase.TabIndex = 4;
            this.lblRestoreDatabase.Text = "Database Name:";
            // 
            // lblRestoreFilePath
            // 
            this.lblRestoreFilePath.AutoSize = true;
            this.lblRestoreFilePath.Location = new System.Drawing.Point(20, 217);
            this.lblRestoreFilePath.Name = "lblRestoreFilePath";
            this.lblRestoreFilePath.Size = new System.Drawing.Size(51, 13);
            this.lblRestoreFilePath.TabIndex = 5;
            this.lblRestoreFilePath.Text = "File Path:";
            // 
            // txtRestoreServer
            // 
            this.txtRestoreServer.Location = new System.Drawing.Point(158, 20);
            this.txtRestoreServer.Name = "txtRestoreServer";
            this.txtRestoreServer.Size = new System.Drawing.Size(200, 20);
            this.txtRestoreServer.TabIndex = 0;
            // 
            // txtRestoreUsername
            // 
            this.txtRestoreUsername.Location = new System.Drawing.Point(158, 59);
            this.txtRestoreUsername.Name = "txtRestoreUsername";
            this.txtRestoreUsername.Size = new System.Drawing.Size(200, 20);
            this.txtRestoreUsername.TabIndex = 1;
            // 
            // txtRestorePassword
            // 
            this.txtRestorePassword.Location = new System.Drawing.Point(158, 99);
            this.txtRestorePassword.Name = "txtRestorePassword";
            this.txtRestorePassword.PasswordChar = '*';
            this.txtRestorePassword.Size = new System.Drawing.Size(200, 20);
            this.txtRestorePassword.TabIndex = 2;
            // 
            // txtRestorePort
            // 
            this.txtRestorePort.Location = new System.Drawing.Point(158, 138);
            this.txtRestorePort.Name = "txtRestorePort";
            this.txtRestorePort.Size = new System.Drawing.Size(200, 20);
            this.txtRestorePort.TabIndex = 3;
            // 
            // txtRestoreDatabase
            // 
            this.txtRestoreDatabase.Location = new System.Drawing.Point(158, 176);
            this.txtRestoreDatabase.Name = "txtRestoreDatabase";
            this.txtRestoreDatabase.Size = new System.Drawing.Size(200, 20);
            this.txtRestoreDatabase.TabIndex = 4;
            // 
            // txtRestoreFilePath
            // 
            this.txtRestoreFilePath.Location = new System.Drawing.Point(158, 217);
            this.txtRestoreFilePath.Name = "txtRestoreFilePath";
            this.txtRestoreFilePath.Size = new System.Drawing.Size(200, 20);
            this.txtRestoreFilePath.TabIndex = 5;
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.LightCoral;
            this.btnRestore.Location = new System.Drawing.Point(201, 257);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(100, 30);
            this.btnRestore.TabIndex = 6;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // lblRestoreMessage
            // 
            this.lblRestoreMessage.AutoSize = true;
            this.lblRestoreMessage.ForeColor = System.Drawing.Color.Red;
            this.lblRestoreMessage.Location = new System.Drawing.Point(20, 300);
            this.lblRestoreMessage.Name = "lblRestoreMessage";
            this.lblRestoreMessage.Size = new System.Drawing.Size(0, 13);
            this.lblRestoreMessage.TabIndex = 7;
            // 
            // lblRestore
            // 
            this.lblRestore.AutoSize = true;
            this.lblRestore.ForeColor = System.Drawing.Color.Black;
            this.lblRestore.Location = new System.Drawing.Point(20, 257);
            this.lblRestore.Name = "lblRestore";
            this.lblRestore.Size = new System.Drawing.Size(95, 13);
            this.lblRestore.TabIndex = 8;
            this.lblRestore.Text = "Click to restore DB";
            // 
            // ConfigForm
            // 
            this.ClientSize = new System.Drawing.Size(1027, 653);
            this.Controls.Add(this.tabControl);
            this.Name = "ConfigForm";
            this.Text = "MySQL Database Management";
            this.tabControl.ResumeLayout(false);
            this.tabDump.ResumeLayout(false);
            this.tabDump.PerformLayout();
            this.tabBackup.ResumeLayout(false);
            this.tabBackup.PerformLayout();
            this.tabRestore.ResumeLayout(false);
            this.tabRestore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

      
    }
}