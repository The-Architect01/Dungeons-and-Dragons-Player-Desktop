using System;
using System.Collections.Generic;
using System.Linq;

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

        public string[] LANGUAGES { get; set; } = new string[] {
            "Common", "Dwarvish", "Elvish", "Giant", "Gnomish",
            "Goblin", "Halfling", "Orc", "Abyssal", "Celestial",
            "Deep Speech", "Draconic", "Infernal", "Primordial",
            "Sylvan", "Undercommon"
        };
        public string[] SKILLS { get; set; } = new string[] {
            "Athletics", "Acrobatics", "Sleight of Hand",
            "Stealth", "Arcana", "History", "Investigation",
            "Nature", "Religion", "Animal Handling", "Insight",
            "Medicine", "Perception", "Survival", "Intimidation",
            "Performance", "Persuasion"
        };
        public string[] TOOLS { get; set; } = new string[] {
            "Alchemist’s supplies", "Brewer’s supplies", "Calligrapher's Supplies", "Carpenter’s tools", "Cartographer’s tools",
            "Cobbler’s tools", "Cook’s utensils", "Glassblower’s tools",
            "Jeweler’s tools", "Leatherworker’s tools", "Mason’s tools",
            "Painter’s supplies", "Potter’s tools", "Smith’s tools",
            "Tinker’s tools", "Weaver’s tools", "Woodcarver’s tools",
            "Dice set", "Playing card set", "Bagpipes", "Drum", "Dulcimer",
            "Flute", "Lute", "Lyre", "Horn", "Pan flute", "Shawm", "Viol",
            "Navigator’s tools", "Thieves’ tools", "Land Vehicles", "Water Vehicles"
        };
        public string[] SIMPLE_WEAPONS { get; set; } = new string[] {
            "Club", "Dagger", "Greatclub", "Handaxe", "Javelin",
            "Light Hammer", "Mace", "Quarterstaff", "Sickle",
            "Spear", "Light Crossbow", "Dart", "Shortbow", "Sling"
        };
        public string[] MARTIAL_WEAPONS { get; set; } = new string[] {
            "Battleaxe", "Flail", "Glaive", "Greataxe", "Greatsword",
            "Halberd", "Lance", "Longsword", "Maul", "Morningstar",
            "Pike", "Rapier", "Scimitar", "Shortsword", "Trident",
            "War pick", "Warhammer", "Whip", "Blowgun", "Heavy Crossbow",
            "Hand Crossbow", "Longbow", "Net"
        };
        public string[] INSTRUMENTS { get; set; } = new string[] {
            "Bagpipes", "Drum", "Dulcimer", "Flute", "Lute", "Lyre",
            "Horn", "Pan flute", "Shawm", "Viol"
        };
        public string[] ARTISAN_TOOLS { get; set; } = new string[] {
            "Alchemist’s supplies", "Brewer’s supplies",
            "Calligrapher's Supplies", "Carpenter’s tools",
            "Cartographer’s tools", "Cobbler’s tools", "Cook’s utensils",
            "Glassblower’s tools", "Jeweler’s tools",
            "Leatherworker’s tools", "Mason’s tools", "Painter’s supplies",
            "Potter’s tools", "Smith’s tools", "Tinker’s tools",
            "Weaver’s tools", "Woodcarver’s tools"
        };
        public string[] MELEE_WEAPONS { get; set; } = new string[] {
            "Club", "Dagger", "Greatclub", "Handaxe", "Javelin",
            "Light Hammer", "Mace", "Quarterstaff", "Sickle", "Spear",
            "Battleaxe", "Flail", "Glaive", "Greataxe", "Greatsword",
            "Halberd", "Lance", "Longsword", "Maul", "Morningstar",
            "Pike", "Rapier", "Scimitar", "Shortsword", "Trident",
            "War pick", "Warhammer", "Whip"
        };
        public string[] RANGE_WEAPONS { get; set; } = new string[] {
            "Light Crossbow", "Dart", "Shortbow", "Sling", "Blowgun",
            "Heavy Crossbow", "Hand Crossbow", "Longbow", "Net"
        };
        public string[] ARMORS { get; } = new string[] {
            "Light", "Medium", "Heavy", "Shields"
        };

    }

    [Serializable]
    public class Homebrew : Book {
        public string Creator { get; set; }

    }

    /// <summary>
    /// The data wrapper for all data relating to a single book.
    /// </summary>
    [Serializable]
    public class Book {

        /// <summary>
        /// The name of the book.
        /// </summary>
        public string Name { get; set; }

        public string Description { get; set; }
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
        public List<LineageTrait> LineageTraits { get; set; } = new List<LineageTrait>();
        public int Darkvision { get; set; }
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
        public string ResourceSource { get; set; }
        public string Creator { get; set; }
        public int Level { get; set; } = 1;
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
            foreach (ClassAbility CA in Abilities)
                if (CA.Name == data) return CA.Description;
            return string.Empty;
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
        public int Level {
            get {
                int lv = 0;
                foreach (Class c in this.Class) lv += c.Level;
                return lv;
            }
        }
        public string Illustration { get; set; }
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
        public bool IsMagicUser {
            get {
                foreach (Class c in this.Class) if (!c.IsFullCaster && !c.IsHalfCaster) return false;
                return true;
            }
        }

        public int SpellBonus {
            get {
                return Engine.Proficincy(Level) + Stats[(int)Class[0].CastingAbility].Modifier;
            }
        }

        public int SpellDC {
            get {
                return 8 + Engine.Proficincy(Level) + Stats[(int)Class[0].CastingAbility].Modifier;
            }
        }

        /// <summary>
        /// The background used to create the character
        /// </summary>
        public Background Background { get; set; }
        public List<string> BackgroundPersonalites { get; set; } = new List<string>();
        public List<string> BackgroundIdeals { get; set; } = new List<string>();
        public List<string> BackgroundBonds { get; set; } = new List<string>();
        public List<string> BackgroundFlaws { get; set; } = new List<string>();


        //Hit Point Data
        /// <summary>
        /// The current hit points of the character
        /// </summary>
        public int CurrentHitPoints { get; set; }
        /// <summary>
        /// The maximum number of hit points of the character
        /// </summary>
        public int MaxHitPoints {
            get {
                int hp = 0;
                foreach (Class c in Class) {
                    for (int i = 1; i <= c.Level; i++) {
                        if (i != 1) hp += (c.HitDie.ParseHitDie() + 1) / 2; else hp += c.HitDie.ParseHitDie();
                    }
                }
                return hp;
            }
        }
        /// <summary>
        /// The amount of temporary hit points of the character
        /// </summary>
        public int TemporaryHitPoints { get; set; }

        //Battle Data
        /// <summary>
        /// The armor class of the character
        /// </summary>
        public int ArmorClass { get; set; } = 12;

        /// <summary>
        /// The initiative bonus of the character
        /// </summary>
        public int Initiative {
            get {
                return Stats[1].Modifier + (Feats.Where(feat => feat.Name == "Alert").Count() != 0 ? 5 : 0);
            }
        }
        /// <summary>
        /// Does the character have inspiration
        /// </summary>
        public bool HasInspriation { get; set; }

        //Proficincy
        /// <summary>
        /// The skills that the character has
        /// </summary>
        public Skill[] Skills { get; set; } = new Skill[] {
            new Skill() { BaseStat = StatName.DEX, Name = "Acrobatics", Description = "This skill measures how well you can stay on your feet in a tricky situtation, such as when you are running across ice, balance, or stay upright. It also covers acrobatic stunts such as dives, rolls, flips, etc." },
            new Skill() { BaseStat = StatName.WIS, Name = "Animal Handling", Description = "This stat measures how well you can calm down or find the intentions of wild animals, mounts, or domesticated animals." },
            new Skill() { BaseStat = StatName.INT, Name = "Arcana", Description = "This stat measures how well you can recall lore about spells, magic items, eldritch symbols, magical traditions, the planes of existence, and the inhabitants of those planes." },
            new Skill() { BaseStat = StatName.STR, Name = "Athletics", Description = "This stat measures how well you can overcome challengs like climbing, jumping, or swimming." },
            new Skill() { BaseStat = StatName.CHA, Name = "Deception", Description = "This stat measures how well you can convincingly hide the truth, either verbally or through your actions. This can encompass everything from misleading others through ambiguity to telling outright lies. This includes fast-talking a guard or con a merchant." },
            new Skill() { BaseStat = StatName.INT, Name = "History", Description = "This stat measures your ability to recall lore about historical events, legendary people, ancient kingdoms, past disputes, recent wars, or lost civilizations." },
            new Skill() { BaseStat = StatName.WIS, Name = "Insight", Description = "This stat measures how well you can determine the true intentions of a creature, such as when searching out a lie or predicting someone's next move. Doing so involves gleaning clues from body langauge, speech habits, and changes in mannerisms." },
            new Skill() { BaseStat = StatName.CHA, Name = "Intimidation", Description = "This stat measures how well you can influence someone through overt threats, hostile actions, and physical violence. This can include prying information out of a prisoner, convincing street thugs to back down, etc." },
            new Skill() { BaseStat = StatName.INT, Name = "Investigation", Description = "This stat measures how well you can look for clues and make deductions based on those clues. You might deduce the location of a hidden object, discern from the appearance of a wound what kind of weapon dealt it, etc." },
            new Skill() { BaseStat = StatName.WIS, Name = "Medicine", Description = "This stat measures how well you can try to stabilize a dying companion or diagnose an illness." },
            new Skill() { BaseStat = StatName.INT, Name = "Nature", Description = "This stat measures your ability to recall lore about terrain, plants and animals, the weather, or natural cycles." },
            new Skill() { BaseStat = StatName.WIS, Name = "Perception", Description = "This stat measures your ability to spot, hear, or otherwise detect the presence of something. It measures your general awareness of your surroundings and the keeness of your senses." },
            new Skill() { BaseStat = StatName.CHA, Name = "Performance", Description = "This stat measures your ability to determine how wel you can delight an audience with music, dance, acting, storytelling, or some other form of entertainment." },
            new Skill() { BaseStat = StatName.CHA, Name = "Persuasion", Description = "This stat measures your ability to influence someone or a group of people with tact, social graces, or good nature. Such as convincing a chamberlain to let your party see the king, negotiating peace, etc." },
            new Skill() { BaseStat = StatName.INT, Name = "Religion", Description = "This stat measures your ability to recall lore about dieties, rites and prayers, religious hierarchies, holy symbols, and the practices of secret cults." },
            new Skill() { BaseStat = StatName.DEX, Name = "Sleight of Hand", Description = "This stat measures your ability to successfully pull off manual trickery, such as planting something on someone else or concealing an object on your person." },
            new Skill() { BaseStat = StatName.DEX, Name = "Stealth", Description = "This stat measures your ability to conceal yourself from enemies, slink past guards, slip away without being noticed, or sneak up on someone without being seen or heard." },
            new Skill() { BaseStat = StatName.WIS, Name = "Survival", Description = "This stat measures your ability to follow tracks, hunt wild game, guide your group through frozen wastelands, predict the weather, or avoid natural hazards." }
        };
        public string GetData(string DataLookUp) {
            Skill s = Skills.First(skill => skill.Name == DataLookUp);
            return $"Name: {s.Name}\nSkill Type: {s.BaseStat}\nDescription: {s.Description}";
        }
        /*/// <summary>
        /// The items that the character has
        /// </summary>
        public List<Item> Items { get; set; } = new List<Item>();*/
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
        public Alignment Alignment = Alignment.Unaligned;
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
        /// The abilities of the character
        /// </summary>
        public Ability[] Stats { get; set; } = {
            new Ability() {
                        Name = StatName.STR,
                        Description = "Can I smash a tomato",
                    },
                    new Ability() {
                        Name = StatName.DEX,
                        Description = "Can I leap over a tomato",
                    },
                    new Ability() {
                        Name = StatName.CON,
                        Description = "Can I eat a bad tomato",
                    },
                    new Ability() {
                        Name = StatName.WIS,
                        Description = "Do I know that a tomato is a fruit",
                    },
                    new Ability() {
                        Name = StatName.INT,
                        Description = "Do I know that a tomato should not be in a fruit salad",
                    },
                    new Ability() {
                        Name = StatName.CHA,
                        Description = "Can I sell a tomato based fruit salad",
                    }
        };

        /// <summary>
        /// The feats that the character has
        /// </summary>
        public List<Feat> Feats { get; set; } = new List<Feat>();

        /// <summary>
        /// The languages that the character speaks
        /// </summary>
        public List<Language> Languages { get; set; } = new List<Language>() { Language.Common };

        public List<IData> Proficiencies { get; set; } = new List<IData>();
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
        Lawful_Evil,
        Unaligned
    }

    /// <summary>
    /// All data relating to a single skill
    /// </summary>
    [Serializable]
    public class Skill : IData, IProf {
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

        public string Description { get; set; }
        public bool HasHalfProficincy { get; set; }
        public bool HasProficincy { get; set; }
        public bool HasExpertise { get; set; }
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
        public SpellLevel Level { get; set; }
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
        public SpellComponents SpellActions { get; set; }
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

        public int NumDice { get; set; }
        public HitDie DamageDie { get; set; }
        public DamageType DamageType { get; set; }

        public override string ToString() {
            if (NumDice > 0)
                return $"{Name}: {CastingTime} : {Range} : {NumDice}{DamageDie} {DamageType}\n";
            else
                return $"{Name}: {CastingTime} : {Range}\n";
        }

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

        /// <summary>
        /// An enum representing Level of spell
        /// </summary>
        public enum SpellLevel {
            Cantrip,
            First,
            Second,
            Third,
            Fourth,
            Fifth,
            Sixth,
            Seventh,
            Eighth,
            Nineth
        }

        /// <summary>
        /// The component elements of a spell
        /// </summary>
        [Flags]
        public enum SpellComponents {
            /// <summary>
            /// The spell requires some kind of verbal component
            /// </summary>
            Verbal = 1 << 0,
            /// <summary>
            /// The spell requires specific gestures (REQUIRES at least one hand to perform gesture)
            /// </summary>
            Somatic = 1 << 1,
            /// <summary>
            /// The spell requires specific objects
            /// </summary>
            Material = 1 << 2,
        }
    }
    #endregion

    #region Data wrappers for specific data 
    /// <summary>
    /// The different types of damage present
    /// </summary>
    [Serializable]
    public enum DamageType {
        Acid,
        Bludgeoning,
        Cold,
        Fire,
        Force,
        Lightning,
        Necrotic,
        Piercing,
        Poison,
        Psychic,
        Radiant,
        Slashing,
        Thunder
    }
    /// <summary>
    /// The data wrapper for a single ability.
    /// </summary>
    [Serializable]
    public class Ability : IData, IProf {
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
        public bool HasHalfProficincy { get; set; }
        public bool HasProficincy { get; set; }
        public bool HasExpertise { get; set; }

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
    public class LineageTrait : ITrait {
        /// <summary>
        /// The trait's name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The in depth description of the trait.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The type the trait falls under
        /// </summary>
        public ITrait.TraitType Type { get; set; }
        public IData TraitData { get; set; }
    }

    /// <summary>
    /// The data wrapper for a single trait granted by a class.
    /// </summary>
    [Serializable]
    public class ClassAbility : ITrait {
        /// <summary>
        /// The name of the trait.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The in depth description of the trait.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The type the trait falls under
        /// </summary>
        public ITrait.TraitType Type { get; set; }
        /// <summary>
        /// The level the trait unlock at.
        /// </summary>
        public int LevelUnlocked { get; set; }
        public IData TraitData { get; set; }
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
        d12,
        /// <summary>
        /// A d20
        /// </summary>
        d20,
        /// <summary>
        /// A d100
        /// </summary>
        d100
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

        [Serializable]
        [Flags]
        public enum ItemType {
            Other = 1 << 0,
            Armor = 1 << 1,
            Potion = 1 << 2,
            Ring = 1 << 3,
            Rod = 1 << 4,
            Scroll = 1 << 5,
            Staff = 1 << 6,
            Wand = 1 << 7,
            Wonderous = 1 << 8,
            SimpleMeleeWeapon = 1 << 9,
            MartialMeleeWeapon = 1 << 10,
            SimpleRangeWeapon = 1 << 11,
            MartialRangeWeapon = 1 << 12,
            AdventureGear = 1 << 13,
            Ammunition = 1 << 14,
            ArcaneFocus = 1 << 15,
            ArtisanTool = 1 << 16,
            GamingSet = 1 << 17,
            MusicalInstrument = 1 << 18,
            Tool = 1 << 19,
            Vehicle = 1 << 20,
            Trinket = 1 << 21,
            TradeGood = 1 << 22,
            Food = 1 << 23,
            Treasure = 1 << 24,
            Coin = 1 << 25
        }
        [Serializable]
        [Flags]
        public enum WeaponProps {
            None = 0,
            Ammunition = 1 << 0,
            Finesse = 1 << 1,
            Heavy = 1 << 2,
            Light = 1 << 3,
            Loading = 1 << 4,
            Range = 1 << 5,
            Reach = 1 << 6,
            Special = 1 << 7,
            Thrown = 1 << 8,
            TwoHanded = 1 << 9,
            Versatile = 1 << 10,
            Imporvised = 1 << 11,
            Silvered = 1 << 12,
        }

        /// <summary>
        /// The Item's name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The type of item
        /// </summary>
        public ItemType Type { get; set; } = ItemType.Other;
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
        /// The type of damage the item does if applicable
        /// </summary>
        public DamageType DamageType { get; set; }
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
        /// The properties of the weapon if the item is a weapon
        /// </summary>
        public WeaponProps WeaponProperties { get; set; } = WeaponProps.None;
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
        /// <summary>
        /// The amount the character has
        /// </summary>
        public int Amount { get; set; } = 0;

        public bool IsWeapon {
            get {
                return Type.HasFlag(ItemType.SimpleMeleeWeapon) ||
                Type.HasFlag(ItemType.MartialMeleeWeapon) ||
                Type.HasFlag(ItemType.MartialRangeWeapon) ||
                Type.HasFlag(ItemType.SimpleRangeWeapon);
            }
        }

        public string ParseAsWeapon(Character PC) {
            bool IsMelee = Type.HasFlag(ItemType.SimpleMeleeWeapon) || Type.HasFlag(ItemType.MartialMeleeWeapon);
            bool IsProficient = PC.Proficiencies.Contains(this);

            return $"{Name} :: {(PC.Stats[(IsMelee ? 0 : 1)].Modifier + (IsProficient ? Engine.Proficincy(PC.Level) : 0)).ParseAsString()}" +
                $" :: {DiceForDamage}{DiceToRoll} {PC.Stats[(IsMelee ? 0 : 1)].Modifier.ParseAsString()} ({(IsMelee ? "Melee" : "Ranged")})\n";
        }

        public string TryParseItem() {
            if (!IsWeapon) return $"{Name}{(Amount > 1 ? $" x{Amount}" : "")}; ";
            return string.Empty;
        }
    }

    /// <summary>
    /// The data contained for a single language
    /// </summary>
    [Serializable]
    public class Language : IData {
        public string Name { get; set; }
        public string Description { get; set; }

        public static readonly Language Common = new(){
            Name = "Common",
            Description = ""
        };
    }

    /// <summary>
    /// A data wrapper for features
    /// </summary>
    [Serializable]
    public class Feature : ITrait {
        public string Name { get; set; }
        public string Description { get; set; }
        public ITrait.TraitType Type { get; set; } = ITrait.TraitType.Other;
        public IData TraitData { get; set; }
    }

    /// <summary>
    /// A data wrapper for Feats
    /// </summary>
    [Serializable]
    public class Feat : IData {
        public string Name { get; set; }
        public string Description { get; set; }

        public KeyValuePair<object, object>[] Prerequisites { get; set; }
        public Feature[] FeaturesGranted { get; set; }
    }

    /// <summary>
    /// A required data field for traits
    /// </summary>
    public interface ITrait : IData {

        public enum TraitType {
            Other,
            Action,
            BonusAction,
            Advantage,
            Resistance,
            Language,
            Skill,
            Weapon,
            Spell
        }

        public TraitType Type { get; set; }

        public IData TraitData { get; set; }
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
    public interface IProf {
        /// <summary>
        /// Does the character have half proficincy
        /// </summary>
        public bool HasHalfProficincy { get; set; }
        /// <summary>
        /// Does the character have proficincy
        /// </summary>
        public bool HasProficincy { get; set; }
        /// <summary>
        /// Does the character have double proficincy
        /// </summary>
        public bool HasExpertise { get; set; }
    }

    #endregion

    

}