
namespace PlayerEngine.Custom_Elements {
    partial class DataDisplay {
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
            this.SuspendLayout();
            // 
            // DataDisplay
            // 
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ReadOnly = true;
            this.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataDisplay_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
