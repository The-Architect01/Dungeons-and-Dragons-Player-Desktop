using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PlayerEngine.Data.APIs {
    public class _5eToolsAPI {
        public LineageData Lineages;
    }

    [Serializable]
    public class LineageData {
        public MetaData _meta;

        [JsonPropertyName("race")]
        public Lineage[] Lineages;

        [JsonPropertyName("subrace")]
        public Sublineage[] Sublineages;
    }
    
    [Serializable]
    public class Lineage {
        public string Name;
        public string Source;
        [JsonPropertyName("page")]
        public int PageRef;
        [JsonPropertyName("srd")]
        public bool SRD;
        public bool BasicRules;
        public string[] Size;
        public Speed Speed;
        [JsonPropertyName("ability")]
        public Ability[] AbilityIncrease;
        public Age Age;
        public int DarkVision;
        public string[] TraitTags;
        public Dictionary<string, bool> LanguageProficiencies;
        public Dictionary<string, bool> WeaponProficiencies;
        public string[] Resist;
        public Entry Entries;
        public bool HasFluff;
        public bool HasFluffImages;
    }

    [Serializable]
    public class Sublineage {

    }

    [Serializable]
    public class Entry {
        public string Name;
        public string Type;
        public string[] Entries;
    }

    [Serializable]
    public class Speed {
        public object Walk;
        public object Fly;
        public object Swim;
    }

    [Serializable]
    public class Age {
        public int Mature;
        public int Max;
    }

    [Serializable]
    public class Ability {
        public int STR;
        public int DEX;
        public int CON;
        public int WIS;
        public int INT;
        public int CHA;
    }

    [Serializable]
    public class MetaData {
        public string[] internalCopies;
    }
}
