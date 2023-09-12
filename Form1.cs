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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO.IOexception;

namespace LAB_2_CAL
{
    public partial class Form1 : Form
    {
        SerialPort serialPort = new SerialPort();
       

        public Form1()
        {
            InitializeComponent();
            serialPort = new SerialPort();
            serialPort.BaudRate = 9600;
            serialPort.PortName = "COM9";
            serialPort.Open();
            serialPort.Parity = Parity.None;
            serialPort.DataBits = 8;
            serialPort.StopBits = StopBits.One;
            serialPort.Handshake = Handshake.None;
            Label label1 = new Label();
            // Set the label's text.
            label1.Location = new Point(10, 10);
            // Add the label to the form.
            this.Controls.Add(label1);
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Send the "connect" command to the Arduino.
            serialPort.WriteLine("CONNECT");
            // Update the label to show the current mode.
            label1.Text = "Mode: Connect";
          
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Send the "mode1" command to the Arduino.
            serialPort.WriteLine("Mode 2");
            // Update the label to show the current mode.
            label1.Text = "Mode: 2";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Send the "mode1" command to the Arduino.
            serialPort.WriteLine("Mode 3");
            // Update the label to show the current mode.
            label1.Text = "Mode: 3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Send the "mode1" command to the Arduino.
            serialPort.WriteLine("Mode 4");
            // Update the label to show the current mode.
            label1.Text = "Mode: 4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Send the "disconnect" command to the Arduino.
            serialPort.WriteLine("disconnect");
            // Update the label to show the current mode.
            label1.Text = "Mode: Disconnect";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Send the "mode1" command to the Arduino.
            serialPort.WriteLine("Mode 1");
            // Update the label to show the current mode.
            label1.Text = "Mode: 1";
        }
    }






      
  
}
