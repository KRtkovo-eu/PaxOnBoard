using System.Windows.Forms;

namespace PaxOnBoard
{
    public partial class AboutWindow : Form
    {
        public AboutWindow()
        {
            InitializeComponent();
            this.Text = $"{ApplicationInit.Language.ToolWindows.AboutWindowTitle}";
            lblAppVersion.Text = $"{ApplicationInit.Language.ToolWindows.AppVersionLbl} {Application.ProductVersion}{Helpers.AppHelper.AppVersionFlavour}";
            lblAppAuthor.Text = $"{ApplicationInit.Language.ToolWindows.AppAuthorLbl} {Application.CompanyName}";
        }

        private void lblPaxOnBoardUrl_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start("https://paxonboard.pro/");
        }
    }
}
