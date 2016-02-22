namespace SystemInfo
{
    partial class ProfileDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileDetails));
            this.dgvProfileDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfileDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProfileDetails
            // 
            this.dgvProfileDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfileDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProfileDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvProfileDetails.Name = "dgvProfileDetails";
            this.dgvProfileDetails.Size = new System.Drawing.Size(574, 187);
            this.dgvProfileDetails.TabIndex = 0;
            // 
            // ProfileDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 187);
            this.Controls.Add(this.dgvProfileDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProfileDetails";
            this.Text = "Profile Details";
            this.Load += new System.EventHandler(this.ProfileDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfileDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProfileDetails;
    }
}