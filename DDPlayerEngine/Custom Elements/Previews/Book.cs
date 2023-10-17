using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

using PlayerEngine.Data;
using PlayerEngine.Data.APIs;

namespace PlayerEngine.Custom_Elements.Previews {
    public partial class Book : UserControl {
        readonly GitFile DownloadLink;
        public Book(Data.Book sbk, GitFile url) {
            InitializeComponent();
            Title.Text = sbk.Name;
            Description.Text = sbk.Description;
            Title.Font = new Font(RuntimeSettings.DefaultFont, 12, FontStyle.Bold);
            Description.Font = new Font(RuntimeSettings.DefaultFont, 9);
            Download.Font = new Font(RuntimeSettings.DefaultFont, 9);
            
            DownloadLink = url;

            if (System.IO.File.Exists($"{Engine.SaveFileLocation + "Cache\\Books\\"}{DownloadLink.Name}")) {
                Download.Text = "Installed";
                Download.Enabled = false;
            }
        }

        private void Download_Click(object sender, EventArgs e) {
            new WebClient().DownloadFile(DownloadLink.Download_url, $"{Engine.SaveFileLocation + "Cache\\Books\\"}{DownloadLink.Name}");
            Download.Text = "Installed";
            Download.Enabled = false;
        }
    }
}
