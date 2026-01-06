namespace Douha_DBMS
{
    partial class TablesForm
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
            this.listTables = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listTables
            // 
            this.listTables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listTables.FormattingEnabled = true;
            this.listTables.ItemHeight = 17;
            this.listTables.Location = new System.Drawing.Point(12, 12);
            this.listTables.Name = "listTables";
            this.listTables.Size = new System.Drawing.Size(290, 293);
            this.listTables.TabIndex = 0;
            // 
            // TablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 331);
            this.Controls.Add(this.listTables);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TablesForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tables";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listTables;
    }
}