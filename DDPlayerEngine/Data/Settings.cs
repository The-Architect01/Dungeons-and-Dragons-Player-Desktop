using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Web;
using System.Windows.Forms;

using PlayerEngine.Data.APIs;
using PlayerEngine.Forms.Pop_Ups;
using PlayerEngine.Properties;

namespace PlayerEngine.Data {

/// <summary>
/// Holds the current Settings for the runtime
/// </summary>
    public static class RuntimeSettings {
        static RuntimeSettings() {
            PrivateFontCollection tmp = new();
            IntPtr FontRef = Marshal.AllocCoTaskMem(Resources.Quicksand_VariableFont_wght.Length);
            Marshal.Copy(Resources.Quicksand_VariableFont_wght, 0, FontRef, Resources.Quicksand_VariableFont_wght.Length);
            tmp.AddMemoryFont(FontRef, Resources.Quicksand_VariableFont_wght.Length);
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
            try {
                if (Engine.IsOnline && (DateTime.UtcNow - File.GetLastWriteTime(Engine.SaveFileLocation + "EngineData")) > Engine.ForceUpdate)
                    CheckForUpdates();
                else
                    EngineData = JsonSerializer.Deserialize<EngineData>(File.ReadAllText(Engine.SaveFileLocation + "EngineData"));
            } catch (Exception e) when (e is HttpException) {
                EngineData = JsonSerializer.Deserialize<EngineData>(File.ReadAllText(Engine.SaveFileLocation + "EngineData"));
            } catch (Exception e) when (e is FileNotFoundException) {
                if (Engine.IsOnline) {
                    CheckForUpdates();
                } else {
                    Engine.ShowCriticalError(new HttpException("You are not connected to the internet! Cannot fetch data."));
                }
            } catch (Exception e) {
                Engine.ShowCriticalError(e);
            }
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

            Settings.Default.LastSync = DateTime.Now.Date;
            Settings.Default.Save();
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

        public static TimeSpan ForceUpdate = new TimeSpan(days:7,0,0,0);

        public static void ShowError(Exception e) {
            new ErrorMessage(e).ShowDialog();
        }

        public static void ShowCriticalError(Exception e) {
            new ErrorMessage(e).ShowDialog();
            Application.Exit();
        }

        /// <summary>
        /// Checks if the user is Online
        /// </summary>
        //public static bool IsOnline { get { try { return new Ping().Send(GitRepo).Status == IPStatus.Success; } catch { return false; } } }
        public static bool IsOnline {
            get {
                foreach (NetworkInterface NetIO in NetworkInterface.GetAllNetworkInterfaces())

                    if (NetIO.OperationalStatus == OperationalStatus.Up)
                        return true;

                return false;
            }
        }

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
            if (Settings.Default.LastSync == DateTime.Now.Date) { return false; }
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

        public static void SetText(this Microsoft.Office.Interop.PowerPoint.Shape me, string Text) { me.TextFrame.TextRange.Text = Text; }
        public static string GetText(this Microsoft.Office.Interop.PowerPoint.Shape me) { return me.TextFrame.TextRange.Text; }
        
        public static byte[] Serialize(this Character me) {
            return JsonSerializer.SerializeToUtf8Bytes(me, JsonSerializerOptions);
        }

        public static bool HasFlag<T>(this T me, params T[] flags ) where T : Enum {
            
            foreach(T flag in flags) 
                if (me.HasFlag(flag)) 
                    return true;

            return false;
        }

        public static string ToString(this List<Item> me, bool Overloaded = true) {
            string Line1 = $"[ARMOR]\n=====================================\n";
            foreach(var item in me.Distinct()) {
                if (item.Type.HasFlag(Item.ItemType.Armor)) {
                    Line1 += $"{item.Name} x{me.Where(e => e.Name == item.Name).Count()}\n";
                }
            }

            string Line2 = $"\n[WEAPONS]\n=====================================\n";
            foreach (var item in me.Distinct()) {
                if (item.Type.HasFlag(Item.ItemType.SimpleMeleeWeapon, Item.ItemType.SimpleRangeWeapon, Item.ItemType.MartialMeleeWeapon, Item.ItemType.MartialRangeWeapon)) {
                    Line2 += $"{item.Name} x{me.Where(e => e.Name == item.Name).Count()}\n";
                }
            }

            string Line3 = $"\n[MAGIC ITEMS]\n=====================================\n";
            foreach (var item in me.Distinct()) {
                if (item.Type.HasFlag(Item.ItemType.Potion, Item.ItemType.Wand, Item.ItemType.ArcaneFocus, Item.ItemType.Staff, Item.ItemType.Rod, Item.ItemType.Scroll, Item.ItemType.Wonderous, Item.ItemType.Ring, Item.ItemType.Staff)) {
                    Line3 += $"{item.Name} x{me.Where(e => e.Name == item.Name).Count()}\n";
                }
            }

            string Line4 = $"\n[OTHER]\n=====================================\n";
            foreach (var item in me.Distinct()) {
                if (item.Type.HasFlag(Item.ItemType.Other, Item.ItemType.AdventureGear, Item.ItemType.ArtisanTool, Item.ItemType.GamingSet, Item.ItemType.MusicalInstrument, Item.ItemType.Tool, Item.ItemType.Vehicle, Item.ItemType.Trinket, Item.ItemType.TradeGood, Item.ItemType.Food, Item.ItemType.Treasure, Item.ItemType.Coin)) {
                    Line4 += $"{item.Name} x{me.Where(e => e.Name == item.Name).Count()}\n";
                }
            }
            return Line1 + Line2 + Line3 + Line4;
        }
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
