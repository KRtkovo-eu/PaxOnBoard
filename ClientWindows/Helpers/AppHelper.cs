using System.Diagnostics;

namespace PaxOnBoard.Client.Windows.Helpers
{
    public static class AppHelper
    {
        public static string AppVersionFlavour = "-alpha";

        public static void OpenUrl(string url)
        {
            if(!String.IsNullOrEmpty(url))
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
    }
}
