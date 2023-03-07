using System.Collections.Generic;
using System;

namespace PlayerEngine.Data {

    #region General Data Required
    [Serializable]
    public class EngineData {
        /// <summary>
        /// The current version of the application. Default is 1.0.0.0a.
        /// </summary>
        public string Version { get; set; } = "1.0.0.0a";
        /// <summary>
        /// The Image to be displayed as the splash/background.
        /// </summary>
        public string SplashImageURL { get; set; } = "https://images.ctfassets.net/swt2dsco9mfe/3a0LIPmT0YfHDP7xhcUaYS/b1c6ad2606983c4b9374ce4e1602eb46/dnd_vpw_othermedia.jpg";
        /// <summary>
        /// The image encoded in base 64
        /// </summary>
        public string SplashImageBase64 { get; set; } = "";
        /// <summary>
        /// The list of all currently available books for the editor.
        /// </summary>
        public List<Book> Books { get; set; } = new List<Book>();
    }

    /// <summary>
    /// The data wrapper for all data relating to a single book.
    /// </summary>
    [Serializable]
    public class Book {

        /// <summary>
        /// The name of the book.
        /// </summary>
        public string Name { get;set; }
        /// <summary>
        /// The code used to reference the book throughout the code.
        /// </summary>
        public string ReferenceCode { get; set; }
        /// <summary>
        /// Every race introduced in the book.
        /// </summary>
        public List<Lineage> Lineages { get; set; } = new List<Lineage>();
        /// <summary>
        /// Every class introduced in the book.
        /// </summary>
        public List<Class> Classes { get; set; } = new List<Class>();
        /// <summary>
        /// Every background introduced in the book.
        /// </summary>
        public List<Background> Backgrounds { get; set; } = new List<Background>();
        /// <summary>
        /// Every spell introduced in the book.
        /// </summary>
        public List<Spell> Spells { get; set; } = new List<Spell>();
        /// <summary>
        /// Every item introduced int eh book.
        /// </summary>
        public List<Item> Items { get; set; } = new List<Item>();
    }
    #endregion

    #region Character Options
    /// <summary>
    /// The data wrapper for all data relating to a single playable race.
    /// </summary>
    [Serializable]
    public class Lineage {

        /// <summary>
        /// The base race for the current race. For instance a Human or Elf.
        /// </summary>
        public string BaseLineage { get; set; }
        /// <summary>
        /// The sub race for the current race. For instance a sea-elf.
        /// </summary>
        public string SubLineage { get; set; }
        /// <summary>
        /// The source for the image displayed.
        /// </summary>
        public string ResourceSource { get; set; }
        /// <summary>
        /// The base64 representation of the resource.
        /// </summary>
        public string ResourceBase64 { get; set; }

        public string Overview { get; set; }
        public string Creator { get; set; }
        /// <summary>
        /// All of the stat modifiers used by the race.
        /// </summary>
        public StatModifier[] StatModifiers { get; set; } = new StatModifier[] { new StatModifier() { Stat = StatName.STR, Modifier = 0 }, new StatModifier() { Stat = StatName.DEX, Modifier = 0 }, new StatModifier() { Stat = StatName.CON, Modifier = 0 }, new StatModifier() { Stat = StatName.WIS, Modifier = 0 }, new StatModifier() { Stat = StatName.INT, Modifier = 0 }, new StatModifier() { Stat = StatName.CHA, Modifier = 0 } };
        /// <summary>
        /// How fast the race on average is.
        /// </summary>
        public int Speed { get; set; } = 30;
        /// <summary>
        /// How fast the race on average is.
        /// </summary>
        public int SwimmingSpeed { get; set; } = 0;
        /// <summary>
        /// How fast the race on average is.
        /// </summary>
        public int FlyingSpeed { get; set; } = 0;
        /// <summary>
        /// How large the race on average is.
        /// </summary>
        public Size Size { get; set; } = Size.Medium;
        /// <summary>
        /// What languages the race implicitly know based on how they are raised.
        /// </summary>
        public string[] Languages { get; set; }
        /// <summary>
        /// What weapons or tools the race implicitly know based on how they are raised.
        /// </summary>
        public string[] Proficincy { get; set; }
        /// <summary>
        /// What traits the race has.
        /// </summary>
        public List<LineageTrait> RacialTraits { get; set; } = new List<LineageTrait>();

        /// <summary>
        /// Retrives the specified data.
        /// </summary>
        /// <param name="data">The data to retrieve</param>
        /// <returns></returns>
        public string FindData(string data) {
            return data;
        }

    }

    /// <summary>
    /// The data wrapper for all data relating to a single playable class.
    /// </summary>
    [Serializable]
    public class Class {

        /// <summary>
        /// The base class of the current class. Examples are Cleric or Rogue.
        /// </summary>
        public string BaseClass { get; set; }
        /// <summary>
        /// The sub class or specialization of the base class. Examples are Cleric (War) or Rogue (Thief).
        /// </summary>
        public string SubClass { get; set; }
        /// <summary>
        /// The url of the image displayed to represent the class.
        /// </summary>
        public string ResourceURL { get; set; }
        /// <summary>
        /// The base64 representation of the resource.
        /// </summary>
        public string ResourceBase64 { get; set; }
        public string Overview { get; set; }
        public string Creator { get; set; }
        /// <summary>
        /// Represents if the class can cast up to level 9 spells.
        /// </summary>
        public bool IsFullCaster { get; set; }
        /// <summary>
        /// Represents if the class can cast up to level 5 spells.
        /// </summary>
        public bool IsHalfCaster { get; set; }
        /// <summary>
        /// The ability the class uses when they cast spells. Note: Only used when IsFullCaster || IsHalfCaster.
        /// </summary>
        public StatName CastingAbility { get; set; }

        /// <summary>
        /// What die is used to determine hit points for the class.
        /// </summary>
        public HitDie HitDie { get; set; }
        /// <summary>
        /// What proficienies the class knows because of training.
        /// </summary>
        public string[] Proficiencies { get; set; }
        /// <summary>
        /// The choices the player will have on what equipment to choose from.
        /// </summary>
        public List<EquipmentOptions> EquipmentOptions { get; set; }
        /// <summary>
        /// What abilities the class gains over time.
        /// </summary>
        public List<ClassAbility> Abilities { get; set; }

        /// <summary>
        /// Retrives the specified data.
        /// </summary>
        /// <param name="data">The data to retrieve</param>
        /// <returns></returns>
        public string FindData(string data) {
            return data;
        }
    }

    /// <summary>
    /// The data wrapper for all data relating to a single playable background.
    /// </summary>
    [Serializable]
    public class Background {

        /// <summary>
        /// The name of the background.
        /// </summary>
        public string Name { get; set; }
        public string Overview { get; set; }
        public string Creator { get; set; }
        /// <summary>
        /// The background's feature.
        /// </summary>
        public Feature Feature { get; set; }
        /// <summary>
        /// The languages known to the background.
        /// </summary>
        public string[] Languages { get; set; }
        /// <summary>
        /// The skills known to the background.
        /// </summary>
        public string[] Skills { get; set; }
        /// <summary>
        /// The tools known to the background.
        /// </summary>
        public string[] Tools { get; set; }
        /// <summary>
        /// The items that the background start with.
        /// </summary>
        public string[] Items { get; set; }

        /// <summary>
        /// The personality traits typical of the background.
        /// </summary>
        public string[] Personality { get; set; }
        /// <summary>
        /// The ideal traits typical of the background.
        /// </summary>
        public string[] Ideals { get; set; }
        /// <summary>
        /// The bond traits typical of the background.
        /// </summary>
        public string[] Bonds { get; set; }
        /// <summary>
        /// The flaws typical of the background.
        /// </summary>
        public string[] Flaws { get; set; }

        /// <summary>
        /// Retrives the specified data.
        /// </summary>
        /// <param name="Data">The data to retrieve</param>
        /// <returns></returns>
        public string FindData(string Data) {
            return Data == Feature.Name ? Feature.Description : "";
        }
        
    }
    #endregion

    #region Character Data
    /// <summary>
    /// All of the data relating to a player
    /// </summary>
    [Serializable]
    public class Character {
        //General Data
        /// <summary>
        /// The level of the character
        /// </summary>
        public int Level { get; set; } = 1;
        /// <summary>
        /// The name of the character
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The race used to create the character
        /// </summary>
        public Lineage Lineage { get; set; }
        /// <summary>
        /// The class used to create the character
        /// </summary>
        public List<Class> Class { get; set; } = new List<Class>();
        /// <summary>
        /// The background used to create the character
        /// </summary>
        public Background Background { get; set; }

        //Hit Point Data
        /// <summary>
        /// The current hit points of the character
        /// </summary>
        public int CurrentHitPoints { get; set; }
        /// <summary>
        /// The maximum number of hit points of the character
        /// </summary>
        public int MaxHitPoints { get; set; } = 1;
        /// <summary>
        /// The amount of temporary hit points of the character
        /// </summary>
        public int TemporaryHitPoints { get; set; }

        //Battle Data
        /// <summary>
        /// The armor class of the character
        /// </summary>
        public int ArmorClass { get; set; }
        /// <summary>
        /// Does the character have inspiration
        /// </summary>
        public bool HasInspriation { get; set; }

        //Proficincy
        /// <summary>
        /// The skills that the character has
        /// </summary>
        public Skill[] Skills { get; set; } = new Skill[18];
        /// <summary>
        /// The items that the character has
        /// </summary>
        public List<Item> Items { get; set; } = new List<Item>();
        /// <summary>
        /// The inventory of the player
        /// </summary>
        public List<Item> Inventory { get; set; } = new List<Item>();
        /// <summary>
        /// The spells known by the player
        /// </summary>
        public List<Spell> SpellsKnown { get; set; } = new List<Spell>();

        //Characteristics
        /// <summary>
        /// The pronouns the character uses
        /// </summary>
        public string Pronouns;
        /// <summary>
        /// The alignment of the character
        /// </summary>
        public Alignment Alignment;
        /// <summary>
        /// The gender identity of the character
        /// </summary>
        public string Gender;
        /// <summary>
        /// The eye color of the character
        /// </summary>
        public string EyeColor;
        /// <summary>
        /// The height of the character
        /// </summary>
        public int Height;
        /// <summary>
        /// The faith of the character
        /// </summary>
        public string Faith;
        /// <summary>
        /// The hair color of the character
        /// </summary>
        public string HairColor;
        /// <summary>
        /// The skin color of the character
        /// </summary>
        public string SkinColor;
        /// <summary>
        /// The current age of the character
        /// </summary>
        public int Age;
        /// <summary>
        /// The weight of the character
        /// </summary>
        public float Weight;

        //Extra Notes
        /// <summary>
        /// The organizations the character is a part of
        /// </summary>
        public List<string> Organizations;
        /// <summary>
        /// The allies the character has
        /// </summary>
        public List<string> Allies;
        /// <summary>
        /// The enemies the character has
        /// </summary>
        public List<string> Enemies;
        /// <summary>
        /// The backstory of the character
        /// </summary>
        public string Backstory;
        /// <summary>
        /// Any extra notes
        /// </summary>
        public string Notes;
        
        //Engine Metadata
        /// <summary>
        /// The creator's name
        /// </summary>
        public string CreatorName;
        /// <summary>
        /// The date the character was created
        /// </summary>
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// The date the character was last modified
        /// </summary>
        public DateTime LastUpdated { get; set; }

        ///<summary>
        ///The abilities of the character
        /// </summary>
        public Ability[] Stats { get; set; }
    }

    /// <summary>
    /// An enum representing character alignments
    /// </summary>
    [Serializable]
    public enum Alignment { 
        /// <summary>
        /// Creatures act as their conscience directs with little regard to what others expect
        /// </summary>
        Chaotic_Good, 
        /// <summary>
        /// Creatures try to do their best to help others according to their needs
        /// </summary>
        Neutral_Good, 
        /// <summary>
        /// Creatures that can be counted on to do the right thing as expected by society
        /// </summary>
        Lawful_Good, 
        /// <summary>
        /// Creatures follow their wims, holding their personal freedom highest
        /// </summary>
        Chaotic_Neutral, 
        /// <summary>
        /// Moral questions? Nah.
        /// </summary>
        Neutral, 
        /// <summary>
        /// Creatures act in accordance with law, tradition, or personal codes
        /// </summary>
        Lawful_Neutral, 
        /// <summary>
        /// Creatures act with arbitrary violence
        /// </summary>
        Chaotic_Evil, 
        /// <summary>
        /// Creatures who do whatever they can get away with, without compassion or qualms
        /// </summary>
        Neutral_Evil, 
        /// <summary>
        /// Creatures methodically take what they want, within the limits of a code or tradition
        /// </summary>
        Lawful_Evil
    }

    /// <summary>
    /// All data relating to a single skill
    /// </summary>
    [Serializable]
    public class Skill : IData {
        /// <summary>
        /// The name of the skill
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The bonus for the skill
        /// </summary>
        public int Bonus { get; set; }
        /// <summary>
        /// The base stat of the skill
        /// </summary>
        public StatName BaseStat { get; set; }
        /// <summary>
        /// Does the character have half proficincy
        /// </summary>
        public bool HasHalfProficincy { get;set; }
        /// <summary>
        /// Does the character have proficincy
        /// </summary>
        public bool HasProficincy { get; set; }
        /// <summary>
        /// Does the character have double proficincy
        /// </summary>
        public bool HasExpertise { get; set; }

        public string Description { get; set; }
    }

    /// <summary>
    /// All data relating to a single spell
    /// </summary>
    [Serializable]
    public class Spell : IData {
        /// <summary>
        /// The name of the spell
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The school of magic the spell has
        /// </summary>
        public School SchoolOfMagic { get; set; }
        /// <summary>
        /// The level of the spell
        /// </summary>
        public int Level { get; set; }
        /// <summary>
        /// The casting time of the spell
        /// </summary>
        public string CastingTime { get; set; }
        /// <summary>
        /// The range of the spell
        /// </summary>
        public string Range { get; set; }
        /// <summary>
        /// The duration of the spell
        /// </summary>
        public string Duration { get; set; }
        /// <summary>
        /// Is the spell a ritual
        /// </summary>
        public bool IsRitual { get; set; }
        /// <summary>
        /// Does the spell require concentration
        /// </summary>
        public bool RequiresConcentration { get; set; }
        /// <summary>
        /// The spell action requirements
        /// </summary>
        public Components SpellActions { get; set; }
        /// <summary>
        /// The components required to cast the spell
        /// </summary>
        public string[] Components { get; set; }
        /// <summary>
        /// The area of effect of the spell
        /// </summary>
        public string AOE { get; set; }
        /// <summary>
        /// The save dc required for the spell
        /// </summary>
        public int SaveDC { get; set; }
        /// <summary>
        /// The description of the spell
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// An enum representing schools of magic
        /// </summary>
        public enum School {
            /// <summary>
            /// A school of magic that typically protects
            /// </summary>
            Abjuration,
            /// <summary>
            /// A school of magic that typically involves transportation
            /// </summary>
            Conjuration,
            /// <summary>
            /// A school of magic that typically reveal information
            /// </summary>
            Divination,
            /// <summary>
            /// A school of magic that typically affect minds
            /// </summary>
            Enchantment,
            /// <summary>
            /// A school of magic that typically modify magical energy
            /// </summary>
            Evocation,
            /// <summary>
            /// A school of magic used to decieve
            /// </summary>
            Illusion,
            /// <summary>
            /// A school of magic that typically is used to manipulate life
            /// </summary>
            Necromancy,
            /// <summary>
            /// A school of magic that change properties of things
            /// </summary>
            Transmutation
        }
    }
    #endregion

    #region Data wrappers for specific data

    /// <summary>
    /// The component elements of a spell
    /// </summary>
    [Serializable]
    public enum Components { 
        /// <summary>
        /// The spell requires some kind of verbal component
        /// </summary>
        Verbal = 1<<0,
        /// <summary>
        /// The spell requires specific gestures (REQUIRES at least one hand to perform gesture)
        /// </summary>
        Somatic = 1 << 1,
        /// <summary>
        /// The spell requires specific objects
        /// </summary>
        Material = 1 << 2,
    }


    /// <summary>
    /// The data wrapper for a single ability.
    /// </summary>
    [Serializable]
    public class Ability : IData {
        /// <summary>
        /// The name of the ability score.
        /// </summary>
        public StatName Name { get; set; }
        /// <summary>
        /// The score of the ability.
        /// </summary>
        public int Score { get; set; }
        /// <summary>
        /// The modifier granted to the roll based on score.
        /// </summary>
        public int Modifier { get { return (int)Math.Floor((Score - 10) / 2f); } }

        public string Description { get; set; }
        string IData.Name { get { return Name.ToString(); } set { } }
    }

    /// <summary>
    /// An enum representing each different core ability score.
    /// </summary>
    [Serializable]
    public enum StatName {
        /// <summary>
        /// Strength (Can I smash a tomato)
        /// </summary>
        STR,
        /// <summary>
        /// Dextarity (Can I leap over a tomato)
        /// </summary>
        DEX,
        /// <summary>
        /// Constitution (Can I eat a bad tomato)
        /// </summary>
        CON,
        /// <summary>
        /// Wisdom (Do I know that a tomato is a fruit)
        /// </summary>
        WIS,
        /// <summary>
        /// Intelligence (Do I know that a tomato should not be in a fruit salad)
        /// </summary>
        INT,
        /// <summary>
        /// Charisma (Can I sell a tomato based fruit salad)
        /// </summary>
        CHA,
        /// <summary>
        /// Speed (How fast can I move)
        /// </summary>
        SPD,
        /// <summary>
        /// Proficiency Bonus (how good I am at things)
        /// </summary>
        PRO,
        /// <summary>
        /// Armor Class (How often can I dodge the hit)
        /// </summary>
        ARC,
    }

    /// <summary>
    /// An enum representing size.
    /// </summary>
    [Serializable]
    public enum Size {
        /// <summary>
        /// You are tiny! (~1/4 the size of a Medium Creature [~18"])
        /// </summary>
        Tiny,
        /// <summary>
        /// You are small! (~1/2 the size of a Medium Creature [~36"])
        /// </summary>
        Small,
        /// <summary>
        /// You are medium! (About the size of an adult human [~60"-72"])
        /// </summary>
        Medium,
        /// <summary>
        /// You are large! (~2* the size of a Medium Creature [~144"])
        /// </summary>
        Large,
        /// <summary>
        /// You are huge! (~4* the size of a Medium Creature [~288"])
        /// </summary>
        Huge,
        /// <summary>
        /// You are gargantuan! (~8* the size of a Medium Creature [~576"])
        /// </summary>
        Gargantuan
    }

    /// <summary>
    /// The data wrapper for a single trait granted by a race.
    /// </summary>
    [Serializable]
    public class LineageTrait : IData {
        /// <summary>
        /// The trait's name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The in depth description of the trait.
        /// </summary>
        public string Description { get; set; }
    }

    /// <summary>
    /// The data wrapper for a single trait granted by a class.
    /// </summary>
    [Serializable]
    public class ClassAbility : IData {
        /// <summary>
        /// The name of the trait.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The in depth description of the trait.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The level the trait unlock at.
        /// </summary>
        public int LevelUnlocked { get; set; }
    }

    /// <summary>
    /// The equipment options to choose from.
    /// </summary>
    [Serializable]
    public class EquipmentOptions {
        /// <summary>
        /// The options available for a single choice.
        /// </summary>
        public string[] Options { get; set; }
    }

    /// <summary>
    /// An enum representing hit die.
    /// </summary>
    [Serializable]
    public enum HitDie {
        /// <summary>
        /// A d4
        /// </summary>
        d4,
        /// <summary>
        /// A d6
        /// </summary>
        d6,
        /// <summary>
        /// A d8
        /// </summary>
        d8,
        /// <summary>
        /// A d10
        /// </summary>
        d10,
        /// <summary>
        /// A d12
        /// </summary>
        d12
    }

    /// <summary>
    /// The data wrapper for a single stat modifier.
    /// </summary>
    [Serializable]
    public class StatModifier {
        /// <summary>
        /// What stat is being modified.
        /// </summary>
        public StatName Stat { get; set; }
        /// <summary>
        /// How much the stat is being modified.
        /// </summary>
        public int Modifier { get; set; }
    }

    /// <summary>
    /// The data wrapper for a single Item.
    /// </summary>
    [Serializable]
    public class Item : IData {
        /// <summary>
        /// The Item's name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The type of item
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Is the item equipped
        /// </summary>
        public bool Equipped { get; set; }
        /// <summary>
        /// Does the item require attunment
        /// </summary>
        public bool AttunmentRequired { get; set; }
        /// <summary>
        /// The cost of the item
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// How many dice are rolled
        /// </summary>
        public int DiceForDamage { get; set; }
        /// <summary>
        /// What size of dice to use
        /// </summary>
        public HitDie DiceToRoll { get; set; }
        /// <summary>
        /// How much the item weighs
        /// </summary>
        public decimal Weight { get; set; }
        /// <summary>
        /// The properties of the item
        /// </summary>
        public string[] Properties { get; set; }
        /// <summary>
        /// The stat modifications coming from the item
        /// </summary>
        public StatModifier Modifier { get; set; }
        /// <summary>
        /// The description of the item
        /// </summary>
        public string Description { get; set; }
    }

    /// <summary>
    /// The data contained for a single language
    /// </summary>
    [Serializable]
    public class Languages : IData {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    /// <summary>
    /// A data wrapper for features
    /// </summary>
    [Serializable]
    public class Feature : IData {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    /// <summary>
    /// A required data field for most elements
    /// </summary>
    public interface IData {
        /// <summary>
        /// The name of the data field
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// The description of the data field
        /// </summary>
        string Description { get; set; }
    }

    #endregion

}