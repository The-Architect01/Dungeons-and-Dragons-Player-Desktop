using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PlayerEngine.Forms {
    public partial class Splash : Form {

        /// <summary>
        /// Displays the Splash Screen
        /// </summary>
        public Splash() {
            InitializeComponent();
            HiddenLoader.Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(Data.RuntimeSettings.EngineData.SplashImageBase64)));
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
