
namespace PlayerEngine.Forms {
    /// <summary>
    /// Creates a new Main Menu
    /// </summary>
    partial class MainMenu {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questionaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adoptACharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HomebrewToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateHomebrew = new System.Windows.Forms.ToolStripMenuItem();
            this.HomebrewLineage = new System.Windows.Forms.ToolStripMenuItem();
            this.HomebrewClass = new System.Windows.Forms.ToolStripMenuItem();
            this.HomebrewBackground = new System.Windows.Forms.ToolStripMenuItem();
            this.HomebrewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HomebrewSpell = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportHomebrew = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.HomebrewToolsToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1007, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.CheckOnClick = true;
            this.fileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCharacterToolStripMenuItem,
            this.loadCharacterToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newCharacterToolStripMenuItem
            // 
            this.newCharacterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classicToolStripMenuItem,
            this.questionaireToolStripMenuItem,
            this.randomToolStripMenuItem,
            this.adoptACharacterToolStripMenuItem});
            this.newCharacterToolStripMenuItem.Name = "newCharacterToolStripMenuItem";
            this.newCharacterToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.newCharacterToolStripMenuItem.Text = "New Character";
            // 
            // classicToolStripMenuItem
            // 
            this.classicToolStripMenuItem.Name = "classicToolStripMenuItem";
            this.classicToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.classicToolStripMenuItem.Text = "Classic";
            this.classicToolStripMenuItem.ToolTipText = "Create a character using the traditional process of choosing details in a step-by" +
    "-step process.";
            this.classicToolStripMenuItem.Click += new System.EventHandler(this.ClassicToolStripMenuItem_Click);
            // 
            // questionaireToolStripMenuItem
            // 
            this.questionaireToolStripMenuItem.Name = "questionaireToolStripMenuItem";
            this.questionaireToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.questionaireToolStripMenuItem.Text = "Questionaire";
            this.questionaireToolStripMenuItem.ToolTipText = "Generate a character by filling out different questions about the character.";
            this.questionaireToolStripMenuItem.Click += new System.EventHandler(this.QuestionaireToolStripMenuItem_Click);
            // 
            // randomToolStripMenuItem
            // 
            this.randomToolStripMenuItem.Name = "randomToolStripMenuItem";
            this.randomToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.randomToolStripMenuItem.Text = "Random";
            this.randomToolStripMenuItem.ToolTipText = "Generate a completely random character.";
            this.randomToolStripMenuItem.Click += new System.EventHandler(this.RandomToolStripMenuItem_Click);
            // 
            // adoptACharacterToolStripMenuItem
            // 
            this.adoptACharacterToolStripMenuItem.Name = "adoptACharacterToolStripMenuItem";
            this.adoptACharacterToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.adoptACharacterToolStripMenuItem.Text = "Adopt a Character";
            // 
            // loadCharacterToolStripMenuItem
            // 
            this.loadCharacterToolStripMenuItem.Name = "loadCharacterToolStripMenuItem";
            this.loadCharacterToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.loadCharacterToolStripMenuItem.Text = "Load Character";
            this.loadCharacterToolStripMenuItem.Click += new System.EventHandler(this.LoadCharacterToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // HomebrewToolsToolStripMenuItem
            // 
            this.HomebrewToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateHomebrew,
            this.ExportHomebrew});
            this.HomebrewToolsToolStripMenuItem.Name = "HomebrewToolsToolStripMenuItem";
            this.HomebrewToolsToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.HomebrewToolsToolStripMenuItem.Text = "Homebrew";
            // 
            // CreateHomebrew
            // 
            this.CreateHomebrew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomebrewLineage,
            this.HomebrewClass,
            this.HomebrewBackground,
            this.HomebrewItem,
            this.HomebrewSpell});
            this.CreateHomebrew.Name = "CreateHomebrew";
            this.CreateHomebrew.Size = new System.Drawing.Size(182, 22);
            this.CreateHomebrew.Text = "Create Homebrew";
            // 
            // HomebrewLineage
            // 
            this.HomebrewLineage.Name = "HomebrewLineage";
            this.HomebrewLineage.Size = new System.Drawing.Size(180, 22);
            this.HomebrewLineage.Text = "Lineage";
            this.HomebrewLineage.Click += new System.EventHandler(this.HomebrewLineage_Click);
            // 
            // HomebrewClass
            // 
            this.HomebrewClass.Name = "HomebrewClass";
            this.HomebrewClass.Size = new System.Drawing.Size(180, 22);
            this.HomebrewClass.Text = "Class";
            this.HomebrewClass.Click += new System.EventHandler(this.HomebrewClass_Click);
            // 
            // HomebrewBackground
            // 
            this.HomebrewBackground.Name = "HomebrewBackground";
            this.HomebrewBackground.Size = new System.Drawing.Size(180, 22);
            this.HomebrewBackground.Text = "Background";
            this.HomebrewBackground.Click += new System.EventHandler(this.HomebrewBackground_Click);
            // 
            // HomebrewItem
            // 
            this.HomebrewItem.Name = "HomebrewItem";
            this.HomebrewItem.Size = new System.Drawing.Size(180, 22);
            this.HomebrewItem.Text = "Item";
            this.HomebrewItem.Click += new System.EventHandler(this.HomebrewItem_Click);
            // 
            // HomebrewSpell
            // 
            this.HomebrewSpell.Name = "HomebrewSpell";
            this.HomebrewSpell.Size = new System.Drawing.Size(180, 22);
            this.HomebrewSpell.Text = "Spell";
            this.HomebrewSpell.Click += new System.EventHandler(this.HomebrewSpell_Click);
            // 
            // ExportHomebrew
            // 
            this.ExportHomebrew.Name = "ExportHomebrew";
            this.ExportHomebrew.Size = new System.Drawing.Size(182, 22);
            this.ExportHomebrew.Text = "Export Homebrew";
            this.ExportHomebrew.Click += new System.EventHandler(this.ExportHomebrew_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.CheckOnClick = true;
            this.optionsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.settingsToolStripMenuItem.Text = "Enable Rulesets";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.UpdateToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Chivo", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(8, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tabletop Player Manager";
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.BackColor = System.Drawing.Color.Transparent;
            this.Version.Font = new System.Drawing.Font("Chivo", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Version.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Version.Location = new System.Drawing.Point(16, 523);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(96, 13);
            this.Version.TabIndex = 3;
            this.Version.Text = "Version: 1.0.0.0a";
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1007, 541);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Activated += new System.EventHandler(this.MainMenu_Activated);
            this.Shown += new System.EventHandler(this.MainMenu_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem classicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questionaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.ToolStripMenuItem HomebrewToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateHomebrew;
        private System.Windows.Forms.ToolStripMenuItem ExportHomebrew;
        private System.Windows.Forms.ToolStripMenuItem adoptACharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HomebrewLineage;
        private System.Windows.Forms.ToolStripMenuItem HomebrewClass;
        private System.Windows.Forms.ToolStripMenuItem HomebrewBackground;
        private System.Windows.Forms.ToolStripMenuItem HomebrewItem;
        private System.Windows.Forms.ToolStripMenuItem HomebrewSpell;
    }
}