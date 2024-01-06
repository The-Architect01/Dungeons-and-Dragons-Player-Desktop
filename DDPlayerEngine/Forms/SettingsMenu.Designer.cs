
namespace PlayerEngine.Forms {
    partial class SettingsMenu {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Rulesets = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.InstallHomebrew = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(200)))), ((int)(((byte)(146)))));
            this.panel1.Controls.Add(this.Rulesets);
            this.panel1.Location = new System.Drawing.Point(19, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 245);
            this.panel1.TabIndex = 0;
            // 
            // Rulesets
            // 
            this.Rulesets.AutoScroll = true;
            this.Rulesets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rulesets.Location = new System.Drawing.Point(0, 0);
            this.Rulesets.Margin = new System.Windows.Forms.Padding(0);
            this.Rulesets.Name = "Rulesets";
            this.Rulesets.Padding = new System.Windows.Forms.Padding(10);
            this.Rulesets.Size = new System.Drawing.Size(300, 245);
            this.Rulesets.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enable Rulesets";
            // 
            // InstallHomebrew
            // 
            this.InstallHomebrew.Location = new System.Drawing.Point(203, 14);
            this.InstallHomebrew.Name = "InstallHomebrew";
            this.InstallHomebrew.Size = new System.Drawing.Size(116, 23);
            this.InstallHomebrew.TabIndex = 2;
            this.InstallHomebrew.Text = "Get Books";
            this.InstallHomebrew.UseVisualStyleBackColor = true;
            this.InstallHomebrew.Click += new System.EventHandler(this.InstallHomebrew_Click);
            // 
            // SettingsMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(337, 311);
            this.Controls.Add(this.InstallHomebrew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsMenu";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsMenu_FormClosed);
            this.Load += new System.EventHandler(this.SettingsMenu_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel Rulesets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InstallHomebrew;
    }
}