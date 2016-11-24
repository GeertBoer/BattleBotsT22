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

        private int timesHitSomeone = 0;
        private int timesGotHit = 0;

        public MainForm()
        {
            InitializeComponent();
            Client.Client.GamePaused += Client_GamePaused;
            Client.Client.GameStopped += Client_GameStopped;
            Client.Client.GameStarted += Client_GameStarted;
            Client.Client.PenaltyReceived += Client_PenaltyReceived;
        }

        private void Client_PenaltyReceived(object sender, EventArgs e)
        {
            AmountOfPenalties++;
        }

        private void Client_GameStarted(object sender, EventArgs e)
        {
            //controller.AllowSending = true;
            testlabel.Text = "mooomooomooo";
        }

        private void Client_GameStopped(object sender, EventArgs e)
        {
            controller.AllowSending = false;
            timesHitSomeone = 0;
            timesGotHit = 0;
            updateLabels();
        }

        private void Client_GamePaused(object sender, EventArgs e)
        {
            controller.AllowSending = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIPAdress.Text))
            {
                string groupNumber = nudGroupNumber.Value.ToString();
                string ip = txtIPAdress.Text;

                Client.Client.Connect("pc6", ip, 5000);
            }
            else MessageBox.Show("Vul een ip-adres in");
        }

        private void btnDisconnectHub_Click(object sender, EventArgs e)
        {
            try
            {
                Client.Client.Close();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Er is geen connectie om te verbreken.");
            }
        }

        private void btnConnectController_Click(object sender, EventArgs e)
        {
            if (controller == null)
            {
                int com = Convert.ToInt32(txtComPort.Text);
                try
                {
                    controller = new ControllerHandler(com);
                    controller.GotHit += Controller_GotHit;
                    controller.HitSomeone += Controller_HitSomeone;
                }
                catch (System.IO.IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else MessageBox.Show("already active");
        }

        private void Controller_HitSomeone(object sender, EventArgs e)
        {
            //Client.Client.Punt();
            //timesHitSomeone++;
            //updateLabels();
        }

        private void Controller_GotHit(object sender, EventArgs e)
        {
            //Client.Client.Hit();
            //timesGotHit++;
            //updateLabels();
        }

        private void btnOverrideStart_Click(object sender, EventArgs e)
        {
            if (controller != null)
            {
                controller.AllowSending = true;
            }
            else MessageBox.Show("De controller functie is nog niet gestart");
        }

        private void btnDisconnectController_Click(object sender, EventArgs e)
        {
            if (controller != null)
            {
                controller.Disconnect();
            }
        }

        private void updateLabels()
        {
            //lblTimesGotHit.Text = timesGotHit.ToString();
            //lblTimesHitSomeone.Text = timesHitSomeone.ToString();
        }
    }
}