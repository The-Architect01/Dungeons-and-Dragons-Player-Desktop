using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using PlayerEngine.Data;

namespace PlayerEngine.Custom_Elements.Play_Engine_Elements {
    public partial class ActionMenu : UserControl {
        public ActionMenu(Character PC) {
            InitializeComponent();

            foreach (var item in PC.Inventory.Where(item => item.IsWeapon))
                Attacks.Controls.Add(new WeaponPreview(item, PC));

            Spells.Visible = PC.IsMagicUser;
            SpellSummary.Text = $"Spell Ability: {PC.Class[0].CastingAbility}, Spell Attack Bonus: {PC.SpellBonus.ParseAsString()}, Save DC: {PC.SpellDC}";
            foreach (var item in PC.SpellsKnown)
                Spells.Controls.Add(new WeaponPreview(item, PC));


            ITrait[] ITraits = null;
            try {
                ITraits = PC.Lineage.LineageTraits.AsQueryable<ITrait>().Union(PC.Class[0].Abilities.AsQueryable<ITrait>()).ToArray();
            } catch {
                ITraits = PC.Class[0].Abilities.AsQueryable<ITrait>().ToArray();
            }

            foreach (ITrait trait in ITraits) {
                switch (trait.Type) {
                    case ITrait.TraitType.Action:
                    case ITrait.TraitType.BonusAction:
                        Extras.Controls.Add(new Label() {
                            Text = trait.Name,
                        });
                        break;
                    case ITrait.TraitType.Weapon:
                        Attacks.Controls.Add(new WeaponPreview((Item)trait.TraitData, PC));
                        break;
                    case ITrait.TraitType.Spell:
                        Spells.Controls.Add(new WeaponPreview((Spell)trait.TraitData, PC));
                        break;

                }
            }

            Dock = DockStyle.Fill;
        }
    }
}
