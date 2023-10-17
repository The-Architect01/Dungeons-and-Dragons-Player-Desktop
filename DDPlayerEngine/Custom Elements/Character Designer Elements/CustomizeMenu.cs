using System;
using System.Drawing;
using System.Windows.Forms;

using PlayerEngine.Data;

namespace PlayerEngine.Custom_Elements.Character_Designer_Elements {
    public partial class CustomizeMenu : UserControl {

        //static readonly string StatText = "Your character's identity is an important part of any adventure! In this section, we will be assigning values for six categories and naming your character. The six categories have been mentioned in other sections; are STR (Strength), DEX (Dextrarity), CON (Constitution), WIS (Wisdom), INT (Intelligence), and CHA (Charisma). These six numbers determine how well your character tends to do with tasks associated with them. For instance, a character with a high STR and a low CHA - might be good at lifting heavy things, but not be good at communicating ideas.";

        public CustomizeMenu() {
            InitializeComponent();

            foreach (Control c in Controls)
                c.Font = new Font(RuntimeSettings.DefaultFont, 12, FontStyle.Regular);

            CustomizeTitle.Font = new Font(RuntimeSettings.DefaultFont, 27, FontStyle.Bold);
            CustomizeDataHost.Controls.Add(new DataDisplay() { Dock = DockStyle.Fill, Name = "OptionsL", DisplaySetting = DisplaySetting.Lineage });
            CustomizeDataHost.Controls.Add(new DataDisplay() { Dock = DockStyle.Fill, Name = "OptionsC", DisplaySetting = DisplaySetting.Class });
            CustomizeDataHost.Controls.Add(new DataDisplay() { Dock = DockStyle.Fill, Name = "OptionsB", DisplaySetting = DisplaySetting.Background });
        }

        private void InfoCustom_Click(object sender, EventArgs e) {
/*
            InfoCustom.BackColor = Engine.SelectedColor;
            StatsCustomize.BackColor = Engine.InactiveColor;
            foreach (Control c in CustomizeDataHost.Controls) c.Visible = false;
            InfoDataCustom.Visible = true;
            InfoDataCustom.Text = CustomizeOptions.SelectedIndex switch {
                0 => PC.Lineage.Overview,
                1 => PC.Class[0].Overview,
                2 => (PC.Class.Count == 2 ? (PC.Class[1].Overview) : PC.Background.Overview),
                3 => (PC.Class.Count == 2 ? (PC.Background.Overview) : StatText),
                4 => (PC.Class.Count == 2 ? StatText : ""),
                _ => "",
            };*/
        }

        private void StatsCustomize_Click(object sender, EventArgs e) {
            InfoCustom.BackColor = Engine.InactiveColor;
            StatsCustomize.BackColor = Engine.SelectedColor;
            foreach (Control c in CustomizeDataHost.Controls) c.Visible = false;

            try { CustomizeDataHost.Controls[CustomizeOptions.Items.Count + CustomizeOptions.SelectedIndex].Visible = true; } catch { }

        }

        public CharacterArgs ValidateForm() {

            string name = CustomizeDataHost.Controls.GetControlOfType(typeof(Stat)).Controls.Find("CharName", true)[0].Text;
            string pronoun = CustomizeDataHost.Controls.GetControlOfType(typeof(Stat)).Controls.Find("CharNouns", true)[0].Text;
            string align = CustomizeDataHost.Controls.GetControlOfType(typeof(Stat)).Controls.Find("CharAlign", true)[0].Text;
            string[] stats = ($"{CustomizeDataHost.Controls.GetControlOfType(typeof(Stat)).Controls.Find("STR", true)[0].Text} " +
                $"{CustomizeDataHost.Controls.GetControlOfType(typeof(Stat)).Controls.Find("DEX", true)[0].Text} " +
                $"{CustomizeDataHost.Controls.GetControlOfType(typeof(Stat)).Controls.Find("CON", true)[0].Text} " +
                $"{CustomizeDataHost.Controls.GetControlOfType(typeof(Stat)).Controls.Find("WIS", true)[0].Text} " +
                $"{CustomizeDataHost.Controls.GetControlOfType(typeof(Stat)).Controls.Find("INT", true)[0].Text} " +
                $"{CustomizeDataHost.Controls.GetControlOfType(typeof(Stat)).Controls.Find("CHA", true)[0].Text}").Split(' ');


            return new CharacterArgs(CurMenu.Customize, new object[] { name, pronoun, align, stats });

            
        }
    }
}

public enum CurMenu { Lineage, Class, Background, Customize, Other }

public class CharacterArgs {

    public CurMenu DataMode;

    public object[] Data;

    public CharacterArgs(CurMenu menu, object[] Data) { DataMode = menu; this.Data = Data; }

}
