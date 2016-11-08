using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Xna.Framework.Input;
using BattleBotClient;

namespace Proftaak
{
    public partial class Proftaak_Form : Form
    {
        private Messenger messenger;
        private List<string> SerialPorts = new List<string>();
        //private Client client = new Client(6, "192.168.1.1", 5000);
        //private bool gameStarted = true;
        //private bool gamePauzed = false;
        public enum State { Start, Pause, Stop};

        private State gamestate;
        public State gameState {
            get
            {
                return gamestate;
            }
            set
            {

            }
        }

        public Proftaak_Form()
        {
            messenger = new Messenger();
            InitializeComponent();
            gamestate = State.Stop;
            //client.GameStarted += Client_GameStarted;
            //client.GamePaused += Client_GamePaused;
            //client.GameStopped += Client_GameStopped;
        }

        private void Client_GameStopped(object sender, EventArgs e)
        {
            gameState = State.Stop;
        }

        private void Client_GamePaused(object sender, EventArgs e)
        {
            gameState = State.Pause;
        }

        private void Client_GameStarted(object sender, EventArgs e)
        {
            gameState = State.Start;
        }

        private void tUpdate_Tick(object sender, EventArgs e)
        {
            UpdatePorts();
            UpdateLabels();            
        }

        private void UpdateLabels()
        {
            lblTriggerLeft.Text = "TriggerLeft: " + (Controller.TriggerLeft/100).ToString();
            lblTriggerRight.Text = "TriggerRight: " + (Controller.TriggerRight/100).ToString();
            lblDirection.Text = "Direction: " + Controller.X.ToString();
            lblSpeed.Text = "Speed: " + (Controller.TriggerRight - Controller.TriggerLeft).ToString();
            lblDirectionString.Text = "DirectionString: " + Controller.DirectionString;
            lblSpeedString.Text = "SpeedString: " + Controller.SpeedString;

            if (Controller.Gamepad.IsConnected)
            {
                lblController.Text = "Controller: Connected";
            }
            else
            {
                lblController.Text = "Controller: Disconnected";
            }

            if (Messenger.RP6.IsOpen && gamestate == State.Start)
            {
                lblRP6.Text = "RP6: Connected";
                btnConnectToRP6.Text = "Disconnect";
            }
            else
            {
                lblRP6.Text = "RP6: Disconnected";
                btnConnectToRP6.Text = "Connect";
            }
        }

        private void btnConnectToRP6_Click(object sender, EventArgs e)
        {
            if (!Messenger.RP6.IsOpen && gamestate == State.Start)
            {
                messenger.OpenConnection(cbCOMPorts.Text);
            }
            else
            {
                messenger.CloseConnection();
            }
        }

        private void UpdatePorts()
        {
            bool newList = false;
            foreach (string port in SerialPorts)
            {
                if (!SerialPort.GetPortNames().Contains(port) && SerialPorts.Count != SerialPort.GetPortNames().Count())
                {
                    newList = true;
                }
            }
            if (SerialPorts.Count == 0)
            {
                newList = true;
            }
            if (SerialPort.GetPortNames().Count() == 0)
            {
                SerialPorts.Clear();
                cbCOMPorts.Text = String.Empty;
            }
            if (newList)
            {
                SerialPorts.Clear();
                cbCOMPorts.Items.Clear();
                cbCOMPorts.Text = String.Empty;
                SerialPorts.AddRange(SerialPort.GetPortNames());
                cbCOMPorts.Items.AddRange(SerialPorts.ToArray());
            }
        }
    }
}
