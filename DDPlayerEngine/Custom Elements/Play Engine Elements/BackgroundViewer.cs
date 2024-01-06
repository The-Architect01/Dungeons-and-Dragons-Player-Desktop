using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PlayerEngine.Data;

namespace PlayerEngine.Custom_Elements.Play_Engine_Elements {
    public partial class BackgroundViewer : UserControl {
        public BackgroundViewer(Character PC) {
            InitializeComponent();

            foreach(Control c in Controls) {
                c.Font = new Font(RuntimeSettings.DefaultFont, 10);
            }

            MasterLabel1.Font = new Font(RuntimeSettings.DefaultFont, 16, FontStyle.Bold);
            MasterLabel2.Font = new Font(RuntimeSettings.DefaultFont, 16, FontStyle.Bold);
            MasterLabel3.Font = new Font(RuntimeSettings.DefaultFont, 16, FontStyle.Bold);

            Background.Text = PC.Background.Name;
            Alignment.Text = PC.Alignment.ToString();
            Hair.Text = PC.HairColor;
            Faith.Text = PC.Faith;
            Pronouns.Text = PC.Pronouns;
            Eyes.Text = PC.EyeColor;
            Skin.Text = PC.SkinColor;
            SizeTxtBox.Text = PC.Lineage.Size.ToString();
            Age.Text = PC.Age.ToString();
            HeightTxtBox.Text = PC.Height.ToString();
            Weight.Text = PC.Weight.ToString();

            foreach(string s in PC.BackgroundPersonalites) {
                PersonalityTraits.Text += $"{s}\n";
            }
            foreach (string s in PC.BackgroundIdeals) {
                Ideals.Text += $"{s}\n";
            }
            foreach (string s in PC.BackgroundBonds) {
                Bonds.Text += $"{s}\n";
            }
            foreach (string s in PC.BackgroundFlaws) {
                Flaws.Text += $"{s}\n";
            }

        }
    }
}
