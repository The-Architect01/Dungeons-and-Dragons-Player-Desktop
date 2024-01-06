//System Imports
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

using PlayerEngine.Custom_Elements.Play_Engine_Elements;

//Custom Imports
using PlayerEngine.Data;
using PlayerEngine.Forms.Pop_Ups;

namespace PlayerEngine.Forms {
    public partial class PlayEngine : Form {

        private Character PC;

        public PlayEngine() {
            InitializeComponent();
        }
        public PlayEngine(Character PC) {
            this.PC = PC;
            InitializeComponent();
            ShowPlayer();
        }
        public PlayEngine(string PCSave) {
            InitializeComponent();
            PC = JsonSerializer.Deserialize<Character>(File.ReadAllText(PCSave));
            ShowPlayer();
        }


        private void ShowPlayer() {
            Display.Controls.Clear();
            // Check if Office is installed, if not then remove the print option as this will be how we will print/export
            printToolStripMenuItem.Visible = (Type.GetTypeFromProgID("PowerPoint.Application") != null);

            try { CharacterPreview.Image = (Image)new ImageConverter().ConvertFrom(Convert.FromBase64String(PC.Illustration)); } catch { }
            foreach (Control c in Controls)
                c.Visible = true;

            CharName.Text = $"{PC.Name} {(!string.IsNullOrEmpty(PC.Pronouns) ? $"({PC.Pronouns})" : "")}";
            Summary.Text = $"Level {PC.Level}{(PC.Alignment == Alignment.Unaligned ? "" : " " + PC.Alignment.ToString().Replace("_"," ")) + " "}{PC.Class[0].SubClass} {PC.Class[0].BaseClass}";
            
            BackColor = unchecked(Color.FromArgb((int)(uint)Enum.Parse(typeof(ClassColors), PC.Class[0].BaseClass)));

            Display.Controls.Add(new SummaryMenu(PC));
            Display.Controls.Add(new ActionMenu(PC));
            Display.Controls.Add(new TraitsMenu(PC));
            Display.Controls.Add(new RichTextBox() { Dock = DockStyle.Fill, Text = PC.Inventory.ToString(true) });
            Display.Controls.Add(new BackgroundViewer(PC));
            Display.Controls.Add(new RichTextBox() { Dock = DockStyle.Fill });
            //((RichTextBox)Display.Controls[(int)View.Inventory]).TextChanged += OnRTFEdit;
            //((RichTextBox)Display.Controls[(int)View.Notes]).TextChanged += OnRTFEdit;
        }

        void OnRTFEdit(object sender, EventArgs e) {
            int cursor = ((RichTextBox)sender).SelectionStart;
            try {
               ((RichTextBox)sender).Rtf = ((RichTextBox)sender).Text;
                ((RichTextBox)sender).SelectionStart = cursor;
            } catch { } finally {
                ((RichTextBox)sender).SelectionStart = cursor;
            }
        }


        private void PlayEngine_FormClosed(object sender, FormClosedEventArgs e) {
            Program.MM.Show();
        }

        private void ChooseCharacter_SelectedIndexChanged(object sender, EventArgs e) {
            ToolStripComboBox caller = (ToolStripComboBox)sender;
            printToolStripMenuItem.Visible = false;

            if (caller.SelectedIndex == -1) return;
            if (caller.Text == "Choose Character") return;
            if (caller.Text == "Characters" || caller.Text == "Adopted") { caller.Text = "Choose Character"; caller.DroppedDown = true; BeginInvoke(delegate (object sender) { caller.Text = "Choose Character"; }, sender);
                return; }
            
            try {
                PC = JsonSerializer.Deserialize<Character>(File.ReadAllText($"{Engine.SaveFileLocation}Characters\\{caller.Text.Trim()}.hro"));
            } catch {
                PC = JsonSerializer.Deserialize<Character>(File.ReadAllText($"{Engine.SaveFileLocation}Characters\\Adoptables\\{caller.Text.Trim()}.hro"));
            }
            ShowPlayer();

            BeginInvoke(delegate (object sender) { caller.Text = "Choose Character"; CharName.Focus(); }, sender);
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e) { CharacterExporter.Export(PC); }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void PlayEngine_Load(object sender, EventArgs e) {
            foreach (Control c in Controls)
                if (c.GetType() != typeof(Panel))
                    c.Font = new Font(RuntimeSettings.DefaultFont, 10, FontStyle.Regular);

            CharName.Font = new Font(RuntimeSettings.DefaultFont, 24, FontStyle.Bold);
            Summary.Font = new Font(RuntimeSettings.DefaultFont, 12, FontStyle.Italic);

            Font TabFont = new Font(RuntimeSettings.DefaultFont, 11, FontStyle.Regular);

            SummaryTab.Font = ActionTab.Font = BackgroundTab.Font = InventoryTab.Font = NotesTab.Font = TraitsTab.Font = TabFont;

            // Update List of Characters
            ChooseCharacter.Items.Add("Characters");
            
            foreach (string m in Directory.GetFileSystemEntries(Engine.SaveFileLocation + "Characters")) if(Path.GetExtension(m) == ".hro") ChooseCharacter.Items.Add("  " + m.Replace(Engine.SaveFileLocation + "Characters\\", "").TrimEnd(".hro".ToCharArray()));

            if (Directory.GetFileSystemEntries(Engine.SaveFileLocation + "Characters\\Adoptables\\").Where(file => Path.GetExtension(file) == ".hro").Count() != 0) ChooseCharacter.Items.Add("Adopted");
            foreach (string m in Directory.GetFileSystemEntries(Engine.SaveFileLocation + "Characters\\Adoptables\\")) if (Path.GetExtension(m) == ".hro") ChooseCharacter.Items.Add("  " + m.Replace(Engine.SaveFileLocation + "Characters\\Adoptables\\", "").TrimEnd(".hro".ToCharArray()));
            
        }

        enum View { Summary, Actions, Traits, Inventory, Background, Notes }
        void SwitchView(View view) {
            SummaryTab.BackColor = view == View.Summary ? Engine.SelectedColor : Engine.InactiveColor;
            ActionTab.BackColor = view == View.Actions ? Engine.SelectedColor : Engine.InactiveColor;
            BackgroundTab.BackColor = view == View.Background ? Engine.SelectedColor : Engine.InactiveColor;
            InventoryTab.BackColor = view == View.Inventory ? Engine.SelectedColor : Engine.InactiveColor;
            NotesTab.BackColor = view == View.Notes ? Engine.SelectedColor : Engine.InactiveColor;
            TraitsTab.BackColor = view == View.Traits ? Engine.SelectedColor : Engine.InactiveColor;
            for (int i = 0; i < Display.Controls.Count; i++)
                Display.Controls[i].Visible = (int)view == i;
        }
        private void SummaryTab_Click(object sender, EventArgs e) { SwitchView(View.Summary); }

        private void ActionTab_Click(object sender, EventArgs e) { SwitchView(View.Actions); }
        
        private void TraitsTab_Click(object sender, EventArgs e) { SwitchView(View.Traits); }

        private void InventoryTab_Click(object sender, EventArgs e) { SwitchView(View.Inventory); }

        private void BackgroundTab_Click(object sender, EventArgs e) { SwitchView(View.Background); }

        private void NotesTab_Click(object sender, EventArgs e) { SwitchView(View.Notes); }

        private void Roll_Click(object sender, EventArgs e)   { new RollDice().ShowDialog(); }
    }
}