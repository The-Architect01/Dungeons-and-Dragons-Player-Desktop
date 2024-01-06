
namespace PlayerEngine.Custom_Elements.Class_Options {
    partial class Barbarian {
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
            this.SkillLabel = new System.Windows.Forms.Label();
            this.Skill1 = new System.Windows.Forms.ComboBox();
            this.Skill2 = new System.Windows.Forms.ComboBox();
            this.EquipmentPair1 = new System.Windows.Forms.Panel();
            this.EquipOption1_2b = new System.Windows.Forms.ComboBox();
            this.Item1 = new System.Windows.Forms.Label();
            this.EquipOption1_2a = new System.Windows.Forms.RadioButton();
            this.EquipOption1_1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EquipOption2_2b = new System.Windows.Forms.ComboBox();
            this.Item2 = new System.Windows.Forms.Label();
            this.EquipOption2_2a = new System.Windows.Forms.RadioButton();
            this.EquipOption2_1 = new System.Windows.Forms.RadioButton();
            this.EquipmentPair1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SkillLabel
            // 
            this.SkillLabel.AutoSize = true;
            this.SkillLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkillLabel.Location = new System.Drawing.Point(-1, 5);
            this.SkillLabel.Name = "SkillLabel";
            this.SkillLabel.Size = new System.Drawing.Size(109, 13);
            this.SkillLabel.TabIndex = 0;
            this.SkillLabel.Text = "Select Two Skills:";
            // 
            // Skill1
            // 
            this.Skill1.DropDownWidth = 126;
            this.Skill1.FormattingEnabled = true;
            this.Skill1.Items.AddRange(new object[] {
            "Animal Handling",
            "Athletics",
            "Intimidation",
            "Nature",
            "Perception",
            "Survival"});
            this.Skill1.Location = new System.Drawing.Point(155, 2);
            this.Skill1.Name = "Skill1";
            this.Skill1.Size = new System.Drawing.Size(121, 21);
            this.Skill1.TabIndex = 1;
            this.Skill1.Text = "Select One";
            // 
            // Skill2
            // 
            this.Skill2.DropDownWidth = 126;
            this.Skill2.FormattingEnabled = true;
            this.Skill2.Items.AddRange(new object[] {
            "Animal Handling",
            "Athletics",
            "Intimidation",
            "Nature",
            "Perception",
            "Survival"});
            this.Skill2.Location = new System.Drawing.Point(155, 32);
            this.Skill2.Name = "Skill2";
            this.Skill2.Size = new System.Drawing.Size(121, 21);
            this.Skill2.TabIndex = 2;
            this.Skill2.Text = "Select One";
            // 
            // EquipmentPair1
            // 
            this.EquipmentPair1.Controls.Add(this.EquipOption1_2b);
            this.EquipmentPair1.Controls.Add(this.Item1);
            this.EquipmentPair1.Controls.Add(this.EquipOption1_2a);
            this.EquipmentPair1.Controls.Add(this.EquipOption1_1);
            this.EquipmentPair1.Location = new System.Drawing.Point(0, 59);
            this.EquipmentPair1.Name = "EquipmentPair1";
            this.EquipmentPair1.Size = new System.Drawing.Size(336, 78);
            this.EquipmentPair1.TabIndex = 3;
            // 
            // EquipOption1_2b
            // 
            this.EquipOption1_2b.FormattingEnabled = true;
            this.EquipOption1_2b.Location = new System.Drawing.Point(115, 49);
            this.EquipOption1_2b.Name = "EquipOption1_2b";
            this.EquipOption1_2b.Size = new System.Drawing.Size(121, 21);
            this.EquipOption1_2b.TabIndex = 6;
            this.EquipOption1_2b.Text = "Select One";
            // 
            // Item1
            // 
            this.Item1.AutoSize = true;
            this.Item1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item1.Location = new System.Drawing.Point(-1, 3);
            this.Item1.Name = "Item1";
            this.Item1.Size = new System.Drawing.Size(80, 13);
            this.Item1.TabIndex = 5;
            this.Item1.Text = "Choose One:";
            // 
            // EquipOption1_2a
            // 
            this.EquipOption1_2a.AutoSize = true;
            this.EquipOption1_2a.Location = new System.Drawing.Point(115, 26);
            this.EquipOption1_2a.Name = "EquipOption1_2a";
            this.EquipOption1_2a.Size = new System.Drawing.Size(147, 17);
            this.EquipOption1_2a.TabIndex = 5;
            this.EquipOption1_2a.TabStop = true;
            this.EquipOption1_2a.Text = "any martial melee weapon";
            this.EquipOption1_2a.UseVisualStyleBackColor = true;
            // 
            // EquipOption1_1
            // 
            this.EquipOption1_1.AutoSize = true;
            this.EquipOption1_1.Location = new System.Drawing.Point(115, 3);
            this.EquipOption1_1.Name = "EquipOption1_1";
            this.EquipOption1_1.Size = new System.Drawing.Size(75, 17);
            this.EquipOption1_1.TabIndex = 5;
            this.EquipOption1_1.TabStop = true;
            this.EquipOption1_1.Text = "a greataxe";
            this.EquipOption1_1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EquipOption2_2b);
            this.panel1.Controls.Add(this.Item2);
            this.panel1.Controls.Add(this.EquipOption2_2a);
            this.panel1.Controls.Add(this.EquipOption2_1);
            this.panel1.Location = new System.Drawing.Point(0, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 78);
            this.panel1.TabIndex = 7;
            // 
            // EquipOption2_2b
            // 
            this.EquipOption2_2b.FormattingEnabled = true;
            this.EquipOption2_2b.Location = new System.Drawing.Point(115, 49);
            this.EquipOption2_2b.Name = "EquipOption2_2b";
            this.EquipOption2_2b.Size = new System.Drawing.Size(121, 21);
            this.EquipOption2_2b.TabIndex = 6;
            this.EquipOption2_2b.Text = "Select One";
            // 
            // Item2
            // 
            this.Item2.AutoSize = true;
            this.Item2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item2.Location = new System.Drawing.Point(-1, 3);
            this.Item2.Name = "Item2";
            this.Item2.Size = new System.Drawing.Size(80, 13);
            this.Item2.TabIndex = 5;
            this.Item2.Text = "Choose One:";
            // 
            // EquipOption2_2a
            // 
            this.EquipOption2_2a.AutoSize = true;
            this.EquipOption2_2a.Location = new System.Drawing.Point(115, 26);
            this.EquipOption2_2a.Name = "EquipOption2_2a";
            this.EquipOption2_2a.Size = new System.Drawing.Size(115, 17);
            this.EquipOption2_2a.TabIndex = 5;
            this.EquipOption2_2a.TabStop = true;
            this.EquipOption2_2a.Text = "any simple weapon";
            this.EquipOption2_2a.UseVisualStyleBackColor = true;
            // 
            // EquipOption2_1
            // 
            this.EquipOption2_1.AutoSize = true;
            this.EquipOption2_1.Location = new System.Drawing.Point(115, 3);
            this.EquipOption2_1.Name = "EquipOption2_1";
            this.EquipOption2_1.Size = new System.Drawing.Size(91, 17);
            this.EquipOption2_1.TabIndex = 5;
            this.EquipOption2_1.TabStop = true;
            this.EquipOption2_1.Text = "two handaxes";
            this.EquipOption2_1.UseVisualStyleBackColor = true;
            // 
            // Barbarian
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EquipmentPair1);
            this.Controls.Add(this.Skill2);
            this.Controls.Add(this.Skill1);
            this.Controls.Add(this.SkillLabel);
            this.Name = "Barbarian";
            this.Size = new System.Drawing.Size(336, 301);
            this.EquipmentPair1.ResumeLayout(false);
            this.EquipmentPair1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SkillLabel;
        private System.Windows.Forms.ComboBox Skill1;
        private System.Windows.Forms.ComboBox Skill2;
        private System.Windows.Forms.Panel EquipmentPair1;
        private System.Windows.Forms.ComboBox EquipOption1_2b;
        private System.Windows.Forms.Label Item1;
        private System.Windows.Forms.RadioButton EquipOption1_2a;
        private System.Windows.Forms.RadioButton EquipOption1_1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox EquipOption2_2b;
        private System.Windows.Forms.Label Item2;
        private System.Windows.Forms.RadioButton EquipOption2_2a;
        private System.Windows.Forms.RadioButton EquipOption2_1;
    }
}
