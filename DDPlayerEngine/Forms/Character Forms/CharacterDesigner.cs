using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text.Json;
using System.Threading;
using System.Windows.Forms;

using PlayerEngine.Custom_Elements;
using PlayerEngine.Custom_Elements.Character_Designer_Elements;
using PlayerEngine.Custom_Elements.Class_Options;
using PlayerEngine.Data;
using PlayerEngine.Properties;

namespace PlayerEngine.Forms {

    /// <summary>
    /// A form holding data for character design
    /// </summary>
    public partial class CharacterDesigner : Form {

        public Character PC;
        bool MadeCharacter = false;

        CustomizeMenu CharacterCustomizationMenu;

        /// <summary>
        /// Create a new form
        /// </summary>
        public CharacterDesigner() {
            InitializeComponent();
            GenerateData();
            LineageTab_Load();
            ClassTab_Load();
            BackgroundTab_Load();

            CharacterCustomizationMenu = new CustomizeMenu();

            PC = new Character();

        }


        private void CharacterDesigner_FormClosed(object sender, FormClosedEventArgs e) {
            if(!MadeCharacter) Program.MM.Show();
        }
        private void CharacterDesigner_FormClosing(object sender, FormClosingEventArgs e) {
            if (MadeCharacter) {
                //if (new UpdateBox().Show("Are you sure you want to go back to the Main Menu?\nYour character will be deleted.", Application.ProductName, MessageBoxButtons.YesNo) == DialogResult.No)
                //    e.Cancel = true;
            }
        }

        #region Loading Events
        private void GenerateData() {
            foreach (Control c in Controls)
                c.Font = new Font(RuntimeSettings.DefaultFont, 12, FontStyle.Regular);

            LineageTitle.Font = new Font(RuntimeSettings.DefaultFont, 27, FontStyle.Bold);
            LineageDataHost.Controls.Add(new DataDisplay() { Dock = DockStyle.Fill, Name = "DescriptionL", DisplaySetting = DisplaySetting.Lineage });
            LineagePreview.BackgroundImage = (Image)new ImageConverter().ConvertFrom(Convert.FromBase64String(RuntimeSettings.EngineData.Books[0].Lineages[0].ResourceBase64));
            InfoDataL.Font = new Font(RuntimeSettings.DefaultFont, 11, FontStyle.Regular);

            ClassTitle.Font = new Font(RuntimeSettings.DefaultFont, 27, FontStyle.Bold);
            ClassDataHost.Controls.Add(new DataDisplay() { Dock = DockStyle.Fill, Name = "DescriptionC", DisplaySetting = DisplaySetting.Class });
            ClassPreview.BackgroundImage = (Image)new ImageConverter().ConvertFrom(Convert.FromBase64String(RuntimeSettings.EngineData.Books[0].Classes[0].ResourceBase64));

            BackgroundTitle.Font = new Font(RuntimeSettings.DefaultFont, 27, FontStyle.Bold);
            BackgroundDataHost.Controls.Add(new DataDisplay() { Dock = DockStyle.Fill, Name = "DescriptionB", DisplaySetting = DisplaySetting.Background });

            

            BackgroundPreview.BackgroundImage = (Image)new ImageConverter().ConvertFrom(Convert.FromBase64String(Settings.Default.BackgroundsImage));
            BackgroundPreview.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
        }

        private void LineageTab_Load() {
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
            Class2Options.Items.Clear();
            List<string> EnabledBooks = JsonSerializer.Deserialize<List<string>>(Settings.Default.EnabledBooks.ToString());
            foreach (Book b in RuntimeSettings.EngineData.Books) {
                if (EnabledBooks.Contains(b.ReferenceCode)) {
                    foreach (Class cl in b.Classes) {
                        ClassOptions.Items.Add($"{cl.BaseClass} ({cl.SubClass})");
                        Class2Options.Items.Add($"{cl.BaseClass} ({cl.SubClass})");
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
        private void BackL_Click(object sender, EventArgs e) { Close(); }

        private void NextL_Click(object sender, EventArgs e) {
            ClassTab.Visible = true;
            Type ControlToAddClass1 = Assembly.GetExecutingAssembly().GetType($"PlayerEngine.Custom_Elements.Class_Options.BloodHunter");

            Panel CustomizeDataHost = CharacterCustomizationMenu.CustomizeDataHost;

            if (!CustomizeDataHost.Controls.ContainsTypes(ControlToAddClass1)) {
                CustomizeDataHost.Controls.Add(Activator.CreateInstance(ControlToAddClass1) as UserControl);
                CustomizeDataHost.Controls[CustomizeDataHost.Controls.Count - 1].Dock = DockStyle.Top;
                CustomizeDataHost.Controls[CustomizeDataHost.Controls.Count - 1].Visible = false;
            }

            Thread.Sleep(100);
        }

        private void BackC_Click(object sender, EventArgs e) {
            ClassTab.Visible = false;
            Thread.Sleep(100);
        }
        private void NextC_Click(object sender, EventArgs e) {
            BackgroundTab.Visible = true;

            Type ControlToAddClass1 = Assembly.GetExecutingAssembly().GetType($"PlayerEngine.Custom_Elements.Class_Options.{PC.Class[0].BaseClass.Replace(" ", "")}");

            Panel CustomizeDataHost = CharacterCustomizationMenu.CustomizeDataHost;

            if (!CustomizeDataHost.Controls.ContainsTypes(ControlToAddClass1)) {
                CustomizeDataHost.Controls.Add(Activator.CreateInstance(ControlToAddClass1) as UserControl);
                CustomizeDataHost.Controls[CustomizeDataHost.Controls.Count - 1].Dock = DockStyle.Top;
                CustomizeDataHost.Controls[CustomizeDataHost.Controls.Count - 1].Visible = false;
            }

            Thread.Sleep(100);

        }

        private void BackB_Click(object sender, EventArgs e) {
            BackgroundTab.Visible = false;
            Thread.Sleep(100);
        }

        private void NextB_Click(object sender, EventArgs e) {
            CharacterCustomizationMenu.Visible = true;

            Panel CustomizeDataHost = CharacterCustomizationMenu.CustomizeDataHost;

            Type BackgroundModifier = typeof(BackgroundCustomization);

            if (!CustomizeDataHost.Controls.ContainsTypes(BackgroundModifier)) {
                CustomizeDataHost.Controls.Add(Activator.CreateInstance(BackgroundModifier) as UserControl);
                CustomizeDataHost.Controls[CustomizeDataHost.Controls.Count - 1].Dock = DockStyle.Top;
                CustomizeDataHost.Controls[CustomizeDataHost.Controls.Count - 1].Visible = false;
            }

            Type StatModifiers = typeof(Stat);

            if (!CustomizeDataHost.Controls.ContainsTypes(StatModifiers)) {
                CustomizeDataHost.Controls.Add(Activator.CreateInstance(StatModifiers) as UserControl);
                CustomizeDataHost.Controls[CustomizeDataHost.Controls.Count - 1].Dock = DockStyle.Top;
                CustomizeDataHost.Controls[CustomizeDataHost.Controls.Count - 1].Visible = false;
                (CustomizeDataHost.Controls[CustomizeDataHost.Controls.Count - 1] as Stat).Update(PC.Lineage);
            }

            Thread.Sleep(100);

        }

        private void BackCs_Click(object sender, EventArgs e) {
            CharacterCustomizationMenu.Visible = false;
            Thread.Sleep(100);
        }

        private void NextCs_Click(object sender, EventArgs e) {
            if (Check()) {
                PlayEngine PE = new(PC);
                Thread.Sleep(100);
                PE.Show();
                MadeCharacter = true;
                Close();
            } else
                MessageBox.Show("Make sure that all the required data is filled in.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool Check() {
            CharacterArgs args = CharacterCustomizationMenu.ValidateForm();

            if (args.DataMode != CurMenu.Other)
                if ((string)args.Data[0] != "" && (((string[])args.Data[3]).Length == 6)) {
                    PC.Name = (string)args.Data[0];
                    PC.Pronouns = (string)args.Data[1];
                    PC.Alignment = (Alignment)Enum.Parse(typeof(Alignment), ((string)args.Data[3]).Replace(" ", "_"), true);

                    foreach (Ability stat in PC.Stats)
                        stat.Score = int.Parse(((string[])args.Data[3])[(int)stat.Name]);

                    File.WriteAllText(Engine.SaveFileLocation + $"Characters\\{PC.Name} ({PC.Class[0].SubClass} {PC.Class[0].BaseClass}).hro", JsonSerializer.Serialize(PC, Engine.JsonSerializerOptions));
                    return true;
                }

            return false;

            /*
            */
        }
        #endregion

        #region Drop Downs
        private void LineageOptions_SelectedIndexChanged(object sender, EventArgs e) {
            NextL.Enabled = true;
            foreach (Book b in RuntimeSettings.EngineData.Books) {
                foreach (Lineage rc in b.Lineages) {

                    string Prof = "", a = "", l = "";
                    try { foreach (string p in rc.Proficincy) { Prof += p + ", "; } Prof = Prof.TrimEnd(',', ' '); } catch { Prof = "None"; }
                    foreach (string ln in rc.Languages) { l += ln + ", "; }
                    l = l.TrimEnd(',', ' ');
                    try { foreach (LineageTrait ca in rc.LineageTraits) { a += ca.Name + ", "; } a = a.TrimEnd(',', ' '); } catch { a = "None"; }

                    if ($"{rc.BaseLineage}{(rc.SubLineage == null ? "" : $" ({rc.SubLineage})")}" == LineageOptions.Text) {
                        ((DataDisplay)LineageDataHost.Controls[1]).Rtf = $@"{{\rtf1\ansi\sl325\slmult1 \b Name: \b0 {rc.BaseLineage} \line{(rc.SubLineage != null ? $@"\b Subrace: \b0 {rc.SubLineage} \line" : string.Empty)}\b Statistic Spread: \b0 \line\tab\ul STR\ul0 : {rc.StatModifiers[0].Modifier}\tab\ul DEX\ul0 : {rc.StatModifiers[1].Modifier}\tab\ul CON\ul0 : {rc.StatModifiers[2].Modifier}\line\tab\ul WIS\ul0 : {rc.StatModifiers[3].Modifier}\tab\ul INT\ul0 : {rc.StatModifiers[4].Modifier}\tab\tab\ul CHA\ul0 : {rc.StatModifiers[5].Modifier}\line\b \ul Speed\ul0 : \b0 {rc.Speed} \line\b \ul Size\ul0 : \b0 {rc.Size} \line\b Languages: \b0 {l}\line\b Proficincies: \b0 {Prof} \line\b Traits: \b0 {a} \line }}";
                    }

                    LineageDataHost.Controls[0].Text = rc.Overview;
                    PC.Lineage = rc;

                    LineageSource.Text = "Source: " + rc.ResourceSource;
                }
            }

        }

        private void ClassOptions_SelectedIndexChanged(object sender, EventArgs e) {
            NextC.Enabled = true;
            ClassUpdate(sender, e);
        }

        private void BackgroundOptions_SelectedIndexChanged(object sender, EventArgs e) {
            NextB.Enabled = true;
            foreach (Book b in RuntimeSettings.EngineData.Books) {
                foreach (Background bg in b.Backgrounds) {

                    string Prof = "", a = "", l = "", items = "";
                    try { foreach (string p in bg.Skills) { Prof += p + ", "; } Prof = Prof.TrimEnd(',', ' '); } catch { Prof = "None"; }
                    try { foreach (string ln in bg.Languages) { l += ln + ", "; } l = l.TrimEnd(',', ' '); } catch { l = "None"; }
                    try { foreach (string ca in bg.Tools) { a += ca + ", "; } a = a.TrimEnd(',', ' '); } catch { a = "None"; }
                    try { foreach (string i in bg.Items) { items += i + ", "; } items = items.TrimEnd(',', ' '); } catch { items = "None"; }

                    if (bg.Name == BackgroundOptions.Text) {
                        ((DataDisplay)BackgroundDataHost.Controls[1]).Rtf = $@"{{\rtf1\ansi \b Name: \b0 {bg.Name} \line\b Feature: \b0 \ul {bg.Feature.Name}\ul0 \line \b Languages:\b0  {l}\line\b Skills:\b0  {Prof}\line\b Tools:\b0  {a}\line\b Equipment: \b0 {items}}}";
                    }
                    BackgroundDataHost.Controls[0].Text = bg.Overview;
                    PC.Background = bg;

                    BackgroundSource.Text = "Source: " + bg.Creator;
                }
            }
        }
        #endregion

        #region Toggles
        enum View { Info, Traits }
        private void ToggleButton(View view) {
            if (BackgroundDataHost.Visible) {
                BackgroundDataHost.Controls[1].Visible = view == View.Traits;
                BackgroundDataHost.Controls[0].Visible = view == View.Info;
                StatsB.BackColor = view == View.Traits ? Engine.SelectedColor : Engine.InactiveColor;
                InfoB.BackColor = view == View.Info ? Engine.SelectedColor : Engine.InactiveColor;
            } else if (ClassDataHost.Visible) {
                ClassDataHost.Controls[1].Visible = view == View.Traits;
                ClassDataHost.Controls[0].Visible = view == View.Info;
                StatsC.BackColor = view == View.Traits ? Engine.SelectedColor : Engine.InactiveColor;
                InfoC.BackColor = view == View.Info ? Engine.SelectedColor : Engine.InactiveColor;
            } else if (LineageDataHost.Visible) {
                LineageDataHost.Controls[1].Visible = view == View.Traits;
                LineageDataHost.Controls[0].Visible = view == View.Info;
                TraitsL.BackColor = view == View.Traits ? Engine.SelectedColor : Engine.InactiveColor;
                InfoL.BackColor = view == View.Info ? Engine.SelectedColor : Engine.InactiveColor;
            }
        }
        private void InfoL_Click(object sender, EventArgs e) { ToggleButton(View.Info); }
        private void TraitsL_Click(object sender, EventArgs e) { ToggleButton(View.Traits); }
        private void InfoC_Click(object sender, EventArgs e) { ToggleButton(View.Info); }
        private void StatsC_Click(object sender, EventArgs e) { ToggleButton(View.Traits); }
        private void InfoB_Click(object sender, EventArgs e) { ToggleButton(View.Info); }
        private void StatsB_Click(object sender, EventArgs e) { ToggleButton(View.Traits); }
        
        #endregion

        #endregion

        private void AddClass_Click(object sender, EventArgs e) {
            AdditionalClass.Visible = true;
            AddClass.Visible = false;
            LevelClass2.SelectedIndex = 0;
            LevelClass1_SelectedIndexChanged(this, e);
            LevelClass2_SelectedIndexChanged(this, e);
            //CustomizeOptions.Items[1] = "Class 1";
            //CustomizeOptions.Items.Insert(2, "Class 2");
        }

        private void RemoveClass_Click(object sender, EventArgs e) {
            AdditionalClass.Visible = false;
            AddClass.Visible = true;
            if (PC.Class.Count > 1) PC.Class.RemoveAt(1);
            LevelClass2.SelectedIndex = -1;
            //CustomizeOptions.Items[1] = "Class";
            //CustomizeOptions.Items.RemoveAt(2);
        }

        bool SpecialUpdate = false;

        private void LevelClass1_SelectedIndexChanged(object sender, EventArgs e) {
            if (SpecialUpdate) { SpecialUpdate = false; return; }
            SpecialUpdate = true;
            int LevelCap = LevelClass2.SelectedIndex + 1;
            LevelClass2.Items.Clear();
            for (int i = 1; i <= 20; i++)
                if (i + LevelClass1.SelectedIndex + 1 <= 20) LevelClass2.Items.Add(i);
            if (LevelClass2.Items.Contains(LevelCap)) { LevelClass2.SelectedIndex = LevelCap - 1; } else { LevelClass2.SelectedIndex = -1; }
            try { PC.Class[0].Level = int.Parse(LevelClass1.Text); } catch { }
        }

        private void LevelClass2_SelectedIndexChanged(object sender, EventArgs e) {
            if (SpecialUpdate) { SpecialUpdate = false; return; }
            SpecialUpdate = true;
            int LevelCap = LevelClass1.SelectedIndex + 1;
            LevelClass1.Items.Clear();
            for (int i = 1; i <= 20; i++)
                if (i + LevelClass2.SelectedIndex + 1 <= 20) LevelClass1.Items.Add(i);
            if (LevelClass1.Items.Contains(LevelCap)) { LevelClass1.SelectedIndex = LevelCap - 1; } else { LevelClass1.SelectedIndex = -1; }
            try { PC.Class[1].Level = int.Parse(LevelClass2.Text); } catch { }
        }

        private void ClassUpdate(object sender, EventArgs e, bool Class1 = true) {
            foreach (Book b in RuntimeSettings.EngineData.Books) {
                foreach (Class cl in b.Classes) {

                    if ($"{cl.BaseClass} ({cl.SubClass})" == ClassOptions.Text) {

                        string Prof = "", EQ = "", a = "";
                        foreach (string p in cl.Proficiencies) { Prof += p + ", "; }
                        Prof = Prof.TrimEnd(',', ' ');
                        foreach (EquipmentOptions eq in cl.EquipmentOptions) { foreach (string s in eq.Options) { EQ += s + ", "; } }
                        EQ = EQ.TrimEnd(',', ' ');
                        foreach (ClassAbility ca in cl.Abilities) { a += ca.Name + ", "; }
                        a = a.TrimEnd(',', ' ');

                        ((DataDisplay)ClassDataHost.Controls[1]).Rtf = $@"{{\rtf1\ansi\sl325\slmult1 \b Name: \b0 {cl.BaseClass} \line\b Subclass: \b0 {cl.SubClass} \line\b Hit Dice:\b0  {cl.HitDie} \line\b Proficiencies:\b0  {Prof}\line\b Spellcasting:\b0  {(cl.IsFullCaster ? "Full Caster" : cl.IsHalfCaster ? "Half-Caster" : "No")} \line\b Equipment:\b0  {EQ} \line\b Abilities:\b0  {a}}}";
                    }
                    ClassDataHost.Controls[0].Text = cl.Overview;
                    if (PC.Class.Count == 0) { PC.Class = new List<Class> { null }; }
                    try { PC.Class[(Class1 ? 0 : 1)] = cl; PC.Class[(Class1 ? 0 : 1)].Level = Class1 ? int.Parse(LevelClass1.Text) : int.Parse(LevelClass2.Text);  } catch { PC.Class.Add(cl); PC.Class[(Class1 ? 0 : 1)].Level = Class1 ? int.Parse(LevelClass1.Text) : int.Parse(LevelClass2.Text); }

                    PC.CurrentHitPoints = PC.MaxHitPoints;

                    ClassSource.Text = "Source: " + cl.ResourceSource;
                }
            }
        }

        private void Class2Options_SelectedIndexChanged(object sender, EventArgs e) { ClassUpdate(sender, e, false); }

        private void CustomizeOptions_SelectedIndexChanged(object sender, EventArgs e) { } //InfoCustom_Click(sender, e); }

        private void ClickMe_Click(object sender, EventArgs e) {
            openFileDialog1.ShowDialog();

            try {
                byte[] b = new byte[openFileDialog1.OpenFile().Length];
                openFileDialog1.OpenFile().Read(b, 0, b.Length);
                PC.Illustration = Convert.ToBase64String(b);
             //   CustomPreview.BackgroundImage = (Image)new ImageConverter().ConvertFrom(Convert.FromBase64String(PC.Illustration));
            } catch { }

        }

        private void CustomPreview_Click(object sender, EventArgs e) { ClickMe_Click(sender, e); }
    }
}
