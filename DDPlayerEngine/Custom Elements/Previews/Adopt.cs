using System;
using System.Diagnostics;
using System.Drawing;
using System.Text.Json;
using System.Windows.Forms;

using PlayerEngine.Data;
using PlayerEngine.Data.APIs;

namespace PlayerEngine.Custom_Elements.Previews {
    public partial class Adopt : UserControl {
        readonly GitIssue DownloadLink;
        readonly Character Character;
        public Adopt(Character character, GitIssue url) {
            InitializeComponent();
            Character = character;
            CharName.Font = new Font(RuntimeSettings.DefaultFont, 13, FontStyle.Bold);
            Summary.Font = new Font(RuntimeSettings.DefaultFont, 10, FontStyle.Italic);
            Report.Font = new Font(RuntimeSettings.DefaultFont, 9, FontStyle.Underline);
            Report.ForeColor = Color.Red;
            Download.Font = View.Font = Description.Font = CreatedBy.Font = new Font(RuntimeSettings.DefaultFont, 9);

            CharName.Text = character.Name;
            Description.Text = url.Body.Split('[')[0];
            Preview.Image = (Image)new ImageConverter().ConvertFrom(Convert.FromBase64String(character.Illustration));
            Summary.Text = $"Level {character.Level}{(character.Alignment == Alignment.Unaligned ? "" : " " + character.Alignment.ToString().Replace("_", " ")) + " "}" +
                $"{character.Class[0].SubClass} {character.Class[0].BaseClass}"; 
            DownloadLink = url;
            CreatedBy.Text = $"Created by {(!string.IsNullOrEmpty(Character.CreatorName) ? Character.CreatorName : url.User.Login)}";


            if (System.IO.File.Exists($"{Engine.SaveFileLocation + "Characters\\Adoptables\\"}{Character.Name}.hro")) {
                Download.Text = "Installed";
                Download.Enabled = false;
            }
        }

        private void Download_Click(object sender, EventArgs e) {
            System.IO.File.WriteAllText($"{Engine.SaveFileLocation + "Characters\\Adoptables\\"}{Character.Name} ({Character.Class[0].SubClass} {Character.Class[0].BaseClass}).hro", JsonSerializer.Serialize(Character, Engine.JsonSerializerOptions)); 
            Download.Text = "Installed";
            Download.Enabled = false;
        }

        private void Report_Click(object sender, EventArgs e) {
            string url = $"https://docs.google.com/forms/d/e/1FAIpQLSdjs772yqRcp66yohixsd7T-xAZGrBHgHUmk9Bp21G_eYeUaw/viewform?usp=pp_url&entry.279450828={DownloadLink.Html_url}";
            Process.Start("msedge", $"--new-window {url}");
            System.IO.File.Delete($"{Engine.SaveFileLocation + "Characters\\Adoptables\\"}{Character.Name}.hro");
            System.IO.File.AppendAllText($"{Engine.SaveFileLocation}Cache\\Blocked", DownloadLink.Html_url);
            Dispose();
        }

        private void View_Click(object sender, EventArgs e) {
            Forms.PlayEngine view = new(Character);
            view.Text = $"{Character.Name} Preview";
            view.Controls["menuStrip1"].Visible = false;
            view.ShowDialog();
        }
    }
}
