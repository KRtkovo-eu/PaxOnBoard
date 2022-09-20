
namespace PaxOnBoard.Client.Windows.Forms
{
    partial class ManagerWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerWindow));
            this.statusPanel = new System.Windows.Forms.StatusStrip();
            this.lblStatusMSFS = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusFlight = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.aircraftInfoBox = new System.Windows.Forms.GroupBox();
            this.aircraftPictureBox = new System.Windows.Forms.Panel();
            this.lblValAircraftTailNumber = new System.Windows.Forms.Label();
            this.lblValAircraftCallsign = new System.Windows.Forms.Label();
            this.lblValAircraftLivery = new System.Windows.Forms.Label();
            this.lblValAircraftModel = new System.Windows.Forms.Label();
            this.lblValAircraftManufacturer = new System.Windows.Forms.Label();
            this.lblAircraftLivery = new System.Windows.Forms.Label();
            this.lblAircraftModel = new System.Windows.Forms.Label();
            this.lblAircraftTailNumber = new System.Windows.Forms.Label();
            this.lblAircraftCallsign = new System.Windows.Forms.Label();
            this.lblAircraftManufacturer = new System.Windows.Forms.Label();
            this.pilotProfileBox = new System.Windows.Forms.GroupBox();
            this.lblValPilotTotalPaxTransported = new System.Windows.Forms.Label();
            this.lblValPilotTotallHoursFlown = new System.Windows.Forms.Label();
            this.lblValPilotPoints = new System.Windows.Forms.Label();
            this.lblValPilotHiredBy = new System.Windows.Forms.Label();
            this.lblValPilotName = new System.Windows.Forms.Label();
            this.btnPilotProfileSettings = new System.Windows.Forms.Button();
            this.lblPilotPoints = new System.Windows.Forms.Label();
            this.lblPilotHiredBy = new System.Windows.Forms.Label();
            this.lblPilotTotalPaxTransported = new System.Windows.Forms.Label();
            this.lblPilotTotalHoursFlown = new System.Windows.Forms.Label();
            this.lblPilotName = new System.Windows.Forms.Label();
            this.pilotProfileBoxLogin = new System.Windows.Forms.GroupBox();
            this.btnLoginBoxCancel = new System.Windows.Forms.Button();
            this.btnLoginBoxOK = new System.Windows.Forms.Button();
            this.txtboxLoginBoxPassword = new System.Windows.Forms.TextBox();
            this.txtboxLoginBoxUsername = new System.Windows.Forms.TextBox();
            this.lblLoginBoxPassword = new System.Windows.Forms.Label();
            this.lblLoginBoxUsername = new System.Windows.Forms.Label();
            this.pilotProfileBoxNotInitialized = new System.Windows.Forms.GroupBox();
            this.btnPilotProfileJoinUs = new System.Windows.Forms.Button();
            this.btnPilotProfileSignIn = new System.Windows.Forms.Button();
            this.spacer = new System.Windows.Forms.Panel();
            this.paxOnBoardLogo = new System.Windows.Forms.Panel();
            this.inflightBox = new System.Windows.Forms.Panel();
            this.flightDetailsBox = new System.Windows.Forms.Panel();
            this.aircraftSymbol = new System.Windows.Forms.Panel();
            this.lblAirportFinal = new System.Windows.Forms.Label();
            this.lblValAirportFinal = new System.Windows.Forms.Label();
            this.lblAirportFrom = new System.Windows.Forms.Label();
            this.lblValAirportFrom = new System.Windows.Forms.Label();
            this.lblFlightNumber = new System.Windows.Forms.Label();
            this.lblValFlightNumber = new System.Windows.Forms.Label();
            this.preflightBox = new System.Windows.Forms.Panel();
            this.btnPreflightProceed = new System.Windows.Forms.Button();
            this.lblPreflightWelcome = new System.Windows.Forms.Label();
            this.notRunningBox = new System.Windows.Forms.Panel();
            this.lblNotRunningWelcome = new System.Windows.Forms.Label();
            this.simManagerMenu = new System.Windows.Forms.MenuStrip();
            this.helpStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportAProblemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.paxOnBoardWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.checkForUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutPaxOnBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.resetSettingsToDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.statusCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.aircraftInfoBox.SuspendLayout();
            this.pilotProfileBox.SuspendLayout();
            this.pilotProfileBoxLogin.SuspendLayout();
            this.pilotProfileBoxNotInitialized.SuspendLayout();
            this.inflightBox.SuspendLayout();
            this.flightDetailsBox.SuspendLayout();
            this.preflightBox.SuspendLayout();
            this.notRunningBox.SuspendLayout();
            this.simManagerMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusPanel
            // 
            this.statusPanel.BackColor = System.Drawing.SystemColors.Control;
            this.statusPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusMSFS,
            this.lblStatusFlight});
            this.statusPanel.Location = new System.Drawing.Point(0, 832);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusPanel.Size = new System.Drawing.Size(1094, 22);
            this.statusPanel.TabIndex = 0;
            this.statusPanel.Text = "statusStrip1";
            // 
            // lblStatusMSFS
            // 
            this.lblStatusMSFS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lblStatusMSFS.Image = global::PaxOnBoard.Client.Windows.Properties.Resources.status_error;
            this.lblStatusMSFS.Name = "lblStatusMSFS";
            this.lblStatusMSFS.Size = new System.Drawing.Size(16, 17);
            this.lblStatusMSFS.Text = "MSFS status";
            // 
            // lblStatusFlight
            // 
            this.lblStatusFlight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStatusFlight.Name = "lblStatusFlight";
            this.lblStatusFlight.Size = new System.Drawing.Size(1061, 17);
            this.lblStatusFlight.Spring = true;
            this.lblStatusFlight.Text = "lblStatusFlight";
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainSplitContainer.IsSplitterFixed = true;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.AutoScroll = true;
            this.mainSplitContainer.Panel1.Controls.Add(this.aircraftInfoBox);
            this.mainSplitContainer.Panel1.Controls.Add(this.pilotProfileBox);
            this.mainSplitContainer.Panel1.Controls.Add(this.pilotProfileBoxLogin);
            this.mainSplitContainer.Panel1.Controls.Add(this.pilotProfileBoxNotInitialized);
            this.mainSplitContainer.Panel1.Controls.Add(this.spacer);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.AutoScroll = true;
            this.mainSplitContainer.Panel2.Controls.Add(this.paxOnBoardLogo);
            this.mainSplitContainer.Panel2.Controls.Add(this.inflightBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.preflightBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.notRunningBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.simManagerMenu);
            this.mainSplitContainer.Size = new System.Drawing.Size(1094, 832);
            this.mainSplitContainer.SplitterDistance = 250;
            this.mainSplitContainer.SplitterWidth = 1;
            this.mainSplitContainer.TabIndex = 1;
            // 
            // aircraftInfoBox
            // 
            this.aircraftInfoBox.Controls.Add(this.aircraftPictureBox);
            this.aircraftInfoBox.Controls.Add(this.lblValAircraftTailNumber);
            this.aircraftInfoBox.Controls.Add(this.lblValAircraftCallsign);
            this.aircraftInfoBox.Controls.Add(this.lblValAircraftLivery);
            this.aircraftInfoBox.Controls.Add(this.lblValAircraftModel);
            this.aircraftInfoBox.Controls.Add(this.lblValAircraftManufacturer);
            this.aircraftInfoBox.Controls.Add(this.lblAircraftLivery);
            this.aircraftInfoBox.Controls.Add(this.lblAircraftModel);
            this.aircraftInfoBox.Controls.Add(this.lblAircraftTailNumber);
            this.aircraftInfoBox.Controls.Add(this.lblAircraftCallsign);
            this.aircraftInfoBox.Controls.Add(this.lblAircraftManufacturer);
            this.aircraftInfoBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.aircraftInfoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aircraftInfoBox.Location = new System.Drawing.Point(0, 522);
            this.aircraftInfoBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.aircraftInfoBox.Name = "aircraftInfoBox";
            this.aircraftInfoBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.aircraftInfoBox.Size = new System.Drawing.Size(250, 235);
            this.aircraftInfoBox.TabIndex = 2;
            this.aircraftInfoBox.TabStop = false;
            this.aircraftInfoBox.Text = "aircraftInfoBox";
            this.aircraftInfoBox.Visible = false;
            // 
            // aircraftPictureBox
            // 
            this.aircraftPictureBox.Location = new System.Drawing.Point(13, 21);
            this.aircraftPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.aircraftPictureBox.Name = "aircraftPictureBox";
            this.aircraftPictureBox.Size = new System.Drawing.Size(226, 84);
            this.aircraftPictureBox.TabIndex = 21;
            // 
            // lblValAircraftTailNumber
            // 
            this.lblValAircraftTailNumber.AutoSize = true;
            this.lblValAircraftTailNumber.Location = new System.Drawing.Point(106, 207);
            this.lblValAircraftTailNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValAircraftTailNumber.Name = "lblValAircraftTailNumber";
            this.lblValAircraftTailNumber.Size = new System.Drawing.Size(143, 13);
            this.lblValAircraftTailNumber.TabIndex = 20;
            this.lblValAircraftTailNumber.Text = "lblValAircraftTailNumber";
            // 
            // lblValAircraftCallsign
            // 
            this.lblValAircraftCallsign.AutoSize = true;
            this.lblValAircraftCallsign.Location = new System.Drawing.Point(92, 183);
            this.lblValAircraftCallsign.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValAircraftCallsign.Name = "lblValAircraftCallsign";
            this.lblValAircraftCallsign.Size = new System.Drawing.Size(123, 13);
            this.lblValAircraftCallsign.TabIndex = 19;
            this.lblValAircraftCallsign.Text = "lblValAircraftCallsign";
            // 
            // lblValAircraftLivery
            // 
            this.lblValAircraftLivery.AutoSize = true;
            this.lblValAircraftLivery.Location = new System.Drawing.Point(86, 160);
            this.lblValAircraftLivery.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValAircraftLivery.Name = "lblValAircraftLivery";
            this.lblValAircraftLivery.Size = new System.Drawing.Size(113, 13);
            this.lblValAircraftLivery.TabIndex = 18;
            this.lblValAircraftLivery.Text = "lblValAircraftLivery";
            // 
            // lblValAircraftModel
            // 
            this.lblValAircraftModel.AutoSize = true;
            this.lblValAircraftModel.Location = new System.Drawing.Point(72, 137);
            this.lblValAircraftModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValAircraftModel.Name = "lblValAircraftModel";
            this.lblValAircraftModel.Size = new System.Drawing.Size(113, 13);
            this.lblValAircraftModel.TabIndex = 17;
            this.lblValAircraftModel.Text = "lblValAircraftModel";
            // 
            // lblValAircraftManufacturer
            // 
            this.lblValAircraftManufacturer.AutoSize = true;
            this.lblValAircraftManufacturer.Location = new System.Drawing.Point(59, 115);
            this.lblValAircraftManufacturer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValAircraftManufacturer.Name = "lblValAircraftManufacturer";
            this.lblValAircraftManufacturer.Size = new System.Drawing.Size(154, 13);
            this.lblValAircraftManufacturer.TabIndex = 16;
            this.lblValAircraftManufacturer.Text = "lblValAircraftManufacturer";
            // 
            // lblAircraftLivery
            // 
            this.lblAircraftLivery.AutoSize = true;
            this.lblAircraftLivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAircraftLivery.Location = new System.Drawing.Point(14, 160);
            this.lblAircraftLivery.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAircraftLivery.Name = "lblAircraftLivery";
            this.lblAircraftLivery.Size = new System.Drawing.Size(78, 13);
            this.lblAircraftLivery.TabIndex = 15;
            this.lblAircraftLivery.Text = "lblAircraftLivery";
            // 
            // lblAircraftModel
            // 
            this.lblAircraftModel.AutoSize = true;
            this.lblAircraftModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAircraftModel.Location = new System.Drawing.Point(14, 137);
            this.lblAircraftModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAircraftModel.Name = "lblAircraftModel";
            this.lblAircraftModel.Size = new System.Drawing.Size(79, 13);
            this.lblAircraftModel.TabIndex = 14;
            this.lblAircraftModel.Text = "lblAircraftModel";
            // 
            // lblAircraftTailNumber
            // 
            this.lblAircraftTailNumber.AutoSize = true;
            this.lblAircraftTailNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAircraftTailNumber.Location = new System.Drawing.Point(14, 207);
            this.lblAircraftTailNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAircraftTailNumber.Name = "lblAircraftTailNumber";
            this.lblAircraftTailNumber.Size = new System.Drawing.Size(104, 13);
            this.lblAircraftTailNumber.TabIndex = 13;
            this.lblAircraftTailNumber.Text = "lblAircraftTailNumber";
            // 
            // lblAircraftCallsign
            // 
            this.lblAircraftCallsign.AutoSize = true;
            this.lblAircraftCallsign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAircraftCallsign.Location = new System.Drawing.Point(14, 183);
            this.lblAircraftCallsign.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAircraftCallsign.Name = "lblAircraftCallsign";
            this.lblAircraftCallsign.Size = new System.Drawing.Size(86, 13);
            this.lblAircraftCallsign.TabIndex = 12;
            this.lblAircraftCallsign.Text = "lblAircraftCallsign";
            // 
            // lblAircraftManufacturer
            // 
            this.lblAircraftManufacturer.AutoSize = true;
            this.lblAircraftManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAircraftManufacturer.Location = new System.Drawing.Point(14, 114);
            this.lblAircraftManufacturer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAircraftManufacturer.Name = "lblAircraftManufacturer";
            this.lblAircraftManufacturer.Size = new System.Drawing.Size(113, 13);
            this.lblAircraftManufacturer.TabIndex = 11;
            this.lblAircraftManufacturer.Text = "lblAircraftManufacturer";
            // 
            // pilotProfileBox
            // 
            this.pilotProfileBox.Controls.Add(this.lblValPilotTotalPaxTransported);
            this.pilotProfileBox.Controls.Add(this.lblValPilotTotallHoursFlown);
            this.pilotProfileBox.Controls.Add(this.lblValPilotPoints);
            this.pilotProfileBox.Controls.Add(this.lblValPilotHiredBy);
            this.pilotProfileBox.Controls.Add(this.lblValPilotName);
            this.pilotProfileBox.Controls.Add(this.btnPilotProfileSettings);
            this.pilotProfileBox.Controls.Add(this.lblPilotPoints);
            this.pilotProfileBox.Controls.Add(this.lblPilotHiredBy);
            this.pilotProfileBox.Controls.Add(this.lblPilotTotalPaxTransported);
            this.pilotProfileBox.Controls.Add(this.lblPilotTotalHoursFlown);
            this.pilotProfileBox.Controls.Add(this.lblPilotName);
            this.pilotProfileBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pilotProfileBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pilotProfileBox.Location = new System.Drawing.Point(0, 384);
            this.pilotProfileBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pilotProfileBox.Name = "pilotProfileBox";
            this.pilotProfileBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pilotProfileBox.Size = new System.Drawing.Size(250, 138);
            this.pilotProfileBox.TabIndex = 0;
            this.pilotProfileBox.TabStop = false;
            this.pilotProfileBox.Text = "pilotProfileBox";
            this.pilotProfileBox.Visible = false;
            // 
            // lblValPilotTotalPaxTransported
            // 
            this.lblValPilotTotalPaxTransported.AutoSize = true;
            this.lblValPilotTotalPaxTransported.Location = new System.Drawing.Point(142, 113);
            this.lblValPilotTotalPaxTransported.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValPilotTotalPaxTransported.Name = "lblValPilotTotalPaxTransported";
            this.lblValPilotTotalPaxTransported.Size = new System.Drawing.Size(181, 13);
            this.lblValPilotTotalPaxTransported.TabIndex = 10;
            this.lblValPilotTotalPaxTransported.Text = "lblValPilotTotalPaxTransported";
            // 
            // lblValPilotTotallHoursFlown
            // 
            this.lblValPilotTotallHoursFlown.AutoSize = true;
            this.lblValPilotTotallHoursFlown.Location = new System.Drawing.Point(91, 90);
            this.lblValPilotTotallHoursFlown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValPilotTotallHoursFlown.Name = "lblValPilotTotallHoursFlown";
            this.lblValPilotTotallHoursFlown.Size = new System.Drawing.Size(161, 13);
            this.lblValPilotTotallHoursFlown.TabIndex = 9;
            this.lblValPilotTotallHoursFlown.Text = "lblValPilotTotallHoursFlown";
            // 
            // lblValPilotPoints
            // 
            this.lblValPilotPoints.AutoSize = true;
            this.lblValPilotPoints.Location = new System.Drawing.Point(85, 67);
            this.lblValPilotPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValPilotPoints.Name = "lblValPilotPoints";
            this.lblValPilotPoints.Size = new System.Drawing.Size(98, 13);
            this.lblValPilotPoints.TabIndex = 8;
            this.lblValPilotPoints.Text = "lblValPilotPoints";
            // 
            // lblValPilotHiredBy
            // 
            this.lblValPilotHiredBy.AutoSize = true;
            this.lblValPilotHiredBy.Location = new System.Drawing.Point(71, 44);
            this.lblValPilotHiredBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValPilotHiredBy.Name = "lblValPilotHiredBy";
            this.lblValPilotHiredBy.Size = new System.Drawing.Size(107, 13);
            this.lblValPilotHiredBy.TabIndex = 7;
            this.lblValPilotHiredBy.Text = "lblValPilotHiredBy";
            // 
            // lblValPilotName
            // 
            this.lblValPilotName.AutoSize = true;
            this.lblValPilotName.Location = new System.Drawing.Point(58, 22);
            this.lblValPilotName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValPilotName.Name = "lblValPilotName";
            this.lblValPilotName.Size = new System.Drawing.Size(95, 13);
            this.lblValPilotName.TabIndex = 6;
            this.lblValPilotName.Text = "lblValPilotName";
            // 
            // btnPilotProfileSettings
            // 
            this.btnPilotProfileSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPilotProfileSettings.BackgroundImage")));
            this.btnPilotProfileSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPilotProfileSettings.Location = new System.Drawing.Point(218, 13);
            this.btnPilotProfileSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnPilotProfileSettings.Name = "btnPilotProfileSettings";
            this.btnPilotProfileSettings.Size = new System.Drawing.Size(28, 28);
            this.btnPilotProfileSettings.TabIndex = 5;
            this.btnPilotProfileSettings.UseVisualStyleBackColor = true;
            this.btnPilotProfileSettings.Click += new System.EventHandler(this.btnPilotProfileSettings_Click);
            // 
            // lblPilotPoints
            // 
            this.lblPilotPoints.AutoSize = true;
            this.lblPilotPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPilotPoints.Location = new System.Drawing.Point(13, 67);
            this.lblPilotPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPilotPoints.Name = "lblPilotPoints";
            this.lblPilotPoints.Size = new System.Drawing.Size(66, 13);
            this.lblPilotPoints.TabIndex = 4;
            this.lblPilotPoints.Text = "lblPilotPoints";
            // 
            // lblPilotHiredBy
            // 
            this.lblPilotHiredBy.AutoSize = true;
            this.lblPilotHiredBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPilotHiredBy.Location = new System.Drawing.Point(13, 44);
            this.lblPilotHiredBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPilotHiredBy.Name = "lblPilotHiredBy";
            this.lblPilotHiredBy.Size = new System.Drawing.Size(74, 13);
            this.lblPilotHiredBy.TabIndex = 3;
            this.lblPilotHiredBy.Text = "lblPilotHiredBy";
            // 
            // lblPilotTotalPaxTransported
            // 
            this.lblPilotTotalPaxTransported.AutoSize = true;
            this.lblPilotTotalPaxTransported.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPilotTotalPaxTransported.Location = new System.Drawing.Point(13, 113);
            this.lblPilotTotalPaxTransported.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPilotTotalPaxTransported.Name = "lblPilotTotalPaxTransported";
            this.lblPilotTotalPaxTransported.Size = new System.Drawing.Size(136, 13);
            this.lblPilotTotalPaxTransported.TabIndex = 2;
            this.lblPilotTotalPaxTransported.Text = "lblPilotTotalPaxTransported";
            // 
            // lblPilotTotalHoursFlown
            // 
            this.lblPilotTotalHoursFlown.AutoSize = true;
            this.lblPilotTotalHoursFlown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPilotTotalHoursFlown.Location = new System.Drawing.Point(13, 90);
            this.lblPilotTotalHoursFlown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPilotTotalHoursFlown.Name = "lblPilotTotalHoursFlown";
            this.lblPilotTotalHoursFlown.Size = new System.Drawing.Size(117, 13);
            this.lblPilotTotalHoursFlown.TabIndex = 1;
            this.lblPilotTotalHoursFlown.Text = "lblPilotTotalHoursFlown";
            // 
            // lblPilotName
            // 
            this.lblPilotName.AutoSize = true;
            this.lblPilotName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPilotName.Location = new System.Drawing.Point(13, 21);
            this.lblPilotName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPilotName.Name = "lblPilotName";
            this.lblPilotName.Size = new System.Drawing.Size(65, 13);
            this.lblPilotName.TabIndex = 0;
            this.lblPilotName.Text = "lblPilotName";
            // 
            // pilotProfileBoxLogin
            // 
            this.pilotProfileBoxLogin.Controls.Add(this.btnLoginBoxCancel);
            this.pilotProfileBoxLogin.Controls.Add(this.btnLoginBoxOK);
            this.pilotProfileBoxLogin.Controls.Add(this.txtboxLoginBoxPassword);
            this.pilotProfileBoxLogin.Controls.Add(this.txtboxLoginBoxUsername);
            this.pilotProfileBoxLogin.Controls.Add(this.lblLoginBoxPassword);
            this.pilotProfileBoxLogin.Controls.Add(this.lblLoginBoxUsername);
            this.pilotProfileBoxLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pilotProfileBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pilotProfileBoxLogin.Location = new System.Drawing.Point(0, 261);
            this.pilotProfileBoxLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pilotProfileBoxLogin.Name = "pilotProfileBoxLogin";
            this.pilotProfileBoxLogin.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pilotProfileBoxLogin.Size = new System.Drawing.Size(250, 123);
            this.pilotProfileBoxLogin.TabIndex = 3;
            this.pilotProfileBoxLogin.TabStop = false;
            this.pilotProfileBoxLogin.Text = "pilotProfileBoxLogin";
            this.pilotProfileBoxLogin.Visible = false;
            // 
            // btnLoginBoxCancel
            // 
            this.btnLoginBoxCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoginBoxCancel.Location = new System.Drawing.Point(157, 84);
            this.btnLoginBoxCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLoginBoxCancel.Name = "btnLoginBoxCancel";
            this.btnLoginBoxCancel.Size = new System.Drawing.Size(82, 27);
            this.btnLoginBoxCancel.TabIndex = 6;
            this.btnLoginBoxCancel.Text = "btnLoginBoxCancel";
            this.btnLoginBoxCancel.UseVisualStyleBackColor = true;
            this.btnLoginBoxCancel.Click += new System.EventHandler(this.btnLoginBoxCancel_Click);
            // 
            // btnLoginBoxOK
            // 
            this.btnLoginBoxOK.Location = new System.Drawing.Point(12, 84);
            this.btnLoginBoxOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLoginBoxOK.Name = "btnLoginBoxOK";
            this.btnLoginBoxOK.Size = new System.Drawing.Size(137, 27);
            this.btnLoginBoxOK.TabIndex = 5;
            this.btnLoginBoxOK.Text = "btnLoginBoxOK";
            this.btnLoginBoxOK.UseVisualStyleBackColor = true;
            this.btnLoginBoxOK.Click += new System.EventHandler(this.btnLoginBoxOK_Click);
            // 
            // txtboxLoginBoxPassword
            // 
            this.txtboxLoginBoxPassword.Location = new System.Drawing.Point(72, 54);
            this.txtboxLoginBoxPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtboxLoginBoxPassword.Name = "txtboxLoginBoxPassword";
            this.txtboxLoginBoxPassword.Size = new System.Drawing.Size(167, 20);
            this.txtboxLoginBoxPassword.TabIndex = 4;
            this.txtboxLoginBoxPassword.UseSystemPasswordChar = true;
            // 
            // txtboxLoginBoxUsername
            // 
            this.txtboxLoginBoxUsername.Location = new System.Drawing.Point(72, 24);
            this.txtboxLoginBoxUsername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtboxLoginBoxUsername.Name = "txtboxLoginBoxUsername";
            this.txtboxLoginBoxUsername.Size = new System.Drawing.Size(167, 20);
            this.txtboxLoginBoxUsername.TabIndex = 3;
            // 
            // lblLoginBoxPassword
            // 
            this.lblLoginBoxPassword.AutoSize = true;
            this.lblLoginBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoginBoxPassword.Location = new System.Drawing.Point(14, 58);
            this.lblLoginBoxPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginBoxPassword.Name = "lblLoginBoxPassword";
            this.lblLoginBoxPassword.Size = new System.Drawing.Size(107, 13);
            this.lblLoginBoxPassword.TabIndex = 2;
            this.lblLoginBoxPassword.Text = "lblLoginBoxPassword";
            // 
            // lblLoginBoxUsername
            // 
            this.lblLoginBoxUsername.AutoSize = true;
            this.lblLoginBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoginBoxUsername.Location = new System.Drawing.Point(14, 28);
            this.lblLoginBoxUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginBoxUsername.Name = "lblLoginBoxUsername";
            this.lblLoginBoxUsername.Size = new System.Drawing.Size(109, 13);
            this.lblLoginBoxUsername.TabIndex = 1;
            this.lblLoginBoxUsername.Text = "lblLoginBoxUsername";
            // 
            // pilotProfileBoxNotInitialized
            // 
            this.pilotProfileBoxNotInitialized.Controls.Add(this.btnPilotProfileJoinUs);
            this.pilotProfileBoxNotInitialized.Controls.Add(this.btnPilotProfileSignIn);
            this.pilotProfileBoxNotInitialized.Dock = System.Windows.Forms.DockStyle.Top;
            this.pilotProfileBoxNotInitialized.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pilotProfileBoxNotInitialized.Location = new System.Drawing.Point(0, 6);
            this.pilotProfileBoxNotInitialized.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pilotProfileBoxNotInitialized.Name = "pilotProfileBoxNotInitialized";
            this.pilotProfileBoxNotInitialized.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pilotProfileBoxNotInitialized.Size = new System.Drawing.Size(250, 255);
            this.pilotProfileBoxNotInitialized.TabIndex = 1;
            this.pilotProfileBoxNotInitialized.TabStop = false;
            this.pilotProfileBoxNotInitialized.Text = "pilotProfileBoxNotInitialized";
            // 
            // btnPilotProfileJoinUs
            // 
            this.btnPilotProfileJoinUs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPilotProfileJoinUs.BackgroundImage")));
            this.btnPilotProfileJoinUs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPilotProfileJoinUs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPilotProfileJoinUs.Location = new System.Drawing.Point(13, 140);
            this.btnPilotProfileJoinUs.Margin = new System.Windows.Forms.Padding(0);
            this.btnPilotProfileJoinUs.Name = "btnPilotProfileJoinUs";
            this.btnPilotProfileJoinUs.Size = new System.Drawing.Size(226, 111);
            this.btnPilotProfileJoinUs.TabIndex = 6;
            this.btnPilotProfileJoinUs.UseVisualStyleBackColor = true;
            this.btnPilotProfileJoinUs.Click += new System.EventHandler(this.btnPilotProfileJoinUs_Click);
            // 
            // btnPilotProfileSignIn
            // 
            this.btnPilotProfileSignIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPilotProfileSignIn.BackgroundImage")));
            this.btnPilotProfileSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPilotProfileSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPilotProfileSignIn.Location = new System.Drawing.Point(13, 21);
            this.btnPilotProfileSignIn.Margin = new System.Windows.Forms.Padding(0);
            this.btnPilotProfileSignIn.Name = "btnPilotProfileSignIn";
            this.btnPilotProfileSignIn.Size = new System.Drawing.Size(226, 111);
            this.btnPilotProfileSignIn.TabIndex = 5;
            this.btnPilotProfileSignIn.UseVisualStyleBackColor = true;
            this.btnPilotProfileSignIn.Click += new System.EventHandler(this.btnPilotProfileSignIn_Click);
            // 
            // spacer
            // 
            this.spacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.spacer.Location = new System.Drawing.Point(0, 0);
            this.spacer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.spacer.Name = "spacer";
            this.spacer.Size = new System.Drawing.Size(250, 6);
            this.spacer.TabIndex = 4;
            // 
            // paxOnBoardLogo
            // 
            this.paxOnBoardLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.paxOnBoardLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paxOnBoardLogo.BackgroundImage")));
            this.paxOnBoardLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.paxOnBoardLogo.Location = new System.Drawing.Point(629, 797);
            this.paxOnBoardLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.paxOnBoardLogo.Name = "paxOnBoardLogo";
            this.paxOnBoardLogo.Size = new System.Drawing.Size(217, 32);
            this.paxOnBoardLogo.TabIndex = 0;
            // 
            // inflightBox
            // 
            this.inflightBox.Controls.Add(this.flightDetailsBox);
            this.inflightBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.inflightBox.Location = new System.Drawing.Point(0, 395);
            this.inflightBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inflightBox.Name = "inflightBox";
            this.inflightBox.Size = new System.Drawing.Size(843, 238);
            this.inflightBox.TabIndex = 4;
            this.inflightBox.Visible = false;
            // 
            // flightDetailsBox
            // 
            this.flightDetailsBox.BackColor = System.Drawing.Color.Black;
            this.flightDetailsBox.Controls.Add(this.aircraftSymbol);
            this.flightDetailsBox.Controls.Add(this.lblAirportFinal);
            this.flightDetailsBox.Controls.Add(this.lblValAirportFinal);
            this.flightDetailsBox.Controls.Add(this.lblAirportFrom);
            this.flightDetailsBox.Controls.Add(this.lblValAirportFrom);
            this.flightDetailsBox.Controls.Add(this.lblFlightNumber);
            this.flightDetailsBox.Controls.Add(this.lblValFlightNumber);
            this.flightDetailsBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.flightDetailsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flightDetailsBox.ForeColor = System.Drawing.Color.White;
            this.flightDetailsBox.Location = new System.Drawing.Point(0, 0);
            this.flightDetailsBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flightDetailsBox.Name = "flightDetailsBox";
            this.flightDetailsBox.Size = new System.Drawing.Size(843, 92);
            this.flightDetailsBox.TabIndex = 1;
            // 
            // aircraftSymbol
            // 
            this.aircraftSymbol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aircraftSymbol.BackColor = System.Drawing.Color.Transparent;
            this.aircraftSymbol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aircraftSymbol.BackgroundImage")));
            this.aircraftSymbol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.aircraftSymbol.Location = new System.Drawing.Point(290, 0);
            this.aircraftSymbol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.aircraftSymbol.Name = "aircraftSymbol";
            this.aircraftSymbol.Size = new System.Drawing.Size(161, 92);
            this.aircraftSymbol.TabIndex = 6;
            // 
            // lblAirportFinal
            // 
            this.lblAirportFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAirportFinal.AutoSize = true;
            this.lblAirportFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAirportFinal.Location = new System.Drawing.Point(482, 53);
            this.lblAirportFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAirportFinal.Name = "lblAirportFinal";
            this.lblAirportFinal.Size = new System.Drawing.Size(82, 15);
            this.lblAirportFinal.TabIndex = 5;
            this.lblAirportFinal.Text = "lblAirportFinal";
            // 
            // lblValAirportFinal
            // 
            this.lblValAirportFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValAirportFinal.AutoSize = true;
            this.lblValAirportFinal.Location = new System.Drawing.Point(482, 20);
            this.lblValAirportFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValAirportFinal.Name = "lblValAirportFinal";
            this.lblValAirportFinal.Size = new System.Drawing.Size(197, 29);
            this.lblValAirportFinal.TabIndex = 4;
            this.lblValAirportFinal.Text = "lblValAirportFinal";
            // 
            // lblAirportFrom
            // 
            this.lblAirportFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAirportFrom.AutoSize = true;
            this.lblAirportFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAirportFrom.Location = new System.Drawing.Point(157, 53);
            this.lblAirportFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAirportFrom.Name = "lblAirportFrom";
            this.lblAirportFrom.Size = new System.Drawing.Size(84, 15);
            this.lblAirportFrom.TabIndex = 3;
            this.lblAirportFrom.Text = "lblAirportFrom";
            // 
            // lblValAirportFrom
            // 
            this.lblValAirportFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValAirportFrom.AutoSize = true;
            this.lblValAirportFrom.Location = new System.Drawing.Point(157, 20);
            this.lblValAirportFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValAirportFrom.Name = "lblValAirportFrom";
            this.lblValAirportFrom.Size = new System.Drawing.Size(201, 29);
            this.lblValAirportFrom.TabIndex = 2;
            this.lblValAirportFrom.Text = "lblValAirportFrom";
            // 
            // lblFlightNumber
            // 
            this.lblFlightNumber.AutoSize = true;
            this.lblFlightNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFlightNumber.Location = new System.Drawing.Point(16, 53);
            this.lblFlightNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightNumber.Name = "lblFlightNumber";
            this.lblFlightNumber.Size = new System.Drawing.Size(95, 15);
            this.lblFlightNumber.TabIndex = 1;
            this.lblFlightNumber.Text = "lblFlightNumber";
            // 
            // lblValFlightNumber
            // 
            this.lblValFlightNumber.AutoSize = true;
            this.lblValFlightNumber.Location = new System.Drawing.Point(16, 20);
            this.lblValFlightNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValFlightNumber.Name = "lblValFlightNumber";
            this.lblValFlightNumber.Size = new System.Drawing.Size(220, 29);
            this.lblValFlightNumber.TabIndex = 0;
            this.lblValFlightNumber.Text = "lblValFlightNumber";
            // 
            // preflightBox
            // 
            this.preflightBox.Controls.Add(this.btnPreflightProceed);
            this.preflightBox.Controls.Add(this.lblPreflightWelcome);
            this.preflightBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.preflightBox.Location = new System.Drawing.Point(0, 139);
            this.preflightBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.preflightBox.Name = "preflightBox";
            this.preflightBox.Size = new System.Drawing.Size(843, 256);
            this.preflightBox.TabIndex = 2;
            this.preflightBox.Visible = false;
            // 
            // btnPreflightProceed
            // 
            this.btnPreflightProceed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreflightProceed.Location = new System.Drawing.Point(676, 213);
            this.btnPreflightProceed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPreflightProceed.Name = "btnPreflightProceed";
            this.btnPreflightProceed.Size = new System.Drawing.Size(153, 36);
            this.btnPreflightProceed.TabIndex = 1;
            this.btnPreflightProceed.Text = "btnPreflightProceed";
            this.btnPreflightProceed.UseVisualStyleBackColor = true;
            // 
            // lblPreflightWelcome
            // 
            this.lblPreflightWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPreflightWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPreflightWelcome.Location = new System.Drawing.Point(16, 16);
            this.lblPreflightWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreflightWelcome.Name = "lblPreflightWelcome";
            this.lblPreflightWelcome.Size = new System.Drawing.Size(812, 190);
            this.lblPreflightWelcome.TabIndex = 0;
            this.lblPreflightWelcome.Text = "lblPreflightWelcome";
            // 
            // notRunningBox
            // 
            this.notRunningBox.Controls.Add(this.lblNotRunningWelcome);
            this.notRunningBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.notRunningBox.Location = new System.Drawing.Point(0, 24);
            this.notRunningBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.notRunningBox.Name = "notRunningBox";
            this.notRunningBox.Size = new System.Drawing.Size(843, 115);
            this.notRunningBox.TabIndex = 3;
            // 
            // lblNotRunningWelcome
            // 
            this.lblNotRunningWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotRunningWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNotRunningWelcome.Location = new System.Drawing.Point(16, 16);
            this.lblNotRunningWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotRunningWelcome.Name = "lblNotRunningWelcome";
            this.lblNotRunningWelcome.Size = new System.Drawing.Size(812, 85);
            this.lblNotRunningWelcome.TabIndex = 1;
            this.lblNotRunningWelcome.Text = "lblNotRunningWelcome";
            // 
            // simManagerMenu
            // 
            this.simManagerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpStripMenuItem,
            this.optionsToolStripMenuItem});
            this.simManagerMenu.Location = new System.Drawing.Point(0, 0);
            this.simManagerMenu.Name = "simManagerMenu";
            this.simManagerMenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.simManagerMenu.ShowItemToolTips = true;
            this.simManagerMenu.Size = new System.Drawing.Size(843, 24);
            this.simManagerMenu.TabIndex = 0;
            this.simManagerMenu.Text = "menuStrip1";
            // 
            // helpStripMenuItem
            // 
            this.helpStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.helpStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportAProblemToolStripMenuItem,
            this.toolStripSeparator2,
            this.paxOnBoardWebsiteToolStripMenuItem,
            this.toolStripSeparator1,
            this.checkForUpdateToolStripMenuItem,
            this.aboutPaxOnBoardToolStripMenuItem});
            this.helpStripMenuItem.Name = "helpStripMenuItem";
            this.helpStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpStripMenuItem.Text = "&Help";
            // 
            // reportAProblemToolStripMenuItem
            // 
            this.reportAProblemToolStripMenuItem.Name = "reportAProblemToolStripMenuItem";
            this.reportAProblemToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.reportAProblemToolStripMenuItem.Text = "&Report a Problem";
            this.reportAProblemToolStripMenuItem.Click += new System.EventHandler(this.reportAProblemToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(182, 6);
            // 
            // paxOnBoardWebsiteToolStripMenuItem
            // 
            this.paxOnBoardWebsiteToolStripMenuItem.Name = "paxOnBoardWebsiteToolStripMenuItem";
            this.paxOnBoardWebsiteToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.paxOnBoardWebsiteToolStripMenuItem.Text = "PaxOnBoard &Website";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // checkForUpdateToolStripMenuItem
            // 
            this.checkForUpdateToolStripMenuItem.Enabled = false;
            this.checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
            this.checkForUpdateToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.checkForUpdateToolStripMenuItem.Text = "&Check for Update";
            // 
            // aboutPaxOnBoardToolStripMenuItem
            // 
            this.aboutPaxOnBoardToolStripMenuItem.Name = "aboutPaxOnBoardToolStripMenuItem";
            this.aboutPaxOnBoardToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.aboutPaxOnBoardToolStripMenuItem.Text = "&About PaxOnBoard";
            this.aboutPaxOnBoardToolStripMenuItem.Click += new System.EventHandler(this.aboutPaxOnBoardToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.toolStripSeparator3,
            this.resetSettingsToDefaultToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.Enabled = false;
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.languageToolStripMenuItem.Text = "&Language";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(197, 6);
            // 
            // resetSettingsToDefaultToolStripMenuItem
            // 
            this.resetSettingsToDefaultToolStripMenuItem.Name = "resetSettingsToDefaultToolStripMenuItem";
            this.resetSettingsToDefaultToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.resetSettingsToDefaultToolStripMenuItem.Text = "&Reset settings to default";
            this.resetSettingsToDefaultToolStripMenuItem.Click += new System.EventHandler(this.resetSettingsToDefaultToolStripMenuItem_Click);
            // 
            // statusCheckTimer
            // 
            this.statusCheckTimer.Interval = 500;
            this.statusCheckTimer.Tick += new System.EventHandler(this.CheckMsfsStatus);
            // 
            // ManagerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 854);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.statusPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.simManagerMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "ManagerWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaxOnBoard | Simulation Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerWindow_FormClosing);
            this.Load += new System.EventHandler(this.ManagerWindow_Load);
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.aircraftInfoBox.ResumeLayout(false);
            this.aircraftInfoBox.PerformLayout();
            this.pilotProfileBox.ResumeLayout(false);
            this.pilotProfileBox.PerformLayout();
            this.pilotProfileBoxLogin.ResumeLayout(false);
            this.pilotProfileBoxLogin.PerformLayout();
            this.pilotProfileBoxNotInitialized.ResumeLayout(false);
            this.inflightBox.ResumeLayout(false);
            this.flightDetailsBox.ResumeLayout(false);
            this.flightDetailsBox.PerformLayout();
            this.preflightBox.ResumeLayout(false);
            this.notRunningBox.ResumeLayout(false);
            this.simManagerMenu.ResumeLayout(false);
            this.simManagerMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusPanel;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusFlight;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.GroupBox pilotProfileBox;
        private System.Windows.Forms.Label lblPilotName;
        private System.Windows.Forms.Label lblPilotTotalPaxTransported;
        private System.Windows.Forms.Label lblPilotTotalHoursFlown;
        private System.Windows.Forms.Button btnPilotProfileSettings;
        private System.Windows.Forms.Label lblPilotPoints;
        private System.Windows.Forms.Label lblPilotHiredBy;
        private System.Windows.Forms.ToolTip toolTipHelp;
        private System.Windows.Forms.Label lblValPilotTotalPaxTransported;
        private System.Windows.Forms.Label lblValPilotTotallHoursFlown;
        private System.Windows.Forms.Label lblValPilotPoints;
        private System.Windows.Forms.Label lblValPilotHiredBy;
        private System.Windows.Forms.Label lblValPilotName;
        private System.Windows.Forms.GroupBox pilotProfileBoxNotInitialized;
        private System.Windows.Forms.Button btnPilotProfileSignIn;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusMSFS;
        private System.Windows.Forms.GroupBox aircraftInfoBox;
        private System.Windows.Forms.Timer statusCheckTimer;
        private System.Windows.Forms.GroupBox pilotProfileBoxLogin;
        private System.Windows.Forms.MenuStrip simManagerMenu;
        private System.Windows.Forms.ToolStripMenuItem helpStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutPaxOnBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportAProblemToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem paxOnBoardWebsiteToolStripMenuItem;
        private System.Windows.Forms.Button btnPilotProfileJoinUs;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdateToolStripMenuItem;
        private System.Windows.Forms.Button btnLoginBoxOK;
        private System.Windows.Forms.TextBox txtboxLoginBoxPassword;
        private System.Windows.Forms.TextBox txtboxLoginBoxUsername;
        private System.Windows.Forms.Label lblLoginBoxPassword;
        private System.Windows.Forms.Label lblLoginBoxUsername;
        private System.Windows.Forms.Button btnLoginBoxCancel;
        private System.Windows.Forms.Label lblValAircraftTailNumber;
        private System.Windows.Forms.Label lblValAircraftCallsign;
        private System.Windows.Forms.Label lblValAircraftLivery;
        private System.Windows.Forms.Label lblValAircraftModel;
        private System.Windows.Forms.Label lblValAircraftManufacturer;
        private System.Windows.Forms.Label lblAircraftLivery;
        private System.Windows.Forms.Label lblAircraftModel;
        private System.Windows.Forms.Label lblAircraftTailNumber;
        private System.Windows.Forms.Label lblAircraftCallsign;
        private System.Windows.Forms.Label lblAircraftManufacturer;
        private System.Windows.Forms.Panel aircraftPictureBox;
        private System.Windows.Forms.Panel flightDetailsBox;
        private System.Windows.Forms.Label lblValFlightNumber;
        private System.Windows.Forms.Label lblFlightNumber;
        private System.Windows.Forms.Panel paxOnBoardLogo;
        private System.Windows.Forms.Panel aircraftSymbol;
        private System.Windows.Forms.Label lblAirportFinal;
        private System.Windows.Forms.Label lblValAirportFinal;
        private System.Windows.Forms.Label lblAirportFrom;
        private System.Windows.Forms.Label lblValAirportFrom;
        private System.Windows.Forms.Panel preflightBox;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem resetSettingsToDefaultToolStripMenuItem;
        private System.Windows.Forms.Panel spacer;
        private System.Windows.Forms.Label lblPreflightWelcome;
        private System.Windows.Forms.Button btnPreflightProceed;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.Panel inflightBox;
        private System.Windows.Forms.Panel notRunningBox;
        private System.Windows.Forms.Label lblNotRunningWelcome;
    }
}

