using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PlayerEngine.Data;

namespace PlayerEngine.Custom_Elements.Play_Engine_Elements {
    public partial class ActionMenu : UserControl {
        public ActionMenu(Character PC) {
            InitializeComponent();

            PC.Inventory.Add(new Item() {
                Name = "Dagger",
                DiceForDamage = 1,
                DiceToRoll = HitDie.d4,
                Price = 2,
                DamageType = DamageType.Slashing,
                Equipped = true,
                Type = Item.ItemType.SimpleMeleeWeapon,
                WeaponProperties = Item.WeaponProps.Finesse | Item.WeaponProps.Light | Item.WeaponProps.Thrown,
                Weight = 1
            });
            PC.Inventory.Add(new Item() {
                Name = "Dagger",
                DiceForDamage = 1,
                DiceToRoll = HitDie.d4,
                Price = 2,
                DamageType = DamageType.Slashing,
                Equipped = true,
                Type = Item.ItemType.SimpleMeleeWeapon,
                WeaponProperties = Item.WeaponProps.Finesse | Item.WeaponProps.Light | Item.WeaponProps.Thrown,
                Weight = 1
            });
            PC.Inventory.Add(new Item() {
                Name = "Dagger",
                DiceForDamage = 1,
                DiceToRoll = HitDie.d4,
                Price = 2,
                DamageType = DamageType.Slashing,
                Equipped = true,
                Type = Item.ItemType.SimpleMeleeWeapon,
                WeaponProperties = Item.WeaponProps.Finesse | Item.WeaponProps.Light | Item.WeaponProps.Thrown,
                Weight = 1
            });
            PC.Inventory.Add(new Item() {
                Name = "Dagger",
                DiceForDamage = 1,
                DiceToRoll = HitDie.d4,
                Price = 2,
                DamageType = DamageType.Slashing,
                Equipped = true,
                Type = Item.ItemType.SimpleMeleeWeapon,
                WeaponProperties = Item.WeaponProps.Finesse | Item.WeaponProps.Light | Item.WeaponProps.Thrown,
                Weight = 1
            });
            PC.Inventory.Add(new Item() {
                Name = "Dagger",
                DiceForDamage = 1,
                DiceToRoll = HitDie.d4,
                Price = 2,
                DamageType = DamageType.Slashing,
                Equipped = true,
                Type = Item.ItemType.MartialRangeWeapon,
                WeaponProperties = Item.WeaponProps.Finesse | Item.WeaponProps.Light | Item.WeaponProps.Thrown,
                Weight = 1
            });

            foreach (var item in PC.Inventory.Where(item => item.IsWeapon))
                Attacks.Controls.Add(new WeaponPreview(item, PC));

            PC.SpellsKnown.Add(new Spell() {
                Name = "Dissonant Whispers",
                SchoolOfMagic = Spell.School.Enchantment,
                Level = Spell.SpellLevel.First,
                CastingTime = "1 Action",
                Range = "60 ft",
                Duration = "Instanaeous",
                IsRitual = false,
                RequiresConcentration = false,
                SpellActions = Spell.SpellComponents.Verbal,
                NumDice = 3,
                DamageDie = HitDie.d6,
                DamageType = DamageType.Psychic
            });
            PC.SpellsKnown.Add(new Spell() {
                Name = "Mage Hand",
                SchoolOfMagic = Spell.School.Conjuration,
                Level = Spell.SpellLevel.Cantrip,
                CastingTime = "1 Action",
                Range = "30 ft",
                Duration = "1 minute",
                IsRitual = false,
                RequiresConcentration = false,
                SpellActions = Spell.SpellComponents.Verbal | Spell.SpellComponents.Somatic,
            });
            PC.SpellsKnown.Add(new Spell() {
                Name = "Mage Hand",
                SchoolOfMagic = Spell.School.Conjuration,
                Level = Spell.SpellLevel.Cantrip,
                CastingTime = "1 Action",
                Range = "30 ft",
                Duration = "1 minute",
                IsRitual = false,
                RequiresConcentration = false,
                SpellActions = Spell.SpellComponents.Verbal | Spell.SpellComponents.Somatic,
            });
            PC.SpellsKnown.Add(new Spell() {
                Name = "Mage Hand",
                SchoolOfMagic = Spell.School.Conjuration,
                Level = Spell.SpellLevel.Cantrip,
                CastingTime = "1 Action",
                Range = "30 ft",
                Duration = "1 minute",
                IsRitual = false,
                RequiresConcentration = false,
                SpellActions = Spell.SpellComponents.Verbal | Spell.SpellComponents.Somatic,
            });

            Spells.Visible = PC.IsMagicUser;
            SpellSummary.Text = $"Spell Ability: {PC.Class[0].CastingAbility}, Spell Attack Bonus: {PC.SpellBonus.ParseAsString()}, Save DC: {PC.SpellDC}";
            foreach (var item in PC.SpellsKnown)
                Spells.Controls.Add(new WeaponPreview(item, PC));


            PC.Lineage.LineageTraits = new List<LineageTrait>() {
                new LineageTrait() {
                    Name = "",
                    Description = "",
                    TraitData = new Spell() {
                        Name = "Testing123",
                SchoolOfMagic = Spell.School.Conjuration,
                Level = Spell.SpellLevel.Cantrip,
                CastingTime = "1 Action",
                Range = "30 ft",
                Duration = "1 minute",
                IsRitual = false,
                RequiresConcentration = false,
                SpellActions = Spell.SpellComponents.Verbal | Spell.SpellComponents.Somatic,
                    },
                    Type = ITrait.TraitType.Spell
                },
            };


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
