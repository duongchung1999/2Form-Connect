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
using System.Threading;
using MerryTest.Entity;

namespace _2FormConnect
{
    public partial class Form1 : Form
    {
        private UIAdaptiveSize uias;
        public Form1()
        {
            InitializeComponent();
            string[] ports = SerialPort.GetPortNames();
            cbPort.Items.AddRange(ports);
        }

        private void cbPort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbBaurate.Text = "9600";
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            uias = new UIAdaptiveSize
            {
                Width = Width,
                Height = Height,
                FormsName = this.Text,
                X = Width,
            };
            uias.SetInitSize(this);
            flag1 = true;
           
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
                serialPort1.PortName = cbPort.Text;
                serialPort1.BaudRate =int.Parse(cbBaurate.Text);
                serialPort1.DataBits = 8;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Parity = Parity.None;
                serialPort1.Open();
                //timer1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Không thể kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            timer1.Enabled = false;
            try
            {
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Không thể ngắt kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(send == "cmd")
            {
                string dataSend = cbDatasend.Text;
                serialPort1.Write(dataSend);
                Thread.Sleep(3000);
                string dataReturn = serialPort1.ReadExisting();
                txbDataReturn.Text = dataReturn;
            }
            if(send == "byte")
            {
                string[] values = cbDatasend.Text.Split(' ');

                byte[] byteArray = new byte[values.Length];
                for (int i = 0; i < values.Length; i++)
                {
                    byteArray[i] = Convert.ToByte(values[i], 16);
                }
                serialPort1.Write(byteArray, 0, byteArray.Length);
                Thread.Sleep(5000);
                string dataReturn = serialPort1.ReadExisting();
                txbDataReturn.Text = dataReturn;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string dataReturn = serialPort1.ReadExisting();
                txbDataReturn.Text += dataReturn;
                richTextBox1.Text += dataReturn;
            }
            catch
            {
                txbDataReturn.Text = false.ToString();
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            txbDataReturn.Text += serialPort1.ReadLine();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //string dataSend = cbDatasend.Text;
            serialPort1.Write("open");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            serialPort1.Write("close");
        }

        private void btnRead_Click_1(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cbPort.Items.Clear();
            cbPort.Items.AddRange(ports);
        }

        bool flag1 = false;
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (!flag1) return;
            var newx = Width;
            uias.UpdateSize(Width, Height, this);
            uias.X = newx;
        }

        private void btnTestAutoClose_Click(object sender, EventArgs e)
        {
            int i = 0;
        }

        private void cbDatasend_KeyDown(object sender, KeyEventArgs e)
        {
            //btnSend_Click(null, null);
        }

        string send = "cmd";
        private void btnByte_Click(object sender, EventArgs e)
        {
            send = "byte";
            btnByte.Enabled = false;
            btnCmd.Enabled = true;
            btnByte.BackColor = Color.Green;
            btnCmd.BackColor = Color.LightGray;
        }

        private void btnCmd_Click(object sender, EventArgs e)
        {
            send = "cmd";
            btnByte.Enabled = true;
            btnCmd.Enabled = false;
            btnByte.BackColor = Color.LightGray;
            btnCmd.BackColor = Color.Green;
        }

        private void btnA11T_Click(object sender, EventArgs e)
        {
            serialPort1.Write("A11T");
            //Thread.Sleep(100);
            serialPort1.Write("A21T");
            //Thread.Sleep(100);
            serialPort1.Write("A11T");
            //Thread.Sleep(100);
            serialPort1.Write("A21T");
        }

        private void btnA10T_Click(object sender, EventArgs e)
        {
            serialPort1.Write("A10T");
            //Thread.Sleep(100);
            serialPort1.Write("A20T");
            //Thread.Sleep(100);
            serialPort1.Write("A10T");
            //Thread.Sleep(100);
            serialPort1.Write("A20T");
        }
        


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                btnA10T_Click(null, null);
            }
            else if (e.KeyCode == Keys.Right)
            {
                btnA11T_Click(null, null);
            }
        }
        private void btn901_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(cbDatasend.Text);
            Thread.Sleep(1000);
            //string b = cbPortSend.Text;
            var buffer = new byte[serialPort1.BytesToRead];
            var data = serialPort1.Read(buffer, 0, serialPort1.BytesToRead);
            var data1 = ASCIIEncoding.ASCII.GetString(buffer);
            ////Console.WriteLine(data1);
            //string[] getValue = data1.Split('\r', '\n');
            //string a;
            //a = data1.Remove(cbDatasend.Text.Length);
            txbDataReturn.Text = data1;
        }

        private void btnRespond_Click(object sender, EventArgs e)
        {
            readExistting();
        }
        private string readExistting()
        {
            string dataReturn = "";
            string value = "";
            
            serialPort1.DataReceived += SerialPort1_DataReceived;
            Console.WriteLine("Press any key to stop reading...");
            Thread.Sleep(5000);
            return data1;


        }
        string data1;
        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort serialPort = (SerialPort)sender;
            string data = serialPort.ReadExisting();
            var value = data.Split('\r', '\n');
            foreach(var value1 in value)
            {
                if (value1 == "") continue;
                data1 += value1;
            }
            
            Console.WriteLine("Received data: " + data);
        }

        void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort serialPort = (SerialPort)sender;
            string data = serialPort.ReadExisting();
            richTextBox1.Text += data;
            Console.WriteLine("Received data: " + data);
        }
    }
}
