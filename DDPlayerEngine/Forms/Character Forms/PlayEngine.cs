//System Imports
using System;
using System.Windows.Forms;

//Custom Imports
using PlayerEngine.Data;

//Office Imports


namespace PlayerEngine.Forms {
    public partial class PlayEngine : Form {
        public PlayEngine() {
            InitializeComponent();

            //Check if Office is installed, if not then remove the print option as this will be how we will print/export
            if (Type.GetTypeFromProgID("Excel.Application") == null) printToolStripMenuItem.Visible = false;

        }

        private void PlayEngine_FormClosed(object sender, FormClosedEventArgs e) {
            Program.MM.Show();
        }

        private void ChooseCharacter_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e) {
            new ExportProgress(new Character()).Show();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e) {

        }
    }
}
