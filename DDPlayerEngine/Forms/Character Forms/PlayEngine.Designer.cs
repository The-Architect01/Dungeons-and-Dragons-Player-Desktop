
using System;
using System.Drawing;

using PlayerEngine.Data;

namespace PlayerEngine.Forms {
    partial class PlayEngine {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayEngine));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChooseCharacter = new System.Windows.Forms.ToolStripComboBox();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CharacterPreview = new System.Windows.Forms.PictureBox();
            this.Display = new System.Windows.Forms.Panel();
            this.DisplayOptions = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SummaryTab = new System.Windows.Forms.Label();
            this.ActionTab = new System.Windows.Forms.Label();
            this.TraitsTab = new System.Windows.Forms.Label();
            this.InventoryTab = new System.Windows.Forms.Label();
            this.BackgroundTab = new System.Windows.Forms.Label();
            this.NotesTab = new System.Windows.Forms.Label();
            this.CharName = new System.Windows.Forms.Label();
            this.Summary = new System.Windows.Forms.Label();
            this.Roll = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterPreview)).BeginInit();
            this.DisplayOptions.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1007, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.editToolStripMenuItem,
            this.printToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChooseCharacter});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // ChooseCharacter
            // 
            this.ChooseCharacter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ChooseCharacter.Name = "ChooseCharacter";
            this.ChooseCharacter.Size = new System.Drawing.Size(130, 25);
            this.ChooseCharacter.Text = "Choose Character";
            this.ChooseCharacter.SelectedIndexChanged += new System.EventHandler(this.ChooseCharacter_SelectedIndexChanged);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.printToolStripMenuItem.Text = "Export";
            this.printToolStripMenuItem.Visible = false;
            this.printToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // CharacterPreview
            // 
            this.CharacterPreview.BackColor = System.Drawing.Color.Transparent;
            this.CharacterPreview.ImageLocation = "";
            this.CharacterPreview.Location = new System.Drawing.Point(12, 149);
            this.CharacterPreview.Name = "CharacterPreview";
            this.CharacterPreview.Size = new System.Drawing.Size(350, 350);
            this.CharacterPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CharacterPreview.TabIndex = 2;
            this.CharacterPreview.TabStop = false;
            this.CharacterPreview.Visible = false;
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.White;
            this.Display.Location = new System.Drawing.Point(379, 94);
            this.Display.Name = "Display";
            this.Display.Padding = new System.Windows.Forms.Padding(5);
            this.Display.Size = new System.Drawing.Size(616, 405);
            this.Display.TabIndex = 3;
            this.Display.Visible = false;
            // 
            // DisplayOptions
            // 
            this.DisplayOptions.BackColor = System.Drawing.Color.White;
            this.DisplayOptions.Controls.Add(this.flowLayoutPanel1);
            this.DisplayOptions.Location = new System.Drawing.Point(379, 40);
            this.DisplayOptions.Name = "DisplayOptions";
            this.DisplayOptions.Size = new System.Drawing.Size(310, 55);
            this.DisplayOptions.TabIndex = 4;
            this.DisplayOptions.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.SummaryTab);
            this.flowLayoutPanel1.Controls.Add(this.ActionTab);
            this.flowLayoutPanel1.Controls.Add(this.TraitsTab);
            this.flowLayoutPanel1.Controls.Add(this.InventoryTab);
            this.flowLayoutPanel1.Controls.Add(this.BackgroundTab);
            this.flowLayoutPanel1.Controls.Add(this.NotesTab);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(4, 6, 0, 6);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(310, 55);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // SummaryTab
            // 
            this.SummaryTab.BackColor = System.Drawing.Color.DimGray;
            this.SummaryTab.Location = new System.Drawing.Point(7, 6);
            this.SummaryTab.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.SummaryTab.Name = "SummaryTab";
            this.SummaryTab.Size = new System.Drawing.Size(95, 20);
            this.SummaryTab.TabIndex = 15;
            this.SummaryTab.Text = "Summary";
            this.SummaryTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SummaryTab.Click += new System.EventHandler(this.SummaryTab_Click);
            // 
            // ActionTab
            // 
            this.ActionTab.BackColor = System.Drawing.Color.LightGray;
            this.ActionTab.Location = new System.Drawing.Point(108, 6);
            this.ActionTab.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ActionTab.Name = "ActionTab";
            this.ActionTab.Size = new System.Drawing.Size(95, 20);
            this.ActionTab.TabIndex = 16;
            this.ActionTab.Text = "Actions";
            this.ActionTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ActionTab.Click += new System.EventHandler(this.ActionTab_Click);
            // 
            // TraitsTab
            // 
            this.TraitsTab.BackColor = System.Drawing.Color.LightGray;
            this.TraitsTab.Location = new System.Drawing.Point(209, 6);
            this.TraitsTab.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.TraitsTab.Name = "TraitsTab";
            this.TraitsTab.Size = new System.Drawing.Size(95, 20);
            this.TraitsTab.TabIndex = 17;
            this.TraitsTab.Text = "Traits";
            this.TraitsTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TraitsTab.Click += new System.EventHandler(this.TraitsTab_Click);
            // 
            // InventoryTab
            // 
            this.InventoryTab.BackColor = System.Drawing.Color.LightGray;
            this.InventoryTab.Location = new System.Drawing.Point(7, 29);
            this.InventoryTab.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.InventoryTab.Name = "InventoryTab";
            this.InventoryTab.Size = new System.Drawing.Size(95, 20);
            this.InventoryTab.TabIndex = 18;
            this.InventoryTab.Text = "Inventory";
            this.InventoryTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InventoryTab.Click += new System.EventHandler(this.InventoryTab_Click);
            // 
            // BackgroundTab
            // 
            this.BackgroundTab.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundTab.Location = new System.Drawing.Point(108, 29);
            this.BackgroundTab.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.BackgroundTab.Name = "BackgroundTab";
            this.BackgroundTab.Size = new System.Drawing.Size(95, 20);
            this.BackgroundTab.TabIndex = 19;
            this.BackgroundTab.Text = "Background";
            this.BackgroundTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BackgroundTab.Click += new System.EventHandler(this.BackgroundTab_Click);
            // 
            // NotesTab
            // 
            this.NotesTab.BackColor = System.Drawing.Color.LightGray;
            this.NotesTab.Location = new System.Drawing.Point(209, 29);
            this.NotesTab.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.NotesTab.Name = "NotesTab";
            this.NotesTab.Size = new System.Drawing.Size(95, 20);
            this.NotesTab.TabIndex = 20;
            this.NotesTab.Text = "Notes";
            this.NotesTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NotesTab.Click += new System.EventHandler(this.NotesTab_Click);
            // 
            // CharName
            // 
            this.CharName.Location = new System.Drawing.Point(12, 49);
            this.CharName.Name = "CharName";
            this.CharName.Size = new System.Drawing.Size(350, 46);
            this.CharName.TabIndex = 5;
            this.CharName.Text = "Character Name";
            this.CharName.Visible = false;
            // 
            // Summary
            // 
            this.Summary.AutoSize = true;
            this.Summary.Location = new System.Drawing.Point(15, 91);
            this.Summary.Name = "Summary";
            this.Summary.Size = new System.Drawing.Size(173, 13);
            this.Summary.TabIndex = 6;
            this.Summary.Text = "Level 20 Chaotic Neutral Lore Bard";
            this.Summary.Visible = false;
            // 
            // Roll
            // 
            this.Roll.Location = new System.Drawing.Point(879, 44);
            this.Roll.Name = "Roll";
            this.Roll.Size = new System.Drawing.Size(116, 44);
            this.Roll.TabIndex = 7;
            this.Roll.Text = "Roll Dice";
            this.Roll.UseVisualStyleBackColor = true;
            this.Roll.Visible = false;
            this.Roll.Click += new System.EventHandler(this.Roll_Click);
            // 
            // PlayEngine
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1007, 511);
            this.Controls.Add(this.Roll);
            this.Controls.Add(this.Summary);
            this.Controls.Add(this.CharName);
            this.Controls.Add(this.DisplayOptions);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.CharacterPreview);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlayEngine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play Engine";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PlayEngine_FormClosed);
            this.Load += new System.EventHandler(this.PlayEngine_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterPreview)).EndInit();
            this.DisplayOptions.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox ChooseCharacter;
        private System.Windows.Forms.PictureBox CharacterPreview;
        private System.Windows.Forms.Panel Display;
        private System.Windows.Forms.Panel DisplayOptions;
        private System.Windows.Forms.Label CharName;
        private System.Windows.Forms.Label Summary;
        private System.Windows.Forms.Button Roll;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label ActionTab;
        private System.Windows.Forms.Label TraitsTab;
        private System.Windows.Forms.Label SummaryTab;
        private System.Windows.Forms.Label BackgroundTab;
        private System.Windows.Forms.Label InventoryTab;
        private System.Windows.Forms.Label NotesTab;
    }
}