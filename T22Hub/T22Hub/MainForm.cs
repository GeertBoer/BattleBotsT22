using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client;
using ControllerLibRP6;

namespace T22Hub
{
    public partial class MainForm : Form
    {
        private int AmountOfPenalties = 0;
        private ControllerHandler controller;
        private bool controllerHasStarted;

        public MainForm()
        {
            InitializeComponent();
            Client.Client.GamePaused += Client_GamePaused;
            Client.Client.GameStopped += Client_GameStopped;
            Client.Client.GameStarted += Client_GameStarted;
            Client.Client.PenaltyReceived += Client_PenaltyReceived;
            controllerHasStarted = false;
        }

        private void Client_PenaltyReceived(object sender, EventArgs e)
        {
            AmountOfPenalties++;
        }

        private void Client_GameStarted(object sender, EventArgs e)
        {
            controller.AllowSending = true;
        }

        private void Client_GameStopped(object sender, EventArgs e)
        {
            controller.AllowSending = false;
        }

        private void Client_GamePaused(object sender, EventArgs e)
        {
            controller.AllowSending = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string groupNumber = nudGroupNumber.Value.ToString();
            string ip = txtIPAdress.Text;

            Client.Client.Connect(groupNumber, ip, 5000);
        }

        private void btnDisconnectHub_Click(object sender, EventArgs e)
        {
            Client.Client.Close();
        }
        
        private void btnConnectController_Click(object sender, EventArgs e)
        {
            if (controller == null)
            {
                int com = Convert.ToInt32(txtComPort.Text);
                controller = new ControllerHandler(com);
                controller.GotHit += Controller_GotHit;
                controller.HitSomeone += Controller_HitSomeone;
            }
        }

        private void Controller_HitSomeone(object sender, EventArgs e)
        {
            Client.Client.Punt();
        }

        private void Controller_GotHit(object sender, EventArgs e)
        {
            Client.Client.Hit();
        }

        private void btnOverrideStart_Click(object sender, EventArgs e)
        {
            controller.AllowSending = true;
        }

        private void btnDisconnectController_Click(object sender, EventArgs e)
        {
            controller.Disconnect();
        }
    }
}
