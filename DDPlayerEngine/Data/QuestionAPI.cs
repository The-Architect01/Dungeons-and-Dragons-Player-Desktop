using System;

namespace PlayerEngine.Data.APIs {
    
    #region Example Questions
    // Pick a cloud
    // What color is your character?
    // Disney Princess
    // Animal?
    // Favorite Cookie
    // Greatest fear
    // atla?
    // Zodiac Sign
    // What dog breed
    // What Plant represents the player
    #endregion

    [Serializable]
    public class Question {
        public string QuestionDescription { get; set; }
        public Answer[] Answers { get; set; }
    }

    [Serializable]
    public class Answer {
        public string AnswerDescription { get; set; }
        public string ImageBase64 { get; set; }
        public PersonalityModifier[] Modifiers { get; set; }
    }
    [Serializable]
    public class PersonalityModifier {
        public PersonalityScore Personality { get; set; }
        public int Modification { get; set; }
    }

    [Serializable]
    public enum PersonalityScore {
        /// <summary>
        /// Players who score high in action like adventures with high combat and enjoy playing builds that are predominately Fighter, Barbarian, Warlock, Ranger, etc.
        /// </summary>
        Action,
        /// <summary>
        /// Players who score high in Curiosity like adventures with high intrigue and puzzles. They primarily play wizards, bards, and rogues.
        /// </summary>
        Curiosity,
        /// <summary>
        /// Players who score high in power, like most adventures as long as the dice have large numbers. They primarily play min/max builds.
        /// </summary>
        Power,

    }
}
