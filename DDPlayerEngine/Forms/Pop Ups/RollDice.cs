using System;
using System.Drawing;
using System.Windows.Forms;

using PlayerEngine.Custom_Elements;
using PlayerEngine.Data;
using PlayerEngine.Properties;

namespace PlayerEngine.Forms.Pop_Ups {
    public partial class RollDice : Form {
        
        int? Modifer = null;
        
        public RollDice(int? Modifier = null, HitDie? defaultdie = null, int? Count = null) {
            InitializeComponent();
            foreach (Control c in Controls) c.Font = new System.Drawing.Font(RuntimeSettings.DefaultFont, 10, System.Drawing.FontStyle.Regular);
            Icon = Resources.D202;
            Modifer = Modifier;
            if (defaultdie.HasValue) {
                DiceSelector.SelectedIndex = DiceSelector.Items.IndexOf(defaultdie.ToString());
                DiceSelector.Enabled = false;
            }
            if (Count.HasValue) {
                NumDice.Value = Count.GetValueOrDefault();
                NumDice.Enabled = false;
            }
        }

        private void Advantage_CheckStateChanged(object sender, EventArgs e) {
            switch (((CheckBox)sender).CheckState) {
                case CheckState.Indeterminate:
                    ((CheckBox)sender).Text = "Normal";
                    break;
                case CheckState.Checked:
                    ((CheckBox)sender).Text = "Advantage";
                    break;
                case CheckState.Unchecked:
                    ((CheckBox)sender).Text = "Disadvantage";
                    break;

            }
        }

        private void RollDie_Click(object sender, EventArgs e) {
            RollAnimator.Start();
            RollEnd.Start();
        }

        private void RollAnimator_Elapsed(object sender, System.Timers.ElapsedEventArgs e) {
            RollDiceAttempt();
        }

        void RollDiceAttempt() {
            RollHistory.Controls.Clear();
            try {
                int c = 0;
                int d = 0;
                bool Repeat = false;
                ADVANTAGE_OR_DISADVANTAGE:
                for (int i = 0; i < NumDice.Value; i++) {
                    var value = Engine.RNG.Next(1, ((HitDie)Enum.Parse(typeof(HitDie), DiceSelector.Text)).ParseHitDie() + 1); 

                    RollHistory.Controls.Add(new DiceView(i + 1, value, Modifer) { ForeColor = value == 1 && DiceSelector.Text == "d20" ? Color.Red : value == 20 && DiceSelector.Text == "d20" ? Color.Green : Color.Black });
                    if (!Repeat) c += (value + Modifer.GetValueOrDefault()); else d += (value + Modifer.GetValueOrDefault());
                }
                if (Advantage.CheckState != CheckState.Indeterminate && !Repeat) { Repeat = true; goto ADVANTAGE_OR_DISADVANTAGE; }
                RollTotal.Text = $"Total Roll: { (Advantage.CheckState == CheckState.Checked ? (c > d ? c : d) : Advantage.CheckState == CheckState.Unchecked ? (c < d ? c : d) : c)}";
            } catch (NotImplementedException) {
                MessageBox.Show("You didn't roll any dice!");
                RollAnimator.Stop();
                RollEnd.Stop();
            }
        }

        private void RollEnd_Elapsed(object sender, System.Timers.ElapsedEventArgs e) {
            RollAnimator.Stop();
            RollDiceAttempt();
            RollEnd.Stop();
        }
    }
}
