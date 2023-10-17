using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

using PlayerEngine.Properties;

namespace PlayerEngine.Forms {
    public partial class SettingsMenu : Form {
        /// <summary>
        /// Creates a new settings menu
        /// </summary>
        public SettingsMenu() {
            InitializeComponent();
            foreach (Control c in Controls)
                c.Font = new Font(Data.RuntimeSettings.DefaultFont, 14, FontStyle.Regular);
            InstallHomebrew.Font = new Font(Data.RuntimeSettings.DefaultFont, 10, FontStyle.Regular);
        }

        private void SettingsMenu_Load(object sender, EventArgs e) {
            List<string> EnabledBooks = JsonSerializer.Deserialize<List<string>>(Settings.Default.EnabledBooks);
            foreach (Data.Book book in Data.RuntimeSettings.EngineData.Books) {
                CheckBox tmpCbox = new(){
                    Name = book.ReferenceCode,
                    Text = book.Name,
                    Checked = book.ReferenceCode == "PHB" || EnabledBooks.Contains(book.ReferenceCode),
                    Padding = new Padding(0, 0, 10, 10),
                    Font = new Font(Data.RuntimeSettings.DefaultFont, 10, FontStyle.Regular),
                    AutoSize = true,
                    Enabled = book.ReferenceCode != "PHB",
                };
                Rulesets.Controls.Add(tmpCbox);
            }
        }

        private void SettingsMenu_FormClosed(object sender, FormClosedEventArgs e) {
            List<string> EnabledBooks = new();
            foreach (CheckBox cb in Rulesets.Controls.OfType<CheckBox>()) {
                if (cb.Checked)
                    EnabledBooks.Add(cb.Name);
            }
            Settings.Default.EnabledBooks = JsonSerializer.Serialize(EnabledBooks);
            Settings.Default.Save();
            //new UpdateBox().Show("Updated rulesets.", Application.ProductName);
        }

        private void InstallHomebrew_Click(object sender, EventArgs e) {
            new InstallHomebrew(Forms.InstallHomebrew.View.OfficialBooks).ShowDialog();
        }
    }
}
