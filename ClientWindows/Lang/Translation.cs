namespace PaxOnBoard.Client.Windows.Lang
{
    public class Translation
    {
        /// <summary>
        /// Add all available languages here.
        /// </summary>
        public enum AvailableLanguages
        {
            en_US,

        }

        /// <summary>
        /// Set language object to the selected language.
        /// </summary>
        /// <param name="selectedLanguage"></param>
        public static void SetAppLanguage(AvailableLanguages selectedLanguage = AvailableLanguages.en_US)
        {
            switch (selectedLanguage)
            {
                default:
                    ApplicationInit.Language.AircraftInfoBox = new en_US.AircraftInfoBox();
                    ApplicationInit.Language.ToolWindows = new en_US.ToolWindows();
                    ApplicationInit.Language.AircraftInfoBox = new en_US.AircraftInfoBox();
                    ApplicationInit.Language.LoginBox = new en_US.LoginBox();
                    ApplicationInit.Language.PilotProfileBox = new en_US.PilotProfileBox();
                    ApplicationInit.Language.PreflightSettings = new en_US.PreflightSettings();
                    ApplicationInit.Language.Status = new en_US.Status();
                    break;
            }
        }
    }
}
