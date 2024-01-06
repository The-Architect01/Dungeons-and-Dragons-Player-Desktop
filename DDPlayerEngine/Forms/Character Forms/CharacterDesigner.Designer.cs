
using PlayerEngine.Custom_Elements;
using PlayerEngine.Data;
using System.Drawing;
using System.Windows.Forms;
using System;
using PlayerEngine.Properties;

namespace PlayerEngine.Forms {
    partial class CharacterDesigner {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterDesigner));
            this.LineageOptions = new System.Windows.Forms.ComboBox();
            this.LineageTitle = new System.Windows.Forms.Label();
            this.LineageTab = new System.Windows.Forms.Panel();
            this.ClassTab = new System.Windows.Forms.Panel();
            this.BackgroundTab = new System.Windows.Forms.Panel();
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
            this.BackgroundPreview = new System.Windows.Forms.Panel();
            this.BackgroundSource = new System.Windows.Forms.Label();
            this.NextB = new System.Windows.Forms.Button();
            this.BackB = new System.Windows.Forms.Button();
            this.BackgroundDataHost = new System.Windows.Forms.Panel();
            this.InfoDataB = new System.Windows.Forms.Label();
            this.BackgroundOptions = new System.Windows.Forms.ComboBox();
            this.BackgroundTitle = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.StatsB = new System.Windows.Forms.Label();
            this.InfoB = new System.Windows.Forms.Label();
            this.ClassPreview = new System.Windows.Forms.Panel();
            this.ClassSource = new System.Windows.Forms.Label();
            this.AddClass = new System.Windows.Forms.Button();
            this.AdditionalClass = new System.Windows.Forms.Panel();
            this.RemoveClass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Class2Options = new System.Windows.Forms.ComboBox();
            this.LevelClass2 = new System.Windows.Forms.ComboBox();
            this.LevelClass1Label = new System.Windows.Forms.Label();
            this.LevelClass1 = new System.Windows.Forms.ComboBox();
            this.NextC = new System.Windows.Forms.Button();
            this.BackC = new System.Windows.Forms.Button();
            this.ClassDataHost = new System.Windows.Forms.Panel();
            this.InfoDataC = new System.Windows.Forms.Label();
            this.ClassOptions = new System.Windows.Forms.ComboBox();
            this.ClassTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.StatsC = new System.Windows.Forms.Label();
            this.InfoC = new System.Windows.Forms.Label();
            this.LineagePreview = new System.Windows.Forms.Panel();
            this.LineageSource = new System.Windows.Forms.Label();
            this.NextL = new System.Windows.Forms.Button();
            this.BackL = new System.Windows.Forms.Button();
            this.LineageDataHost = new System.Windows.Forms.Panel();
            this.InfoDataL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TraitsL = new System.Windows.Forms.Label();
            this.InfoL = new System.Windows.Forms.Label();
            this.Animator = new System.Timers.Timer();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.LineageTab.SuspendLayout();
            this.ClassTab.SuspendLayout();
            this.BackgroundTab.SuspendLayout();
            this.CustomizeTab.SuspendLayout();
            this.CustomPreview.SuspendLayout();
            this.CustomizeDataHost.SuspendLayout();
            this.panel5.SuspendLayout();
            this.BackgroundPreview.SuspendLayout();
            this.BackgroundDataHost.SuspendLayout();
            this.panel4.SuspendLayout();
            this.ClassPreview.SuspendLayout();
            this.AdditionalClass.SuspendLayout();
            this.ClassDataHost.SuspendLayout();
            this.panel3.SuspendLayout();
            this.LineagePreview.SuspendLayout();
            this.LineageDataHost.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Animator)).BeginInit();
            this.SuspendLayout();
            // 
            // LineageOptions
            // 
            this.LineageOptions.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.LineageOptions.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.LineageOptions.FormattingEnabled = true;
            this.LineageOptions.Items.AddRange(new object[] {
            "Human",
            "Changeling",
            "Huge",
            "Testing",
            "Sample",
            "SuperLong"});
            this.LineageOptions.Location = new System.Drawing.Point(18, 82);
            this.LineageOptions.Name = "LineageOptions";
            this.LineageOptions.Size = new System.Drawing.Size(350, 21);
            this.LineageOptions.TabIndex = 1;
            this.LineageOptions.Text = "Choose One";
            this.LineageOptions.SelectedIndexChanged += new System.EventHandler(this.LineageOptions_SelectedIndexChanged);
            // 
            // LineageTitle
            // 
            this.LineageTitle.AutoSize = true;
            this.LineageTitle.Location = new System.Drawing.Point(12, 20);
            this.LineageTitle.Name = "LineageTitle";
            this.LineageTitle.Size = new System.Drawing.Size(50, 13);
            this.LineageTitle.TabIndex = 2;
            this.LineageTitle.Text = "Lineages";
            // 
            // LineageTab
            // 
            this.LineageTab.Controls.Add(this.ClassTab);
            this.LineageTab.Controls.Add(this.LineagePreview);
            this.LineageTab.Controls.Add(this.NextL);
            this.LineageTab.Controls.Add(this.BackL);
            this.LineageTab.Controls.Add(this.LineageDataHost);
            this.LineageTab.Controls.Add(this.LineageOptions);
            this.LineageTab.Controls.Add(this.LineageTitle);
            this.LineageTab.Controls.Add(this.panel1);
            this.LineageTab.Location = new System.Drawing.Point(0, 1);
            this.LineageTab.Name = "LineageTab";
            this.LineageTab.Size = new System.Drawing.Size(767, 511);
            this.LineageTab.TabIndex = 3;
            // 
            // ClassTab
            // 
            this.ClassTab.Controls.Add(this.BackgroundTab);
            this.ClassTab.Controls.Add(this.ClassPreview);
            this.ClassTab.Controls.Add(this.AddClass);
            this.ClassTab.Controls.Add(this.AdditionalClass);
            this.ClassTab.Controls.Add(this.LevelClass1Label);
            this.ClassTab.Controls.Add(this.LevelClass1);
            this.ClassTab.Controls.Add(this.NextC);
            this.ClassTab.Controls.Add(this.BackC);
            this.ClassTab.Controls.Add(this.ClassDataHost);
            this.ClassTab.Controls.Add(this.ClassOptions);
            this.ClassTab.Controls.Add(this.ClassTitle);
            this.ClassTab.Controls.Add(this.panel3);
            this.ClassTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassTab.Location = new System.Drawing.Point(0, 0);
            this.ClassTab.Name = "ClassTab";
            this.ClassTab.Size = new System.Drawing.Size(767, 511);
            this.ClassTab.TabIndex = 8;
            this.ClassTab.Visible = false;
            // 
            // BackgroundTab
            // 
            this.BackgroundTab.Controls.Add(this.CustomizeTab);
            this.BackgroundTab.Controls.Add(this.BackgroundPreview);
            this.BackgroundTab.Controls.Add(this.NextB);
            this.BackgroundTab.Controls.Add(this.BackB);
            this.BackgroundTab.Controls.Add(this.BackgroundDataHost);
            this.BackgroundTab.Controls.Add(this.BackgroundOptions);
            this.BackgroundTab.Controls.Add(this.BackgroundTitle);
            this.BackgroundTab.Controls.Add(this.panel4);
            this.BackgroundTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundTab.Location = new System.Drawing.Point(0, 0);
            this.BackgroundTab.Name = "BackgroundTab";
            this.BackgroundTab.Size = new System.Drawing.Size(767, 511);
            this.BackgroundTab.TabIndex = 9;
            this.BackgroundTab.Visible = false;
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
            this.CustomizeTab.TabIndex = 14;
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
            this.CustomPreview.Click += new System.EventHandler(this.CustomPreview_Click);
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
            this.ClickMe.Click += new System.EventHandler(this.ClickMe_Click);
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
            this.NextCs.Click += new System.EventHandler(this.NextCs_Click);
            // 
            // BackCs
            // 
            this.BackCs.Location = new System.Drawing.Point(545, 20);
            this.BackCs.Name = "BackCs";
            this.BackCs.Size = new System.Drawing.Size(96, 33);
            this.BackCs.TabIndex = 6;
            this.BackCs.Text = "Back";
            this.BackCs.UseVisualStyleBackColor = true;
            this.BackCs.Click += new System.EventHandler(this.BackCs_Click);
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
            this.CustomizeOptions.SelectedIndexChanged += new System.EventHandler(this.CustomizeOptions_SelectedIndexChanged);
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
            this.StatsCustomize.Click += new System.EventHandler(this.StatsCustomize_Click);
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
            this.InfoCustom.Click += new System.EventHandler(this.InfoCustom_Click);
            // 
            // BackgroundPreview
            // 
            this.BackgroundPreview.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackgroundPreview.Controls.Add(this.BackgroundSource);
            this.BackgroundPreview.Location = new System.Drawing.Point(416, 159);
            this.BackgroundPreview.Name = "BackgroundPreview";
            this.BackgroundPreview.Size = new System.Drawing.Size(350, 350);
            this.BackgroundPreview.TabIndex = 13;
            // 
            // BackgroundSource
            // 
            this.BackgroundSource.AutoSize = true;
            this.BackgroundSource.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundSource.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundSource.Location = new System.Drawing.Point(4, 332);
            this.BackgroundSource.Name = "BackgroundSource";
            this.BackgroundSource.Size = new System.Drawing.Size(145, 13);
            this.BackgroundSource.TabIndex = 12;
            this.BackgroundSource.Text = "Source: Wizards of the Coast";
            this.BackgroundSource.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NextB
            // 
            this.NextB.BackColor = System.Drawing.Color.Transparent;
            this.NextB.Enabled = false;
            this.NextB.Location = new System.Drawing.Point(659, 20);
            this.NextB.Name = "NextB";
            this.NextB.Size = new System.Drawing.Size(96, 33);
            this.NextB.TabIndex = 7;
            this.NextB.Text = "Next";
            this.NextB.UseVisualStyleBackColor = false;
            this.NextB.Click += new System.EventHandler(this.NextB_Click);
            // 
            // BackB
            // 
            this.BackB.Location = new System.Drawing.Point(545, 20);
            this.BackB.Name = "BackB";
            this.BackB.Size = new System.Drawing.Size(96, 33);
            this.BackB.TabIndex = 6;
            this.BackB.Text = "Back";
            this.BackB.UseVisualStyleBackColor = true;
            this.BackB.Click += new System.EventHandler(this.BackB_Click);
            // 
            // BackgroundDataHost
            // 
            this.BackgroundDataHost.AutoScroll = true;
            this.BackgroundDataHost.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundDataHost.Controls.Add(this.InfoDataB);
            this.BackgroundDataHost.Location = new System.Drawing.Point(18, 172);
            this.BackgroundDataHost.Name = "BackgroundDataHost";
            this.BackgroundDataHost.Padding = new System.Windows.Forms.Padding(7);
            this.BackgroundDataHost.Size = new System.Drawing.Size(350, 315);
            this.BackgroundDataHost.TabIndex = 5;
            // 
            // InfoDataB
            // 
            this.InfoDataB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoDataB.Location = new System.Drawing.Point(7, 7);
            this.InfoDataB.Name = "InfoDataB";
            this.InfoDataB.Size = new System.Drawing.Size(336, 301);
            this.InfoDataB.TabIndex = 1;
            // 
            // BackgroundOptions
            // 
            this.BackgroundOptions.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.BackgroundOptions.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.BackgroundOptions.FormattingEnabled = true;
            this.BackgroundOptions.Items.AddRange(new object[] {
            "Criminal",
            "Demo",
            "Huge",
            "Testing",
            "Sample",
            "SuperLong"});
            this.BackgroundOptions.Location = new System.Drawing.Point(18, 82);
            this.BackgroundOptions.Name = "BackgroundOptions";
            this.BackgroundOptions.Size = new System.Drawing.Size(350, 21);
            this.BackgroundOptions.TabIndex = 1;
            this.BackgroundOptions.Text = "Choose One";
            this.BackgroundOptions.SelectedIndexChanged += new System.EventHandler(this.BackgroundOptions_SelectedIndexChanged);
            // 
            // BackgroundTitle
            // 
            this.BackgroundTitle.AutoSize = true;
            this.BackgroundTitle.Location = new System.Drawing.Point(12, 20);
            this.BackgroundTitle.Name = "BackgroundTitle";
            this.BackgroundTitle.Size = new System.Drawing.Size(70, 13);
            this.BackgroundTitle.TabIndex = 2;
            this.BackgroundTitle.Text = "Backgrounds";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.StatsB);
            this.panel4.Controls.Add(this.InfoB);
            this.panel4.Location = new System.Drawing.Point(18, 135);
            this.panel4.Margin = new System.Windows.Forms.Padding(5);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(137, 39);
            this.panel4.TabIndex = 11;
            // 
            // StatsB
            // 
            this.StatsB.AutoSize = true;
            this.StatsB.BackColor = System.Drawing.Color.LightGray;
            this.StatsB.Dock = System.Windows.Forms.DockStyle.Left;
            this.StatsB.Location = new System.Drawing.Point(50, 5);
            this.StatsB.Margin = new System.Windows.Forms.Padding(5);
            this.StatsB.Name = "StatsB";
            this.StatsB.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.StatsB.Size = new System.Drawing.Size(51, 23);
            this.StatsB.TabIndex = 4;
            this.StatsB.Text = "Stats";
            this.StatsB.Click += new System.EventHandler(this.StatsB_Click);
            // 
            // InfoB
            // 
            this.InfoB.AutoSize = true;
            this.InfoB.BackColor = System.Drawing.Color.DimGray;
            this.InfoB.Dock = System.Windows.Forms.DockStyle.Left;
            this.InfoB.Location = new System.Drawing.Point(5, 5);
            this.InfoB.Margin = new System.Windows.Forms.Padding(5);
            this.InfoB.Name = "InfoB";
            this.InfoB.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.InfoB.Size = new System.Drawing.Size(45, 23);
            this.InfoB.TabIndex = 3;
            this.InfoB.Text = "Info";
            this.InfoB.Click += new System.EventHandler(this.InfoB_Click);
            // 
            // ClassPreview
            // 
            this.ClassPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClassPreview.Controls.Add(this.ClassSource);
            this.ClassPreview.Location = new System.Drawing.Point(417, 161);
            this.ClassPreview.Name = "ClassPreview";
            this.ClassPreview.Size = new System.Drawing.Size(350, 350);
            this.ClassPreview.TabIndex = 16;
            // 
            // ClassSource
            // 
            this.ClassSource.AutoSize = true;
            this.ClassSource.BackColor = System.Drawing.Color.Transparent;
            this.ClassSource.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ClassSource.Location = new System.Drawing.Point(3, 327);
            this.ClassSource.Name = "ClassSource";
            this.ClassSource.Size = new System.Drawing.Size(145, 13);
            this.ClassSource.TabIndex = 11;
            this.ClassSource.Text = "Source: Wizards of the Coast";
            // 
            // AddClass
            // 
            this.AddClass.AutoSize = true;
            this.AddClass.Location = new System.Drawing.Point(391, 80);
            this.AddClass.Name = "AddClass";
            this.AddClass.Size = new System.Drawing.Size(75, 23);
            this.AddClass.TabIndex = 15;
            this.AddClass.Text = "Add Class";
            this.AddClass.UseVisualStyleBackColor = true;
            this.AddClass.Visible = false;
            this.AddClass.Click += new System.EventHandler(this.AddClass_Click);
            // 
            // AdditionalClass
            // 
            this.AdditionalClass.Controls.Add(this.RemoveClass);
            this.AdditionalClass.Controls.Add(this.label1);
            this.AdditionalClass.Controls.Add(this.Class2Options);
            this.AdditionalClass.Controls.Add(this.LevelClass2);
            this.AdditionalClass.Location = new System.Drawing.Point(391, 63);
            this.AdditionalClass.Name = "AdditionalClass";
            this.AdditionalClass.Size = new System.Drawing.Size(376, 81);
            this.AdditionalClass.TabIndex = 14;
            this.AdditionalClass.Visible = false;
            // 
            // RemoveClass
            // 
            this.RemoveClass.AutoSize = true;
            this.RemoveClass.Location = new System.Drawing.Point(4, 49);
            this.RemoveClass.Name = "RemoveClass";
            this.RemoveClass.Size = new System.Drawing.Size(85, 23);
            this.RemoveClass.TabIndex = 16;
            this.RemoveClass.Text = "Remove Class";
            this.RemoveClass.UseVisualStyleBackColor = true;
            this.RemoveClass.Click += new System.EventHandler(this.RemoveClass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Level:";
            // 
            // Class2Options
            // 
            this.Class2Options.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Class2Options.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Class2Options.FormattingEnabled = true;
            this.Class2Options.Items.AddRange(new object[] {
            "Cleric",
            "Rogue",
            "Huge",
            "Testing",
            "Sample",
            "SuperLong"});
            this.Class2Options.Location = new System.Drawing.Point(4, 19);
            this.Class2Options.Name = "Class2Options";
            this.Class2Options.Size = new System.Drawing.Size(350, 21);
            this.Class2Options.TabIndex = 16;
            this.Class2Options.Text = "Choose One";
            this.Class2Options.SelectedIndexChanged += new System.EventHandler(this.Class2Options_SelectedIndexChanged);
            // 
            // LevelClass2
            // 
            this.LevelClass2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.LevelClass2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.LevelClass2.FormattingEnabled = true;
            this.LevelClass2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19"});
            this.LevelClass2.Location = new System.Drawing.Point(277, 51);
            this.LevelClass2.Name = "LevelClass2";
            this.LevelClass2.Size = new System.Drawing.Size(77, 21);
            this.LevelClass2.TabIndex = 17;
            this.LevelClass2.Text = "1";
            this.LevelClass2.SelectedIndexChanged += new System.EventHandler(this.LevelClass2_SelectedIndexChanged);
            // 
            // LevelClass1Label
            // 
            this.LevelClass1Label.AutoSize = true;
            this.LevelClass1Label.Location = new System.Drawing.Point(238, 117);
            this.LevelClass1Label.Name = "LevelClass1Label";
            this.LevelClass1Label.Size = new System.Drawing.Size(36, 13);
            this.LevelClass1Label.TabIndex = 13;
            this.LevelClass1Label.Text = "Level:";
            // 
            // LevelClass1
            // 
            this.LevelClass1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.LevelClass1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.LevelClass1.Enabled = false;
            this.LevelClass1.FormattingEnabled = true;
            this.LevelClass1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.LevelClass1.Location = new System.Drawing.Point(291, 114);
            this.LevelClass1.Name = "LevelClass1";
            this.LevelClass1.Size = new System.Drawing.Size(77, 21);
            this.LevelClass1.TabIndex = 12;
            this.LevelClass1.Text = "1";
            this.LevelClass1.SelectedIndexChanged += new System.EventHandler(this.LevelClass1_SelectedIndexChanged);
            // 
            // NextC
            // 
            this.NextC.BackColor = System.Drawing.Color.Transparent;
            this.NextC.Enabled = false;
            this.NextC.Location = new System.Drawing.Point(659, 20);
            this.NextC.Name = "NextC";
            this.NextC.Size = new System.Drawing.Size(96, 33);
            this.NextC.TabIndex = 7;
            this.NextC.Text = "Next";
            this.NextC.UseVisualStyleBackColor = false;
            this.NextC.Click += new System.EventHandler(this.NextC_Click);
            // 
            // BackC
            // 
            this.BackC.Location = new System.Drawing.Point(545, 20);
            this.BackC.Name = "BackC";
            this.BackC.Size = new System.Drawing.Size(96, 33);
            this.BackC.TabIndex = 6;
            this.BackC.Text = "Back";
            this.BackC.UseVisualStyleBackColor = true;
            this.BackC.Click += new System.EventHandler(this.BackC_Click);
            // 
            // ClassDataHost
            // 
            this.ClassDataHost.AutoScroll = true;
            this.ClassDataHost.BackColor = System.Drawing.SystemColors.Menu;
            this.ClassDataHost.Controls.Add(this.InfoDataC);
            this.ClassDataHost.Location = new System.Drawing.Point(18, 172);
            this.ClassDataHost.Name = "ClassDataHost";
            this.ClassDataHost.Padding = new System.Windows.Forms.Padding(7);
            this.ClassDataHost.Size = new System.Drawing.Size(350, 315);
            this.ClassDataHost.TabIndex = 5;
            // 
            // InfoDataC
            // 
            this.InfoDataC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoDataC.Location = new System.Drawing.Point(7, 7);
            this.InfoDataC.Name = "InfoDataC";
            this.InfoDataC.Size = new System.Drawing.Size(336, 301);
            this.InfoDataC.TabIndex = 1;
            // 
            // ClassOptions
            // 
            this.ClassOptions.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ClassOptions.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ClassOptions.FormattingEnabled = true;
            this.ClassOptions.Items.AddRange(new object[] {
            "Cleric",
            "Rogue",
            "Huge",
            "Testing",
            "Sample",
            "SuperLong"});
            this.ClassOptions.Location = new System.Drawing.Point(18, 82);
            this.ClassOptions.Name = "ClassOptions";
            this.ClassOptions.Size = new System.Drawing.Size(350, 21);
            this.ClassOptions.TabIndex = 1;
            this.ClassOptions.Text = "Choose One";
            this.ClassOptions.SelectedIndexChanged += new System.EventHandler(this.ClassOptions_SelectedIndexChanged);
            // 
            // ClassTitle
            // 
            this.ClassTitle.AutoSize = true;
            this.ClassTitle.Location = new System.Drawing.Point(12, 20);
            this.ClassTitle.Name = "ClassTitle";
            this.ClassTitle.Size = new System.Drawing.Size(43, 13);
            this.ClassTitle.TabIndex = 2;
            this.ClassTitle.Text = "Classes";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.StatsC);
            this.panel3.Controls.Add(this.InfoC);
            this.panel3.Location = new System.Drawing.Point(18, 135);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(137, 39);
            this.panel3.TabIndex = 10;
            // 
            // StatsC
            // 
            this.StatsC.AutoSize = true;
            this.StatsC.BackColor = System.Drawing.Color.LightGray;
            this.StatsC.Dock = System.Windows.Forms.DockStyle.Left;
            this.StatsC.Location = new System.Drawing.Point(50, 5);
            this.StatsC.Margin = new System.Windows.Forms.Padding(5);
            this.StatsC.Name = "StatsC";
            this.StatsC.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.StatsC.Size = new System.Drawing.Size(51, 23);
            this.StatsC.TabIndex = 4;
            this.StatsC.Text = "Stats";
            this.StatsC.Click += new System.EventHandler(this.StatsC_Click);
            // 
            // InfoC
            // 
            this.InfoC.AutoSize = true;
            this.InfoC.BackColor = System.Drawing.Color.DimGray;
            this.InfoC.Dock = System.Windows.Forms.DockStyle.Left;
            this.InfoC.Location = new System.Drawing.Point(5, 5);
            this.InfoC.Margin = new System.Windows.Forms.Padding(5);
            this.InfoC.Name = "InfoC";
            this.InfoC.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.InfoC.Size = new System.Drawing.Size(45, 23);
            this.InfoC.TabIndex = 3;
            this.InfoC.Text = "Info";
            this.InfoC.Click += new System.EventHandler(this.InfoC_Click);
            // 
            // LineagePreview
            // 
            this.LineagePreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LineagePreview.Controls.Add(this.LineageSource);
            this.LineagePreview.Location = new System.Drawing.Point(417, 161);
            this.LineagePreview.Name = "LineagePreview";
            this.LineagePreview.Size = new System.Drawing.Size(350, 350);
            this.LineagePreview.TabIndex = 11;
            // 
            // LineageSource
            // 
            this.LineageSource.AutoSize = true;
            this.LineageSource.BackColor = System.Drawing.Color.Transparent;
            this.LineageSource.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LineageSource.Location = new System.Drawing.Point(2, 327);
            this.LineageSource.Name = "LineageSource";
            this.LineageSource.Size = new System.Drawing.Size(145, 13);
            this.LineageSource.TabIndex = 10;
            this.LineageSource.Text = "Source: Wizards of the Coast";
            // 
            // NextL
            // 
            this.NextL.BackColor = System.Drawing.Color.Transparent;
            this.NextL.Enabled = false;
            this.NextL.Location = new System.Drawing.Point(659, 20);
            this.NextL.Name = "NextL";
            this.NextL.Size = new System.Drawing.Size(96, 33);
            this.NextL.TabIndex = 7;
            this.NextL.Text = "Next";
            this.NextL.UseVisualStyleBackColor = false;
            this.NextL.Click += new System.EventHandler(this.NextL_Click);
            // 
            // BackL
            // 
            this.BackL.Location = new System.Drawing.Point(545, 20);
            this.BackL.Name = "BackL";
            this.BackL.Size = new System.Drawing.Size(96, 33);
            this.BackL.TabIndex = 6;
            this.BackL.Text = "Back";
            this.BackL.UseVisualStyleBackColor = true;
            this.BackL.Click += new System.EventHandler(this.BackL_Click);
            // 
            // LineageDataHost
            // 
            this.LineageDataHost.BackColor = System.Drawing.SystemColors.Menu;
            this.LineageDataHost.Controls.Add(this.InfoDataL);
            this.LineageDataHost.Location = new System.Drawing.Point(18, 172);
            this.LineageDataHost.Name = "LineageDataHost";
            this.LineageDataHost.Padding = new System.Windows.Forms.Padding(7);
            this.LineageDataHost.Size = new System.Drawing.Size(350, 315);
            this.LineageDataHost.TabIndex = 5;
            // 
            // InfoDataL
            // 
            this.InfoDataL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoDataL.Location = new System.Drawing.Point(7, 7);
            this.InfoDataL.Name = "InfoDataL";
            this.InfoDataL.Size = new System.Drawing.Size(336, 301);
            this.InfoDataL.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.TraitsL);
            this.panel1.Controls.Add(this.InfoL);
            this.panel1.Location = new System.Drawing.Point(18, 135);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(137, 39);
            this.panel1.TabIndex = 9;
            // 
            // TraitsL
            // 
            this.TraitsL.AutoSize = true;
            this.TraitsL.BackColor = System.Drawing.Color.LightGray;
            this.TraitsL.Dock = System.Windows.Forms.DockStyle.Left;
            this.TraitsL.Location = new System.Drawing.Point(50, 5);
            this.TraitsL.Margin = new System.Windows.Forms.Padding(5);
            this.TraitsL.Name = "TraitsL";
            this.TraitsL.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.TraitsL.Size = new System.Drawing.Size(51, 23);
            this.TraitsL.TabIndex = 4;
            this.TraitsL.Text = "Stats";
            this.TraitsL.Click += new System.EventHandler(this.TraitsL_Click);
            // 
            // InfoL
            // 
            this.InfoL.AutoSize = true;
            this.InfoL.BackColor = System.Drawing.Color.DimGray;
            this.InfoL.Dock = System.Windows.Forms.DockStyle.Left;
            this.InfoL.Location = new System.Drawing.Point(5, 5);
            this.InfoL.Margin = new System.Windows.Forms.Padding(5);
            this.InfoL.Name = "InfoL";
            this.InfoL.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.InfoL.Size = new System.Drawing.Size(45, 23);
            this.InfoL.TabIndex = 3;
            this.InfoL.Text = "Info";
            this.InfoL.Click += new System.EventHandler(this.InfoL_Click);
            // 
            // Animator
            // 
            this.Animator.Enabled = true;
            this.Animator.SynchronizingObject = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image Files|*.gif;*.jpg;*.jpeg;*.bmp;*.png";
            // 
            // CharacterDesigner
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(96)))), ((int)(((byte)(136)))));
            this.ClientSize = new System.Drawing.Size(767, 511);
            this.Controls.Add(this.LineageTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CharacterDesigner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character Designer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CharacterDesigner_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CharacterDesigner_FormClosed);
            this.LineageTab.ResumeLayout(false);
            this.LineageTab.PerformLayout();
            this.ClassTab.ResumeLayout(false);
            this.ClassTab.PerformLayout();
            this.BackgroundTab.ResumeLayout(false);
            this.BackgroundTab.PerformLayout();
            this.CustomizeTab.ResumeLayout(false);
            this.CustomizeTab.PerformLayout();
            this.CustomPreview.ResumeLayout(false);
            this.CustomPreview.PerformLayout();
            this.CustomizeDataHost.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.BackgroundPreview.ResumeLayout(false);
            this.BackgroundPreview.PerformLayout();
            this.BackgroundDataHost.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ClassPreview.ResumeLayout(false);
            this.ClassPreview.PerformLayout();
            this.AdditionalClass.ResumeLayout(false);
            this.AdditionalClass.PerformLayout();
            this.ClassDataHost.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.LineagePreview.ResumeLayout(false);
            this.LineagePreview.PerformLayout();
            this.LineageDataHost.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Animator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox LineageOptions;
        private System.Windows.Forms.Label LineageTitle;
        private System.Windows.Forms.Panel LineageTab;
        private System.Windows.Forms.Label InfoL;
        private System.Windows.Forms.Panel LineageDataHost;
        private System.Windows.Forms.Button BackL;
        private System.Windows.Forms.Button NextL;
        private System.Timers.Timer Animator;
        private System.Windows.Forms.Panel ClassTab;
        private System.Windows.Forms.Button NextC;
        private System.Windows.Forms.Button BackC;
        private System.Windows.Forms.Panel ClassDataHost;
        private System.Windows.Forms.ComboBox ClassOptions;
        private System.Windows.Forms.Label ClassTitle;
        private System.Windows.Forms.Panel BackgroundTab;
        private System.Windows.Forms.Button NextB;
        private System.Windows.Forms.Button BackB;
        private System.Windows.Forms.Panel BackgroundDataHost;
        private System.Windows.Forms.ComboBox BackgroundOptions;
        private System.Windows.Forms.Label BackgroundTitle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TraitsL;
        private System.Windows.Forms.Label InfoDataL;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label StatsB;
        private System.Windows.Forms.Label InfoB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label StatsC;
        private System.Windows.Forms.Label InfoC;
        private System.Windows.Forms.Label InfoDataB;
        private System.Windows.Forms.Label InfoDataC;
        private System.Windows.Forms.Label LineageSource;
        private System.Windows.Forms.Label BackgroundSource;
        private System.Windows.Forms.Label ClassSource;
        private System.Windows.Forms.Label LevelClass1Label;
        private System.Windows.Forms.ComboBox LevelClass1;
        private System.Windows.Forms.Button AddClass;
        private System.Windows.Forms.Panel AdditionalClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Class2Options;
        private System.Windows.Forms.ComboBox LevelClass2;
        private System.Windows.Forms.Button RemoveClass;
        private System.Windows.Forms.Panel BackgroundPreview;
        private System.Windows.Forms.Panel ClassPreview;
        private System.Windows.Forms.Panel LineagePreview;
        private Panel CustomizeTab;
        private Panel CustomPreview;
        private Label ClickMe;
        private Label CustomSource;
        private Button NextCs;
        private Button BackCs;
        public Panel CustomizeDataHost;
        private Label InfoDataCustom;
        private ComboBox CustomizeOptions;
        private Label CustomizeTitle;
        private Panel panel5;
        private Label StatsCustomize;
        private Label InfoCustom;
    }
}