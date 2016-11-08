using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Proftaak
{
    class Controller
    {
        public static float X { get; private set; }
        public static float TriggerRight { get; private set; }
        public static float TriggerLeft { get; private set; }
        public static string SpeedString = "";
        public static string DirectionString = "";
        public static GamePadState Gamepad;
        public static System.Threading.Timer timer = new System.Threading.Timer(Timer_Tick, null, 0, 100);

        private static void Timer_Tick(object sender)
        {
            Gamepad = GamePad.GetState(PlayerIndex.One);
            X = Gamepad.ThumbSticks.Left.X;
            TriggerLeft = Gamepad.Triggers.Left * 100;
            TriggerRight = Gamepad.Triggers.Right * 100;

            SpeedString = BitRekenen((int)(((TriggerRight - TriggerLeft) * 127)/100));
            DirectionString = BitRekenen((int)((X * 127) / 1));
            Messenger.SendStates("%" + SpeedString +  "," + DirectionString + "," + "00000000" + "$");
        }

        private static string BitRekenen(int value)
        {
            char[] bitvalue = "00000000".ToCharArray();
            if (value < 0)
            {
                bitvalue[0] = '1';
                value *= -1;
            }
            int index = 1;
            for (int i = 64; i >= 1; i /= 2)
            {
                if(value >= i)
                {
                    bitvalue[index] = '1';
                    value -= i;
                }
                index++;
            }

            string returnString = "";
            foreach (char character in bitvalue)
            {
                returnString += character;
            }
            return returnString;
        }
    }
}
