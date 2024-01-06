using System.Windows.Forms;

using Microsoft.Office.Core;

using PlayerEngine.Data;

namespace PlayerEngine.Custom_Elements.Play_Engine_Elements {
    public partial class TraitsMenu : UserControl {
        public TraitsMenu(Character PC) {
            InitializeComponent();

            LineageLabel.Font = new System.Drawing.Font(RuntimeSettings.DefaultFont, 20, System.Drawing.FontStyle.Bold);
            ClassLabel.Font = new System.Drawing.Font(RuntimeSettings.DefaultFont, 20, System.Drawing.FontStyle.Bold);
            BackgroundLabels.Font = new System.Drawing.Font(RuntimeSettings.DefaultFont, 20, System.Drawing.FontStyle.Bold);


            if (PC.Lineage.LineageTraits == null || PC.Lineage.LineageTraits.Count == 0) {
                LineageTrait.Controls.Add(new Label() {
                    Text = "NONE",
                    Font = new System.Drawing.Font(RuntimeSettings.DefaultFont, 10),
                    AutoSize = true
                });
            } else {
                foreach (LineageTrait lt in PC.Lineage.LineageTraits) {
                    LineageTrait.Controls.Add(new Label() {
                        Text = $"{lt.Name}\n{lt.Description}",
                        Font = new System.Drawing.Font(RuntimeSettings.DefaultFont, 10),
                        AutoSize = true
                    });
                }
            }

            foreach (ClassAbility ca in PC.Class[0].Abilities) {
                if (PC.Class[0].Level >= ca.LevelUnlocked) {
                    ClassTrait.Controls.Add(new Label() {
                        Text = ca.Name,
                        Font = new System.Drawing.Font(RuntimeSettings.DefaultFont, 15, System.Drawing.FontStyle.Bold),
                        AutoSize = true
                    });
                    ClassTrait.Controls.Add(new Label() {
                        Text = ca.Description,
                        Font = new System.Drawing.Font(RuntimeSettings.DefaultFont, 10),
                        AutoSize = true
                    });
                }
            }

            BackgroundTraitHost.Controls.Add(new Label() {
                Text = PC.Background.Feature.Name,
                Font = new System.Drawing.Font(RuntimeSettings.DefaultFont, 15, System.Drawing.FontStyle.Bold),
                AutoSize = true
            });
            BackgroundTraitHost.Controls.Add(new Label() {
                Text = PC.Background.Feature.Description,
                Font = new System.Drawing.Font(RuntimeSettings.DefaultFont, 10),
                AutoSize = true
            });

        }
    }
}
