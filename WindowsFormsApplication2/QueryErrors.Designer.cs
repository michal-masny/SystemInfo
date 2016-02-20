namespace SystemInfo
{
    partial class QueryErrors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryErrors));
            this.tbQueryErrors = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbQueryErrors
            // 
            this.tbQueryErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbQueryErrors.Enabled = false;
            this.tbQueryErrors.Location = new System.Drawing.Point(0, 0);
            this.tbQueryErrors.Multiline = true;
            this.tbQueryErrors.Name = "tbQueryErrors";
            this.tbQueryErrors.Size = new System.Drawing.Size(241, 261);
            this.tbQueryErrors.TabIndex = 0;
            // 
            // QueryErrors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 261);
            this.Controls.Add(this.tbQueryErrors);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QueryErrors";
            this.Text = "Query Errors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbQueryErrors;
    }
}