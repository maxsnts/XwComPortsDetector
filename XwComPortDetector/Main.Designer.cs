namespace XwComPortDetector
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnShowComPorts = new System.Windows.Forms.Button();
            this.appTryIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.appTrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showCOMPortsNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMainApplicationWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonHideMainWindow = new System.Windows.Forms.Button();
            this.checkAutoStart = new System.Windows.Forms.CheckBox();
            this.btnGuessWork = new System.Windows.Forms.Button();
            this.appTrayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowComPorts
            // 
            this.btnShowComPorts.Location = new System.Drawing.Point(6, 44);
            this.btnShowComPorts.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowComPorts.Name = "btnShowComPorts";
            this.btnShowComPorts.Size = new System.Drawing.Size(394, 31);
            this.btnShowComPorts.TabIndex = 0;
            this.btnShowComPorts.Text = "Show COM ports notification now";
            this.btnShowComPorts.UseVisualStyleBackColor = true;
            this.btnShowComPorts.Click += new System.EventHandler(this.btnShowComPorts_Click);
            // 
            // appTryIcon
            // 
            this.appTryIcon.BalloonTipTitle = "XwComPortDetector";
            this.appTryIcon.ContextMenuStrip = this.appTrayMenu;
            this.appTryIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("appTryIcon.Icon")));
            this.appTryIcon.Text = "AppTrayIcon";
            this.appTryIcon.Visible = true;
            this.appTryIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.appTryIcon_MouseClick);
            // 
            // appTrayMenu
            // 
            this.appTrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showCOMPortsNowToolStripMenuItem,
            this.showMainApplicationWindowToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.appTrayMenu.Name = "appTrayMenu";
            this.appTrayMenu.Size = new System.Drawing.Size(241, 70);
            // 
            // showCOMPortsNowToolStripMenuItem
            // 
            this.showCOMPortsNowToolStripMenuItem.Name = "showCOMPortsNowToolStripMenuItem";
            this.showCOMPortsNowToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.showCOMPortsNowToolStripMenuItem.Text = "Show COM ports now";
            this.showCOMPortsNowToolStripMenuItem.Click += new System.EventHandler(this.showCOMPortsNowToolStripMenuItem_Click);
            // 
            // showMainApplicationWindowToolStripMenuItem
            // 
            this.showMainApplicationWindowToolStripMenuItem.Name = "showMainApplicationWindowToolStripMenuItem";
            this.showMainApplicationWindowToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.showMainApplicationWindowToolStripMenuItem.Text = "Show main application window";
            this.showMainApplicationWindowToolStripMenuItem.Click += new System.EventHandler(this.showMainApplicationWindowToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(6, 160);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(394, 31);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit application";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonHideMainWindow
            // 
            this.buttonHideMainWindow.Location = new System.Drawing.Point(6, 125);
            this.buttonHideMainWindow.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHideMainWindow.Name = "buttonHideMainWindow";
            this.buttonHideMainWindow.Size = new System.Drawing.Size(394, 31);
            this.buttonHideMainWindow.TabIndex = 3;
            this.buttonHideMainWindow.Text = "Hide/Minimize to tray this window";
            this.buttonHideMainWindow.UseVisualStyleBackColor = true;
            this.buttonHideMainWindow.Click += new System.EventHandler(this.buttonHideMainWindow_Click);
            // 
            // checkAutoStart
            // 
            this.checkAutoStart.AutoSize = true;
            this.checkAutoStart.Location = new System.Drawing.Point(8, 12);
            this.checkAutoStart.Name = "checkAutoStart";
            this.checkAutoStart.Size = new System.Drawing.Size(191, 17);
            this.checkAutoStart.TabIndex = 4;
            this.checkAutoStart.Text = "Auto Start this application at Logon";
            this.checkAutoStart.UseVisualStyleBackColor = true;
            this.checkAutoStart.CheckedChanged += new System.EventHandler(this.checkAutoStart_CheckedChanged);
            // 
            // btnGuessWork
            // 
            this.btnGuessWork.Location = new System.Drawing.Point(6, 79);
            this.btnGuessWork.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuessWork.Name = "btnGuessWork";
            this.btnGuessWork.Size = new System.Drawing.Size(394, 31);
            this.btnGuessWork.TabIndex = 5;
            this.btnGuessWork.Text = "Try guess COM settings";
            this.btnGuessWork.UseVisualStyleBackColor = true;
            this.btnGuessWork.Click += new System.EventHandler(this.btnGuessWork_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 201);
            this.Controls.Add(this.btnGuessWork);
            this.Controls.Add(this.checkAutoStart);
            this.Controls.Add(this.buttonHideMainWindow);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.btnShowComPorts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XwComPortDetector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.appTrayMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowComPorts;
        private System.Windows.Forms.NotifyIcon appTryIcon;
        private System.Windows.Forms.ContextMenuStrip appTrayMenu;
        private System.Windows.Forms.ToolStripMenuItem showCOMPortsNowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMainApplicationWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonHideMainWindow;
        private System.Windows.Forms.CheckBox checkAutoStart;
        private System.Windows.Forms.Button btnGuessWork;
    }
}

