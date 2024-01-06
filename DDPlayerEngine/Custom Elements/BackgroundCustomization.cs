using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using PlayerEngine.Data;

namespace PlayerEngine.Custom_Elements {
    public partial class BackgroundCustomization : UserControl {
        public BackgroundCustomization(Background Target) {
            InitializeComponent();
            foreach (Control c in Controls)
                c.Font = new Font(RuntimeSettings.DefaultFont, 12, FontStyle.Regular);
            Equipment.Font = new Font(RuntimeSettings.DefaultFont, 12, FontStyle.Regular);

            label9.Font = new Font(RuntimeSettings.DefaultFont, 12, FontStyle.Bold);
            label10.Font = new Font(RuntimeSettings.DefaultFont, 12, FontStyle.Bold);
            label4.Font = new Font(RuntimeSettings.DefaultFont, 12, FontStyle.Bold);
            label1.Font = new Font(RuntimeSettings.DefaultFont, 12, FontStyle.Bold);
            label3.Font = new Font(RuntimeSettings.DefaultFont, 12, FontStyle.Bold);
            label2.Font = new Font(RuntimeSettings.DefaultFont, 12, FontStyle.Bold);

            PersonalityBox.Items.Clear();
            IdealBox.Items.Clear();
            BondBox.Items.Clear();
            FlawBox.Items.Clear();
            
            PersonalityBox.Items.AddRange(Target.Personality);
            IdealBox.Items.AddRange(Target.Ideals);
            BondBox.Items.AddRange(Target.Bonds);
            FlawBox.Items.AddRange(Target.Flaws);

            if (Target.Skills == null || Target.Skills.Length == 0) {
                Skills.Controls.Add(new Label() { Text = "None", Size = new System.Drawing.Size(302, 21) });
            } else {
                foreach (var t in Target.Skills) {
                    if (t.Contains("Choose")) {
                        Skills.Controls.Add(new ComboBox() { Size = new System.Drawing.Size(302, 21) });
                        ((ComboBox)Skills.Controls[Skills.Controls.Count - 1]).Items.AddRange(RuntimeSettings.EngineData.SKILLS);
                    } else {
                        Skills.Controls.Add(new Label() { Text = t, Size = new System.Drawing.Size(302, 21) });
                    }
                }
            }

            if (Target.Languages == null || Target.Languages.Length == 0) {
                LanguageBox1.Controls.Add(new Label() { Text = "None", Size = new System.Drawing.Size(302, 21) });
            } else {
                foreach (var t in Target.Languages) {
                    if (t.Contains("Choose")) {
                        LanguageBox1.Controls.Add(new ComboBox() { Size = new System.Drawing.Size(302, 21) });
                        ((ComboBox)LanguageBox1.Controls[LanguageBox1.Controls.Count - 1]).Items.AddRange(RuntimeSettings.EngineData.LANGUAGES);
                    } else {
                        LanguageBox1.Controls.Add(new Label() { Text = t, Size = new System.Drawing.Size(302, 21) });
                    }
                }
            }

            if (Target.Tools == null || Target.Tools.Length == 0) {
                ToolBox1.Controls.Add(new Label() { Text = "None", Size = new System.Drawing.Size(302, 21) });
            } else { 
                foreach(var t in Target.Tools) {
                    if (t.Contains("Choose")) {
                        ToolBox1.Controls.Add(new ComboBox() { Size = new System.Drawing.Size(302, 21) });
                        ((ComboBox)ToolBox1.Controls[ToolBox1.Controls.Count - 1]).Items.AddRange(RuntimeSettings.EngineData.ARTISAN_TOOLS);
                    } else {
                        ToolBox1.Controls.Add(new Label() { Text = t, Size = new System.Drawing.Size(302, 21) });
                    }
                }
            }

            foreach(string s in Target.Items) {
                Equipment.Text += s + ", ";
            }
            Equipment.Text = Equipment.Text.Trim( ' ', ',');

        }
    }
}
