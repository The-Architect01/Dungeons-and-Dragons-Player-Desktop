
namespace PlayerEngine.Custom_Elements.Character_Designer_Elements {
    partial class CustomizeMenu {
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
            this.CustomizeTab = new System.Windows.Forms.Panel();
            this.CustomPreview = new System.Windows.Forms.Panel();
            this.ClickMe = new System.Windows.Forms.Label();
            this.CustomSource = new System.Windows.Forms.Label();
            this.NextCs = new System.Windows.Forms.Button();
            this.BackCs = new System.Windows.Forms.Button();
            this.CustomizeDataHost = new System.Windows.Forms.Panel();
            this.InfoDataCustom = new System.Windows.Forms.Label();
            this.CustomizeOptions = new System.Windows.Forms.ComboBox();
            this.CustomizeTitle = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.StatsCustomize = new System.Windows.Forms.Label();
            this.InfoCustom = new System.Windows.Forms.Label();
            this.CustomizeTab.SuspendLayout();
            this.CustomPreview.SuspendLayout();
            this.CustomizeDataHost.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomizeTab
            // 
            this.CustomizeTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(96)))), ((int)(((byte)(136)))));
            this.CustomizeTab.Controls.Add(this.CustomPreview);
            this.CustomizeTab.Controls.Add(this.NextCs);
            this.CustomizeTab.Controls.Add(this.BackCs);
            this.CustomizeTab.Controls.Add(this.CustomizeDataHost);
            this.CustomizeTab.Controls.Add(this.CustomizeOptions);
            this.CustomizeTab.Controls.Add(this.CustomizeTitle);
            this.CustomizeTab.Controls.Add(this.panel5);
            this.CustomizeTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomizeTab.Location = new System.Drawing.Point(0, 0);
            this.CustomizeTab.Name = "CustomizeTab";
            this.CustomizeTab.Size = new System.Drawing.Size(767, 511);
            this.CustomizeTab.TabIndex = 11;
            this.CustomizeTab.Visible = false;
            // 
            // CustomPreview
            // 
            this.CustomPreview.BackColor = System.Drawing.Color.White;
            this.CustomPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CustomPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomPreview.Controls.Add(this.ClickMe);
            this.CustomPreview.Controls.Add(this.CustomSource);
            this.CustomPreview.Location = new System.Drawing.Point(418, 161);
            this.CustomPreview.Name = "CustomPreview";
            this.CustomPreview.Size = new System.Drawing.Size(350, 350);
            this.CustomPreview.TabIndex = 12;
            // 
            // ClickMe
            // 
            this.ClickMe.BackColor = System.Drawing.Color.White;
            this.ClickMe.Location = new System.Drawing.Point(0, 169);
            this.ClickMe.Name = "ClickMe";
            this.ClickMe.Size = new System.Drawing.Size(350, 25);
            this.ClickMe.TabIndex = 12;
            this.ClickMe.Text = "Add Image";
            this.ClickMe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomSource
            // 
            this.CustomSource.AutoSize = true;
            this.CustomSource.BackColor = System.Drawing.Color.Transparent;
            this.CustomSource.Location = new System.Drawing.Point(3, 330);
            this.CustomSource.Name = "CustomSource";
            this.CustomSource.Size = new System.Drawing.Size(0, 13);
            this.CustomSource.TabIndex = 11;
            // 
            // NextCs
            // 
            this.NextCs.BackColor = System.Drawing.Color.Transparent;
            this.NextCs.Location = new System.Drawing.Point(659, 20);
            this.NextCs.Name = "NextCs";
            this.NextCs.Size = new System.Drawing.Size(96, 33);
            this.NextCs.TabIndex = 7;
            this.NextCs.Text = "Next";
            this.NextCs.UseVisualStyleBackColor = false;
            // 
            // BackCs
            // 
            this.BackCs.Location = new System.Drawing.Point(545, 20);
            this.BackCs.Name = "BackCs";
            this.BackCs.Size = new System.Drawing.Size(96, 33);
            this.BackCs.TabIndex = 6;
            this.BackCs.Text = "Back";
            this.BackCs.UseVisualStyleBackColor = true;
            // 
            // CustomizeDataHost
            // 
            this.CustomizeDataHost.AutoScroll = true;
            this.CustomizeDataHost.BackColor = System.Drawing.SystemColors.Menu;
            this.CustomizeDataHost.Controls.Add(this.InfoDataCustom);
            this.CustomizeDataHost.Location = new System.Drawing.Point(18, 172);
            this.CustomizeDataHost.Name = "CustomizeDataHost";
            this.CustomizeDataHost.Padding = new System.Windows.Forms.Padding(7);
            this.CustomizeDataHost.Size = new System.Drawing.Size(350, 315);
            this.CustomizeDataHost.TabIndex = 5;
            // 
            // InfoDataCustom
            // 
            this.InfoDataCustom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoDataCustom.Location = new System.Drawing.Point(7, 7);
            this.InfoDataCustom.Name = "InfoDataCustom";
            this.InfoDataCustom.Size = new System.Drawing.Size(336, 301);
            this.InfoDataCustom.TabIndex = 1;
            // 
            // CustomizeOptions
            // 
            this.CustomizeOptions.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CustomizeOptions.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CustomizeOptions.FormattingEnabled = true;
            this.CustomizeOptions.Items.AddRange(new object[] {
            "Lineage",
            "Class",
            "Background",
            "Stats"});
            this.CustomizeOptions.Location = new System.Drawing.Point(18, 82);
            this.CustomizeOptions.Name = "CustomizeOptions";
            this.CustomizeOptions.Size = new System.Drawing.Size(350, 21);
            this.CustomizeOptions.TabIndex = 1;
            this.CustomizeOptions.Text = "Choose One";
            // 
            // CustomizeTitle
            // 
            this.CustomizeTitle.AutoSize = true;
            this.CustomizeTitle.Location = new System.Drawing.Point(12, 20);
            this.CustomizeTitle.Name = "CustomizeTitle";
            this.CustomizeTitle.Size = new System.Drawing.Size(55, 13);
            this.CustomizeTitle.TabIndex = 2;
            this.CustomizeTitle.Text = "Customize";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.StatsCustomize);
            this.panel5.Controls.Add(this.InfoCustom);
            this.panel5.Location = new System.Drawing.Point(18, 134);
            this.panel5.Margin = new System.Windows.Forms.Padding(5);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5);
            this.panel5.Size = new System.Drawing.Size(154, 39);
            this.panel5.TabIndex = 10;
            // 
            // StatsCustomize
            // 
            this.StatsCustomize.AutoSize = true;
            this.StatsCustomize.BackColor = System.Drawing.Color.LightGray;
            this.StatsCustomize.Dock = System.Windows.Forms.DockStyle.Left;
            this.StatsCustomize.Location = new System.Drawing.Point(50, 5);
            this.StatsCustomize.Margin = new System.Windows.Forms.Padding(5);
            this.StatsCustomize.Name = "StatsCustomize";
            this.StatsCustomize.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.StatsCustomize.Size = new System.Drawing.Size(63, 23);
            this.StatsCustomize.TabIndex = 4;
            this.StatsCustomize.Text = "Options";
            // 
            // InfoCustom
            // 
            this.InfoCustom.AutoSize = true;
            this.InfoCustom.BackColor = System.Drawing.Color.DimGray;
            this.InfoCustom.Dock = System.Windows.Forms.DockStyle.Left;
            this.InfoCustom.Location = new System.Drawing.Point(5, 5);
            this.InfoCustom.Margin = new System.Windows.Forms.Padding(5);
            this.InfoCustom.Name = "InfoCustom";
            this.InfoCustom.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.InfoCustom.Size = new System.Drawing.Size(45, 23);
            this.InfoCustom.TabIndex = 3;
            this.InfoCustom.Text = "Info";
            // 
            // CustomizeMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.CustomizeTab);
            this.Name = "CustomizeMenu";
            this.Size = new System.Drawing.Size(767, 511);
            this.CustomizeTab.ResumeLayout(false);
            this.CustomizeTab.PerformLayout();
            this.CustomPreview.ResumeLayout(false);
            this.CustomPreview.PerformLayout();
            this.CustomizeDataHost.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CustomizeTab;
        private System.Windows.Forms.Panel CustomPreview;
        private System.Windows.Forms.Label ClickMe;
        private System.Windows.Forms.Label CustomSource;
        private System.Windows.Forms.Button NextCs;
        private System.Windows.Forms.Button BackCs;
        private System.Windows.Forms.Label InfoDataCustom;
        private System.Windows.Forms.ComboBox CustomizeOptions;
        private System.Windows.Forms.Label CustomizeTitle;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label StatsCustomize;
        private System.Windows.Forms.Label InfoCustom;
        public System.Windows.Forms.Panel CustomizeDataHost;
    }
}
