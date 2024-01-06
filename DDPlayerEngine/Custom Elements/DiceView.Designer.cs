
namespace PlayerEngine.Custom_Elements {
    partial class DiceView {
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
            this.Roll = new System.Windows.Forms.Label();
            this.Value = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Roll
            // 
            this.Roll.AutoSize = true;
            this.Roll.BackColor = System.Drawing.Color.Transparent;
            this.Roll.Location = new System.Drawing.Point(3, 0);
            this.Roll.Name = "Roll";
            this.Roll.Size = new System.Drawing.Size(37, 13);
            this.Roll.TabIndex = 0;
            this.Roll.Text = "Roll 1:";
            // 
            // Value
            // 
            this.Value.AutoSize = true;
            this.Value.BackColor = System.Drawing.Color.Transparent;
            this.Value.Location = new System.Drawing.Point(47, 0);
            this.Value.Margin = new System.Windows.Forms.Padding(4, 0, 3, 0);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(25, 13);
            this.Value.TabIndex = 1;
            this.Value.Text = "999";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Roll);
            this.flowLayoutPanel1.Controls.Add(this.Value);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(166, 22);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // DiceView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "DiceView";
            this.Size = new System.Drawing.Size(166, 22);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Roll;
        private System.Windows.Forms.Label Value;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
