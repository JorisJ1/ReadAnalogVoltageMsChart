using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Markup;

namespace TestRealtimeChart2 {
    public partial class Form1 : Form {

        private LinkedList<double> values = new LinkedList<double>();
        private bool isValuesFilled = false;
        private static string portName = "COM3";
        private static SerialPort _serialPort;
        private static Series series1;

        private bool _continue = false;
        private bool _pauseReading = false;

        private ManualResetEvent mre;

        public Form1() {
            InitializeComponent();

            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            series1 = chart1.Series[0];

            Debug.Print("Started");

            mre = new ManualResetEvent(false);
        }

        

        public void ReadSerial() {
            
            while (_continue) {
                mre.WaitOne();

                if (!isValuesFilled && values.Count > 500) {
                        isValuesFilled = true;
                    }
                // IOException when disconnetced.
                    if (double.TryParse(_serialPort.ReadLine(), out double value)) {
                        values.AddLast(value);

                        if (isValuesFilled) {
                            values.RemoveFirst();
                        }

                }
            }
        }

        private void BtnStart_Click(object sender, EventArgs e) {

            Thread readThread = new Thread(new ThreadStart(ReadSerial));

            _serialPort = new SerialPort();
            _serialPort.PortName = "COM3";
            _serialPort.Open();
            _continue = true;
            readThread.Start();

            //readThread.Join();
            //_serialPort.Close();

        }

        private void PortCheckTimer_Tick(object sender, EventArgs e) {
            string[] ports = SerialPort.GetPortNames();
            if (ports.Contains(portName)) {
                LblPortStatus.Text = "Device ready.";
                BtnStart.Enabled = true;
            } else {
                LblPortStatus.Text = "Device not connected.";
                BtnStart.Enabled = false;
                _continue = false;
            }
        }

        private void ChartRefreshTimer_Tick(object sender, EventArgs e) {

            mre.Reset();

            series1.Points.Clear();
            series1.Points.SuspendUpdates();
            foreach (double value in values) {
                series1.Points.AddY(value);
            }
            series1.Points.ResumeUpdates();
            mre.Set();
        }
    }
}
