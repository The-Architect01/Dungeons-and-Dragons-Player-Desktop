using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PlayerEngine.Data;

namespace PlayerEngine.Custom_Elements {
    public partial class BackgroundCustomization : UserControl {
        public BackgroundCustomization() {
            InitializeComponent();
            foreach (Control c in Controls)
                c.Font = new Font(RuntimeSettings.DefaultFont, 12, FontStyle.Regular);

        }
    }
}
