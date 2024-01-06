using System;
using System.Drawing;
using System.Windows.Forms;

using PlayerEngine.Data;

namespace PlayerEngine.Custom_Elements {
    public partial class DiceView : UserControl {
        public DiceView(int RollNum, int RollVal, int? Modifier) {
            InitializeComponent();
            Roll.Text = $"Roll {RollNum}:";
            Value.Text = $"{RollVal}{(Modifier != null ? (Modifier < 0 ? $" - {Math.Abs(Modifier.GetValueOrDefault())}" : $" + {Modifier}") : "")}";// RollVal.ToString();
            
            Roll.Font = new Font(RuntimeSettings.DefaultFont, 11, FontStyle.Regular);
            Value.Font = new Font(RuntimeSettings.DefaultFont, 11, FontStyle.Regular);
        }
    }
}
