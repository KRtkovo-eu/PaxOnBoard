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
        private LegacyHelper.MSFSinstallation _msfsDetected = LegacyHelper.MSFSinstallation.undefined;
        private bool _msfsRunning = false;
        private bool _simInFlight = false;

        public ManagerWindow()
        {
            InitializeComponent();

            // Initialize with english language
            TranslateForm();

            CheckMsfsStatus(null, null);
            statusCheckTimer.Start();
        }

        /// <summary>
        /// Translates form to selected language (TO BE IMPLEMENTED).
        /// </summary>
        private void TranslateForm()
        {
            this.Text = $"PaxOnBoard | { Lang.en_US.ToolWindows.SimulationManagerTitle } { Application.ProductVersion }-alpha";

            pilotProfileBox.Text = Lang.en_US.PilotProfileBox.Title;
            pilotProfileBoxNotInitialized.Text = Lang.en_US.PilotProfileBox.Title;
            lblPilotName.Text = Lang.en_US.PilotProfileBox.PilotNameLbl;
            lblPilotHiredBy.Text = Lang.en_US.PilotProfileBox.HiredByCompanyLbl;
            lblVaPilotHiredBy.Text = Lang.en_US.PilotProfileBox.HiredByNoCompanyDefVal;
            lblPilotPoints.Text = Lang.en_US.PilotProfileBox.PilotPointsLbl;
            lblPilotTotalHoursFlown.Text = Lang.en_US.PilotProfileBox.HoursFlownLbl;
            lblPilotTotalPaxTransported.Text = Lang.en_US.PilotProfileBox.TotalPaxTransportedLbl;
            toolTipHelp.SetToolTip(lblPilotTotalPaxTransported, Lang.en_US.PilotProfileBox.ToolTipTotalPaxTransported);
            toolTipHelp.SetToolTip(lblValPilotTotalPaxTransported, Lang.en_US.PilotProfileBox.ToolTipTotalPaxTransported);

            aircraftInfoBox.Text = Lang.en_US.AircraftInfoBox.Title;
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

            // Save all settings
            Properties.Settings.Default.Save();
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
                        lblStatusFlight.Text = Lang.en_US.Status.FlightNotStarted;
                    }
                }
                // MSFS is not running
                else
                {
                    lblStatusMSFS.Image = (_msfsDetected == LegacyHelper.MSFSinstallation.MSStore ? Properties.Resources.msstore_off : Properties.Resources.steam_off);

                    lblStatusFlight.Text = Lang.en_US.Status.SimulationNotRunning;

                    // End SimConnect (cover case when MSFS was running and ended)
                    LegacyHelper.EndSimConnect();
                }
            }
            // MSFS is not detected (probably not installed)
            else
            {
                lblStatusMSFS.Image = Properties.Resources.status_error;

                lblStatusFlight.Text = Lang.en_US.Status.InstallMSFS;
                statusPanel.BackColor = Color.Red;

                // Stop checking sim status
                statusCheckTimer.Stop();
            }
        }

        private void reportAProblemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/KRtkovo-eu/PaxOnBoard/issues/new");
        }
    }
}
