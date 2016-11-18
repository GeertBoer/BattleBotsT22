using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using Microsoft.Xna.Framework.Input;
using System.Threading;

namespace ControllerReader
{
    public partial class Form1 : Form
    {
        ControllerHandler handler;
        public Form1()
        {
            InitializeComponent();
            handler = new ControllerHandler();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            handler.Connect((Convert.ToInt32(txtCom.Text)));
        }

        private void btnStartSending_Click(object sender, EventArgs e)
        {
            handler.Start();
        }

        private void btnStopSending_Click(object sender, EventArgs e)
        {
            handler.Stop();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            handler.DisconnectCom();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            handler.CleanUp();
        }
    }
}
