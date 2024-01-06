
namespace PlayerEngine.Custom_Elements.Previews {
    partial class HomebrewBook {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Download = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Creator = new System.Windows.Forms.Label();
            this.Report = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Download
            // 
            this.Download.Location = new System.Drawing.Point(183, 1);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(89, 23);
            this.Download.TabIndex = 6;
            this.Download.Text = "Install";
            this.Download.UseVisualStyleBackColor = true;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // Description
            // 
            this.Description.AutoEllipsis = true;
            this.Description.Location = new System.Drawing.Point(1, 47);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(271, 103);
            this.Description.TabIndex = 5;
            this.Description.Text = "Description";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(3, 3);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(55, 13);
            this.Title.TabIndex = 4;
            this.Title.Text = "Book Title";
            // 
            // Creator
            // 
            this.Creator.AutoSize = true;
            this.Creator.Location = new System.Drawing.Point(3, 25);
            this.Creator.Name = "Creator";
            this.Creator.Size = new System.Drawing.Size(41, 13);
            this.Creator.TabIndex = 7;
            this.Creator.Text = "Creator";
            // 
            // Report
            // 
            this.Report.AutoSize = true;
            this.Report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Report.Location = new System.Drawing.Point(233, 27);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(39, 13);
            this.Report.TabIndex = 8;
            this.Report.Text = "Report";
            this.Report.Click += new System.EventHandler(this.Report_Click);
            // 
            // HomebrewBook
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Report);
            this.Controls.Add(this.Creator);
            this.Controls.Add(this.Download);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Title);
            this.Name = "HomebrewBook";
            this.Size = new System.Drawing.Size(275, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Download;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Creator;
        private System.Windows.Forms.Label Report;
    }
}
