using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beleuchtungssteuerung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Co0nUtilZ.C_NetClient TCPConnection;

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

       

        private void Handle_Connected(object sender, Co0nUtilZ.ProgressEventArgs e)
        {
            this.GUIswitchDisConnected(true);
        }

        private void Handle_Disconnected(object sender, Co0nUtilZ.ProgressEventArgs e)
        {
            this.GUIswitchDisConnected(false);
            this.GUIswitchLEDControllerReady(false);
        }

        private void Handle_DataReceived(object sender, Co0nUtilZ.ProgressEventArgs e)
        {
            bool trueness = e.Message.StartsWith("LED-Control ready."); 
            if (trueness)
            {
                this.GUIswitchLEDControllerReady(true);
            }

        }

        private void Handle_DataSent(object sender, Co0nUtilZ.ProgressEventArgs e)
        {


        }

        delegate void SetControlCallback(bool connected);
        private void GUIswitchDisConnected(bool connected)
        {
            if (this.btnConnect.InvokeRequired) //Falls Invoke benötigt wird (da von anderem Thread aufgerufen)...
            {
                SetControlCallback d = new SetControlCallback(GUIswitchDisConnected);
                this.Invoke(d, new object[] { connected });
            }
            else
            {
                if (connected)
                {
                    
                    this.btnConnect.Enabled = false;
                    this.btnDisconnect.Enabled = true;
                }
                else
                {
                  
                    this.btnConnect.Enabled = true;
                    this.btnDisconnect.Enabled = false;
                }
            }
        }

        private void GUIswitchLEDControllerReady(bool ready)
        {
            if (this.grpLEDControl.InvokeRequired) //Falls Invoke benötigt wird (da von anderem Thread aufgerufen)...
            {
                SetControlCallback d = new SetControlCallback(GUIswitchLEDControllerReady);
                this.Invoke(d, new object[] { ready });
            }
            else
            {
                this.grpLEDControl.Enabled = ready; //When ready is activiated, when not: deactivated

            }
        }

        private void Handle_ErrorOccured(object sender, Co0nUtilZ.ErrorEventArgs e)
        {
            MessageBox.Show("Es ist ein Fehler aufgetreten.\r\n\r\n" + e.Err, "Fehler,", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                this.TCPConnection = new Co0nUtilZ.C_NetClient(this.txtHost.Text, int.Parse(this.txtPort.Text));
                this.TCPConnection.Connected += this.Handle_Connected;
                this.TCPConnection.Disconnected += this.Handle_Disconnected;
                this.TCPConnection.DataReceived += this.Handle_DataReceived;
                this.TCPConnection.DataSent += this.Handle_DataSent;
                this.TCPConnection.OnError += this.Handle_ErrorOccured;
                this.TCPConnection.ConnectToServer();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Verbinden. Bitte prüfen Sie die angegebenen Daten.\r\n\r\n"+ex.ToString(), "Fehler,", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (this.TCPConnection!=null&& this.TCPConnection.IsConnected){
                this.TCPConnection.Disconnect();
            }
        }

        private void btnLedRed_Click(object sender, EventArgs e)
        {
            if (this.TCPConnection!=null && this.TCPConnection.IsConnected)
            {
                this.TCPConnection.SendData(C_RGB_Codes.LEDRED+"\r\n");
            }
        }

        private void btnLedGreen_Click(object sender, EventArgs e)
        {
            if (this.TCPConnection != null && this.TCPConnection.IsConnected)
            {
                this.TCPConnection.SendData(C_RGB_Codes.LEDGREEN + "\r\n");
            }
        }

        private void btnLedBlue_Click(object sender, EventArgs e)
        {
            if (this.TCPConnection != null && this.TCPConnection.IsConnected)
            {
                this.TCPConnection.SendData(C_RGB_Codes.LEDBLUE + "\r\n");
            }
        }

        private void btnLedYellow_Click(object sender, EventArgs e)
        {
            if (this.TCPConnection != null && this.TCPConnection.IsConnected)
            {
                this.TCPConnection.SendData(C_RGB_Codes.LEDYELLOW + "\r\n");
            }
        }

        private void btnLedTurkis_Click(object sender, EventArgs e)
        {
            if (this.TCPConnection != null && this.TCPConnection.IsConnected)
            {
                this.TCPConnection.SendData(C_RGB_Codes.LEDTURKIS + "\r\n");
            }
        }

        private void btnLedOff_Click(object sender, EventArgs e)
        {
            if (this.TCPConnection != null && this.TCPConnection.IsConnected)
            {
                this.TCPConnection.SendData(C_RGB_Codes.LEDOFF + "\r\n");
            }
        }

        private void btnLedPink_Click(object sender, EventArgs e)
        {
            if (this.TCPConnection != null && this.TCPConnection.IsConnected)
            {
                this.TCPConnection.SendData(C_RGB_Codes.LEDPINK + "\r\n");
            }
        }

        private void btnLedWhite_Click(object sender, EventArgs e)
        {
            if (this.TCPConnection != null && this.TCPConnection.IsConnected)
            {
                this.TCPConnection.SendData(C_RGB_Codes.LEDWHITE + "\r\n");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {//Close Connection when closing Window
            if (this.TCPConnection != null && this.TCPConnection.IsConnected)
            {
                //Do not get Events anymory
                this.TCPConnection.Connected -= this.Handle_Connected;
                this.TCPConnection.Disconnected -= this.Handle_Disconnected;
                this.TCPConnection.DataReceived -= this.Handle_DataReceived;
                this.TCPConnection.DataSent -= this.Handle_DataSent;
                this.TCPConnection.OnError -= this.Handle_ErrorOccured;

                this.TCPConnection.Disconnect();
            }
        }
    }
}
