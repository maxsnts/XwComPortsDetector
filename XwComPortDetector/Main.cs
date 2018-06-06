using Microsoft.Win32;
using System;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace XwComPortDetector
{
    public partial class Main : Form
    {
        //****************************************************************************
        private const int WM_DEVICECHANGE = 0x219;
        private const int DBT_DEVICEARRIVAL = 0x8000;
        private const int DBT_DEVICEREMOVECOMPLETE = 0x8004;
        private static string[] PreviousAvailablePorts = SerialPort.GetPortNames();
        public int PopupIndex = 1;

        //****************************************************************************
        public Main()
        {
            InitializeComponent();
        }

        //****************************************************************************
        protected override void SetVisibleCore(bool value)
        {
            if (!this.IsHandleCreated)
            {
                value = !GetRunAtLogon();
                CreateHandle();
            }
            base.SetVisibleCore(value);
        }

        //****************************************************************************
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case WM_DEVICECHANGE:
                    switch ((int)m.WParam)
                    {
                        case DBT_DEVICEARRIVAL:
                            {
                                string[] ports = SerialPort.GetPortNames();
                                string connectedDevice = ports.Except(PreviousAvailablePorts).FirstOrDefault();
                                PreviousAvailablePorts = ports;
                                if (connectedDevice != null)
                                {
                                    Popup popup = new Popup(connectedDevice, 1, this);
                                    ShowInactiveTopmost(popup, PopupIndex++);
                                }
                            }
                            break;
                        case DBT_DEVICEREMOVECOMPLETE:
                            {
                                string[] ports = SerialPort.GetPortNames();
                                string disconnectedDevice = PreviousAvailablePorts.Except(ports).FirstOrDefault();
                                PreviousAvailablePorts = ports;
                                if (disconnectedDevice != null)
                                {
                                    Popup popup = new Popup(disconnectedDevice, 2, this);
                                    ShowInactiveTopmost(popup, PopupIndex++);
                                }
                            }
                            break;
                    }
                    break;
            }
        }

        //****************************************************************************
        private void btnShowComPorts_Click(object sender, EventArgs e)
        {
            Popup popup = new Popup("test", 0, this);
            ShowInactiveTopmost(popup, PopupIndex++);
        }

        //****************************************************************************
        private void ApplicationExit()
        {
            appTryIcon.Visible = false;
            Application.Exit();
        }

        //****************************************************************************
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationExit();
        }

        //****************************************************************************
        private void showMainApplicationWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
        }

        //****************************************************************************
        private void showCOMPortsNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnShowComPorts_Click(sender, e);
        }
        
        //****************************************************************************
        private void buttonExit_Click(object sender, EventArgs e)
        {
            ApplicationExit();
        }

        //****************************************************************************
        private void SetRunAtLogon(bool set)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (set)
                registryKey.SetValue("XwComPortsDetector", Application.ExecutablePath);
            else
                registryKey.DeleteValue("XwComPortsDetector");
        }

        //****************************************************************************
        private bool GetRunAtLogon()
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            object run = registryKey.GetValue("XwComPortsDetector");
            return (run != null);
        }

        //****************************************************************************
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
#if !DEBUG
            Hide();
            e.Cancel = true;
#endif
        }

        //****************************************************************************
        private void buttonHideMainWindow_Click(object sender, EventArgs e)
        {
            Hide();
        }

        //****************************************************************************
        private void checkAutoStart_CheckedChanged(object sender, EventArgs e)
        {
            SetRunAtLogon(checkAutoStart.Checked);
        }

        //****************************************************************************
        private void Main_Load(object sender, EventArgs e)
        {
            checkAutoStart.Checked = GetRunAtLogon();
        }

        //****************************************************************************
        private void appTryIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                btnShowComPorts_Click(sender, e);
        }

        //****************************************************************************
        // Show popup withou geting the focus
        //****************************************************************************
        private const int SW_SHOWNOACTIVATE = 4;
        private const int HWND_TOPMOST = -1;
        private const uint SWP_NOACTIVATE = 0x0010;

        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        static extern bool SetWindowPos(
             int hWnd,             // Window handle
             int hWndInsertAfter,  // Placement-order handle
             int X,                // Horizontal position
             int Y,                // Vertical position
             int cx,               // Width
             int cy,               // Height
             uint uFlags);         // Window positioning flags

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        static void ShowInactiveTopmost(Form frm, int index)
        {
            int SW = Screen.PrimaryScreen.Bounds.Width;
            int SH = Screen.PrimaryScreen.Bounds.Height;

            int FW = 200;
            int FH = 140;

            int Margin = 10;
            
            ShowWindow(frm.Handle, SW_SHOWNOACTIVATE);
            SetWindowPos(frm.Handle.ToInt32(), HWND_TOPMOST,
            SW - Margin - FW, 
            SH - ((Margin + FH) * index), 
            FW, 
            FH,
            SWP_NOACTIVATE);
        }

        //****************************************************************************
        private void btnGuessWork_Click(object sender, EventArgs e)
        {
            Guess guess = new Guess();
            guess.ShowDialog();
        }
    }
}
