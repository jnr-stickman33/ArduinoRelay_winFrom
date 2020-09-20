using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ArduinoRelay
{
    public partial class Form1 : Form
    {
        SerialPort SerialPort;
        
        public Form1()
        {
            InitializeComponent();
            ReadFromPort();
          
        }
        public void ReadFromPort()
        {
            // Initialise the serial port on COM4.
            // obviously we would normally parameterise this, but
            // this is for demonstration purposes only.
            this.SerialPort = new SerialPort("COM3")
            {
                BaudRate = 9600,
                Parity = Parity.None,
                StopBits = StopBits.One,
                DataBits = 8,
                Handshake = Handshake.None
            };

            // Subscribe to the DataReceived event.
            //this.SerialPort.DataReceived += SerialPortDataReceived;

            // Now open the port.
            this.SerialPort.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            
            if (b.Text.Equals("On"))
            {
                b.Text = "Off";
                SerialPort.Write("A");
            }
            else
            {
                b.Text = "On";
                SerialPort.Write("B");
            }
        }
    }
}
