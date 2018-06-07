using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XwComPortDetector
{
    public partial class Guess : Form
    {
        //********************************************************************************************
        public Guess()
        {
            InitializeComponent();
        }

        //********************************************************************************************
        public void Log(string text)
        {
            Invoke((Action)(() =>
            {
                lock (StatusBox)
                {
                    try
                    {
                        string str = text + "\r\n";
                        StatusBox.AppendText(str);
                        StatusBox.ScrollToCaret();
                    }
                    catch { }
                }
            }));
        }

        //********************************************************************************************
        private void Guess_Load(object sender, EventArgs e)
        {

        }

        //********************************************************************************************
        private System.Object SerialIncoming = null;
        private void btnStart_Click(object sender, EventArgs e)
        {
            StatusBox.Text = "";
            Task.Run(() =>
            {
                string[] ports = SerialPort.GetPortNames();
                foreach (string PortName in ports)
                {
                    Log($"---------------- Try port {PortName} ------------------");

                    foreach (int databits in new[] { 8, 7, 6, 5 })
                    {
                        if (databits == 8 && !checkData8.Checked) continue;
                        if (databits == 7 && !checkData7.Checked) continue;
                        if (databits == 6 && !checkData6.Checked) continue;
                        if (databits == 5 && !checkData5.Checked) continue;

                        foreach (StopBits stop in new[] { StopBits.One, StopBits.OnePointFive, StopBits.Two })
                        {
                            if (stop == StopBits.One && !checkStop1.Checked) continue;
                            if (stop == StopBits.OnePointFive && !checkStop15.Checked) continue;
                            if (stop == StopBits.Two && !checkStop2.Checked) continue;

                            foreach (Parity parity in Enum.GetValues(typeof(Parity)))
                            {
                                if (parity == Parity.Even && !checkParityEven.Checked) continue;
                                if (parity == Parity.Mark && !checkParityMark.Checked) continue;
                                if (parity == Parity.None && !checkParityNone.Checked) continue;
                                if (parity == Parity.Odd && !checkParityOdd.Checked) continue;
                                if (parity == Parity.Space && !checkParitySpace.Checked) continue;

                                foreach (int speed in new[] { 1200, 2400, 4800, 9600, 19200, 38400, 57600, 115200 })
                                {
                                    //wowwww, this is stupid!
                                    if (speed == 1200 && !check1200.Checked) continue;
                                    if (speed == 2400 && !check2400.Checked) continue;
                                    if (speed == 4800 && !check4800.Checked) continue;
                                    if (speed == 9600 && !check9600.Checked) continue;
                                    if (speed == 19200 && !check19200.Checked) continue;
                                    if (speed == 38400 && !check38400.Checked) continue;
                                    if (speed == 57600 && !check57600.Checked) continue;
                                    if (speed == 115200 && !check115200.Checked) continue;

                                    Thread.Sleep(1000);
                                    Log($"- - - - - - - - - - - - - - - - - - - - - - - - -");
                                    SerialIncoming = new Object();
                                    using (SerialPort port = new SerialPort(PortName, speed, parity, databits, stop))
                                    {
                                        try
                                        {
                                            port.Open();
                                            Log($"Connected: {speed},8,{parity},{stop}");
                                            if (checkTestBySend.Checked)
                                            { 
                                                string test = textTest.Text;
                                                test = test.Replace("\\n", "\n");
                                                test = test.Replace("\\r", "\r");
                                                test = test.Replace("\\t", "\t");
                                                port.Write(test);
                                            }
                                            WaitForAData(10000);
                                            string data = port.ReadExisting().Trim();
                                            data = data.Replace("\n", "\\n");
                                            data = data.Replace("\r", "\\r");
                                            data = data.Replace("\t", "\\t");
                                            if (data == "")
                                                Log("NO DATA");
                                            else
                                            {
                                                Log($"DATA: {data}");
                                                Log("\r\n");
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            if (ex.Message.Contains("does not exists"))
                                            {
                                                Log("Port not fount: skip to next Port");
                                                goto NextPort;
                                            }
                                            if (ex.Message.Contains("timeout"))
                                            {
                                                Log("Timeout: skip to next setting");
                                                continue;
                                            }

                                            Log(ex.Message);
                                        }
                                        finally
                                        {
                                            try
                                            {
                                                port.Close();
                                            }
                                            catch { }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    NextPort:;
                }

                Log("-------------------- Done! ----------------------");
            });
        }

        //********************************************************************************************
        private void Proxy(Object unused1, SerialDataReceivedEventArgs unused2)
        {
            lock (SerialIncoming)
            {
                Monitor.Pulse(SerialIncoming);
            }
        }

        //********************************************************************************************
        public bool WaitForAData(int Timeout)
        {
            lock (SerialIncoming)
            {
                if (!Monitor.Wait(SerialIncoming, Timeout))
                {
                    return false;
                }
                return true;
            }
        }
    }
}
