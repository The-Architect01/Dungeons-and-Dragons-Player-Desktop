using System;
using System.Windows.Forms;

using PlayerEngine.Data;

namespace PlayerEngine.Custom_Elements {
    public partial class Stat : UserControl {

        bool Rolled = false;
        readonly Label[] Rolls;
        readonly ComboBox[] Assignments;
        int[] Modifiers;

        public Stat() {
            InitializeComponent();
            Rolls = new Label[6] {
                Roll1, Roll2, Roll3, Roll4, Roll5, Roll6
            };
            Assignments = new ComboBox[6] {
                Roll1Apply, Roll2Apply, Roll3Apply, Roll4Apply, Roll5Apply, Roll6Apply
            };

        }

        public void Update(Lineage lineage) {
            Modifiers = new int[]{
                lineage.StatModifiers[0].Modifier,
                lineage.StatModifiers[1].Modifier,
                lineage.StatModifiers[2].Modifier,
                lineage.StatModifiers[3].Modifier,
                lineage.StatModifiers[4].Modifier,
                lineage.StatModifiers[5].Modifier
            };
        }

        private void Reroll_Click(object sender, EventArgs e) {
            Rolled = true;
            if (Rolled) Reroll.Text = "Reroll";
            RollAnimator.Start();
            RollEnd.Start();
        }

        private void RollAnimator_Elapsed(object sender, System.Timers.ElapsedEventArgs e) {
            foreach (Label l in Rolls) {
                int d61 = Engine.RNG.Next(1,6);
                int d62 = Engine.RNG.Next(1,6);
                int d63 = Engine.RNG.Next(1,6);
                int d64 = Engine.RNG.Next(1,6);

                int score = (d61 + d62 + d63 + d64) - Engine.Min(d61, d62, d63, d64);

                l.Text = score.ToString();
            }
        }

        private void RollEnd_Elapsed(object sender, System.Timers.ElapsedEventArgs e) {
            RollAnimator.Stop();
            int i = 0;
            foreach (Label l in Rolls) {
                int d61 = Engine.RNG.Next(1,6);
                int d62 = Engine.RNG.Next(1,6);
                int d63 = Engine.RNG.Next(1,6);
                int d64 = Engine.RNG.Next(1,6);

                int score1 = (d61 + d62 + d63 + d64) - Engine.Min(d61, d62, d63, d64);

                d61 = Engine.RNG.Next(1,6);
                d62 = Engine.RNG.Next(1,6);
                d63 = Engine.RNG.Next(1,6);
                d64 = Engine.RNG.Next(1,6);
                int score2 = (d61 + d62 + d63 + d64) - Engine.Min(d61, d62, d63, d64);

                int score = Engine.Max(score1, score2) + Modifiers[i];

                l.Text = score.ToString();
                i++;
            }
            RollEnd.Stop();
        }

        private void Apply_Click(object sender, EventArgs e) {
            try {
                foreach (ComboBox b in Assignments) {
                    Controls.Find(b.SelectedItem.ToString(), true)[0].Text = Controls.Find(b.Name.Substring(0, 5), true)[0].Text;
                    Controls.Find(b.SelectedItem.ToString() + "Mod", true)[0].Text = "+ 2";
                }
            } catch {
                MessageBox.Show("Please assign all stats.");
            }
        }
    }
}
