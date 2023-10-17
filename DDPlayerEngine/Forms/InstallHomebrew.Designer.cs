
namespace PlayerEngine.Forms {
    partial class InstallHomebrew {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallHomebrew));
            this.CustomizeDataHost = new System.Windows.Forms.Panel();
            this.OfficialBookView = new System.Windows.Forms.FlowLayoutPanel();
            this.HomebrewBookView = new System.Windows.Forms.FlowLayoutPanel();
            this.AdoptCharacterView = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Homebrew = new System.Windows.Forms.Label();
            this.Adopt = new System.Windows.Forms.Label();
            this.OfficalBooks = new System.Windows.Forms.Label();
            this.CustomizeDataHost.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomizeDataHost
            // 
            this.CustomizeDataHost.AutoScroll = true;
            this.CustomizeDataHost.BackColor = System.Drawing.SystemColors.Menu;
            this.CustomizeDataHost.Controls.Add(this.OfficialBookView);
            this.CustomizeDataHost.Controls.Add(this.HomebrewBookView);
            this.CustomizeDataHost.Controls.Add(this.AdoptCharacterView);
            this.CustomizeDataHost.Location = new System.Drawing.Point(14, 50);
            this.CustomizeDataHost.Name = "CustomizeDataHost";
            this.CustomizeDataHost.Padding = new System.Windows.Forms.Padding(7);
            this.CustomizeDataHost.Size = new System.Drawing.Size(720, 388);
            this.CustomizeDataHost.TabIndex = 11;
            // 
            // OfficialBookView
            // 
            this.OfficialBookView.AutoScroll = true;
            this.OfficialBookView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OfficialBookView.Location = new System.Drawing.Point(7, 7);
            this.OfficialBookView.Name = "OfficialBookView";
            this.OfficialBookView.Size = new System.Drawing.Size(706, 374);
            this.OfficialBookView.TabIndex = 0;
            // 
            // HomebrewBookView
            // 
            this.HomebrewBookView.AutoScroll = true;
            this.HomebrewBookView.BackColor = System.Drawing.SystemColors.Menu;
            this.HomebrewBookView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomebrewBookView.Location = new System.Drawing.Point(7, 7);
            this.HomebrewBookView.Name = "HomebrewBookView";
            this.HomebrewBookView.Size = new System.Drawing.Size(706, 374);
            this.HomebrewBookView.TabIndex = 1;
            // 
            // AdoptCharacterView
            // 
            this.AdoptCharacterView.AutoScroll = true;
            this.AdoptCharacterView.BackColor = System.Drawing.SystemColors.Menu;
            this.AdoptCharacterView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdoptCharacterView.Location = new System.Drawing.Point(7, 7);
            this.AdoptCharacterView.Name = "AdoptCharacterView";
            this.AdoptCharacterView.Size = new System.Drawing.Size(706, 374);
            this.AdoptCharacterView.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.Homebrew);
            this.panel5.Controls.Add(this.Adopt);
            this.panel5.Controls.Add(this.OfficalBooks);
            this.panel5.Location = new System.Drawing.Point(14, 14);
            this.panel5.Margin = new System.Windows.Forms.Padding(5);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5);
            this.panel5.Size = new System.Drawing.Size(498, 39);
            this.panel5.TabIndex = 12;
            // 
            // Homebrew
            // 
            this.Homebrew.AutoSize = true;
            this.Homebrew.BackColor = System.Drawing.Color.LightGray;
            this.Homebrew.Dock = System.Windows.Forms.DockStyle.Left;
            this.Homebrew.Location = new System.Drawing.Point(210, 5);
            this.Homebrew.Margin = new System.Windows.Forms.Padding(5);
            this.Homebrew.Name = "Homebrew";
            this.Homebrew.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.Homebrew.Size = new System.Drawing.Size(131, 23);
            this.Homebrew.TabIndex = 5;
            this.Homebrew.Text = "Get Homebrew Books";
            this.Homebrew.Click += new System.EventHandler(this.Homebrew_Click);
            // 
            // Adopt
            // 
            this.Adopt.AutoSize = true;
            this.Adopt.BackColor = System.Drawing.Color.LightGray;
            this.Adopt.Dock = System.Windows.Forms.DockStyle.Left;
            this.Adopt.Location = new System.Drawing.Point(97, 5);
            this.Adopt.Margin = new System.Windows.Forms.Padding(5);
            this.Adopt.Name = "Adopt";
            this.Adopt.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.Adopt.Size = new System.Drawing.Size(113, 23);
            this.Adopt.TabIndex = 4;
            this.Adopt.Text = "Adopt a Character";
            this.Adopt.Click += new System.EventHandler(this.Adopt_Click);
            // 
            // OfficalBooks
            // 
            this.OfficalBooks.AutoSize = true;
            this.OfficalBooks.BackColor = System.Drawing.Color.DimGray;
            this.OfficalBooks.Dock = System.Windows.Forms.DockStyle.Left;
            this.OfficalBooks.Location = new System.Drawing.Point(5, 5);
            this.OfficalBooks.Margin = new System.Windows.Forms.Padding(5);
            this.OfficalBooks.Name = "OfficalBooks";
            this.OfficalBooks.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.OfficalBooks.Size = new System.Drawing.Size(92, 23);
            this.OfficalBooks.TabIndex = 3;
            this.OfficalBooks.Text = "Official Books";
            this.OfficalBooks.Click += new System.EventHandler(this.OfficalBooks_Click);
            // 
            // InstallHomebrew
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(140)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.CustomizeDataHost);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InstallHomebrew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get Additional Materials";
            this.Load += new System.EventHandler(this.InstallHomebrew_Load);
            this.CustomizeDataHost.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CustomizeDataHost;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Adopt;
        private System.Windows.Forms.Label OfficalBooks;
        private System.Windows.Forms.FlowLayoutPanel OfficialBookView;
        private System.Windows.Forms.Label Homebrew;
        private System.Windows.Forms.FlowLayoutPanel HomebrewBookView;
        private System.Windows.Forms.FlowLayoutPanel AdoptCharacterView;
    }
}