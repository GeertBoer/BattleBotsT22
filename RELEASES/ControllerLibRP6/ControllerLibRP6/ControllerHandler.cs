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
    public class ControllerHandler
    {
        private SerialPort arduino;
        private Thread sendThread;

        public bool AllowSending = true;

        private bool JustHitSomeone = false;
        private bool JustGotHit = false;

        public delegate void GotHitHandler(object sender, EventArgs e);
        public event GotHitHandler GotHit;
        private void OnGotHit(EventArgs e)
        {
            GotHit(null, e);
        }

        public delegate void HitSomeoneHandler(object sender, EventArgs e);
        public event HitSomeoneHandler HitSomeone;
        private void OnHitSomeone(EventArgs e)
        {
            HitSomeone(null, e);
        }

        public ControllerHandler(int comPort)
        {
            sendThread = new Thread(sendAll);
            connect(comPort);
            sendThread.Start();
        }

        private void connect(int comPort)
        {
            arduino = new SerialPort("COM" + comPort);
            arduino.Open();
            arduino.DataReceived += Arduino_DataReceived;
        }

        public void Disconnect()
        {
            stopSending();
            disconnectCom();
        }

        public void PauseSending()
        {
            if (sendThread.ThreadState == ThreadState.Running)
            {
                stopRP6();
                sendThread.Suspend();
            }
        }

        private void Arduino_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte responseByte = Convert.ToByte(arduino.ReadByte());
            Console.WriteLine(responseByte);
            if ((responseByte & 0x01) != 0)
            {
                OnGotHit(EventArgs.Empty);
                JustGotHit = true;
            }
            if ((responseByte & 0x02) != 0)
            {
                OnHitSomeone(EventArgs.Empty);
                JustHitSomeone = true;
            }
        }

        private void sendTriggers()
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

            if (JustHitSomeone == true)
            {
                toReturn |= 0x10;
                JustHitSomeone = false;
            }

            if (JustGotHit == true)
            {
                toReturn |= 0x20;
                JustGotHit = false;
            }

            return toReturn;
        }

        private void sendThreeBytes(byte[] toSend)
        {
            if (AllowSending == true)
            {
                arduino.Write(toSend, 0, 3);
            }
        }

        private void sendAll()
        {
            while (true)
            {
                sendTriggers();
                Thread.Sleep(35);
            }
        }

        private void stopRP6()
        {
            byte[] nullArray = { 0, 0, 0 };
            sendThreeBytes(nullArray);
        }

        private byte[] makeSpeedBytes(float forwardSpeed, float backwardSpeed, float direction)
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

        private void stopSending()
        { 
            if (sendThread.ThreadState == ThreadState.Suspended)
            {
                sendThread.Resume();
                sendThread.Abort();
            } 
            if ((sendThread.ThreadState != ThreadState.Aborted) || (sendThread.ThreadState != ThreadState.Unstarted))
            {
                sendThread.Abort();
            }
        }

        private void disconnectCom()
        {
            if (arduino.IsOpen)
            {
                arduino.Close();
            }
        }
    }
}