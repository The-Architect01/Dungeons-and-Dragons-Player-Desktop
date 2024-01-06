
namespace PlayerEngine.Custom_Elements.Play_Engine_Elements {
    partial class TraitsMenu {
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LineageTrait = new System.Windows.Forms.FlowLayoutPanel();
            this.LineageLabel = new System.Windows.Forms.Label();
            this.ClassTrait = new System.Windows.Forms.FlowLayoutPanel();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.BackgroundTraitHost = new System.Windows.Forms.FlowLayoutPanel();
            this.BackgroundLabels = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.LineageTrait.SuspendLayout();
            this.ClassTrait.SuspendLayout();
            this.BackgroundTraitHost.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.LineageTrait);
            this.flowLayoutPanel1.Controls.Add(this.ClassTrait);
            this.flowLayoutPanel1.Controls.Add(this.BackgroundTraitHost);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(608, 398);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // LineageTrait
            // 
            this.LineageTrait.AutoScroll = true;
            this.LineageTrait.AutoSize = true;
            this.LineageTrait.Controls.Add(this.LineageLabel);
            this.LineageTrait.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LineageTrait.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.LineageTrait.Location = new System.Drawing.Point(3, 3);
            this.LineageTrait.MinimumSize = new System.Drawing.Size(585, 0);
            this.LineageTrait.Name = "LineageTrait";
            this.LineageTrait.Size = new System.Drawing.Size(585, 16);
            this.LineageTrait.TabIndex = 4;
            this.LineageTrait.WrapContents = false;
            // 
            // LineageLabel
            // 
            this.LineageLabel.AutoSize = true;
            this.LineageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineageLabel.Location = new System.Drawing.Point(3, 0);
            this.LineageLabel.Name = "LineageLabel";
            this.LineageLabel.Size = new System.Drawing.Size(112, 16);
            this.LineageLabel.TabIndex = 0;
            this.LineageLabel.Text = "Lineage Traits:";
            // 
            // ClassTrait
            // 
            this.ClassTrait.AutoScroll = true;
            this.ClassTrait.AutoSize = true;
            this.ClassTrait.Controls.Add(this.ClassLabel);
            this.ClassTrait.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassTrait.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ClassTrait.Location = new System.Drawing.Point(3, 25);
            this.ClassTrait.MinimumSize = new System.Drawing.Size(585, 0);
            this.ClassTrait.Name = "ClassTrait";
            this.ClassTrait.Size = new System.Drawing.Size(585, 16);
            this.ClassTrait.TabIndex = 5;
            this.ClassTrait.WrapContents = false;
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassLabel.Location = new System.Drawing.Point(3, 0);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(95, 16);
            this.ClassLabel.TabIndex = 0;
            this.ClassLabel.Text = "Class Traits:";
            // 
            // BackgroundTraitHost
            // 
            this.BackgroundTraitHost.AutoScroll = true;
            this.BackgroundTraitHost.AutoSize = true;
            this.BackgroundTraitHost.Controls.Add(this.BackgroundLabels);
            this.BackgroundTraitHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundTraitHost.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.BackgroundTraitHost.Location = new System.Drawing.Point(3, 47);
            this.BackgroundTraitHost.MinimumSize = new System.Drawing.Size(585, 0);
            this.BackgroundTraitHost.Name = "BackgroundTraitHost";
            this.BackgroundTraitHost.Size = new System.Drawing.Size(585, 16);
            this.BackgroundTraitHost.TabIndex = 6;
            this.BackgroundTraitHost.WrapContents = false;
            // 
            // BackgroundLabels
            // 
            this.BackgroundLabels.AutoSize = true;
            this.BackgroundLabels.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackgroundLabels.Location = new System.Drawing.Point(3, 0);
            this.BackgroundLabels.Name = "BackgroundLabels";
            this.BackgroundLabels.Size = new System.Drawing.Size(131, 16);
            this.BackgroundLabels.TabIndex = 0;
            this.BackgroundLabels.Text = "Background Trait:";
            // 
            // TraitsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "TraitsMenu";
            this.Size = new System.Drawing.Size(608, 398);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.LineageTrait.ResumeLayout(false);
            this.LineageTrait.PerformLayout();
            this.ClassTrait.ResumeLayout(false);
            this.ClassTrait.PerformLayout();
            this.BackgroundTraitHost.ResumeLayout(false);
            this.BackgroundTraitHost.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel LineageTrait;
        private System.Windows.Forms.Label LineageLabel;
        private System.Windows.Forms.FlowLayoutPanel ClassTrait;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.FlowLayoutPanel BackgroundTraitHost;
        private System.Windows.Forms.Label BackgroundLabels;
    }
}
