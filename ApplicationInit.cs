using System;
using System.Windows.Forms;

namespace PaxOnBoard
{
    static class ApplicationInit
    {
        internal static class Language
        {
            internal static Lang.Language.ToolWindows ToolWindows;
            internal static Lang.Language.AircraftInfoBox AircraftInfoBox;
            internal static Lang.Language.LoginBox LoginBox;
            internal static Lang.Language.PilotProfileBox PilotProfileBox;
            internal static Lang.Language.PreflightSettings PreflightSettings;
            internal static Lang.Language.Status Status;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Set application to the user defined language
            Lang.Translation.AvailableLanguages savedLanguage = (Lang.Translation.AvailableLanguages)Properties.Settings.Default.UserLanguage;
            Lang.Translation.SetAppLanguage(savedLanguage);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ManagerWindow());
        }
    }
}
