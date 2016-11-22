using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;
using Microsoft.Xna.Framework.Input;
using System.Threading;

namespace ControllerLibRP6
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
            if (sendThread.ThreadState != ThreadState.Unstarted || sendThread.ThreadState != ThreadState.Suspended)
            {
                byte[] nullArray = { 0, 0, 0 };
                sendThreeBytes(nullArray);

                sendThread.Suspend();
            }
        }

        public void sendTriggers()
        {
            float rt = GamePad.GetState(Microsoft.Xna.Framework.PlayerIndex.One).Triggers.Right;
            float lt = GamePad.GetState(Microsoft.Xna.Framework.PlayerIndex.One).Triggers.Left;
            float ls = GamePad.GetState(Microsoft.Xna.Framework.PlayerIndex.One).ThumbSticks.Left.X;
            ButtonState btnA = GamePad.GetState(Microsoft.Xna.Framework.PlayerIndex.One).Buttons.A;

            byte controlByte = makeControlByte(lt, rt, btnA);
            byte[] speedByte = makeSpeedBytes(lt, rt, ls);

            byte[] toSend = { controlByte, speedByte[0], speedByte[1] };

            sendThreeBytes(toSend);
        }

        private byte makeControlByte(float lt, float rt, ButtonState mustHit)
        {
            byte toReturn = 0x00;

            if (lt > rt)
            {
                toReturn |= 0x01;
            }

            if (mustHit == ButtonState.Pressed)
            {
                toReturn |= 0x02;
            }

            return toReturn;
        }

        private void sendThreeBytes(byte[] toSend)
        {
            arduino.Write(toSend, 0, 3);
        }

        private void sendAll()
        {
            while (true)
            {
                sendTriggers();
                //Thread.Sleep(2);
            }
        }

        public void DisconnectCom()
        {
            if (arduino.IsOpen)
            {
                byte[] nullArray = { 0, 0, 0 };
                sendThreeBytes(nullArray);
                arduino.Close();
            }
        }

        public void CleanUp()
        {
            if (arduino != null)
            {
                DisconnectCom();
            }

            if (sendThread.ThreadState != ThreadState.Unstarted)
            {
                if (sendThread.ThreadState == ThreadState.Suspended)
                {
                    sendThread.Resume();
                }
                sendThread.Abort();
            }
        }

        public byte[] makeSpeedBytes(float forwardSpeed, float backwardSpeed, float direction)
        {
            Direction rp6Direction;
            float speed;
            float rightMotorSpeed;
            float leftMotorSpeed;

            if (forwardSpeed > backwardSpeed)
            {
                rp6Direction = Direction.Forward;
                speed = forwardSpeed;
            }
            else
            {
                rp6Direction = Direction.Backward;
                speed = backwardSpeed;
            }

            float toSubtract = 0;
            if (direction >= 0) //RIGHT
            {
                leftMotorSpeed = speed;
                toSubtract = speed * direction;
                rightMotorSpeed = speed - toSubtract;
            }
            else                //LEFT
            {
                rightMotorSpeed = speed;
                toSubtract = speed * direction * -1;
                leftMotorSpeed = speed - toSubtract;
            }

            byte leftMotorByte = Convert.ToByte(leftMotorSpeed * 255);
            byte rightMotorByte = Convert.ToByte(rightMotorSpeed * 255);

            byte[] toReturn = { leftMotorByte, rightMotorByte };

            return toReturn;
        }
    }
}