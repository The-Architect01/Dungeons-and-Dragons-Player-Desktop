using System.Runtime.InteropServices;
using PlayerEngine.Properties;
using System.Text.Json;
using System.Net;
using System;
using System.Drawing.Text;
using System.Drawing;

namespace PlayerEngine.Data {

    /// <summary>
    /// Holds the current Settings for the runtime
    /// </summary>
    public static class RuntimeSettings {

        static RuntimeSettings() {
            PrivateFontCollection tmp = new();
            IntPtr refToFont = Marshal.AllocCoTaskMem(Resources.Chivo_1og4.Length);
            Marshal.Copy(Resources.Chivo_1og4, 0, refToFont, Resources.Chivo_1og4.Length);
            tmp.AddMemoryFont(refToFont, Resources.Chivo_1og4.Length);
            DefaultFont = tmp.Families[0];
        }

        /// <summary>
        /// The global EngineData
        /// </summary>
        public static EngineData EngineData;
        
        /// <summary>
        /// Checks if the user is online, if online update, else use cached.
        /// </summary>
        public static void Update() {
            if (IsOnline)
                CheckForUpdates();
            else
                EngineData = JsonSerializer.Deserialize<EngineData>(Settings.Default["SerializedData"].ToString());
        }

        /// <summary>
        /// Checks if the user is Online
        /// </summary>
        public static bool IsOnline { get { return InternetGetConnectedState(out _, 0); } }

        /// <summary>
        /// The default font
        /// </summary>
        public static FontFamily DefaultFont;

        static void CheckForUpdates() {
            //EngineData = JsonSerializer.Deserialize<EngineData>(Settings.Default.SerializedData, new JsonSerializerOptions() { IncludeFields = true, WriteIndented = true }) ;
            using WebClient wc = new();
            EngineData = JsonSerializer.Deserialize<EngineData>(wc.DownloadString("https://raw.githubusercontent.com/The-Architect01/Dungeons-and-Dragons-Player-Maker/master/Test.json"), new JsonSerializerOptions() { IncludeFields = true, WriteIndented = true });
            EngineData.SplashImageBase64 = Convert.ToBase64String(wc.DownloadData(EngineData.SplashImageURL));
            //System.Windows.Forms.MessageBox.Show(Convert.ToBase64String(wc.DownloadData(EngineData.SplashImageURL)));
        }

        #region DLL Imports
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);
        #endregion

    }

    
}
