
namespace PlayerEngine.Custom_Elements.Play_Engine_Elements {
    partial class ActionMenu {
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
            this.Attacks = new System.Windows.Forms.FlowLayoutPanel();
            this.AttackLabel = new System.Windows.Forms.Label();
            this.Host = new System.Windows.Forms.FlowLayoutPanel();
            this.Spells = new System.Windows.Forms.FlowLayoutPanel();
            this.SpellLabel = new System.Windows.Forms.Label();
            this.SpellSummary = new System.Windows.Forms.Label();
            this.Extras = new System.Windows.Forms.FlowLayoutPanel();
            this.ExtraLabels = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Attacks.SuspendLayout();
            this.Host.SuspendLayout();
            this.Spells.SuspendLayout();
            this.Extras.SuspendLayout();
            this.SuspendLayout();
            // 
            // Attacks
            // 
            this.Attacks.AutoScroll = true;
            this.Attacks.AutoSize = true;
            this.Attacks.Controls.Add(this.AttackLabel);
            this.Attacks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Attacks.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Attacks.Location = new System.Drawing.Point(3, 3);
            this.Attacks.Name = "Attacks";
            this.Attacks.Size = new System.Drawing.Size(570, 16);
            this.Attacks.TabIndex = 1;
            this.Attacks.WrapContents = false;
            // 
            // AttackLabel
            // 
            this.AttackLabel.AutoSize = true;
            this.AttackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttackLabel.Location = new System.Drawing.Point(3, 0);
            this.AttackLabel.Name = "AttackLabel";
            this.AttackLabel.Size = new System.Drawing.Size(63, 16);
            this.AttackLabel.TabIndex = 0;
            this.AttackLabel.Text = "Attacks:";
            // 
            // Host
            // 
            this.Host.AutoScroll = true;
            this.Host.Controls.Add(this.Attacks);
            this.Host.Controls.Add(this.Spells);
            this.Host.Controls.Add(this.Extras);
            this.Host.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Host.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Host.Location = new System.Drawing.Point(0, 0);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(608, 398);
            this.Host.TabIndex = 2;
            this.Host.WrapContents = false;
            // 
            // Spells
            // 
            this.Spells.AutoScroll = true;
            this.Spells.AutoSize = true;
            this.Spells.Controls.Add(this.SpellLabel);
            this.Spells.Controls.Add(this.SpellSummary);
            this.Spells.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Spells.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Spells.Location = new System.Drawing.Point(3, 25);
            this.Spells.Name = "Spells";
            this.Spells.Size = new System.Drawing.Size(570, 29);
            this.Spells.TabIndex = 2;
            this.Spells.WrapContents = false;
            // 
            // SpellLabel
            // 
            this.SpellLabel.AutoSize = true;
            this.SpellLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpellLabel.Location = new System.Drawing.Point(3, 0);
            this.SpellLabel.Name = "SpellLabel";
            this.SpellLabel.Size = new System.Drawing.Size(56, 16);
            this.SpellLabel.TabIndex = 0;
            this.SpellLabel.Text = "Spells:";
            // 
            // SpellSummary
            // 
            this.SpellSummary.AutoSize = true;
            this.SpellSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpellSummary.Location = new System.Drawing.Point(3, 16);
            this.SpellSummary.Name = "SpellSummary";
            this.SpellSummary.Size = new System.Drawing.Size(243, 13);
            this.SpellSummary.TabIndex = 1;
            this.SpellSummary.Text = "Modifier: +1, Spell Attack Bonus: +3, Save DC: 18";
            // 
            // Extras
            // 
            this.Extras.AutoScroll = true;
            this.Extras.AutoSize = true;
            this.Extras.Controls.Add(this.ExtraLabels);
            this.Extras.Controls.Add(this.label1);
            this.Extras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Extras.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Extras.Location = new System.Drawing.Point(3, 60);
            this.Extras.Name = "Extras";
            this.Extras.Size = new System.Drawing.Size(570, 29);
            this.Extras.TabIndex = 3;
            this.Extras.WrapContents = false;
            // 
            // ExtraLabels
            // 
            this.ExtraLabels.AutoSize = true;
            this.ExtraLabels.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtraLabels.Location = new System.Drawing.Point(3, 0);
            this.ExtraLabels.Name = "ExtraLabels";
            this.ExtraLabels.Size = new System.Drawing.Size(49, 16);
            this.ExtraLabels.TabIndex = 0;
            this.ExtraLabels.Text = "Other:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(564, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Attack, Cast a Spell, Dash, Disengage, Dodge, Grapple, Help, Hide, Improvise, Rea" +
    "dy, Search, Shove, Use an Object";
            // 
            // ActionMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Host);
            this.Name = "ActionMenu";
            this.Size = new System.Drawing.Size(608, 398);
            this.Attacks.ResumeLayout(false);
            this.Attacks.PerformLayout();
            this.Host.ResumeLayout(false);
            this.Host.PerformLayout();
            this.Spells.ResumeLayout(false);
            this.Spells.PerformLayout();
            this.Extras.ResumeLayout(false);
            this.Extras.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Attacks;
        private System.Windows.Forms.Label AttackLabel;
        private System.Windows.Forms.FlowLayoutPanel Host;
        private System.Windows.Forms.FlowLayoutPanel Spells;
        private System.Windows.Forms.Label SpellLabel;
        private System.Windows.Forms.Label SpellSummary;
        private System.Windows.Forms.FlowLayoutPanel Extras;
        private System.Windows.Forms.Label ExtraLabels;
        private System.Windows.Forms.Label label1;
    }
}
