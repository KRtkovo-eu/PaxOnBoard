
namespace PaxOnBoard
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
            this.pilotProfileBoxNotInitialized = new System.Windows.Forms.GroupBox();
            this.btnPilotProfileSignIn = new System.Windows.Forms.Button();
            this.pilotProfileBox = new System.Windows.Forms.GroupBox();
            this.lblValPilotTotalPaxTransported = new System.Windows.Forms.Label();
            this.lblVaPilotTotallHoursFlown = new System.Windows.Forms.Label();
            this.lblValPilotPoints = new System.Windows.Forms.Label();
            this.lblVaPilotHiredBy = new System.Windows.Forms.Label();
            this.lblValPilotName = new System.Windows.Forms.Label();
            this.btnPilotProfileSettings = new System.Windows.Forms.Button();
            this.lblPilotPoints = new System.Windows.Forms.Label();
            this.lblPilotHiredBy = new System.Windows.Forms.Label();
            this.lblPilotTotalPaxTransported = new System.Windows.Forms.Label();
            this.lblPilotTotalHoursFlown = new System.Windows.Forms.Label();
            this.lblPilotName = new System.Windows.Forms.Label();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.statusCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.pilotProfileBoxLogin = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutPaxOnBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paxOnBoardWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.reportAProblemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.pilotProfileBoxNotInitialized.SuspendLayout();
            this.pilotProfileBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusPanel
            // 
            this.statusPanel.BackColor = System.Drawing.SystemColors.Control;
            this.statusPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusMSFS,
            this.lblStatusFlight});
            this.statusPanel.Location = new System.Drawing.Point(0, 639);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(784, 22);
            this.statusPanel.TabIndex = 0;
            this.statusPanel.Text = "statusStrip1";
            // 
            // lblStatusMSFS
            // 
            this.lblStatusMSFS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lblStatusMSFS.Image = global::PaxOnBoard.Properties.Resources.status_error;
            this.lblStatusMSFS.Name = "lblStatusMSFS";
            this.lblStatusMSFS.Size = new System.Drawing.Size(16, 17);
            this.lblStatusMSFS.Text = "MSFS status";
            // 
            // lblStatusFlight
            // 
            this.lblStatusFlight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStatusFlight.Name = "lblStatusFlight";
            this.lblStatusFlight.Size = new System.Drawing.Size(753, 17);
            this.lblStatusFlight.Spring = true;
            this.lblStatusFlight.Text = "lblStatusFlight";
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainSplitContainer.IsSplitterFixed = true;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.AutoScroll = true;
            this.mainSplitContainer.Panel1.Controls.Add(this.aircraftInfoBox);
            this.mainSplitContainer.Panel1.Controls.Add(this.pilotProfileBox);
            this.mainSplitContainer.Panel1.Controls.Add(this.pilotProfileBoxLogin);
            this.mainSplitContainer.Panel1.Controls.Add(this.pilotProfileBoxNotInitialized);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.AutoScroll = true;
            this.mainSplitContainer.Panel2.Controls.Add(this.menuStrip1);
            this.mainSplitContainer.Size = new System.Drawing.Size(784, 639);
            this.mainSplitContainer.SplitterDistance = 250;
            this.mainSplitContainer.SplitterWidth = 1;
            this.mainSplitContainer.TabIndex = 1;
            // 
            // aircraftInfoBox
            // 
            this.aircraftInfoBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.aircraftInfoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aircraftInfoBox.Location = new System.Drawing.Point(0, 375);
            this.aircraftInfoBox.Name = "aircraftInfoBox";
            this.aircraftInfoBox.Size = new System.Drawing.Size(250, 121);
            this.aircraftInfoBox.TabIndex = 2;
            this.aircraftInfoBox.TabStop = false;
            this.aircraftInfoBox.Text = "aircraftInfoBox";
            this.aircraftInfoBox.Visible = false;
            // 
            // pilotProfileBoxNotInitialized
            // 
            this.pilotProfileBoxNotInitialized.Controls.Add(this.btnPilotProfileSignIn);
            this.pilotProfileBoxNotInitialized.Dock = System.Windows.Forms.DockStyle.Top;
            this.pilotProfileBoxNotInitialized.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pilotProfileBoxNotInitialized.Location = new System.Drawing.Point(0, 0);
            this.pilotProfileBoxNotInitialized.Name = "pilotProfileBoxNotInitialized";
            this.pilotProfileBoxNotInitialized.Size = new System.Drawing.Size(250, 136);
            this.pilotProfileBoxNotInitialized.TabIndex = 1;
            this.pilotProfileBoxNotInitialized.TabStop = false;
            this.pilotProfileBoxNotInitialized.Text = "pilotProfileBoxNotInitialized";
            // 
            // btnPilotProfileSignIn
            // 
            this.btnPilotProfileSignIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPilotProfileSignIn.BackgroundImage")));
            this.btnPilotProfileSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPilotProfileSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPilotProfileSignIn.Location = new System.Drawing.Point(11, 18);
            this.btnPilotProfileSignIn.Margin = new System.Windows.Forms.Padding(0);
            this.btnPilotProfileSignIn.Name = "btnPilotProfileSignIn";
            this.btnPilotProfileSignIn.Size = new System.Drawing.Size(226, 111);
            this.btnPilotProfileSignIn.TabIndex = 5;
            this.btnPilotProfileSignIn.UseVisualStyleBackColor = true;
            this.btnPilotProfileSignIn.Click += new System.EventHandler(this.btnPilotProfileSignIn_Click);
            // 
            // pilotProfileBox
            // 
            this.pilotProfileBox.Controls.Add(this.lblValPilotTotalPaxTransported);
            this.pilotProfileBox.Controls.Add(this.lblVaPilotTotallHoursFlown);
            this.pilotProfileBox.Controls.Add(this.lblValPilotPoints);
            this.pilotProfileBox.Controls.Add(this.lblVaPilotHiredBy);
            this.pilotProfileBox.Controls.Add(this.lblValPilotName);
            this.pilotProfileBox.Controls.Add(this.btnPilotProfileSettings);
            this.pilotProfileBox.Controls.Add(this.lblPilotPoints);
            this.pilotProfileBox.Controls.Add(this.lblPilotHiredBy);
            this.pilotProfileBox.Controls.Add(this.lblPilotTotalPaxTransported);
            this.pilotProfileBox.Controls.Add(this.lblPilotTotalHoursFlown);
            this.pilotProfileBox.Controls.Add(this.lblPilotName);
            this.pilotProfileBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pilotProfileBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pilotProfileBox.Location = new System.Drawing.Point(0, 255);
            this.pilotProfileBox.Name = "pilotProfileBox";
            this.pilotProfileBox.Size = new System.Drawing.Size(250, 120);
            this.pilotProfileBox.TabIndex = 0;
            this.pilotProfileBox.TabStop = false;
            this.pilotProfileBox.Text = "pilotProfileBox";
            this.pilotProfileBox.Visible = false;
            // 
            // lblValPilotTotalPaxTransported
            // 
            this.lblValPilotTotalPaxTransported.AutoSize = true;
            this.lblValPilotTotalPaxTransported.Location = new System.Drawing.Point(122, 98);
            this.lblValPilotTotalPaxTransported.Name = "lblValPilotTotalPaxTransported";
            this.lblValPilotTotalPaxTransported.Size = new System.Drawing.Size(181, 13);
            this.lblValPilotTotalPaxTransported.TabIndex = 10;
            this.lblValPilotTotalPaxTransported.Text = "lblValPilotTotalPaxTransported";
            // 
            // lblVaPilotTotallHoursFlown
            // 
            this.lblVaPilotTotallHoursFlown.AutoSize = true;
            this.lblVaPilotTotallHoursFlown.Location = new System.Drawing.Point(78, 78);
            this.lblVaPilotTotallHoursFlown.Name = "lblVaPilotTotallHoursFlown";
            this.lblVaPilotTotallHoursFlown.Size = new System.Drawing.Size(158, 13);
            this.lblVaPilotTotallHoursFlown.TabIndex = 9;
            this.lblVaPilotTotallHoursFlown.Text = "lblVaPilotTotallHoursFlown";
            // 
            // lblValPilotPoints
            // 
            this.lblValPilotPoints.AutoSize = true;
            this.lblValPilotPoints.Location = new System.Drawing.Point(73, 58);
            this.lblValPilotPoints.Name = "lblValPilotPoints";
            this.lblValPilotPoints.Size = new System.Drawing.Size(98, 13);
            this.lblValPilotPoints.TabIndex = 8;
            this.lblValPilotPoints.Text = "lblValPilotPoints";
            // 
            // lblVaPilotHiredBy
            // 
            this.lblVaPilotHiredBy.AutoSize = true;
            this.lblVaPilotHiredBy.Location = new System.Drawing.Point(61, 38);
            this.lblVaPilotHiredBy.Name = "lblVaPilotHiredBy";
            this.lblVaPilotHiredBy.Size = new System.Drawing.Size(104, 13);
            this.lblVaPilotHiredBy.TabIndex = 7;
            this.lblVaPilotHiredBy.Text = "lblVaPilotHiredBy";
            // 
            // lblValPilotName
            // 
            this.lblValPilotName.AutoSize = true;
            this.lblValPilotName.Location = new System.Drawing.Point(50, 19);
            this.lblValPilotName.Name = "lblValPilotName";
            this.lblValPilotName.Size = new System.Drawing.Size(95, 13);
            this.lblValPilotName.TabIndex = 6;
            this.lblValPilotName.Text = "lblValPilotName";
            // 
            // btnPilotProfileSettings
            // 
            this.btnPilotProfileSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPilotProfileSettings.BackgroundImage")));
            this.btnPilotProfileSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPilotProfileSettings.Location = new System.Drawing.Point(221, 8);
            this.btnPilotProfileSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnPilotProfileSettings.Name = "btnPilotProfileSettings";
            this.btnPilotProfileSettings.Size = new System.Drawing.Size(24, 24);
            this.btnPilotProfileSettings.TabIndex = 5;
            this.btnPilotProfileSettings.UseVisualStyleBackColor = true;
            this.btnPilotProfileSettings.Click += new System.EventHandler(this.btnPilotProfileSettings_Click);
            // 
            // lblPilotPoints
            // 
            this.lblPilotPoints.AutoSize = true;
            this.lblPilotPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPilotPoints.Location = new System.Drawing.Point(11, 58);
            this.lblPilotPoints.Name = "lblPilotPoints";
            this.lblPilotPoints.Size = new System.Drawing.Size(66, 13);
            this.lblPilotPoints.TabIndex = 4;
            this.lblPilotPoints.Text = "lblPilotPoints";
            // 
            // lblPilotHiredBy
            // 
            this.lblPilotHiredBy.AutoSize = true;
            this.lblPilotHiredBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPilotHiredBy.Location = new System.Drawing.Point(11, 38);
            this.lblPilotHiredBy.Name = "lblPilotHiredBy";
            this.lblPilotHiredBy.Size = new System.Drawing.Size(74, 13);
            this.lblPilotHiredBy.TabIndex = 3;
            this.lblPilotHiredBy.Text = "lblPilotHiredBy";
            // 
            // lblPilotTotalPaxTransported
            // 
            this.lblPilotTotalPaxTransported.AutoSize = true;
            this.lblPilotTotalPaxTransported.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPilotTotalPaxTransported.Location = new System.Drawing.Point(11, 98);
            this.lblPilotTotalPaxTransported.Name = "lblPilotTotalPaxTransported";
            this.lblPilotTotalPaxTransported.Size = new System.Drawing.Size(136, 13);
            this.lblPilotTotalPaxTransported.TabIndex = 2;
            this.lblPilotTotalPaxTransported.Text = "lblPilotTotalPaxTransported";
            // 
            // lblPilotTotalHoursFlown
            // 
            this.lblPilotTotalHoursFlown.AutoSize = true;
            this.lblPilotTotalHoursFlown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPilotTotalHoursFlown.Location = new System.Drawing.Point(11, 78);
            this.lblPilotTotalHoursFlown.Name = "lblPilotTotalHoursFlown";
            this.lblPilotTotalHoursFlown.Size = new System.Drawing.Size(117, 13);
            this.lblPilotTotalHoursFlown.TabIndex = 1;
            this.lblPilotTotalHoursFlown.Text = "lblPilotTotalHoursFlown";
            // 
            // lblPilotName
            // 
            this.lblPilotName.AutoSize = true;
            this.lblPilotName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPilotName.Location = new System.Drawing.Point(11, 18);
            this.lblPilotName.Name = "lblPilotName";
            this.lblPilotName.Size = new System.Drawing.Size(65, 13);
            this.lblPilotName.TabIndex = 0;
            this.lblPilotName.Text = "lblPilotName";
            // 
            // statusCheckTimer
            // 
            this.statusCheckTimer.Interval = 500;
            this.statusCheckTimer.Tick += new System.EventHandler(this.CheckMsfsStatus);
            // 
            // pilotProfileBoxLogin
            // 
            this.pilotProfileBoxLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pilotProfileBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pilotProfileBoxLogin.Location = new System.Drawing.Point(0, 136);
            this.pilotProfileBoxLogin.Name = "pilotProfileBoxLogin";
            this.pilotProfileBoxLogin.Size = new System.Drawing.Size(250, 119);
            this.pilotProfileBoxLogin.TabIndex = 3;
            this.pilotProfileBoxLogin.TabStop = false;
            this.pilotProfileBoxLogin.Text = "pilotProfileBoxLogin";
            this.pilotProfileBoxLogin.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(533, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportAProblemToolStripMenuItem,
            this.toolStripSeparator2,
            this.paxOnBoardWebsiteToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutPaxOnBoardToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem1.Text = "&Help";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // aboutPaxOnBoardToolStripMenuItem
            // 
            this.aboutPaxOnBoardToolStripMenuItem.Name = "aboutPaxOnBoardToolStripMenuItem";
            this.aboutPaxOnBoardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutPaxOnBoardToolStripMenuItem.Text = "&About PaxOnBoard";
            // 
            // paxOnBoardWebsiteToolStripMenuItem
            // 
            this.paxOnBoardWebsiteToolStripMenuItem.Name = "paxOnBoardWebsiteToolStripMenuItem";
            this.paxOnBoardWebsiteToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.paxOnBoardWebsiteToolStripMenuItem.Text = "PaxOnBoard &Website";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(182, 6);
            // 
            // reportAProblemToolStripMenuItem
            // 
            this.reportAProblemToolStripMenuItem.Image = global::PaxOnBoard.Properties.Resources.status_error;
            this.reportAProblemToolStripMenuItem.Name = "reportAProblemToolStripMenuItem";
            this.reportAProblemToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.reportAProblemToolStripMenuItem.Text = "&Report a Problem";
            this.reportAProblemToolStripMenuItem.Click += new System.EventHandler(this.reportAProblemToolStripMenuItem_Click);
            // 
            // ManagerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.statusPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
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
            this.pilotProfileBoxNotInitialized.ResumeLayout(false);
            this.pilotProfileBox.ResumeLayout(false);
            this.pilotProfileBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Label lblVaPilotTotallHoursFlown;
        private System.Windows.Forms.Label lblValPilotPoints;
        private System.Windows.Forms.Label lblVaPilotHiredBy;
        private System.Windows.Forms.Label lblValPilotName;
        private System.Windows.Forms.GroupBox pilotProfileBoxNotInitialized;
        private System.Windows.Forms.Button btnPilotProfileSignIn;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusMSFS;
        private System.Windows.Forms.GroupBox aircraftInfoBox;
        private System.Windows.Forms.Timer statusCheckTimer;
        private System.Windows.Forms.GroupBox pilotProfileBoxLogin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutPaxOnBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportAProblemToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem paxOnBoardWebsiteToolStripMenuItem;
    }
}

