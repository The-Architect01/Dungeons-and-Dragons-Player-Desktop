
namespace PlayerEngine.Custom_Elements.Previews {
    partial class Adopt {
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
            this.CharName = new System.Windows.Forms.Label();
            this.Summary = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.Preview = new System.Windows.Forms.PictureBox();
            this.Download = new System.Windows.Forms.Button();
            this.Report = new System.Windows.Forms.Label();
            this.CreatedBy = new System.Windows.Forms.Label();
            this.View = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Preview)).BeginInit();
            this.SuspendLayout();
            // 
            // CharName
            // 
            this.CharName.AutoSize = true;
            this.CharName.Location = new System.Drawing.Point(0, 0);
            this.CharName.Name = "CharName";
            this.CharName.Size = new System.Drawing.Size(112, 13);
            this.CharName.TabIndex = 0;
            this.CharName.Text = "Super long Char name";
            // 
            // Summary
            // 
            this.Summary.AutoSize = true;
            this.Summary.Location = new System.Drawing.Point(0, 27);
            this.Summary.Name = "Summary";
            this.Summary.Size = new System.Drawing.Size(120, 13);
            this.Summary.TabIndex = 1;
            this.Summary.Text = "Level 20 Wizard Wizard";
            // 
            // Description
            // 
            this.Description.AutoEllipsis = true;
            this.Description.Location = new System.Drawing.Point(0, 75);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(160, 160);
            this.Description.TabIndex = 2;
            this.Description.Text = "Super long description explaining the background of the character and the like. B" +
    "lah blah blah. Insert fill text here fill text fill text fill text.";
            // 
            // Preview
            // 
            this.Preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Preview.ImageLocation = "";
            this.Preview.Location = new System.Drawing.Point(160, 75);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(160, 160);
            this.Preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Preview.TabIndex = 3;
            this.Preview.TabStop = false;
            // 
            // Download
            // 
            this.Download.Location = new System.Drawing.Point(242, 3);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(75, 23);
            this.Download.TabIndex = 4;
            this.Download.Text = "Install";
            this.Download.UseVisualStyleBackColor = true;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // Report
            // 
            this.Report.AutoSize = true;
            this.Report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Report.Location = new System.Drawing.Point(261, 59);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(39, 13);
            this.Report.TabIndex = 5;
            this.Report.Text = "Report";
            this.Report.Click += new System.EventHandler(this.Report_Click);
            // 
            // CreatedBy
            // 
            this.CreatedBy.AutoSize = true;
            this.CreatedBy.Location = new System.Drawing.Point(0, 59);
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.Size = new System.Drawing.Size(61, 13);
            this.CreatedBy.TabIndex = 6;
            this.CreatedBy.Text = "Created by ";
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(242, 27);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(75, 23);
            this.View.TabIndex = 7;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // Adopt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.View);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.Download);
            this.Controls.Add(this.Preview);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Summary);
            this.Controls.Add(this.CharName);
            this.Controls.Add(this.CreatedBy);
            this.Name = "Adopt";
            this.Size = new System.Drawing.Size(320, 234);
            ((System.ComponentModel.ISupportInitialize)(this.Preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CharName;
        private System.Windows.Forms.Label Summary;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.PictureBox Preview;
        private System.Windows.Forms.Button Download;
        private System.Windows.Forms.Label Report;
        private System.Windows.Forms.Label CreatedBy;
        private System.Windows.Forms.Button View;
    }
}
