
namespace PlayerEngine.Forms {
    partial class ExportProgress {
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
            this.ExportLocation = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // ExportLocation
            // 
            this.ExportLocation.CheckFileExists = true;
            this.ExportLocation.DefaultExt = "pdf";
            this.ExportLocation.Filter = "PDFs|*.pdf";
            this.ExportLocation.InitialDirectory = "Desktop";
            // 
            // ExportProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "ExportProgress";
            this.Text = "ExportProgress";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog ExportLocation;
    }
}