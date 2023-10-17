using System;
using System.Windows.Forms;

using PlayerEngine.Forms.Pop_Ups;

class Program {

    ///<summary>The main menu referrence</summary>
    public static PlayerEngine.Forms.MainMenu MM;

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main(string[] args) {
        PlayerEngine.Data.RuntimeSettings.Update();
        
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        Application.Run(new PlayerEngine.Forms.Splash());
        MM = new PlayerEngine.Forms.MainMenu();

        try {
            string[] Args = AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData;
            if (Args != null) foreach (string arg in Args) if (arg.Contains(".hro")) Application.Run(new PlayerEngine.Forms.PlayEngine(arg));
        } catch {
            try {
                if (args != null) foreach (string arg in args) if (arg.Contains(".hro")) Application.Run(new PlayerEngine.Forms.PlayEngine(arg));
            } catch { }
        }
        
        Application.Run(MM);
    }
}