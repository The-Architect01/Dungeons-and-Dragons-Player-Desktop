using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Windows.Forms;

using PlayerEngine.Data.APIs;
using PlayerEngine.Properties;
namespace PlayerEngine.Data {

/// <summary>
/// Holds the current Settings for the runtime
/// </summary>
    public static class RuntimeSettings {
        static RuntimeSettings() {
            PrivateFontCollection tmp = new();
            IntPtr FontRef = Marshal.AllocCoTaskMem(Resources.Chivo_1og4.Length);
            Marshal.Copy(Resources.Chivo_1og4, 0, FontRef, Resources.Chivo_1og4.Length);
            tmp.AddMemoryFont(FontRef, Resources.Chivo_1og4.Length);
            DefaultFont = tmp.Families[0];
        }

        /// <summary>
        /// The global EngineData
        /// </summary>
        public static EngineData EngineData = null;

        /// <summary>
        /// The default font
        /// </summary>
        public static FontFamily DefaultFont;
        /// <summary>
        /// Checks if the user is online, if online update, else use cached.
        /// </summary>
        public static void Update() {
            if (Engine.IsOnline)
                CheckForUpdates();
            else
                EngineData = JsonSerializer.Deserialize<EngineData>(File.ReadAllText(Engine.SaveFileLocation + "EngineData"));
        }

        

        static void CheckForUpdates() {

            WebClient wc = new();

            Engine.CreateDirectories();
            if (Engine.RequireUpdate("EngineData.json", Engine.SaveFileLocation + "EngineData")) {
                EngineData tmp = JsonSerializer.Deserialize<EngineData>(wc.DownloadString("https://raw.githubusercontent.com/The-Architect01/Dungeons-and-Dragons-Player-Desktop/master/EngineData.json"), Engine.JsonSerializerOptions);
                tmp.SplashImageBase64 ??= Convert.ToBase64String(wc.DownloadData(tmp.SplashImageURL));
                EngineData = tmp;
                File.WriteAllText(Engine.SaveFileLocation + "EngineData", JsonSerializer.Serialize(tmp));
            }

            if (Engine.RequireUpdate("Books/PHB.sbk", $"{Engine.SaveFileLocation + "Cache\\Books\\"}PHB.sbk"))
                wc.DownloadFile($"{Engine.GitRepo}Books/PHB.sbk", $"{Engine.SaveFileLocation + "Cache\\Books\\"}PHB.sbk");

            EngineData ??= JsonSerializer.Deserialize<EngineData>(File.ReadAllText(Engine.SaveFileLocation + "EngineData"));

            foreach (string file in Directory.GetFiles(Engine.SaveFileLocation + "Cache\\Books").Union(Directory.GetFiles(Engine.SaveFileLocation + "Cache\\Homebrews"))) try { EngineData.Books.Add(JsonSerializer.Deserialize<Book>(File.ReadAllText(file), Engine.JsonSerializerOptions)); } catch { }

        }

    }

    public static class Engine {
        
        public static Random RNG = new();
        public static JsonSerializerOptions JsonSerializerOptions = new() { IncludeFields = true, WriteIndented = true, PropertyNameCaseInsensitive = true };
        public static Color InactiveColor { get; } = Color.LightGray;
        public static Color SelectedColor { get; } = Color.DimGray;


        public static string SaveSymbolic = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Tabletop Character Manager\\";
        public static string SaveFileLocation = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Tabletop Character Manager\\";
        public static string GitRepo = "https://raw.githubusercontent.com/The-Architect01/Dungeons-and-Dragons-Player-Desktop/master/";
        public static string GitAPI = "https://api.github.com/repos/The-Architect01/Dungeons-and-Dragons-Player-Desktop/";

        /// <summary>
        /// Checks if the user is Online
        /// </summary>
        public static bool IsOnline { get { try { return new Ping().Send(GitRepo).Status == IPStatus.Success; } catch { return false; } } }


        public static int ParseHitDie(this HitDie hitDie) {
            return hitDie switch {
                HitDie.d4 => 4,
                HitDie.d6 => 6,
                HitDie.d8 => 8,
                HitDie.d10 => 10,
                HitDie.d12 => 12,
                HitDie.d20 => 20,
                HitDie.d100 => 100,
                _ => 20
            };
        }

        public static bool RequireUpdate(string URL, string checkFile) {
            if (!File.Exists(checkFile)) return true;
            using HttpClient client = new();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.UserAgent.TryParseAdd("request");
            GitCommit lastCommit = JsonSerializer.Deserialize<List<GitCommit>>(client.GetAsync($"{GitAPI}commits?path=/{URL}").Result.Content.ReadAsStringAsync().Result, JsonSerializerOptions)[0];
            return (lastCommit.Details.Author.Date) > File.GetLastWriteTimeUtc(checkFile);           
        }

        public static void CreateDirectories() {
            if (!Directory.Exists(SaveFileLocation)) Directory.CreateDirectory(SaveFileLocation);
            if (!Directory.Exists(SaveFileLocation + "Characters")) Directory.CreateDirectory(SaveFileLocation + "Characters");
            if (!Directory.Exists(SaveFileLocation + "Homebrews")) Directory.CreateDirectory(SaveFileLocation + "Homebrews");

            if (!Directory.Exists(SaveFileLocation + "Cache")) Directory.CreateDirectory(SaveFileLocation + "Cache");
            if (!Directory.Exists(SaveFileLocation + "Cache\\Books")) Directory.CreateDirectory(SaveFileLocation + "Cache\\Books");
            if (!Directory.Exists(SaveFileLocation + "Cache\\Homebrews")) Directory.CreateDirectory(SaveFileLocation + "Cache\\Homebrews");
            if (!Directory.Exists(SaveFileLocation + "Characters\\Adoptables")) Directory.CreateDirectory(SaveFileLocation + "Characters\\Adoptables\\");

            if (!Directory.Exists(SaveSymbolic)) Directory.CreateDirectory(SaveSymbolic);
            if (!Directory.Exists(SaveSymbolic + "Exported Characters")) Directory.CreateDirectory(SaveSymbolic + "Exported Characters");
            if (!File.Exists(SaveSymbolic + "Characters.lnk")) CreateSymbolicDirectory(SaveSymbolic + "Characters", SaveFileLocation + "Characters");
            if (!File.Exists(SaveSymbolic + "Homebrews.lnk")) CreateSymbolicDirectory(SaveSymbolic + "Homebrews", SaveFileLocation + "Homebrews");


            if (!File.Exists(SaveFileLocation + "Cache\\Blocked")) { File.CreateText(SaveFileLocation + "Cache\\Blocked"); }
        }

        public static void CreateSymbolicDirectory(string newdir, string target) {
            IWshRuntimeLibrary.IWshShortcut shortcut;
            var wshShell = new IWshRuntimeLibrary.WshShell();
            shortcut = (IWshRuntimeLibrary.IWshShortcut)wshShell.CreateShortcut(newdir + ".lnk");
            shortcut.TargetPath = target;
            shortcut.IconLocation = @"%SystemRoot%\System32\SHELL32.dll,3";
            shortcut.Save();
        }

        public static int Proficincy(int Level) {
            return Level switch {
                >= 1 and < 5 =>2,
                >= 5 and < 10 =>3,
                >= 10 and < 17 =>5,
                >= 17 and < 21 =>6,
                _=>0
            };
        }

        #region Extension Methods
        public static bool ContainsTypes(this Control.ControlCollection collection, params Type[] types) {
            foreach (Control control in collection)
                if (types.Contains(control.GetType())) return true;
            return false;
        }

        public static Control GetControlOfType(this Control.ControlCollection collection, Type type) {
            foreach(Control control in collection)
                if (control.GetType() == type)
                    return control;
            return null;
        }

        public static string ParseAsString(this int value) {
            return (value == 0 ? "+ 0" : value > 0 ? $"+ {Math.Abs(value)}" : $"- {Math.Abs(value)}");
        }

        public static int Min(params int[] values) {
            int tmp = int.MaxValue;
            foreach (int value in values)
                if (value < tmp) tmp = value;
            return tmp;
        }
        public static int Max(params int[] values) {
            int tmp = int.MinValue;
            foreach (int value in values)
                if (value > tmp) tmp = value;
            return tmp;
        }

        public static int PassiveScore(this Character PC, string Skill) {
            Skill Target = PC.Skills.Where(x => x.Name.ToLower() == Skill.ToLower()).ToArray()[0];
            Ability TargetAbility = PC.Stats.Where(x => x.Name == Target.BaseStat).ToArray()[0];
            return 10 + TargetAbility.Modifier + (int)(Target.HasExpertise ? 2 * Proficincy(PC.Level) :
                 Target.HasProficincy ? Proficincy(PC.Level) :
                 Target.HasHalfProficincy ? .5f * Proficincy(PC.Level) : 0
                );
        }

        public static void SetText(this Microsoft.Office.Interop.PowerPoint.Shape me, string Text) {
            me.TextFrame.TextRange.Text = Text;
        }
        public static string GetText(this Microsoft.Office.Interop.PowerPoint.Shape me) { return me.TextFrame.TextRange.Text; }
        #endregion
    }

    public enum ClassColors : uint {
        Barbarian = 0xFFD22B2B,
        Bard = 0xFFb76e79,//E0B0FF
        Cleric = 0xFFEDEAE0,
        Druid = 0xFF8A9A5B,
        Fighter = 0xFF545AA7,//DADD98
        Monk =  0xFF00A879,
        Paladin = 0xFFD4AF37,
        Ranger = 0xFFDADD98,
        Rogue = 0xFF58111A,//58111A,674846,660000
        Sorcerer = 0xFF39A78D,//3AA8C1,00CCCC,CF71AF
        Warlock = 0xFF645394,//B768A2,86608E,414A4C
        Wizard = 0xFF7289DA, //7289da,ADD8E6,AFDBF5,80DAEB,81D8D0

    }

}
