namespace Douha_DBMS
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textServer = new System.Windows.Forms.TextBox();
            this.textUser = new System.Windows.Forms.TextBox();
            this.textPW = new System.Windows.Forms.TextBox();
            this.checkAuth = new System.Windows.Forms.CheckBox();
            this.btnGetDBs = new System.Windows.Forms.Button();
            this.listDB = new System.Windows.Forms.ListBox();
            this.btnDropDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textServer
            // 
            this.textServer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textServer.Location = new System.Drawing.Point(49, 77);
            this.textServer.Name = "textServer";
            this.textServer.Size = new System.Drawing.Size(204, 25);
            this.textServer.TabIndex = 0;
            // 
            // textUser
            // 
            this.textUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textUser.Enabled = false;
            this.textUser.Location = new System.Drawing.Point(49, 163);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(204, 25);
            this.textUser.TabIndex = 1;
            // 
            // textPW
            // 
            this.textPW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textPW.Enabled = false;
            this.textPW.Location = new System.Drawing.Point(49, 207);
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
            this.checkAuth.Location = new System.Drawing.Point(49, 121);
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
            this.btnGetDBs.Location = new System.Drawing.Point(49, 251);
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
            this.listDB.Location = new System.Drawing.Point(279, 77);
            this.listDB.Name = "listDB";
            this.listDB.Size = new System.Drawing.Size(322, 157);
            this.listDB.TabIndex = 6;
            // 
            // btnDropDB
            // 
            this.btnDropDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDropDB.Location = new System.Drawing.Point(279, 251);
            this.btnDropDB.Name = "btnDropDB";
            this.btnDropDB.Size = new System.Drawing.Size(204, 37);
            this.btnDropDB.TabIndex = 7;
            this.btnDropDB.Text = "Drop database";
            this.btnDropDB.UseVisualStyleBackColor = true;
            this.btnDropDB.Click += new System.EventHandler(this.BtnDropDB_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 365);
            this.Controls.Add(this.btnDropDB);
            this.Controls.Add(this.listDB);
            this.Controls.Add(this.btnGetDBs);
            this.Controls.Add(this.checkAuth);
            this.Controls.Add(this.textPW);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.textServer);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "MainForm";
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
    }
}

