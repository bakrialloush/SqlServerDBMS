namespace Douha_DBMS
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.textServer = new System.Windows.Forms.TextBox();
            this.textUser = new System.Windows.Forms.TextBox();
            this.textPW = new System.Windows.Forms.TextBox();
            this.checkAuth = new System.Windows.Forms.CheckBox();
            this.btnGetDBs = new System.Windows.Forms.Button();
            this.listDB = new System.Windows.Forms.ListBox();
            this.btnDropDB = new System.Windows.Forms.Button();
            this.textDbName = new System.Windows.Forms.TextBox();
            this.btnCreateDB = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textServer
            // 
            this.textServer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textServer.Location = new System.Drawing.Point(16, 47);
            this.textServer.Name = "textServer";
            this.textServer.Size = new System.Drawing.Size(204, 25);
            this.textServer.TabIndex = 0;
            // 
            // textUser
            // 
            this.textUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textUser.Enabled = false;
            this.textUser.Location = new System.Drawing.Point(16, 133);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(204, 25);
            this.textUser.TabIndex = 1;
            // 
            // textPW
            // 
            this.textPW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textPW.Enabled = false;
            this.textPW.Location = new System.Drawing.Point(16, 177);
            this.textPW.Name = "textPW";
            this.textPW.Size = new System.Drawing.Size(204, 25);
            this.textPW.TabIndex = 2;
            // 
            // checkAuth
            // 
            this.checkAuth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkAuth.AutoSize = true;
            this.checkAuth.Checked = true;
            this.checkAuth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAuth.Location = new System.Drawing.Point(16, 91);
            this.checkAuth.Name = "checkAuth";
            this.checkAuth.Size = new System.Drawing.Size(124, 23);
            this.checkAuth.TabIndex = 3;
            this.checkAuth.Text = "Integrated auth";
            this.checkAuth.UseVisualStyleBackColor = true;
            this.checkAuth.CheckedChanged += new System.EventHandler(this.CheckAuth_CheckedChanged);
            // 
            // btnGetDBs
            // 
            this.btnGetDBs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGetDBs.Location = new System.Drawing.Point(16, 221);
            this.btnGetDBs.Name = "btnGetDBs";
            this.btnGetDBs.Size = new System.Drawing.Size(204, 37);
            this.btnGetDBs.TabIndex = 5;
            this.btnGetDBs.Text = "Get databases";
            this.btnGetDBs.UseVisualStyleBackColor = true;
            this.btnGetDBs.Click += new System.EventHandler(this.BtnGetDBs_Click);
            // 
            // listDB
            // 
            this.listDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listDB.FormattingEnabled = true;
            this.listDB.ItemHeight = 17;
            this.listDB.Location = new System.Drawing.Point(246, 47);
            this.listDB.Name = "listDB";
            this.listDB.Size = new System.Drawing.Size(322, 123);
            this.listDB.TabIndex = 6;
            this.listDB.DoubleClick += new System.EventHandler(this.ListDB_DoubleClick);
            // 
            // btnDropDB
            // 
            this.btnDropDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDropDB.Enabled = false;
            this.btnDropDB.ForeColor = System.Drawing.Color.IndianRed;
            this.btnDropDB.Location = new System.Drawing.Point(246, 219);
            this.btnDropDB.Name = "btnDropDB";
            this.btnDropDB.Size = new System.Drawing.Size(322, 37);
            this.btnDropDB.TabIndex = 7;
            this.btnDropDB.Text = "Drop Selected Database";
            this.btnDropDB.UseVisualStyleBackColor = true;
            this.btnDropDB.Click += new System.EventHandler(this.BtnDropDB_Click);
            // 
            // textDbName
            // 
            this.textDbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textDbName.Enabled = false;
            this.textDbName.Location = new System.Drawing.Point(574, 47);
            this.textDbName.Name = "textDbName";
            this.textDbName.Size = new System.Drawing.Size(126, 25);
            this.textDbName.TabIndex = 8;
            // 
            // btnCreateDB
            // 
            this.btnCreateDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateDB.Enabled = false;
            this.btnCreateDB.Location = new System.Drawing.Point(574, 121);
            this.btnCreateDB.Name = "btnCreateDB";
            this.btnCreateDB.Size = new System.Drawing.Size(126, 37);
            this.btnCreateDB.TabIndex = 9;
            this.btnCreateDB.Text = "Create New";
            this.btnCreateDB.UseVisualStyleBackColor = true;
            this.btnCreateDB.Click += new System.EventHandler(this.BtnCreateDB_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackup.Location = new System.Drawing.Point(246, 176);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(322, 37);
            this.btnBackup.TabIndex = 10;
            this.btnBackup.Text = "Backup Selected";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            // 
            // btnRename
            // 
            this.btnRename.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRename.Location = new System.Drawing.Point(574, 78);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(126, 37);
            this.btnRename.TabIndex = 11;
            this.btnRename.Text = "Rename Selected";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.BtnRename_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 305);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnCreateDB);
            this.Controls.Add(this.textDbName);
            this.Controls.Add(this.btnDropDB);
            this.Controls.Add(this.listDB);
            this.Controls.Add(this.btnGetDBs);
            this.Controls.Add(this.checkAuth);
            this.Controls.Add(this.textPW);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.textServer);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textServer;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.TextBox textPW;
        private System.Windows.Forms.CheckBox checkAuth;
        private System.Windows.Forms.Button btnGetDBs;
        private System.Windows.Forms.ListBox listDB;
        private System.Windows.Forms.Button btnDropDB;
        private System.Windows.Forms.TextBox textDbName;
        private System.Windows.Forms.Button btnCreateDB;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnRename;
    }
}