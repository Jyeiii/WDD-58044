using lab2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialPort1.Open(); //initialize and open serial port
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Turn mode1 signal to ArduinoIDE
            serialPort1.Write("mode1");

            label1.Text = "Mode 1";


            button3.Enabled = false;
            button3.BackColor = Color.Gray;

            button4.Enabled = true;
            button4.BackColor = Color.Lime;

            button5.Enabled = true;
            button5.BackColor = Color.Lime;

            button6.Enabled = true;
            button6.BackColor = Color.Lime;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.Write("mode2");

            label1.Text = "Mode 2";


            button3.Enabled = false;
            button3.BackColor = Color.Lime;

            button4.Enabled = true;
            button4.BackColor = Color.Gray;

            button5.Enabled = true;
            button5.BackColor = Color.Lime;

            button6.Enabled = true;
            button6.BackColor = Color.Lime;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            serialPort1.Write("mode1");

            label1.Text = "Mode 1";


            button3.Enabled = false;
            button3.BackColor = Color.Gray;

            button4.Enabled = true;
            button4.BackColor = Color.Lime;

            button5.Enabled = true;
            button5.BackColor = Color.Gray;

            button6.Enabled = true;
            button6.BackColor = Color.Lime;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            serialPort1.Write("mode 4");

            label1.Text = "Mode 4";


            button3.Enabled = false;
            button3.BackColor = Color.Lime;

            button4.Enabled = true;
            button4.BackColor = Color.Lime;

            button5.Enabled = true;
            button5.BackColor = Color.Lime;

            button6.Enabled = true;
            button6.BackColor = Color.Gray;
        }
    }
}

