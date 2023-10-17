
namespace PlayerEngine.Custom_Elements.Previews {
    partial class Book {
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
            this.Title = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.Download = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(55, 13);
            this.Title.TabIndex = 0;
            this.Title.Text = "Book Title";
            // 
            // Description
            // 
            this.Description.AutoEllipsis = true;
            this.Description.Location = new System.Drawing.Point(0, 25);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(271, 90);
            this.Description.TabIndex = 2;
            this.Description.Text = "Description";
            // 
            // Download
            // 
            this.Download.Location = new System.Drawing.Point(180, -2);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(89, 23);
            this.Download.TabIndex = 3;
            this.Download.Text = "Install";
            this.Download.UseVisualStyleBackColor = true;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // Book
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Download);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Title);
            this.Name = "Book";
            this.Size = new System.Drawing.Size(272, 120);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Button Download;
    }
}
