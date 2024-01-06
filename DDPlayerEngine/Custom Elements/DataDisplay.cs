using System;
using System.Linq;
using System.Windows.Forms;

using PlayerEngine.Data;

namespace PlayerEngine.Custom_Elements {
    /// <summary>
    /// 
    /// </summary>
    public partial class DataDisplay : RichTextBox {

        /// <summary>
        /// 
        /// </summary>
        public DisplaySetting DisplaySetting;

        /// <summary>
        /// Creates a new DataDisplay Control
        /// </summary>
        public DataDisplay() : base() {
            InitializeComponent();
            SetStyle(ControlStyles.Selectable, false);
            SetStyle(ControlStyles.UserMouse, true);
        }

        private void DataDisplay_MouseClick(object sender, MouseEventArgs e) {
            string CHARS = ":,;.\n\t0123456789\v\t\0";

            for (int i = GetCharIndexFromPosition(e.Location) - 1; i >= 0; i--) {
                if (CHARS.Contains(Text[i])) {
                    int length = Text.IndexOfAny(CHARS.ToCharArray(), GetCharIndexFromPosition(e.Location)) - (i+2);
                    length = length < 0 ? TextLength - (i + 2) : length;

                    string text = Text.Substring(i+1, length+1).Trim();
                    switch (DisplaySetting) {
                        case DisplaySetting.Background:
                            foreach (Book b in RuntimeSettings.EngineData.Books) {
                                foreach (Background bg in b.Backgrounds) {
                                    //if (bg.FindData(text) != "")
                                        //MessageBox.Show(bg.FindData(text), Application.ProductName + " Help");
                                }
                            }
                            break;
                        case DisplaySetting.Lineage:
                            foreach (Book b in RuntimeSettings.EngineData.Books) {
                                foreach (Lineage r in b.Lineages) {
                                    //if (r.FindData(text) != "")
                                        //MessageBox.Show(r.FindData(text), Application.ProductName + " Help");
                                }
                            }
                            break;
                        case DisplaySetting.Class:
                            foreach (Book b in RuntimeSettings.EngineData.Books) {
                                foreach (Class cl in b.Classes) {
                                    //if (cl.FindData(text) != "")
                                        //MessageBox.Show(cl.FindData(text), Application.ProductName + " Help");
                                }
                            }
                            break;
                    }
                    return;
                }
            }
        }

    }

    /// <summary>
    /// An enum to represent the different data displays
    /// </summary>
    public enum DisplaySetting {
        /// <summary>
        /// Displays Lineage Data
        /// </summary>
        Lineage,
        /// <summary>
        /// Displays Class Data
        /// </summary>
        Class,
        /// <summary>
        /// Displays Background Data
        /// </summary>
        Background,
        /// <summary>
        /// Displays Item data
        /// </summary>
        Item,
        /// <summary>
        /// Displays Spell Data
        /// </summary>
        Spell
    }
}