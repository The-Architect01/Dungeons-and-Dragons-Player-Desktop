using System;
using System.Drawing;
using System.Windows.Forms;

namespace PlayerEngine.Forms {
    public partial class UpdateBox : Form {
        public UpdateBox() {
            InitializeComponent();
            foreach (Control c in Controls)
                c.Font = new Font(Data.RuntimeSettings.DefaultFont, 10, FontStyle.Regular);
            Label.Font = new Font(Data.RuntimeSettings.DefaultFont, 12, FontStyle.Regular);
            Text = Application.ProductName;            
        }

        /*async Task<EngineData> LoadData() {
            EngineData dummy = new EngineData();
            await Task.Factory.StartNew(delegate {
                using (WebClient wc = new WebClient()) {
                    dummy = JsonSerializer.Deserialize<EngineData>(wc.DownloadStringTaskAsync("https://raw.githubusercontent.com/The-Architect01/Dungeons-and-Dragons-Player-Maker/master/Test.json").Result, new JsonSerializerOptions() { IncludeFields = true, WriteIndented = true });
                    dummy.SplashImageBase64 

                }
            });
            
        }*/

        private void UpdateBox_Load(object sender, EventArgs e) {
            //await LoadData();
        }
    }
}
