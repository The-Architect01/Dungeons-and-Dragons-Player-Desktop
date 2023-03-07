using System;
using System.Windows.Forms;
using PlayerEngine.Properties;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Security.Cryptography;

namespace PlayerEngine.Forms {
    /// <summary>
    /// 
    /// </summary>
    public partial class ExportProgress : Form {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="me"></param>
        public ExportProgress(Data.Character me) {
            InitializeComponent();

            me.Name = "Testing123";
            me.Lineage = new Data.Lineage();
            me.Background = new Data.Background();
            me.Class.Add(new Data.Class() { HitDie = Data.HitDie.d6});
            for (int i = 0; i < me.Skills.Length; i++) {
                me.Skills[i] = new Data.Skill() {
                    BaseStat = Data.StatName.STR,
                    Name = "",
                    HasExpertise = new Random().Next(3) % 3 == 0,
                    HasHalfProficincy = new Random().Next(3) % 3 == 0,
                    HasProficincy = new Random().Next(3) % 3 == 0
                };
            }
            me.Lineage = new Data.Lineage();

            Microsoft.Office.Interop.Excel.Application Excel = new(){
                DisplayAlerts = false,
                Visible = false,
                ScreenUpdating = false,
                ShowWindowsInTaskbar = false,
            };

            string FileName = $"{Directory.GetCurrentDirectory()}/temp.xlsx";
            using (FileStream fs = File.Create(FileName)) {
                fs.Write(Resources.PlayerSheet, 0, Resources.PlayerSheet.Length);
            }

            ExportLocation.FileName = me.Name;
            if (ExportLocation.ShowDialog() != DialogResult.OK) {
                File.Delete(FileName);
                return;
            }

            Workbook Host = Excel.Workbooks.Open(FileName, IgnoreReadOnlyRecommended: true);

            Worksheet MainWorksheet = Host.Worksheets[1];

            #region POPULATE
            try {
                //MainWorksheet.Range["ACTIONS"].Value = "";
                MainWorksheet.Range["ABILITIES"].Value = "";
                MainWorksheet.Range["ARMOR_CLASS"].Value = me.ArmorClass;
                MainWorksheet.Range["BONUS_ACTIONS"].Value = "";
                MainWorksheet.Range["DARKVISION"].Value = "";
                MainWorksheet.Range["HIT_DIE"].Value = me.Class[0].HitDie;
                //MainWorksheet.Range["INITATIVE"].Value = me.Stats[0].Modifier;

                //Speed
                MainWorksheet.Range["FLYING_SPEED"].Value = me.Lineage.FlyingSpeed;
                MainWorksheet.Range["SWIMMING_SPEED"].Value = me.Lineage.SwimmingSpeed;
                MainWorksheet.Range["WALKING_SPEED"].Value = me.Lineage.Speed;

                MainWorksheet.Range["CLASS"].Value = $"{me.Class[0].BaseClass} ({me.Class[0].SubClass})";
                MainWorksheet.Range["BACKGROUND"].Value = $"{(me.Class.Count > 1 ? $"{me.Class[1].BaseClass} ({me.Class[1].SubClass})" : me.Background.Name)}";
                MainWorksheet.Range["BACKGROUND_LABEL"].Value = $"{(me.Class.Count > 1 ? "Class" : "Background")}";

                //Skills
                /*MainWorksheet.Range["DECEPTION"].Value = "◉";
                MainWorksheet.Range["DECEPTION"].Font.Size = 8;
                MainWorksheet.Range["CON_SAVE"].Value = "○";
                MainWorksheet.Range["INSIGHT"].Value = "◎";
                MainWorksheet.Range["INSIGHT"].Font.Size = 8;
                MainWorksheet.Range["STR_SAVE"].Font.Size = 8;*/
                MainWorksheet.Range["ACROBATICS"].Value = me.Skills[0].HasProficincy ? "◉" : me.Skills[0].HasHalfProficincy ? "◎" : "○";
                MainWorksheet.Range["ACROBATICS"].Font.Size = me.Skills[0].HasProficincy || me.Skills[0].HasHalfProficincy ? 8 : 11;
                MainWorksheet.Range["ANIMAL_HANDLING"].Value = me.Skills[1].HasProficincy ? "◉" : me.Skills[1].HasHalfProficincy ? "◎" : "○";
                MainWorksheet.Range["ANIMAL_HANDLING"].Font.Size = me.Skills[1].HasProficincy || me.Skills[1].HasHalfProficincy ? 8 : 11;
                MainWorksheet.Range["ARCANA"].Value = me.Skills[02].HasProficincy ? "◉" : me.Skills[02].HasHalfProficincy ? "◎" : "○";
                MainWorksheet.Range["ARCANA"].Font.Size = me.Skills[02].HasProficincy || me.Skills[02].HasHalfProficincy ? 8 : 11;
                MainWorksheet.Range["ATHLETICS"].Value = me.Skills[03].HasProficincy ? "◉" : me.Skills[03].HasHalfProficincy ? "◎" : "○";
                MainWorksheet.Range["ATHLETICS"].Font.Size = me.Skills[03].HasProficincy || me.Skills[03].HasHalfProficincy ? 8 : 11;
                MainWorksheet.Range["DECEPTION"].Value = me.Skills[04].HasProficincy ? "◉" : me.Skills[04].HasHalfProficincy ? "◎" : "○";
                MainWorksheet.Range["DECEPTION"].Font.Size = me.Skills[04].HasProficincy || me.Skills[04].HasHalfProficincy ? 8 : 11;
                MainWorksheet.Range["HISTORY"].Value = me.Skills[05].HasProficincy ? "◉" : me.Skills[05].HasHalfProficincy ? "◎" : "○";
                MainWorksheet.Range["HISTORY"].Font.Size = me.Skills[05].HasProficincy || me.Skills[05].HasHalfProficincy ? 8 : 11;
                MainWorksheet.Range["INSIGHT"].Value = me.Skills[06].HasProficincy ? "◉" : me.Skills[06].HasHalfProficincy ? "◎" : "○";
                MainWorksheet.Range["INSIGHT"].Font.Size = me.Skills[06].HasProficincy || me.Skills[06].HasHalfProficincy ? 8 : 11;
                MainWorksheet.Range["INTIMIDATION"].Value = me.Skills[07].HasProficincy ? "◉" : me.Skills[07].HasHalfProficincy ? "◎" : "○";
                MainWorksheet.Range["INTIMIDATION"].Font.Size = me.Skills[07].HasProficincy || me.Skills[07].HasHalfProficincy ? 8 : 11;
                MainWorksheet.Range["INVESTIGATION"].Value = me.Skills[08].HasProficincy ? "◉" : me.Skills[08].HasHalfProficincy ? "◎" : "○";
                MainWorksheet.Range["INVESTIGATION"].Font.Size = me.Skills[08].HasProficincy || me.Skills[08].HasHalfProficincy ? 8 : 11;
                MainWorksheet.Range["MEDICINE"].Value = me.Skills[09].HasProficincy ? "◉" : me.Skills[09].HasHalfProficincy ? "◎" : "○";
                MainWorksheet.Range["MEDICINE"].Font.Size = me.Skills[09].HasProficincy || me.Skills[09].HasHalfProficincy ? 8 : 11;
                MainWorksheet.Range["NATURE"].Value = me.Skills[10].HasProficincy ? "◉" : me.Skills[10].HasHalfProficincy ? "◎" : "○";
                MainWorksheet.Range["NATURE"].Font.Size = me.Skills[10].HasProficincy || me.Skills[10].HasHalfProficincy ? 8 : 11;
                MainWorksheet.Range["PERCEPTION"].Value = me.Skills[11].HasProficincy ? "◉" : me.Skills[11].HasHalfProficincy ? "◎" : "○";
                MainWorksheet.Range["PERCEPTION"].Font.Size = me.Skills[11].HasProficincy || me.Skills[11].HasHalfProficincy ? 8 : 11;
                MainWorksheet.Range["PERFORMANCE"].Value = me.Skills[12].HasProficincy ? "◉" : me.Skills[12].HasHalfProficincy ? "◎" : "○";
                MainWorksheet.Range["PERFORMANCE"].Font.Size = me.Skills[12].HasProficincy || me.Skills[12].HasHalfProficincy ? 8 : 11;
                MainWorksheet.Range["PERSUASION"].Value = me.Skills[13].HasProficincy ? "◉" : me.Skills[13].HasHalfProficincy ? "◎" : "○";
                MainWorksheet.Range["PERSUASION"].Font.Size = me.Skills[13].HasProficincy || me.Skills[13].HasHalfProficincy ? 8 : 11;
                MainWorksheet.Range["RELIGION"].Value = me.Skills[14].HasProficincy ? "◉" : me.Skills[14].HasHalfProficincy ? "◎" : "○";
                MainWorksheet.Range["RELIGION"].Font.Size = me.Skills[14].HasProficincy || me.Skills[14].HasHalfProficincy ? 8 : 11;
                MainWorksheet.Range["SLEIGHT_OF_HAND"].Value = me.Skills[15].HasProficincy ? "◉" : me.Skills[15].HasHalfProficincy ? "◎" : "○";
                MainWorksheet.Range["SLEIGHT_OF_HAND"].Font.Size = me.Skills[15].HasProficincy || me.Skills[15].HasHalfProficincy ? 8 : 11;
                MainWorksheet.Range["STEALTH"].Value = me.Skills[16].HasProficincy ? "◉" : me.Skills[16].HasHalfProficincy ? "◎" : "○";
                MainWorksheet.Range["STEALTH"].Font.Size = me.Skills[16].HasProficincy || me.Skills[16].HasHalfProficincy ? 8 : 11;
                MainWorksheet.Range["SURVIVAL"].Value = me.Skills[17].HasProficincy ? "◉" : me.Skills[17].HasHalfProficincy ? "◎" : "○";
                MainWorksheet.Range["SURVIVAL"].Font.Size = me.Skills[17].HasProficincy || me.Skills[17].HasHalfProficincy ? 8 : 11;

                //Attack Data
                MainWorksheet.Range["ATTACK_EIGHT_DMG"].Value = "◉";
                MainWorksheet.Range["ATTACK_EIGHT_DMG_TYPE"].Value = "◉";
                MainWorksheet.Range["ATTACK_EIGHT_HIT"].Value = "◉";
                MainWorksheet.Range["ATTACK_EIGHT_NAME"].Value = "◉";
                MainWorksheet.Range["ATTACK_EIGHT_NOTES"].Value = "◉";
                MainWorksheet.Range["ATTACK_FIVE_DMG"].Value = "◉";
                MainWorksheet.Range["ATTACK_FIVE_DMG_TYPE"].Value = "◉";
                MainWorksheet.Range["ATTACK_FIVE_HIT"].Value = "◉";
                MainWorksheet.Range["ATTACK_FIVE_NAME"].Value = "◉";
                MainWorksheet.Range["ATTACK_FIVE_NOTES"].Value = "◉";
                MainWorksheet.Range["ATTACK_FOUR_DMG"].Value = "◉";
                MainWorksheet.Range["ATTACK_FOUR_DMG_TYPE"].Value = "◉";
                MainWorksheet.Range["ATTACK_FOUR_HIT"].Value = "◉";
                MainWorksheet.Range["ATTACK_FOUR_NAME"].Value = "◉";
                MainWorksheet.Range["ATTACK_FOUR_NOTES"].Value = "◉";
                MainWorksheet.Range["ATTACK_ONE_DMG"].Value = "◉";
                MainWorksheet.Range["ATTACK_ONE_DMG_TYPE"].Value = "◉";
                MainWorksheet.Range["ATTACK_ONE_HIT"].Value = "◉";
                MainWorksheet.Range["ATTACK_ONE_NAME"].Value = "◉";
                MainWorksheet.Range["ATTACK_ONE_NOTES"].Value = "◉";
                MainWorksheet.Range["ATTACK_SEVEN_DMG"].Value = "◉";
                MainWorksheet.Range["ATTACK_SEVEN_DMG_TYPE"].Value = "◉";
                MainWorksheet.Range["ATTACK_SEVEN_HIT"].Value = "◉";
                MainWorksheet.Range["ATTACK_SEVEN_NAME"].Value = "◉";
                MainWorksheet.Range["ATTACK_SEVEN_NOTES"].Value = "◉";
                MainWorksheet.Range["ATTACK_SIX_DMG"].Value = "◉";
                MainWorksheet.Range["ATTACK_SIX_DMG_TYPE"].Value = "◉";
                MainWorksheet.Range["ATTACK_SIX_HIT"].Value = "◉";
                MainWorksheet.Range["ATTACK_SIX_NAME"].Value = "◉";
                MainWorksheet.Range["ATTACK_SIX_NOTES"].Value = "◉";
                MainWorksheet.Range["ATTACK_THREE_DMG"].Value = "◉";
                MainWorksheet.Range["ATTACK_THREE_DMG_TYPE"].Value = "◉";
                MainWorksheet.Range["ATTACK_THREE_HIT"].Value = "◉";
                MainWorksheet.Range["ATTACK_THREE_NAME"].Value = "◉";
                MainWorksheet.Range["ATTACK_THREE_NOTES"].Value = "◉";
                MainWorksheet.Range["ATTACK_TWO_DMG"].Value = "◉";
                MainWorksheet.Range["ATTACK_TWO_DMG_TYPE"].Value = "◉";
                MainWorksheet.Range["ATTACK_TWO_HIT"].Value = "◉";
                MainWorksheet.Range["ATTACK_TWO_NAME"].Value = "◉";
                MainWorksheet.Range["ATTACK_TWO_NOTES"].Value = "◉";

                //Mods
                //MainWorksheet.Range["CHA_MOD"].Value = me.Stats[5].Modifier;
                MainWorksheet.Range["CHA_SAVE"].Value = "";
                //MainWorksheet.Range["CHA_SCORE"].Value = me.Stats[5].Score;

                MainWorksheet.Range["CON_MOD"].Value = "◉";
                MainWorksheet.Range["CON_SAVE"].Value = "◉";
                MainWorksheet.Range["CON_SCORE"].Value = "◉";

                MainWorksheet.Range["DEX_MOD"].Value = "◉";
                MainWorksheet.Range["DEX_SAVE"].Value = "◉";
                MainWorksheet.Range["DEX_SCORE"].Value = "◉";

                MainWorksheet.Range["INT_MOD"].Value = "◉";
                MainWorksheet.Range["INT_SAVE"].Value = "◉";
                MainWorksheet.Range["INT_SCORE"].Value = "◉";

                MainWorksheet.Range["STR_MOD"].Value = "◉";
                MainWorksheet.Range["STR_SAVE"].Value = "◉";
                MainWorksheet.Range["STR_SCORE"].Value = "◉";

                MainWorksheet.Range["WIS_MOD"].Value = "◉";
                MainWorksheet.Range["WIS_SAVE"].Value = "◉";
                MainWorksheet.Range["WIS_SCORE"].Value = "◉";

                MainWorksheet.Range["LEVEL"].Value = me.Level;
                MainWorksheet.Range["MAX_HP"].Value = me.MaxHitPoints;
                MainWorksheet.Range["NAME"].Value = $"{(string.IsNullOrWhiteSpace(me.Pronouns) ? me.Name : $"{me.Name} ({me.Pronouns})")}";
                MainWorksheet.Range["PASSIVE_INSIGHT"].Value = me.Stats[0].Modifier + 10;
                MainWorksheet.Range["PASSIVE_INT"].Value = me.Stats[0].Modifier + 10;
                MainWorksheet.Range["PASSIVE_INVESTIGATION"].Value = me.Stats[0].Modifier + 10;
                MainWorksheet.Range["PASSIVE_PERCEPTION"].Value = me.Stats[0].Modifier + 10;
                MainWorksheet.Range["PASSIVE_WIS"].Value = me.Stats[0].Modifier + 10;
                MainWorksheet.Range["PROF_BONUS"].Value = "";
                MainWorksheet.Range["RESISTANCES"].Value = "";

                //Spell Data
                MainWorksheet.Range["SPELL_EIGHT_CAST"].Value = "◉";
                MainWorksheet.Range["SPELL_EIGHT_DC"].Value = "◉";
                MainWorksheet.Range["SPELL_EIGHT_NAME"].Value = "◉";
                MainWorksheet.Range["SPELL_EIGHT_NOTES"].Value = "◉";
                MainWorksheet.Range["SPELL_EIGHT_RANGE"].Value = "◉";

                MainWorksheet.Range["SPELL_FIVE_CAST"].Value = "◉";
                MainWorksheet.Range["SPELL_FIVE_DC"].Value = "◉";
                MainWorksheet.Range["SPELL_FIVE_NAME"].Value = "◉";
                MainWorksheet.Range["SPELL_FIVE_NOTES"].Value = "◉";
                MainWorksheet.Range["SPELL_FIVE_RANGE"].Value = "◉";

                MainWorksheet.Range["SPELL_FOUR_CAST"].Value = "◉";
                MainWorksheet.Range["SPELL_FOUR_DC"].Value = "◉";
                MainWorksheet.Range["SPELL_FOUR_NAME"].Value = "◉";
                MainWorksheet.Range["SPELL_FOUR_NOTES"].Value = "◉";
                MainWorksheet.Range["SPELL_FOUR_RANGE"].Value = "◉";

                MainWorksheet.Range["SPELL_ONE_CAST"].Value = "◉";
                MainWorksheet.Range["SPELL_ONE_DC"].Value = "◉";
                MainWorksheet.Range["SPELL_ONE_NAME"].Value = "◉";
                MainWorksheet.Range["SPELL_ONE_NOTES"].Value = "◉";
                MainWorksheet.Range["SPELL_ONE_RANGE"].Value = "◉";

                MainWorksheet.Range["SPELL_SEVEN_CAST"].Value = "◉";
                MainWorksheet.Range["SPELL_SEVEN_DC"].Value = "◉";
                MainWorksheet.Range["SPELL_SEVEN_NAME"].Value = "◉";
                MainWorksheet.Range["SPELL_SEVEN_NOTES"].Value = "◉";
                MainWorksheet.Range["SPELL_SEVEN_RANGE"].Value = "◉";

                MainWorksheet.Range["SPELL_SIX_CAST"].Value = "◉";
                MainWorksheet.Range["SPELL_SIX_DC"].Value = "◉";
                MainWorksheet.Range["SPELL_SIX_NAME"].Value = "◉";
                MainWorksheet.Range["SPELL_SIX_NOTES"].Value = "◉";
                MainWorksheet.Range["SPELL_SIX_RANGE"].Value = "◉";

                MainWorksheet.Range["SPELL_THREE_CAST"].Value = "◉";
                MainWorksheet.Range["SPELL_THREE_DC"].Value = "◉";
                MainWorksheet.Range["SPELL_THREE_NAME"].Value = "◉";
                MainWorksheet.Range["SPELL_THREE_NOTES"].Value = "◉";
                MainWorksheet.Range["SPELL_THREE_RANGE"].Value = "◉";

                MainWorksheet.Range["SPELL_TWO_CAST"].Value = "◉";
                MainWorksheet.Range["SPELL_TWO_DC"].Value = "◉";
                MainWorksheet.Range["SPELL_TWO_NAME"].Value = "◉";
                MainWorksheet.Range["SPELL_TWO_NOTES"].Value = "◉";
                MainWorksheet.Range["SPELL_TWO_RANGE"].Value = "◉";
            } catch { }
            #endregion

            Host.ExportAsFixedFormat(XlFixedFormatType.xlTypePDF, ExportLocation.FileName, OpenAfterPublish: true);

            Host.Close();
            Excel.Quit();

            File.Delete(FileName);

        }

        //◈ = Full Prof Saving Throw
        //◉ = Full Prof Skill
        //○ = No Prof Skill
        //◎ = Half Prof Skill
        //◇ = No Prof Saving Throw
        //▢ = Has Used
        
    }
}
