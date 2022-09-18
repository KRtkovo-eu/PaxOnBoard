using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaxOnBoard.Helpers;
using PaxOnBoard.Helpers.Common;

namespace PaxOnBoard
{
    public partial class ManagerWindow : Form
    {
        protected bool __settingsReset = false;

        private LegacyHelper.MSFSinstallation _msfsDetected = LegacyHelper.MSFSinstallation.undefined;
        private bool _msfsRunning = false;
        private bool _simInFlight = false;
        private bool _pilotLoggedIn = false;

        public ManagerWindow()
        {
            InitializeComponent();

            preflightBox.Dock = DockStyle.Fill;
            inflightBox.Dock = DockStyle.Fill;
            notRunningBox.Dock = DockStyle.Fill;

            // Initialize with language selected by user
            TranslateForm();

            CheckMsfsStatus(null, null);
            statusCheckTimer.Start();
        }

        /// <summary>
        /// Translates form to selected language.
        /// </summary>
        private void TranslateForm()
        {
            this.Text = $"{Application.ProductName} | {ApplicationInit.Language.ToolWindows.SimulationManagerTitle} {Application.ProductVersion}{Helpers.AppHelper.AppVersionFlavour}";

            pilotProfileBox.Text = ApplicationInit.Language.PilotProfileBox.Title;
            pilotProfileBoxNotInitialized.Text = ApplicationInit.Language.PilotProfileBox.Title;
            pilotProfileBoxLogin.Text = ApplicationInit.Language.PilotProfileBox.Title;

            lblLoginBoxUsername.Text = ApplicationInit.Language.LoginBox.Username;
            lblLoginBoxPassword.Text = ApplicationInit.Language.LoginBox.Password;
            btnLoginBoxOK.Text = _pilotLoggedIn ? ApplicationInit.Language.LoginBox.Logout : ApplicationInit.Language.LoginBox.Login;
            btnLoginBoxCancel.Text = ApplicationInit.Language.LoginBox.Cancel;

            lblPilotName.Text = ApplicationInit.Language.PilotProfileBox.PilotNameLbl;
            lblPilotHiredBy.Text = ApplicationInit.Language.PilotProfileBox.HiredByCompanyLbl;
            lblValPilotHiredBy.Text = ApplicationInit.Language.PilotProfileBox.HiredByNoCompanyDefVal;
            lblPilotPoints.Text = ApplicationInit.Language.PilotProfileBox.PilotPointsLbl;
            lblPilotTotalHoursFlown.Text = ApplicationInit.Language.PilotProfileBox.HoursFlownLbl;
            lblPilotTotalPaxTransported.Text = ApplicationInit.Language.PilotProfileBox.TotalPaxTransportedLbl;
            toolTipHelp.SetToolTip(lblPilotTotalPaxTransported, ApplicationInit.Language.PilotProfileBox.ToolTipTotalPaxTransported);
            toolTipHelp.SetToolTip(lblValPilotTotalPaxTransported, ApplicationInit.Language.PilotProfileBox.ToolTipTotalPaxTransported);

            aircraftInfoBox.Text = ApplicationInit.Language.AircraftInfoBox.Title;
            lblAircraftManufacturer.Text = ApplicationInit.Language.AircraftInfoBox.Manufacturer;
            lblAircraftModel.Text = ApplicationInit.Language.AircraftInfoBox.AircraftModel;
            lblAircraftLivery.Text = ApplicationInit.Language.AircraftInfoBox.Livery;
            lblAircraftCallsign.Text = ApplicationInit.Language.AircraftInfoBox.Callsign;
            lblAircraftTailNumber.Text = ApplicationInit.Language.AircraftInfoBox.TailNumber;

            lblPreflightWelcome.Text = ApplicationInit.Language.PreflightSettings.WelcomeMessage;
            btnPreflightProceed.Text = ApplicationInit.Language.PreflightSettings.ProceedButton;

            optionsToolStripMenuItem.Text = ApplicationInit.Language.ToolWindows.MenuOptions;
            resetSettingsToDefaultToolStripMenuItem.Text = ApplicationInit.Language.ToolWindows.MenuOptionsResetSettings;
            languageToolStripMenuItem.Text = ApplicationInit.Language.ToolWindows.MenuOptionsLanguage;
            helpStripMenuItem.Text = ApplicationInit.Language.ToolWindows.MenuHelp;
            reportAProblemToolStripMenuItem.Text = ApplicationInit.Language.ToolWindows.MenuHelpReportProblem;
            paxOnBoardWebsiteToolStripMenuItem.Text = ApplicationInit.Language.ToolWindows.MenuHelpPobWebsite;
            checkForUpdateToolStripMenuItem.Text = ApplicationInit.Language.ToolWindows.MenuHelpCheckUpdate;
            aboutPaxOnBoardToolStripMenuItem.Text = ApplicationInit.Language.ToolWindows.MenuHelpAbout;

            lblNotRunningWelcome.Text = ApplicationInit.Language.PreflightSettings.NotRunningWelcomeMessage;
        }

        /// <summary>
        /// Show login form to pilot profile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPilotProfileSignIn_Click(object sender, EventArgs e)
        {
            pilotProfileBoxNotInitialized.Visible = false;
            pilotProfileBoxLogin.Visible = true;
            pilotProfileBox.Visible = false;

            //if(new FlightSettingsWindow().ShowDialog() != DialogResult.OK)
            //{
            //    this.Close();
            //}
        }

        /// <summary>
        /// Show login/logout form to pilot profile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPilotProfileSettings_Click(object sender, EventArgs e)
        {
            pilotProfileBoxNotInitialized.Visible = false;
            pilotProfileBoxLogin.Visible = true;
            pilotProfileBox.Visible = false;
        }

        /// <summary>
        /// Handle click on Cancel button in LoginBox. Different boxes should be shown if pilot is logged in or not.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoginBoxCancel_Click(object sender, EventArgs e)
        {
            if(_pilotLoggedIn)
            {
                pilotProfileBoxNotInitialized.Visible = false;
                pilotProfileBoxLogin.Visible = false;
                pilotProfileBox.Visible = true;
            }
            else
            {
                pilotProfileBoxNotInitialized.Visible = true;
                pilotProfileBoxLogin.Visible = false;
                pilotProfileBox.Visible = false;
            }
        }

        private void btnLoginBoxOK_Click(object sender, EventArgs e)
        {
            // TODO pilot login
            _pilotLoggedIn = true;

            pilotProfileBoxNotInitialized.Visible = false;
            pilotProfileBoxLogin.Visible = false;
            pilotProfileBox.Visible = true;
        }

        /// <summary>
        /// Save all settings before the application will terminate (it exits with this main form closed) and clean other application routines.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManagerWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Stop checking sim status
            if (statusCheckTimer.Enabled)
            {
                statusCheckTimer.Stop();
            }

            // End SimConnect
            LegacyHelper.EndSimConnect();


            // Remember last form size and location set by user
            if (this.WindowState != FormWindowState.Minimized)
            {
                Properties.Settings.Default.ManagerFormSize = this.Size;
                Properties.Settings.Default.ManagerFormLocation = this.Location; // to do detection of location out of display bounds (e.g. in case of monitor disconnected)
                Properties.Settings.Default.ManagerFormWindowState = this.WindowState;
            }

            // Save all settings (just in case that app is not reseting due to settings reset)
            if (!__settingsReset)
            {
                Properties.Settings.Default.Save();
            }
        }

        /// <summary>
        /// Load settings affecting after the form is initiated.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManagerWindow_Load(object sender, EventArgs e)
        {
            this.Size = Properties.Settings.Default.ManagerFormSize;
            this.Location = Properties.Settings.Default.ManagerFormLocation;
            this.WindowState = Properties.Settings.Default.ManagerFormWindowState;
        }

        /// <summary>
        /// Checks status of Microsoft Flight Simulator 2020 (not installed/not running/running/in flight).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckMsfsStatus(object sender, EventArgs e)
        {
            // Reset visibility of boxes to prevent showing them while sim is not running
            aircraftInfoBox.Visible = false;
            statusPanel.BackColor = SystemColors.Control;
            lblStatusFlight.ForeColor = SystemColors.ControlText;
            preflightBox.Visible = false;
            inflightBox.Visible = false;
            notRunningBox.Visible = true;

            // Check if MSFS is installed (once on app start by reading registry entry)
            if (_msfsDetected == LegacyHelper.MSFSinstallation.undefined)
            {
                _msfsDetected = LegacyHelper.CheckMSFSinstallation();
            }

            // MSFS is installed correctly
            if (_msfsDetected == LegacyHelper.MSFSinstallation.MSStore || _msfsDetected == LegacyHelper.MSFSinstallation.Steam)
            {
                // Check if MSFS is running (periodically)
                _msfsRunning = LegacyHelper.CheckMSFSrunning();

                // MSFS is running
                if (_msfsRunning)
                {
                    lblStatusMSFS.Image = (_msfsDetected == LegacyHelper.MSFSinstallation.MSStore ? Properties.Resources.msstore_on : Properties.Resources.steam_on);

                    // Start SimConnect
                    LegacyHelper.StartSimConnect();

                    // Check if sim is in flight (periodically)
                    SimConnectHelper.GetSimVar(SimConnectHelper.GetSimConnectVariableObject("TITLE"));

                    // Simulation in flight
                    if (_simInFlight)
                    {
                        aircraftInfoBox.Visible = true;

                        // Fill status area with dynamic flight information
                        lblStatusFlight.Text = "LOREM IPSUM";

                        statusPanel.BackColor = Color.RoyalBlue;
                        lblStatusFlight.ForeColor = Color.White;
                    }
                    // Simulation flight ended
                    else
                    {
                        lblStatusFlight.Text = ApplicationInit.Language.Status.FlightNotStarted;
                    }
                }
                // MSFS is not running
                else
                {
                    lblStatusMSFS.Image = (_msfsDetected == LegacyHelper.MSFSinstallation.MSStore ? Properties.Resources.msstore_off : Properties.Resources.steam_off);

                    lblStatusFlight.Text = ApplicationInit.Language.Status.SimulationNotRunning;

                    // End SimConnect (cover case when MSFS was running and ended)
                    LegacyHelper.EndSimConnect();
                }
            }
            // MSFS is not detected (probably not installed)
            else
            {
                lblStatusMSFS.Image = Properties.Resources.status_error;

                lblStatusFlight.Text = ApplicationInit.Language.Status.InstallMSFS;
                statusPanel.BackColor = Color.Red;

                // Stop checking sim status
                statusCheckTimer.Stop();
            }
        }

        private void reportAProblemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/KRtkovo-eu/PaxOnBoard/issues/new");
        }

        private void aboutPaxOnBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutWindow().ShowDialog();
        }

        private void resetSettingsToDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(ApplicationInit.Language.ToolWindows.WarningBeforeSettingsResetMessage, ApplicationInit.Language.ToolWindows.WarningBeforeSettingsResetCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                Properties.Settings.Default.Reset();
                __settingsReset = true;
                Application.Restart();
            }
        }

        private void btnPilotProfileJoinUs_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://paxonboard.pro/");
        }
    }
}
