using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;

using PlayerEngine.Data;
using PlayerEngine.Data.APIs;

namespace PlayerEngine.Forms {
    public partial class InstallHomebrew : Form {

        public enum View { OfficialBooks, Adoptables, Homebrews }
        public InstallHomebrew(View openview = View.OfficialBooks) {
            InitializeComponent();
            foreach (Control c in Controls)
                c.Font = new Font(RuntimeSettings.DefaultFont, 12, FontStyle.Regular);
            if (openview == View.OfficialBooks) OfficalBooks_Click(null, null);
            if (openview == View.Adoptables) Adopt_Click(null, null);
            if (openview == View.Homebrews) Homebrew_Click(null, null);
        }

        private void OfficalBooks_Click(object sender, EventArgs e) { SwitchView(View.OfficialBooks); }

        private void Adopt_Click(object sender, EventArgs e) { SwitchView(View.Adoptables); }

        private void Homebrew_Click(object sender, EventArgs e) { SwitchView(View.Homebrews); }

        void SwitchView(View view) {
            OfficialBookView.Visible = view == View.OfficialBooks;
            AdoptCharacterView.Visible = view == View.Adoptables;
            HomebrewBookView.Visible = view == View.Homebrews;

            OfficalBooks.BackColor = view == View.OfficialBooks ? Engine.SelectedColor : Engine.InactiveColor;
            Adopt.BackColor = view == View.Adoptables ? Engine.SelectedColor : Engine.InactiveColor;
            Homebrew.BackColor = view == View.Homebrews ? Engine.SelectedColor : Engine.InactiveColor;
        }

        private void InstallHomebrew_Load(object sender, EventArgs e) {
            PopulateOfficialBooks();
            PopulateAdoptables();
            PopulateHomebrews();
        }

        public void PopulateAdoptables() {
            WebClient wc = new();
            using HttpClient client = new();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.UserAgent.TryParseAdd("request");

            using HttpResponseMessage response = client.GetAsync("https://api.github.com/repos/The-Architect01/Dungeons-and-Dragons-Player-Desktop/issues?label=Adopt&label!=FLAGGED").Result;
            response.EnsureSuccessStatusCode();
            var responseBody = response.Content.ReadAsStringAsync().Result;

            List<GitIssue> adoptables = JsonSerializer.Deserialize<List<GitIssue>>(responseBody, Engine.JsonSerializerOptions);

            foreach (GitIssue issue in adoptables) {
                if (File.ReadAllText($"{Engine.SaveFileLocation}Cache\\Blocked").Contains(issue.Html_url)) continue;
                wc.DownloadFile(issue.Body.Substring(issue.Body.IndexOf(".zip")).TrimStart(".zip](".ToCharArray()).TrimEnd(")\r\n".ToCharArray()), $"{Path.GetTempPath()}TempDDFile.zip");
                using ZipArchive zip = ZipFile.Open($"{Path.GetTempPath()}TempDDFile.zip", ZipArchiveMode.Read);
                foreach (ZipArchiveEntry file in zip.Entries) {
                    if (file.FullName.EndsWith(".hro")) {
                        AdoptCharacterView.Controls.Add(new Custom_Elements.Previews.Adopt(JsonSerializer.Deserialize<Character>(file.Open(), Engine.JsonSerializerOptions), issue));
                        return;
                    }
                }

            }
        }

        public void PopulateHomebrews() {
            List<GitIssue> brews;
            try {
                using HttpClient client = new();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.UserAgent.TryParseAdd("request");

                using HttpResponseMessage response  = client.GetAsync("https://api.github.com/repos/The-Architect01/Dungeons-and-Dragons-Player-Desktop/issues?labels=Homebrews&label!=FLAGGED").Result;
                response.EnsureSuccessStatusCode();
                var responseBody = response.Content.ReadAsStringAsync().Result;
                brews = JsonSerializer.Deserialize<List<GitIssue>>(responseBody, Engine.JsonSerializerOptions);
            } catch (HttpRequestException) {
                Debug.WriteLine("Either device is online or rate limit exceeded. Proceeding with cache.");
                brews = JsonSerializer.Deserialize<List<GitIssue>>(File.ReadAllText(Engine.SaveFileLocation + "Cache\\Homebrews\\cache"), Engine.JsonSerializerOptions);
            }
            foreach (GitIssue issue in brews) {
                    AdoptCharacterView.Controls.Add(new Custom_Elements.Previews.Book(null, null));
                  
                }
            
        }

        public void PopulateOfficialBooks() {
            WebClient wc = new();
            using HttpClient client = new();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.UserAgent.TryParseAdd("request");
            using HttpResponseMessage response = client.GetAsync("https://api.github.com/repos/The-Architect01/Dungeons-and-Dragons-Player-Desktop/contents/Books").Result;

            response.EnsureSuccessStatusCode();
            var responseBody = response.Content.ReadAsStringAsync().Result;
            List<GitFile> books = JsonSerializer.Deserialize<List<GitFile>>(responseBody, Engine.JsonSerializerOptions);
            foreach (GitFile file in books) {
                OfficialBookView.Controls.Add(new Custom_Elements.Previews.Book(JsonSerializer.Deserialize<Book>(wc.DownloadString(file.Download_url), Engine.JsonSerializerOptions), file));
            }
        }
    }
}
