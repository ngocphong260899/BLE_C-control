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
namespace BLE_Control
{
    public partial class Form1 : Form
    {
        string relay1_on = "{\"cmd\":1}";
        string relay1_off = "{\"cmd\":2}";
        string relay2_on = "{\"cmd\":3}";
        string relay2_off = "{\"cmd\":4}";
        String json = "{\"name\":\"phong\", \"age\": 15, \"add\": \"this is add\"}";
        DateTime data = DateTime.Now;
        //​delegate void SetTextCallback(string text);



        public Form1()
        {
            InitializeComponent();
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            this.label4.Text = data.ToString();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            comboBox1.Text = ("COM3");
            comboBox1.DataSource = SerialPort.GetPortNames();
            textBox1.ReadOnly = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {

                          
             serialPort1.PortName = comboBox1.Text;
             
             serialPort1.Open();
             label3.Text = ("Connect");
             label3.ForeColor = Color.Green;
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            label3.Text = ("Disconnect");
            label3.ForeColor = Color.Red;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("Please connect COM");
                return;
            }

            serialPort1.Write(relay1_on);
            textBox1.Text += (relay1_on)+' ' + data.ToString()+ "\r\n";


        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("Please connect COM");
                return;
            }

            serialPort1.Write(relay1_off);
            textBox1.Text += (relay1_off) + ' ' + data.ToString() + "\r\n";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("Please connect COM");
                return;
            }

            serialPort1.Write(relay2_on);
            textBox1.Text += (relay2_on) + ' ' + data.ToString() + "\r\n";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("Please connect COM");
                return;
            }

            serialPort1.Write(relay2_off);
            textBox1.Text += (relay2_off) + ' ' + data.ToString() + "\r\n";
        }
    }
}
