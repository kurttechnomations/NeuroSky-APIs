using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.IO;
using System.IO.Ports;

using NeuroSky.ThinkGear;
using NeuroSky.ThinkGear.Algorithms;

namespace Neurosky
{
    public partial class Form1 : Form
    {
        Connector connector;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            pictureBox1.Image = Properties.Resources.off;
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            // Initialize a new Connector and add event handlers
            connector = new Connector();
            connector.DeviceConnected += new EventHandler(OnDeviceConnected);
            connector.DeviceConnectFail += new EventHandler(OnDeviceFail);
            connector.DeviceDisconnected += new EventHandler(OnDeviceDisconnected);

            // Scan for devices across COM ports
            // The COM port named will be the first COM port that is checked.
            connector.ConnectScan("COM4");

            connector.setBlinkDetectionEnabled(true);
        }

        void OnDeviceConnected(object sender, EventArgs e)
        {
            Connector.DeviceEventArgs de = (Connector.DeviceEventArgs)e; 
            //MessageBox.Show("Device found: " + de.Device.PortName, "Connect");
            picConnectionStatus.Image = Properties.Resources.Connected;
            de.Device.DataReceived += new EventHandler(OnDataReceived);
        }

        // Called when scanning fails
        void OnDeviceFail(object sender, EventArgs e)
        {
            MessageBox.Show("No devices found!", "Fail");
            picConnectionStatus.Image = Properties.Resources.Fail;
        }

        void OnDeviceDisconnected(object sender, EventArgs e)
        {
            picConnectionStatus.Image = Properties.Resources.Fail;
        }

        void OnDataReceived(object sender, EventArgs e)
        {
            Device.DataEventArgs de = (Device.DataEventArgs)e;
            NeuroSky.ThinkGear.DataRow[] tempDataRowArray = de.DataRowArray;
            
            TGParser tgParser = new TGParser();
            tgParser.Read(de.DataRowArray);
            
            bool hasBlink = false;
            int blinkeye = 0;

            /* Loops through the newly parsed data of the connected headset*/
            // The comments below indicate and can be used to print out the different data outputs. 

            for (int i = 0; i < tgParser.ParsedData.Length; i++)
            {
                if (radio_att.Checked==true 
                    && tgParser.ParsedData[i].ContainsKey("Attention"))
                {
                    
                    updateAttentionMode(tgParser, i);
                    
                }
                else if (radio_me.Checked==true 
                    && tgParser.ParsedData[i].ContainsKey("Meditation"))
                {
                    updateMediationMode(tgParser, i);
                }
                else
                {
                    updateBlinkMode(tgParser, ref hasBlink, ref blinkeye, i);
                }
            }
        }

        private void updateBlinkMode(TGParser tgParser, ref bool hasBlink, ref int blinkeye, int i)
        {
            progressBar1.Visible = false;

            if (tgParser.ParsedData[i].ContainsKey("BlinkStrength"))
            {
                if (tgParser.ParsedData[i]["BlinkStrength"] != blinkeye)
                {
                    hasBlink = true;
                }
                lb_value.Text = tgParser.ParsedData[i]["BlinkStrength"].ToString();
                blinkeye = Convert.ToInt32(tgParser.ParsedData[i]["BlinkStrength"]);
            }

            if (hasBlink == true)
            {
                pictureBox1.Image = Properties.Resources.on;
                Thread.Sleep(1000);
                pictureBox1.Image = Properties.Resources.off;
                hasBlink = false;
            }
        }

        private void updateMediationMode(TGParser tgParser, int i)
        {
            lb_value.Text = tgParser.ParsedData[i]["Meditation"].ToString();
            progressBar1.Value = Convert.ToInt32(tgParser.ParsedData[i]["Meditation"]);

            progressBar1.Visible = true;
            
            if (tgParser.ParsedData[i]["Meditation"] >= 50)
            {
                pictureBox1.Image = Properties.Resources.on;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.off;
            }
        }

        private void updateAttentionMode(TGParser tgParser, int i)
        {
            lb_value.Text = tgParser.ParsedData[i]["Attention"].ToString();
            progressBar1.Value = Convert.ToInt32(tgParser.ParsedData[i]["Attention"]);

            progressBar1.Visible = true;
           
            if (tgParser.ParsedData[i]["Attention"] >= 50)
            {
                pictureBox1.Image = Properties.Resources.on;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.off;
            }
        }

        private void btn_dis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Disconnect!", "Disconnect");
            connector.Close();
        }

    }
}
