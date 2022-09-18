using System;
using System.Windows.Forms;

namespace PaxOnBoard.Lang
{
    internal class en_US : Language
    {
        internal class ToolWindows : Language.ToolWindows
        {
            public override string SimulationManagerTitle => "Simulation Manager";
            public override string AboutWindowTitle => $"About {Application.ProductName}";
            public override string AppVersionLbl => "Version:";
            public override string AppAuthorLbl => "Author:";
            public override string WarningBeforeSettingsResetCaption => "Are you sure?";
            public override string WarningBeforeSettingsResetMessage => $"Do you really want to reset application settings?{Environment.NewLine}" +
                $"{Environment.NewLine}" +
                $"This action will erase all saved settings to its default values and application will be restarted.{Environment.NewLine}" +
                $"It will also log out your account. All uploaded statistics will remain on server and will be synchronized after you log in again.";
            public override string MenuOptions => "&Options";
            public override string MenuOptionsLanguage => "Select &Language";
            public override string MenuOptionsResetSettings => "&Reset settings to default";
            public override string MenuHelp => "&Help";
            public override string MenuHelpAbout => $"&About {Application.ProductName}";
            public override string MenuHelpReportProblem => "&Report a Problem";
            public override string MenuHelpCheckUpdate => "Check for &Update";
            public override string MenuHelpPobWebsite => "Visit our &Website";
        }

        internal class PilotProfileBox : Language.PilotProfileBox
        {
            public override string Title => "Captain profile";
            public override string PilotNameLbl => "Name:";
            public override string HiredByCompanyLbl => "Hired by:";
            public override string HiredByNoCompanyDefVal => "freelancer";
            public override string PilotPointsLbl => "Pilot points:";
            public override string HoursFlownLbl => "Hours flown:";
            public override string TotalPaxTransportedLbl => "Total pax transported:";
            public override string ToolTipTotalPaxTransported => "Total count of pax successfully transported to their final destination.";
        }

        internal class AircraftInfoBox : Language.AircraftInfoBox
        {
            public override string Title => "Aircraft details";
            public override string Manufacturer => "Manufacturer:";
            public override string AircraftModel => "Model:";
            public override string Livery => "Livery:";
            public override string Callsign => "Callsign:";
            public override string TailNumber => "Tail number:";
        }

        internal class LoginBox : Language.LoginBox
        {
            public override string Username => "E-mail:";
            public override string Password => "Password:";
            public override string Login => "Log in";
            public override string Logout => "Log out";
            public override string Cancel => "Cancel";
        }

        internal class Status : Language.Status
        {
            public override string MSFSnotDetected => "MSFS 2020 not detected";
            public override string InstallMSFS => "To use this tool, you have to install and run MSFS 2020.";
            public override string FlightNotStarted => "Start the flight in the game.";
            public override string SimulationNotRunning => "Simulation is not running. First, start the MSFS 2020.";
            
        }

        internal class PreflightSettings : Language.PreflightSettings
        {
            public override string NotRunningWelcomeMessage => $"Airports are bursting at the seams and need your help to transport passengers.{Environment.NewLine}" +
                Environment.NewLine +
                Environment.NewLine +
                $"Join the PaxOnBoard community, transport passengers, earn points and become the best pilot!{Environment.NewLine}" +
                $"You can also set up your own virtual airline with friends and collect points together.{Environment.NewLine}" +
                Environment.NewLine +
                $"Fly on your own routes or fulfill global orders. As the number of successfully transported passengers increases, more and more lucrative orders will be unlocked.{Environment.NewLine}" +
                Environment.NewLine +
                Environment.NewLine +
                $"---------------------------------------------------------------------{Environment.NewLine}" +
                Environment.NewLine +
                Environment.NewLine +
                $"PaxOnBoard is a must-have addition for all MSFS 2020 players who want to experience the atmosphere of a commercial airline pilot.";
            public override string ProceedButton => "Proceed";
            public override string WelcomeMessage => $"Welcome captain!{Environment.NewLine}" +
                Environment.NewLine +
                $"Before we can start boarding passengers to the aircraft, you have to adjust some flight details that we couldn't grab directly from the game.{Environment.NewLine}" +
                $"Please check all values below and then click on {ProceedButton} button.";
        }
    }
}
