using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;
using Microsoft.Xna.Framework.Input;
using System.Threading;

namespace ControllerReader
{
    class ControllerHandler
    {
        private SerialPort arduino;
        private Thread sendThread;

        public ControllerHandler()
        {
            sendThread = new Thread(sendAll);
        }

        private void Arduino_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int incoming = arduino.ReadByte();
            Console.WriteLine(incoming);
        }

        public void Connect(int comPort)
        {
            arduino = new SerialPort("COM" + comPort);
            arduino.Open();
            arduino.DataReceived += Arduino_DataReceived;
        }

        public void Start()
        {
            if (sendThread.ThreadState == ThreadState.Unstarted)
            {
                sendThread.Start();
            }
            else if (sendThread.ThreadState == ThreadState.Suspended)
            {
                sendThread.Resume();
            }
        }

        public void Stop()
        {
            sendThread.Suspend();
            sendTwoBytes(0, 0);
        }

        public void sendTriggers()
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
                Thread.Sleep(2);
            }
        }

        public void DisconnectCom()
        {
            if (arduino.IsOpen)
            {
                arduino.Close();
            }
        }

        public void CleanUp()
        {
            if (arduino != null)
            {
                sendTwoBytes(0, 0);
                arduino.Close();
            }
            
            if (sendThread.ThreadState == ThreadState.Suspended)
            {
                sendThread.Start();
            }
            sendThread.Abort();
        }
    }
}
