using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Text.Json;
using PlayerEngine.Properties;
using PlayerEngine.Data;

namespace PlayerEngine.Forms {


    /// <summary>
    /// A form holding data for character design
    /// </summary>
    public partial class CharacterDesigner : Form {

        public Character PC;

        /// <summary>
        /// Create a new form
        /// </summary>
        public CharacterDesigner() {
            InitializeComponent();
            foreach (Control c in Controls)
                c.Font = new Font(RuntimeSettings.DefaultFont, 12, FontStyle.Regular);

            LineageTitle.Font = new Font(RuntimeSettings.DefaultFont, 27, FontStyle.Bold);
            //InfoL.Font = new Font(RuntimeSettings.DefaultFont, 18, FontStyle.Bold);
            LineageDataHost.Controls.Add(new Custom_Elements.DataDisplay() { Dock = DockStyle.Fill, Name = "DescriptionR", DisplaySetting = Custom_Elements.DisplaySetting.Lineage });
            LineagePreview.Image = (Image)new ImageConverter().ConvertFrom(Convert.FromBase64String(RuntimeSettings.EngineData.Books[0].Lineages[0].ResourceBase64));
            LineagePreview.ImageLocation = null;
            InfoDataL.Font = new Font(RuntimeSettings.DefaultFont, 11, FontStyle.Regular);

            ClassTitle.Font = new Font(RuntimeSettings.DefaultFont, 27, FontStyle.Bold);
            //TraitsC.Font = new Font(RuntimeSettings.DefaultFont, 18, FontStyle.Bold);
            ClassDataHost.Controls.Add(new Custom_Elements.DataDisplay() { Dock = DockStyle.Fill, Name = "DescriptionC", DisplaySetting = Custom_Elements.DisplaySetting.Class });
            ClassPreview.Image = (Image)new ImageConverter().ConvertFrom(Convert.FromBase64String(RuntimeSettings.EngineData.Books[0].Classes[0].ResourceBase64));
            ClassPreview.ImageLocation = null;

            BackgroundTitle.Font = new Font(RuntimeSettings.DefaultFont, 27, FontStyle.Bold);
            //TraitsB.Font = new Font(RuntimeSettings.DefaultFont, 18, FontStyle.Bold);
            BackgroundDataHost.Controls.Add(new Custom_Elements.DataDisplay() { Dock = DockStyle.Fill, Name="DescriptionB", DisplaySetting = Custom_Elements.DisplaySetting.Background });

            CustomizeTitle.Font = new Font(RuntimeSettings.DefaultFont, 27, FontStyle.Bold);
            CustomizeDataHost.Controls.Add(new Custom_Elements.DataDisplay() { Dock = DockStyle.Fill, Name = "OptionsL", DisplaySetting = Custom_Elements.DisplaySetting.Lineage });
            CustomizeDataHost.Controls.Add(new Custom_Elements.DataDisplay() { Dock = DockStyle.Fill, Name = "OptionsC", DisplaySetting = Custom_Elements.DisplaySetting.Class });
            CustomizeDataHost.Controls.Add(new Custom_Elements.DataDisplay() { Dock = DockStyle.Fill, Name = "OptionsB", DisplaySetting = Custom_Elements.DisplaySetting.Background });

            RaceTab_Load();
            ClassTab_Load();
            BackgroundTab_Load();

            PC = new Character();
        }

        private void CharacterDesigner_FormClosed(object sender, FormClosedEventArgs e) {
            Program.MM.Show();
        }
        private void CharacterDesigner_FormClosing(object sender, FormClosingEventArgs e) {
            //if (new UpdateBox().Show("Are you sure you want to go back to the Main Menu?\nYour character will be deleted.", Application.ProductName, MessageBoxButtons.YesNo) == DialogResult.No)
            //    e.Cancel = true;
        }

        #region Loading Events
        private void RaceTab_Load() {
            LineageOptions.Items.Clear();
            List<string> EnabledBooks = JsonSerializer.Deserialize<List<string>>(Settings.Default.EnabledBooks.ToString());
            foreach (Book b in RuntimeSettings.EngineData.Books) {
                if (EnabledBooks.Contains(b.ReferenceCode)) {
                    foreach (Lineage rc in b.Lineages) {
                        LineageOptions.Items.Add($"{ rc.BaseLineage }{(rc.SubLineage == null ? "" : $" ({rc.SubLineage})")}");
                    }
                }
            }
        }

        private void ClassTab_Load() {
            ClassOptions.Items.Clear();
            List<string> EnabledBooks = JsonSerializer.Deserialize<List<string>>(Settings.Default.EnabledBooks.ToString());
            foreach (Book b in RuntimeSettings.EngineData.Books) {
                if (EnabledBooks.Contains(b.ReferenceCode)) {
                    foreach (Class cl in b.Classes) {
                        ClassOptions.Items.Add($"{cl.BaseClass} ({cl.SubClass})");
                    }
                }
            }
        }

        private void BackgroundTab_Load() {
            BackgroundOptions.Items.Clear();
            List<string> EnabledBooks = JsonSerializer.Deserialize<List<string>>(Settings.Default.EnabledBooks.ToString());
            foreach (Book b in RuntimeSettings.EngineData.Books) {
                if (EnabledBooks.Contains(b.ReferenceCode)) {
                    foreach (Background bg in b.Backgrounds) {
                        BackgroundOptions.Items.Add(bg.Name);
                    }
                }
            }
        }
        #endregion

        #region UI Code
        #region Buttons
        private void BackR_Click(object sender, EventArgs e) {
            Close();
        }

        private void NextR_Click(object sender, EventArgs e) {
            ClassTab.Visible = true;
            Thread.Sleep(100);
        }

        private void BackC_Click(object sender, EventArgs e) {
            ClassTab.Visible = false;
            Thread.Sleep(100);
        }

        private void NextC_Click(object sender, EventArgs e) {
            BackgroundTab.Visible = true;
            BackgroundPreview.Image = (Image)new ImageConverter().ConvertFrom(Convert.FromBase64String(Settings.Default.BackgroundsImage));
            BackgroundPreview.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);

            Thread.Sleep(100);
        }

        private void BackB_Click(object sender, EventArgs e) {
            BackgroundTab.Visible = false;
            Thread.Sleep(100);
        }

        private void NextB_Click(object sender, EventArgs e) {
            CustomizeTab.Visible = true;
            Thread.Sleep(100);

        }

        private void BackCs_Click(object sender, EventArgs e) {
            CustomizeTab.Visible = false;
            Thread.Sleep(100);

        }

        private void NextCs_Click(object sender, EventArgs e) {
            Thread.Sleep(100);
        }

        #endregion

        #region Drop Downs
        private void RaceOptions_SelectedIndexChanged(object sender, EventArgs e) {
            NextL.Enabled = true;
            foreach (Book b in RuntimeSettings.EngineData.Books) {
                foreach (Lineage rc in b.Lineages) {
                    if ($"{rc.BaseLineage}{(rc.SubLineage == null ? "" : $" ({rc.SubLineage})")}" == LineageOptions.Text) {
                        ((Custom_Elements.DataDisplay)LineageDataHost.Controls[1]).Rtf = $@"{{\rtf1\ansi\sl325\slmult1 \b Name: \b0 {rc.BaseLineage} \line{(rc.SubLineage != null ? $@"\b Subrace: \b0 {rc.SubLineage} \line" : string.Empty)}\b Statistic Spread: \b0 \line\tab\ul STR\ul0 : {rc.StatModifiers[0].Modifier}\tab\ul DEX\ul0 : {rc.StatModifiers[1].Modifier}\tab\ul CON\ul0 : {rc.StatModifiers[2].Modifier}\line\tab\ul WIS\ul0 : {rc.StatModifiers[3].Modifier}\tab\ul INT\ul0 : {rc.StatModifiers[4].Modifier}\tab\tab\ul CHA\ul0 : {rc.StatModifiers[5].Modifier}\line\b \ul Speed\ul0 : \b0 {rc.Speed} \line\b \ul Size\ul0 : \b0 {rc.Size} \line\b Languages: \b0 \line\b Proficincies: \b0 \line\b Traits: \b0 \line }}";
                    }
                    LineageDataHost.Controls[0].Text = rc.Overview;
                    PC.Lineage = rc;
                }
            }
        }


        private void ClassOptions_SelectedIndexChanged(object sender, EventArgs e) {
            NextC.Enabled = true;
            foreach (Book b in RuntimeSettings.EngineData.Books) {
                foreach (Class cl in b.Classes) {
                    if ($"{cl.BaseClass} ({cl.SubClass})" == ClassOptions.Text) {
                        ((Custom_Elements.DataDisplay)ClassDataHost.Controls[1]).Rtf = $@"{{\rtf1\ansi \b Name: \b0 {cl.BaseClass} \line\b Subclass: \b0 {cl.SubClass}}}";
                    }
                    ClassDataHost.Controls[0].Text = cl.Overview;

                }
            }
        }

        private void BackgroundOptions_SelectedIndexChanged(object sender, EventArgs e) {
            NextB.Enabled = true;
            foreach(Book b in RuntimeSettings.EngineData.Books) {
                foreach(Background bg in b.Backgrounds) {
                    if(bg.Name == BackgroundOptions.Text) {
                        ((Custom_Elements.DataDisplay)BackgroundDataHost.Controls[1]).Rtf = $@"{{\rtf1\ansi \b Name: \b0 {bg.Name} \line\b Feature: \b0 \ul {bg.Feature.Name}\ul0}}";
                    }
                    BackgroundDataHost.Controls[0].Text = bg.Overview;
                }
            }
        }

        #endregion

        #region Toggles
        private void InfoL_Click(object sender, EventArgs e) {
            LineageDataHost.Controls[1].Visible = false;
            LineageDataHost.Controls[0].Visible = true;
            TraitsL.BackColor = Color.LightGray;
            InfoL.BackColor = Color.DimGray;
        }
        private void TraitsL_Click(object sender, EventArgs e) {
            LineageDataHost.Controls[1].Visible = true;
            LineageDataHost.Controls[0].Visible = false;
            TraitsL.BackColor = Color.DimGray;
            InfoL.BackColor = Color.LightGray;
        }

        private void InfoC_Click(object sender, EventArgs e) {
            ClassDataHost.Controls[1].Visible = false;
            ClassDataHost.Controls[0].Visible = true;
            StatsC.BackColor = Color.LightGray;
            InfoC.BackColor = Color.DimGray;
        }
        private void StatsC_Click(object sender, EventArgs e) {
            ClassDataHost.Controls[1].Visible = true;
            ClassDataHost.Controls[0].Visible = false;
            StatsC.BackColor = Color.DimGray;
            InfoC.BackColor = Color.LightGray;
        }
        private void InfoB_Click(object sender, EventArgs e) {
            BackgroundDataHost.Controls[1].Visible = false;
            BackgroundDataHost.Controls[0].Visible = true;
            StatsB.BackColor = Color.LightGray;
            InfoB.BackColor = Color.DimGray;
        }
        private void StatsB_Click(object sender, EventArgs e) {
            BackgroundDataHost.Controls[1].Visible = true;
            BackgroundDataHost.Controls[0].Visible = false;
            StatsB.BackColor = Color.DimGray;
            InfoB.BackColor = Color.LightGray;
        }
        private void InfoCustom_Click(object sender, EventArgs e) {
            foreach(Control c in CustomizeDataHost.Controls) c.Visible = false;
            InfoDataCustom.Text = CustomizeOptions.SelectedIndex switch { 
                0=>PC.Lineage.Overview,
                1=>PC.Class[0].Overview,
                2=>PC.Background.Overview,
                _=>"",
            };
        }

        private void StatsCustomize_Click(object sender, EventArgs e) {
            //LineageDataHost.Controls[1].Visible = true;
            //LineageDataHost.Controls[0].Visible = false;
            //TraitsL.BackColor = Color.DimGray;
            //InfoL.BackColor = Color.LightGray;
        }
        #endregion
        #endregion





    }
}
