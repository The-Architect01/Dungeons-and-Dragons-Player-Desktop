
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
            this.LineagePreview = new System.Windows.Forms.PictureBox();
            this.LineageOptions = new System.Windows.Forms.ComboBox();
            this.LineageTitle = new System.Windows.Forms.Label();
            this.LineageTab = new System.Windows.Forms.Panel();
            this.ClassTab = new System.Windows.Forms.Panel();
            this.BackgroundTab = new System.Windows.Forms.Panel();
            this.CustomizeTab = new System.Windows.Forms.Panel();
            this.NextCs = new System.Windows.Forms.Button();
            this.BackCs = new System.Windows.Forms.Button();
            this.CustomizeDataHost = new System.Windows.Forms.Panel();
            this.InfoDataCustom = new System.Windows.Forms.Label();
            this.CustomizeOptions = new System.Windows.Forms.ComboBox();
            this.CustomizeTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.StatsCustomize = new System.Windows.Forms.Label();
            this.InfoCustom = new System.Windows.Forms.Label();
            this.NextB = new System.Windows.Forms.Button();
            this.BackB = new System.Windows.Forms.Button();
            this.BackgroundDataHost = new System.Windows.Forms.Panel();
            this.InfoDataB = new System.Windows.Forms.Label();
            this.BackgroundOptions = new System.Windows.Forms.ComboBox();
            this.BackgroundTitle = new System.Windows.Forms.Label();
            this.BackgroundPreview = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.StatsB = new System.Windows.Forms.Label();
            this.InfoB = new System.Windows.Forms.Label();
            this.NextC = new System.Windows.Forms.Button();
            this.BackC = new System.Windows.Forms.Button();
            this.ClassDataHost = new System.Windows.Forms.Panel();
            this.InfoDataC = new System.Windows.Forms.Label();
            this.ClassOptions = new System.Windows.Forms.ComboBox();
            this.ClassTitle = new System.Windows.Forms.Label();
            this.ClassPreview = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.StatsC = new System.Windows.Forms.Label();
            this.InfoC = new System.Windows.Forms.Label();
            this.NextL = new System.Windows.Forms.Button();
            this.BackL = new System.Windows.Forms.Button();
            this.LineageDataHost = new System.Windows.Forms.Panel();
            this.InfoDataL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TraitsL = new System.Windows.Forms.Label();
            this.InfoL = new System.Windows.Forms.Label();
            this.Animator = new System.Timers.Timer();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.LineagePreview)).BeginInit();
            this.LineageTab.SuspendLayout();
            this.ClassTab.SuspendLayout();
            this.BackgroundTab.SuspendLayout();
            this.CustomizeTab.SuspendLayout();
            this.CustomizeDataHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.BackgroundDataHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPreview)).BeginInit();
            this.panel4.SuspendLayout();
            this.ClassDataHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassPreview)).BeginInit();
            this.panel3.SuspendLayout();
            this.LineageDataHost.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Animator)).BeginInit();
            this.SuspendLayout();
            // 
            // LineagePreview
            // 
            this.LineagePreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LineagePreview.ImageLocation = "https://www.dndbeyond.com/avatars/thumbnails/7743/443/340/340/637093220265349425." +
    "png";
            this.LineagePreview.Location = new System.Drawing.Point(418, 162);
            this.LineagePreview.Name = "LineagePreview";
            this.LineagePreview.Size = new System.Drawing.Size(350, 350);
            this.LineagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LineagePreview.TabIndex = 0;
            this.LineagePreview.TabStop = false;
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
            this.LineageOptions.SelectedIndexChanged += new System.EventHandler(this.RaceOptions_SelectedIndexChanged);
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
            this.LineageTab.Controls.Add(this.NextL);
            this.LineageTab.Controls.Add(this.BackL);
            this.LineageTab.Controls.Add(this.LineageDataHost);
            this.LineageTab.Controls.Add(this.LineageOptions);
            this.LineageTab.Controls.Add(this.LineageTitle);
            this.LineageTab.Controls.Add(this.LineagePreview);
            this.LineageTab.Controls.Add(this.panel1);
            this.LineageTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LineageTab.Location = new System.Drawing.Point(0, 0);
            this.LineageTab.Name = "LineageTab";
            this.LineageTab.Size = new System.Drawing.Size(767, 511);
            this.LineageTab.TabIndex = 3;
            // 
            // ClassTab
            // 
            this.ClassTab.Controls.Add(this.BackgroundTab);
            this.ClassTab.Controls.Add(this.NextC);
            this.ClassTab.Controls.Add(this.BackC);
            this.ClassTab.Controls.Add(this.ClassDataHost);
            this.ClassTab.Controls.Add(this.ClassOptions);
            this.ClassTab.Controls.Add(this.ClassTitle);
            this.ClassTab.Controls.Add(this.ClassPreview);
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
            this.BackgroundTab.Controls.Add(this.NextB);
            this.BackgroundTab.Controls.Add(this.BackB);
            this.BackgroundTab.Controls.Add(this.BackgroundDataHost);
            this.BackgroundTab.Controls.Add(this.BackgroundOptions);
            this.BackgroundTab.Controls.Add(this.BackgroundTitle);
            this.BackgroundTab.Controls.Add(this.BackgroundPreview);
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
            this.CustomizeTab.Controls.Add(this.NextCs);
            this.CustomizeTab.Controls.Add(this.BackCs);
            this.CustomizeTab.Controls.Add(this.CustomizeDataHost);
            this.CustomizeTab.Controls.Add(this.CustomizeOptions);
            this.CustomizeTab.Controls.Add(this.CustomizeTitle);
            this.CustomizeTab.Controls.Add(this.pictureBox1);
            this.CustomizeTab.Controls.Add(this.panel5);
            this.CustomizeTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomizeTab.Location = new System.Drawing.Point(0, 0);
            this.CustomizeTab.Name = "CustomizeTab";
            this.CustomizeTab.Size = new System.Drawing.Size(767, 511);
            this.CustomizeTab.TabIndex = 10;
            this.CustomizeTab.Visible = false;
            // 
            // NextCs
            // 
            this.NextCs.BackColor = System.Drawing.Color.Transparent;
            this.NextCs.Enabled = false;
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
            "Background"});
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
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(418, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // BackgroundPreview
            // 
            this.BackgroundPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BackgroundPreview.ImageLocation = "";
            this.BackgroundPreview.Location = new System.Drawing.Point(418, 162);
            this.BackgroundPreview.Name = "BackgroundPreview";
            this.BackgroundPreview.Size = new System.Drawing.Size(350, 350);
            this.BackgroundPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackgroundPreview.TabIndex = 0;
            this.BackgroundPreview.TabStop = false;
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
            // ClassPreview
            // 
            this.ClassPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClassPreview.ImageLocation = "https://www.dndbeyond.com/avatars/thumbnails/8551/970/340/340/637158853104763253." +
    "png";
            this.ClassPreview.Location = new System.Drawing.Point(418, 162);
            this.ClassPreview.Name = "ClassPreview";
            this.ClassPreview.Size = new System.Drawing.Size(350, 350);
            this.ClassPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClassPreview.TabIndex = 0;
            this.ClassPreview.TabStop = false;
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
            this.NextL.Click += new System.EventHandler(this.NextR_Click);
            // 
            // BackL
            // 
            this.BackL.Location = new System.Drawing.Point(545, 20);
            this.BackL.Name = "BackL";
            this.BackL.Size = new System.Drawing.Size(96, 33);
            this.BackL.TabIndex = 6;
            this.BackL.Text = "Back";
            this.BackL.UseVisualStyleBackColor = true;
            this.BackL.Click += new System.EventHandler(this.BackR_Click);
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
            this.openFileDialog1.FileName = "openFileDialog1";
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
            ((System.ComponentModel.ISupportInitialize)(this.LineagePreview)).EndInit();
            this.LineageTab.ResumeLayout(false);
            this.LineageTab.PerformLayout();
            this.ClassTab.ResumeLayout(false);
            this.ClassTab.PerformLayout();
            this.BackgroundTab.ResumeLayout(false);
            this.BackgroundTab.PerformLayout();
            this.CustomizeTab.ResumeLayout(false);
            this.CustomizeTab.PerformLayout();
            this.CustomizeDataHost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.BackgroundDataHost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPreview)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ClassDataHost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClassPreview)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.LineageDataHost.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Animator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LineagePreview;
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
        private System.Windows.Forms.PictureBox ClassPreview;
        private System.Windows.Forms.Panel BackgroundTab;
        private System.Windows.Forms.Button NextB;
        private System.Windows.Forms.Button BackB;
        private System.Windows.Forms.Panel BackgroundDataHost;
        private System.Windows.Forms.ComboBox BackgroundOptions;
        private System.Windows.Forms.Label BackgroundTitle;
        private System.Windows.Forms.PictureBox BackgroundPreview;
        private System.Windows.Forms.Panel CustomizeTab;
        private System.Windows.Forms.Button NextCs;
        private System.Windows.Forms.Button BackCs;
        private System.Windows.Forms.Panel CustomizeDataHost;
        private System.Windows.Forms.ComboBox CustomizeOptions;
        private System.Windows.Forms.Label CustomizeTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TraitsL;
        private System.Windows.Forms.Label InfoDataL;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label StatsCustomize;
        private System.Windows.Forms.Label InfoCustom;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label StatsB;
        private System.Windows.Forms.Label InfoB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label StatsC;
        private System.Windows.Forms.Label InfoC;
        private System.Windows.Forms.Label InfoDataCustom;
        private System.Windows.Forms.Label InfoDataB;
        private System.Windows.Forms.Label InfoDataC;
    }
}