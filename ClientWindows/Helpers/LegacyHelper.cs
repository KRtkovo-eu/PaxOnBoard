using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace PaxOnBoard.Client.Windows.Helpers
{
    public static class LegacyHelper
    {
        public enum MSFSinstallation
        {
            undefined,
            NotInstalled,
            MSStore,
            Steam
        }

        // The file is called userCfg.opt and the last line shows where you put the content folder and the community folder is inside that. InstalledPackagesPath

        /// <summary>
        /// Checks if the Microsoft Flight Simulator 2020 is installed.
        /// This function looks for the MSFS 2020 config path:<br />
        /// Config path for Steam Edition: “%AppData%\Microsoft Flight Simulator”<br />
        /// Config path for MS Edition: C:\Users[user name]\AppData\Local\Packages\Microsoft.FlightSimulator_8wekyb3d8bbwe\LocalCache<br />
        /// </summary>
        /// <returns></returns>
        public static MSFSinstallation CheckMSFSinstallation()
        {
            if(System.IO.Directory.Exists($@"{Environment.ExpandEnvironmentVariables("%localappdata%")}\Packages\Microsoft.FlightSimulator_8wekyb3d8bbwe\LocalCache"))
            {
                return MSFSinstallation.MSStore;
            }
            else if(System.IO.Directory.Exists($@"{Environment.ExpandEnvironmentVariables("%appdata%")}\Microsoft Flight Simulator")) {
                return MSFSinstallation.Steam;
            }
            else
            {
                return MSFSinstallation.NotInstalled;
            }
        }

        public static bool CheckMSFSrunning()
        {
            return (System.Diagnostics.Process.GetProcessesByName("FlightSimulator").FirstOrDefault() != null);
        }

        public static void StartSimConnect()
        {
            if (!SimConnectHelper.SimConnectHelper.IsConnected)
            {
                var server = "localhost";
                var port = 500;
                
                IPAddress ipAddr = Dns.GetHostAddresses(server).FirstOrDefault(x => x.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
                EndPoint ep = new IPEndPoint(ipAddr, port);

                SimConnectHelper.SimConnectHelper.Connect(ep);
            }
        }

        public static void EndSimConnect()
        {
            if (SimConnectHelper.SimConnectHelper.IsConnected)
            {
                SimConnectHelper.SimConnectHelper.Disconnect();
            }
        }
    }
}
