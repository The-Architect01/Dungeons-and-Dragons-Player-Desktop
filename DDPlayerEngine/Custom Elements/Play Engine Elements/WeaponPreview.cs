using System.Windows.Forms;

using PlayerEngine.Data;
using PlayerEngine.Forms.Pop_Ups;

namespace PlayerEngine.Custom_Elements.Play_Engine_Elements {
    public partial class WeaponPreview : UserControl {
        public WeaponPreview(Item Item, Character PC) {
            if (!Item.IsWeapon) { return; }
            InitializeComponent();
            
            if (Item.Type.HasFlag(Item.ItemType.SimpleMeleeWeapon) || Item.Type.HasFlag(Item.ItemType.MartialMeleeWeapon)) 
                ItemType.Text = "⚔️";
            else 
                ItemType.Text = "🏹";

            ItemName.Text = Item.Name;
            ItemNotes.Text = Item.WeaponProperties.ToString();
            
            int AttackModifier = Item.Type.HasFlag(Item.ItemType.SimpleMeleeWeapon) || Item.Type.HasFlag(Item.ItemType.MartialMeleeWeapon) ?
                (PC.Stats[(int)StatName.STR].Modifier + (PC.Proficiencies.Contains(Item) ? Engine.Proficincy(PC.Level) : 0))
                : (PC.Stats[(int)StatName.DEX].Modifier + (PC.Proficiencies.Contains(Item) ? Engine.Proficincy(PC.Level) : 0));
            RollAttack.Text = AttackModifier.ParseAsString();
            RollAttack.Click += delegate { new RollDice(AttackModifier, HitDie.d20, 1).ShowDialog(); };

            RollDamage.Text = $"{Item.DiceForDamage}{Item.DiceToRoll} " +
                $"{(Item.Type.HasFlag(Item.ItemType.SimpleMeleeWeapon) || Item.Type.HasFlag(Item.ItemType.MartialMeleeWeapon) ? PC.Stats[(int)StatName.STR].Modifier.ParseAsString() : PC.Stats[(int)StatName.DEX].Modifier.ParseAsString())} {Item.DamageType}";
            RollDamage.Click += delegate { new RollDice((Item.Type.HasFlag(Item.ItemType.SimpleMeleeWeapon) || Item.Type.HasFlag(Item.ItemType.MartialMeleeWeapon) ? PC.Stats[(int)StatName.STR].Modifier : PC.Stats[(int)StatName.DEX].Modifier), Item.DiceToRoll, Item.DiceForDamage).ShowDialog(); };
        }

        public WeaponPreview(Spell Spell, Character PC) {
            InitializeComponent();

            RollAttack.Dispose();

            if (Spell.NumDice == 0) {
                ItemType.Text = "🔮";
                RollDamage.Dispose();
            } else {
                ItemType.Text = "🪄";
                RollDamage.Text = $"{Spell.NumDice}{Spell.DamageDie} {Spell.DamageType}";
                RollDamage.Click += delegate { new RollDice(defaultdie: Spell.DamageDie, Count: Spell.NumDice).ShowDialog(); };
            }

            ItemName.Text = Spell.Name;
            ItemNotes.Text = $"{Spell.Level} Level, Range: {Spell.Range}";
            
        }
    }
}
