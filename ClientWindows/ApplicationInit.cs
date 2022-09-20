using PaxOnBoard.Client.Windows.Forms;

namespace PaxOnBoard.Client.Windows
{
    internal static class ApplicationInit
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
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Set application to the user defined language
            Lang.Translation.AvailableLanguages savedLanguage = (Lang.Translation.AvailableLanguages)Properties.Settings.Default.UserLanguage;
            Lang.Translation.SetAppLanguage(savedLanguage);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new ManagerWindow());
        }
    }
}