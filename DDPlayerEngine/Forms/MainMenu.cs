using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;

using PlayerEngine.Data;
using PlayerEngine.Data.APIs;
using PlayerEngine.Properties;

namespace PlayerEngine.Forms {
    public partial class MainMenu : Form {

        /// <summary>
        /// Creates a new Main Menu.
        /// </summary>
        public MainMenu() {
            InitializeComponent();
            try {
                using HttpClient client = new();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.UserAgent.TryParseAdd("request");

                using HttpResponseMessage response  = client.GetAsync("https://5e.tools/data/races.json").Result;
                response.EnsureSuccessStatusCode();
                var responseBody = response.Content.ReadAsStringAsync().Result;
                LineageData LD = JsonSerializer.Deserialize<LineageData>(responseBody, Engine.JsonSerializerOptions);
            } catch {
                Debug.WriteLine("You goofed!");
            }

            BackgroundImage = (Image)new ImageConverter().ConvertFrom(Convert.FromBase64String(Data.RuntimeSettings.EngineData.SplashImageBase64));//HiddenLoader.Image;
            foreach (Control c in Controls)
                c.Font = new Font(Data.RuntimeSettings.DefaultFont, 10, FontStyle.Regular);
            label2.Font = new Font(Data.RuntimeSettings.DefaultFont, 27, FontStyle.Regular);
            Version.Font = new Font(Data.RuntimeSettings.DefaultFont, 8, FontStyle.Regular);
            Version.Text = $"Version {Data.RuntimeSettings.EngineData.Version}";
            //CharacterComboBox.Font = new Font(Data.RuntimeSettings.DefaultFont, 10, FontStyle.Regular);
        }

        #region Events
        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e) {
            SettingsMenu sm = new();
            sm.ShowDialog();
        }

        private void LoadCharacterToolStripMenuItem_Click(object sender, EventArgs e) {
            PlayEngine pe = new();
            pe.Show();
            Hide();
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e) {
            Settings.Default.Save();
            Close();
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e) {
            Data.RuntimeSettings.Update();
            //new UpdateBox().Show("Application Updated.", Application.ProductName, MessageBoxButtons.OK);
        }

        private void ClassicToolStripMenuItem_Click(object sender, EventArgs e) {
            CharacterDesigner cd = new();
            cd.Show();
            Hide();
        }

        private void QuestionaireToolStripMenuItem_Click(object sender, EventArgs e) {
            //new UpdateBox().Show("Not Implemented", Application.ProductName);
        }

        private void RandomToolStripMenuItem_Click(object sender, EventArgs e) {
            //PlayEngine pe = new PlayEngine(new Data.Character());
            //new UpdateBox().Show("Not Implemented", Application.ProductName);
        }

        #region Homebrew Options
        private void HomebrewLineage_Click(object sender, EventArgs e) {

        }

        private void HomebrewClass_Click(object sender, EventArgs e) {

        }

        private void HomebrewBackground_Click(object sender, EventArgs e) {

        }

        private void HomebrewItem_Click(object sender, EventArgs e) {

        }

        private void HomebrewSpell_Click(object sender, EventArgs e) {

        }
        private void ExportHomebrew_Click(object sender, EventArgs e) {

        }
        #endregion

        #endregion

        private void MainMenu_Shown(object sender, EventArgs e) {

        }

        private void MainMenu_Activated(object sender, EventArgs e) {

        }

        private void ImportHomebrewToolStripMenuItem_Click(object sender, EventArgs e) {
            new InstallHomebrew(InstallHomebrew.View.Homebrews).ShowDialog();
        }

        private void AdoptACharacterToolStripMenuItem_Click(object sender, EventArgs e) {
            new InstallHomebrew(InstallHomebrew.View.Adoptables).ShowDialog();
        }
    }
}
