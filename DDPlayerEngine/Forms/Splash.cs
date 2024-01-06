using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

using PlayerEngine.Data;

namespace PlayerEngine.Forms {
    public partial class Splash : Form {

        /// <summary>
        /// Displays the Splash Screen
        /// </summary>
        public Splash() {
            InitializeComponent();
            if (Engine.IsOnline) {
                HiddenLoader.Load(RuntimeSettings.EngineData.SplashImageURL);
                WebClient wc = new();
                RuntimeSettings.EngineData.SplashImageBase64 = Convert.ToBase64String(wc.DownloadData(RuntimeSettings.EngineData.SplashImageURL));
                File.WriteAllText(Engine.SaveFileLocation + "EngineData", System.Text.Json.JsonSerializer.Serialize(RuntimeSettings.EngineData));
            } else {
                HiddenLoader.Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(RuntimeSettings.EngineData.SplashImageBase64)));
            }
            BackgroundImage = HiddenLoader.Image;
            HiddenLoader.Hide();
            label2.Font = new Font(Data.RuntimeSettings.DefaultFont, 27, FontStyle.Regular);
            Version.Font = new Font(Data.RuntimeSettings.DefaultFont, 8, FontStyle.Regular);
            Version.Text = $"Version {Data.RuntimeSettings.EngineData.Version}";
        }

        private void Timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e) {
            Close();
        }
    }
}
