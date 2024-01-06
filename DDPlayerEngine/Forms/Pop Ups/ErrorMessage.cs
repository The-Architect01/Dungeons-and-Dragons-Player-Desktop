using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PlayerEngine.Data;
using PlayerEngine.Properties;

namespace PlayerEngine.Forms.Pop_Ups {
    public partial class ErrorMessage : Form {


        public ErrorMessage(Exception error) {
            InitializeComponent();
            //pictureBox1.Image = (Image)ne ImageConverter().ConvertFrom(Convert.FromBase64String());
            Text = Application.ProductName;
            WarnTitle.Font = new Font(RuntimeSettings.DefaultFont, 12, FontStyle.Bold);
            WarnTitle.Text = $"Uh oh, {error.GetType().Name} occurred";
            WarnMessage.Font = new Font(RuntimeSettings.DefaultFont, 10);
            label1.Font = new Font(RuntimeSettings.DefaultFont, 12, FontStyle.Bold);
            WarnMessage.Text = "That wasn't supposed to happen. It seems our backend dragon fell asleep again.\nI rely on user submitted bug reports to fix issues. \nIn your report please include the following information:\n*  The exception report below\n*  A detailed account of what happened (the more information the better)";
            richTextBox1.Text = $"An exception ({error.GetType().Name}) occurred.\n\n\tMessage:\n\n\t{error.Message}\n\nStack Trace:\n\t{error.StackTrace}";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            linkLabel1.LinkVisited = true;
            Process.Start("msedge", $"--new-window https://github.com/The-Architect01/Dungeons-and-Dragons-Player-Desktop/issues/new?assignees=&labels=bug&projects=&template=Bug+Report.md&title=BUG+REPORT%3A+%5BBUG+NAME%5D");
        }

    }
}
