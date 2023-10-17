using System;
using System.Diagnostics;
using System.Drawing;
using System.Text.Json;
using System.Windows.Forms;
using PlayerEngine.Data;
using PlayerEngine.Data.APIs;

namespace PlayerEngine.Custom_Elements.Previews {
    public partial class HomebrewBook : UserControl {
        readonly Homebrew Data;
        readonly GitIssue DownloadLink;

        public HomebrewBook(Homebrew homebrew, GitIssue URL) {
            InitializeComponent();

            Data = homebrew;
            Title.Font = new Font(RuntimeSettings.DefaultFont, 13, FontStyle.Bold);
            Description.Font = new Font(RuntimeSettings.DefaultFont, 9);
            Download.Font = new Font(RuntimeSettings.DefaultFont, 9);
            Report.Font = new Font(RuntimeSettings.DefaultFont, 9, FontStyle.Underline);
            Report.ForeColor = Color.Red;
            Creator.Font = new Font(RuntimeSettings.DefaultFont, 9);

            Title.Text = Data.Name;
            Description.Text = URL.Body.Split('[')[0];
            DownloadLink = URL;
            Creator.Text = $"Created by {(!string.IsNullOrEmpty(homebrew.Creator) ? homebrew.Creator : URL.User.Login)}";


            if (System.IO.File.Exists($"{Engine.SaveFileLocation + "Homebrews\\"}{homebrew.Name}.hro")) {
                Download.Text = "Installed";
                Download.Enabled = false;
            }
        }

        private void Report_Click(object sender, EventArgs e) {
            string url = $"https://docs.google.com/forms/d/e/1FAIpQLSdjs772yqRcp66yohixsd7T-xAZGrBHgHUmk9Bp21G_eYeUaw/viewform?usp=pp_url&entry.279450828={DownloadLink.Html_url}";
            Process.Start("msedge", $"--new-window {url}");
            System.IO.File.Delete($"{Engine.SaveFileLocation + "Homebrews\\"}{Data.Name}.brew");
            System.IO.File.AppendAllText($"{Engine.SaveFileLocation}Cache\\Blocked", DownloadLink.Html_url);
            Dispose();
        }

        private void Download_Click(object sender, EventArgs e) {
            System.IO.File.WriteAllText($"{Engine.SaveFileLocation + "Homebrews\\"}{Data.Name}.brew", JsonSerializer.Serialize(Data, Engine.JsonSerializerOptions));
            Download.Text = "Installed";
            Download.Enabled = false;
        }
    }
}
