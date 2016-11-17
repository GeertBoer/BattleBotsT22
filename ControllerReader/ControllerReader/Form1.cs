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
        SerialPort arduino;
        Thread sendThread;
        public Form1()
        {
            InitializeComponent();
            sendThread = new Thread(sendAll);
        }

        private void Arduino_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int incoming = arduino.ReadByte();
            Console.WriteLine(incoming);
        }

        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            arduino = new SerialPort("COM8");
            arduino.Open();
            arduino.DataReceived += Arduino_DataReceived;
        }

        private void sendTriggers()
        {
            float rt = GamePad.GetState(Microsoft.Xna.Framework.PlayerIndex.One).Triggers.Right;
            float lt = GamePad.GetState(Microsoft.Xna.Framework.PlayerIndex.One).Triggers.Left;
            sendTwoBytes(rt, lt);
        }

        private void sendTwoBytes(float leftFloat, float rightFloat)
        {
            leftFloat *= 255;
            rightFloat *= 255;
            byte leftByte = Convert.ToByte(leftFloat);
            byte rightByte = Convert.ToByte(rightFloat);

            byte[] arrayToSend = new byte[2];
            arrayToSend[0] = leftByte;
            arrayToSend[1] = rightByte;

            arduino.Write(arrayToSend, 0, 2);
        }

        private void sendAll()
        {
            while (true)
            {
                sendTriggers();
                Thread.Sleep(50);
            }
        }

        private void btnSendTrigger_Click(object sender, EventArgs e)
        {
            sendThread.Start();
        }

        public void CleanUp()
        {
            sendThread.Abort();
            if (arduino.IsOpen)
            {
                arduino.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CleanUp();
        }

        private byte[] converter(float speed, float direction)
        {
            Direction direct;
            byte leftSpeed;
            byte rightSpeed;

            if (direction <= 0) //LINKS
            {
                direct = Direction.Left;
                direction *= -1;
            }
            else if (direction > 0)
            {
                direct = Direction.Right;
            }
            else direct = Direction.Forward;

            byte directionByte = Convert.ToByte(direction * 255);
            byte speedByte = Convert.ToByte(speed * 255);

            if (direct == Direction.Left)
            {
                rightSpeed = speedByte;
                leftSpeed = Convert.ToByte(rightSpeed - directionByte);
            }
            else if (direct == Direction.Right)
            {
                leftSpeed = speedByte;
                rightSpeed = Convert.ToByte(leftSpeed - directionByte);
            }
            else leftSpeed = rightSpeed = speedByte;

            byte[] toReturn = new byte[2];
            toReturn[0] = leftSpeed;
            toReturn[1] = rightSpeed;

            return toReturn;
        }
    }
}
