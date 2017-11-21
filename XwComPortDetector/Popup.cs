using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace XwComPortDetector
{
    public partial class Popup : Form
    {
        //****************************************************************************
        private Main main = null;

        public Popup(string text, int action, Main main)
        {
            this.main = main;
            InitializeComponent();
            textAvailable.Text = text;
            switch (action)
            {
                case 0:
                    {
                        groupDevice.Text = "";
                        textDevice.Text = "";
                    }
                    break;
                case 1:
                    {
                        groupDevice.Text = "Connected";
                        textDevice.Text = text;
                        textDevice.ForeColor = Color.Green;
                    }
                    break;
                case 2:
                    {
                        groupDevice.Text = "Disconnected";
                        textDevice.Text = text;
                        textDevice.ForeColor = Color.Red;
                    }
                    break;
            }
            string[] ports = SerialPort.GetPortNames();
            string available = "";
            foreach (string port in ports)
            {
                available += $"{port}\n";
            }
            textAvailable.Text = available;
        }

        //****************************************************************************
        private void timerAutoClose_Tick(object sender, EventArgs e)
        {
            main.PopupIndex--;
            this.Close();
        }
    }
}
