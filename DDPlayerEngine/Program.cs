using System;
using System.Windows.Forms;

static class Program {

    ///<summary>The main menu referrence</summary>
    public static PlayerEngine.Forms.MainMenu MM;

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
        PlayerEngine.Data.RuntimeSettings.Update();
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        Application.Run(new PlayerEngine.Forms.Splash());
        MM = new PlayerEngine.Forms.MainMenu();
        Application.Run(MM);
    }
}