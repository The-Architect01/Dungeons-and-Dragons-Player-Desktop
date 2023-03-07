
namespace PlayerEngine.Forms {
    partial class UpdateBox {
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
            this.CurrentProcess = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // CurrentProcess
            // 
            this.CurrentProcess.AutoSize = true;
            this.CurrentProcess.Location = new System.Drawing.Point(12, 183);
            this.CurrentProcess.Name = "CurrentProcess";
            this.CurrentProcess.Size = new System.Drawing.Size(100, 13);
            this.CurrentProcess.TabIndex = 0;
            this.CurrentProcess.Text = "Serializing Images...";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(12, 9);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(234, 13);
            this.Label.TabIndex = 1;
            this.Label.Text = "Currently updating. Thank you for your patience.";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 157);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(240, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // UpdateBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 210);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.CurrentProcess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UpdateBox";
            this.Load += new System.EventHandler(this.UpdateBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentProcess;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}