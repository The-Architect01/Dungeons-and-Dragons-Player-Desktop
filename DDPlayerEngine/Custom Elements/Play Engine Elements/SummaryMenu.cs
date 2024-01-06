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
using PlayerEngine.Forms.Pop_Ups;

namespace PlayerEngine.Custom_Elements.Play_Engine_Elements {
    public partial class SummaryMenu : UserControl {

        Panel[] Skills;
        Character PC;

        public SummaryMenu(Character PC) {
            this.PC = PC;
            InitializeComponent();
            
            Skills = new Panel[] {
                Acrobatics, AnimalHandling, Arcana, Athletics,
                Deception, History, Insight, Intimidation,
                Investigation, Medicine, Nature, Perception,
                Performance, Persuasion, Religion, SleightOfHand,
                Stealth, Survival
            };

            foreach (Language L in PC.Languages) {
                LanguageDisplay.Controls.Add(new Label() {
                    Text = L.Name,
                    Font = new Font(RuntimeSettings.DefaultFont, 10, FontStyle.Regular)
                });
                //LanguageDisplay.Controls[LanguageDisplay.Controls.Count - 1].Click += PlayEngine_Click;
            }

            int i = 0;
            foreach (Panel Skill in Skills) {
                Skill.Controls[0].Font = new Font(RuntimeSettings.DefaultFont, 9, FontStyle.Underline);
                Skill.Controls[1].Font = new Font(RuntimeSettings.DefaultFont, 9, FontStyle.Regular);

                Skill.Controls[0].Click += PlayEngine_Click;
                Skill.Controls[1].Text = (PC.Stats[(int)PC.Skills[i].BaseStat].Modifier + (PC.Skills[i].HasExpertise ? Engine.Proficincy(PC.Level) * 2 : PC.Skills[i].HasProficincy ? Engine.Proficincy(PC.Level) : PC.Skills[i].HasHalfProficincy ? Engine.Proficincy(PC.Level) / 2 : 0)).ParseAsString();
                Skill.Controls[1].Click += delegate (object sender, EventArgs e) { new RollDice(Skill.Controls[1].Text.Contains("-") ? 0 - int.Parse(Skill.Controls[1].Text.TrimStart('+').TrimStart('-')) : int.Parse(Skill.Controls[1].Text.TrimStart('+').TrimStart('-')), HitDie.d20, 1).ShowDialog(); };
                i++;
            }

            STRLabel.Font = new Font(RuntimeSettings.DefaultFont, 13, FontStyle.Regular);
            DEXLabel.Font = new Font(RuntimeSettings.DefaultFont, 13, FontStyle.Regular);
            CONLabel.Font = new Font(RuntimeSettings.DefaultFont, 13, FontStyle.Regular);
            WISLabel.Font = new Font(RuntimeSettings.DefaultFont, 13, FontStyle.Regular);
            INTLabel.Font = new Font(RuntimeSettings.DefaultFont, 13, FontStyle.Regular);
            CHALabel.Font = new Font(RuntimeSettings.DefaultFont, 13, FontStyle.Regular);

            STR.Text = PC.Stats[0].Score.ToString();
            STR.Font = new Font(RuntimeSettings.DefaultFont, 16, FontStyle.Bold);
            DEX.Text = PC.Stats[1].Score.ToString();
            DEX.Font = new Font(RuntimeSettings.DefaultFont, 16, FontStyle.Bold);
            CON.Text = PC.Stats[2].Score.ToString();
            CON.Font = new Font(RuntimeSettings.DefaultFont, 16, FontStyle.Bold);
            WIS.Text = PC.Stats[3].Score.ToString();
            WIS.Font = new Font(RuntimeSettings.DefaultFont, 16, FontStyle.Bold);
            INT.Text = PC.Stats[4].Score.ToString();
            INT.Font = new Font(RuntimeSettings.DefaultFont, 16, FontStyle.Bold);
            CHA.Text = PC.Stats[5].Score.ToString();
            CHA.Font = new Font(RuntimeSettings.DefaultFont, 16, FontStyle.Bold);

            STRMod.Text = PC.Stats[0].Modifier.ParseAsString();
            STRMod.Font = new Font(RuntimeSettings.DefaultFont, 10, FontStyle.Regular);
            DEXMod.Text = PC.Stats[1].Modifier.ParseAsString();
            DEXMod.Font = new Font(RuntimeSettings.DefaultFont, 10, FontStyle.Regular);
            CONMod.Text = PC.Stats[2].Modifier.ParseAsString();
            CONMod.Font = new Font(RuntimeSettings.DefaultFont, 10, FontStyle.Regular);
            WISMod.Text = PC.Stats[3].Modifier.ParseAsString();
            WISMod.Font = new Font(RuntimeSettings.DefaultFont, 10, FontStyle.Regular);
            INTMod.Text = PC.Stats[4].Modifier.ParseAsString();
            INTMod.Font = new Font(RuntimeSettings.DefaultFont, 10, FontStyle.Regular);
            CHAMod.Text = PC.Stats[5].Modifier.ParseAsString();
            CHAMod.Font = new Font(RuntimeSettings.DefaultFont, 10, FontStyle.Regular);

            Speed.Text = $"Speed: {PC.Lineage.Speed} ft";            
            HP.Font = new Font(RuntimeSettings.DefaultFont, 10, FontStyle.Regular);
            HP.Text = $"HP: {PC.CurrentHitPoints}/{PC.MaxHitPoints}";
            Initiative.Text = $"Initative: {PC.Stats[1].Modifier.ParseAsString()}";
            Prof.Text = $"Proficincy: {Engine.Proficincy(PC.Level).ParseAsString()}";
            PassivePerception.Text = $"Passive Perception: {PC.PassiveScore("Perception")}";

            LangLabel.Font = new Font(RuntimeSettings.DefaultFont, 10, FontStyle.Bold);
            WeaponLabel.Font = new Font(RuntimeSettings.DefaultFont, 10, FontStyle.Bold);
            ToolLabel.Font = new Font(RuntimeSettings.DefaultFont, 10, FontStyle.Bold);
            ArmorLabel.Font = new Font(RuntimeSettings.DefaultFont, 10, FontStyle.Bold);
            
            Dock = DockStyle.Fill;
        }

        private void PlayEngine_Click(object sender, EventArgs e) { MessageBox.Show(PC.GetData(((Label)sender).Text)); }

        private void STRMod_Click(object sender, EventArgs e) { new RollDice(PC.Stats[0].Modifier, HitDie.d20, 1).ShowDialog(); }

        private void DEXMod_Click(object sender, EventArgs e) { new RollDice(PC.Stats[1].Modifier, HitDie.d20, 1).ShowDialog(); }

        private void CONMod_Click(object sender, EventArgs e) { new RollDice(PC.Stats[2].Modifier, HitDie.d20, 1).ShowDialog(); }

        private void WISMod_Click(object sender, EventArgs e) { new RollDice(PC.Stats[3].Modifier, HitDie.d20, 1).ShowDialog(); }

        private void INTMod_Click(object sender, EventArgs e) { new RollDice(PC.Stats[4].Modifier, HitDie.d20, 1).ShowDialog(); }

        private void CHAMod_Click(object sender, EventArgs e) { new RollDice(PC.Stats[5].Modifier, HitDie.d20, 1).ShowDialog(); }

    }
}
