namespace PaxOnBoard.Lang
{
    internal abstract class Language
    {
        internal abstract class ToolWindows
        {
            public abstract string SimulationManagerTitle { get; }
            public abstract string AboutWindowTitle { get; }
            public abstract string AppVersionLbl { get; }
            public abstract string AppAuthorLbl { get; }
            public abstract string WarningBeforeSettingsResetCaption { get; }
            public abstract string WarningBeforeSettingsResetMessage { get; }
            public abstract string MenuOptions { get; }
            public abstract string MenuOptionsResetSettings { get; }
            public abstract string MenuOptionsLanguage { get; }
            public abstract string MenuHelp { get; }
            public abstract string MenuHelpAbout { get; }
            public abstract string MenuHelpReportProblem { get; }
            public abstract string MenuHelpPobWebsite { get; }
            public abstract string MenuHelpCheckUpdate { get; }
        }

        internal abstract class PilotProfileBox
        {
            public abstract string Title { get; }
            public abstract string PilotNameLbl { get; }
            public abstract string HiredByCompanyLbl { get; }
            public abstract string HiredByNoCompanyDefVal { get; }
            public abstract string PilotPointsLbl { get; }
            public abstract string HoursFlownLbl { get; }
            public abstract string TotalPaxTransportedLbl { get; }
            public abstract string ToolTipTotalPaxTransported { get; }
        }

        internal abstract class AircraftInfoBox
        {
            public abstract string Title { get; }
            public abstract string Manufacturer { get; }
            public abstract string AircraftModel { get; }
            public abstract string Livery { get; }
            public abstract string Callsign { get; }
            public abstract string TailNumber { get; }
        }

        internal abstract class LoginBox
        {
            public abstract string Username { get; }
            public abstract string Password { get; }
            public abstract string Login { get; }
            public abstract string Logout { get; }
            public abstract string Cancel { get; }
        }

        internal abstract class Status
        {
            public abstract string MSFSnotDetected { get; }
            public abstract string InstallMSFS { get; }
            public abstract string FlightNotStarted { get; }
            public abstract string SimulationNotRunning { get; }

        }

        internal abstract class PreflightSettings
        {
            public abstract string NotRunningWelcomeMessage { get; }
            public abstract string ProceedButton { get; }
            public abstract string WelcomeMessage { get; }
        }
    }
}
