
namespace PaxOnBoard.Client.Windows.Forms
{
    partial class AboutWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPaxOnBoardUrl = new System.Windows.Forms.LinkLabel();
            this.lblAppVersion = new System.Windows.Forms.Label();
            this.lblAppAuthor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 77);
            this.panel1.TabIndex = 0;
            // 
            // lblPaxOnBoardUrl
            // 
            this.lblPaxOnBoardUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaxOnBoardUrl.AutoSize = true;
            this.lblPaxOnBoardUrl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(170)))));
            this.lblPaxOnBoardUrl.Location = new System.Drawing.Point(182, 135);
            this.lblPaxOnBoardUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaxOnBoardUrl.Name = "lblPaxOnBoardUrl";
            this.lblPaxOnBoardUrl.Size = new System.Drawing.Size(132, 15);
            this.lblPaxOnBoardUrl.TabIndex = 1;
            this.lblPaxOnBoardUrl.TabStop = true;
            this.lblPaxOnBoardUrl.Text = "https://paxonboard.pro";
            this.lblPaxOnBoardUrl.Click += new System.EventHandler(this.lblPaxOnBoardUrl_Click);
            // 
            // lblAppVersion
            // 
            this.lblAppVersion.AutoSize = true;
            this.lblAppVersion.Location = new System.Drawing.Point(9, 81);
            this.lblAppVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppVersion.Name = "lblAppVersion";
            this.lblAppVersion.Size = new System.Drawing.Size(80, 15);
            this.lblAppVersion.TabIndex = 2;
            this.lblAppVersion.Text = "lblAppVersion";
            // 
            // lblAppAuthor
            // 
            this.lblAppAuthor.AutoSize = true;
            this.lblAppAuthor.Location = new System.Drawing.Point(9, 102);
            this.lblAppAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppAuthor.Name = "lblAppAuthor";
            this.lblAppAuthor.Size = new System.Drawing.Size(79, 15);
            this.lblAppAuthor.TabIndex = 3;
            this.lblAppAuthor.Text = "lblAppAuthor";
            // 
            // AboutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 161);
            this.Controls.Add(this.lblAppAuthor);
            this.Controls.Add(this.lblAppVersion);
            this.Controls.Add(this.lblPaxOnBoardUrl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lblPaxOnBoardUrl;
        private System.Windows.Forms.Label lblAppVersion;
        private System.Windows.Forms.Label lblAppAuthor;
    }
}