using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaxOnBoard.Lang
{
    internal static class en_US
    {
        internal static class ToolWindows
        {
            public static string SimulationManagerTitle = "Simulation Manager";
        }

        internal static class PilotProfileBox
        {
            public static string Title = "Captain profile";
            public static string PilotNameLbl = "Name:";
            public static string HiredByCompanyLbl = "Hired by:";
            public static string HiredByNoCompanyDefVal = "freelancer";
            public static string PilotPointsLbl = "Pilot points:";
            public static string HoursFlownLbl = "Hours flown:";
            public static string TotalPaxTransportedLbl = "Total pax transported:";
            public static string ToolTipTotalPaxTransported = "Total count of pax successfully transported to their final destination.";
        }

        internal static class AircraftInfoBox
        {
            public static string Title = "Aircraft details";
        }

        internal static class Status
        {
            public static string MSFSnotDetected = "MSFS 2020 not detected";
            public static string InstallMSFS = "To use this tool, you have to install and run MSFS 2020.";
            public static string FlightNotStarted = "Start the flight in the game.";
            public static string SimulationNotRunning = "Simulation is not running. First, start the MSFS 2020.";
            
        }
    }
}
