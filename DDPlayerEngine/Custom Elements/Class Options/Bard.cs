using System.Drawing;
using System.Windows.Forms;

using PlayerEngine.Data;

namespace PlayerEngine.Custom_Elements.Class_Options {
    public partial class Bard : UserControl {
        public Bard() {
            InitializeComponent();
            foreach (Control c in Controls)
                c.Font = new Font(RuntimeSettings.DefaultFont, 12, FontStyle.Regular);

            SkillLabel.Font = new Font(RuntimeSettings.DefaultFont, 12, FontStyle.Bold);
            ToolLabel.Font = new Font(RuntimeSettings.DefaultFont, 12, FontStyle.Bold);
            Item1.Font = new Font(RuntimeSettings.DefaultFont, 12, FontStyle.Bold);
            Item2.Font = new Font(RuntimeSettings.DefaultFont, 12, FontStyle.Bold);
            Item3.Font = new Font(RuntimeSettings.DefaultFont, 12, FontStyle.Bold);
        }
    }
}
