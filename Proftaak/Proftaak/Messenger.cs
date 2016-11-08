using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proftaak
{
    class Messenger
    {
        public static SerialPort RP6 { get; private set; }

        public Messenger()
        {
            RP6 = new SerialPort();
            RP6.BaudRate = 9600;
        }

        public static void SendStates(string message)
        {
            if (RP6.IsOpen)
            {
                try
                {
                    RP6.WriteLine(message);
                }
                catch (IOException)
                {

                }
            }   
        }

        public void OpenConnection(string port)
        {
            if(port == null) {MessageBox.Show("Geen COM poort geselecteerd");}
            RP6.PortName = port;
            try
            {
                RP6.Open(); 
            }
            catch (IOException ex)
            {
               
            }
        }

        public void CloseConnection()
        {
            try
            {
                RP6.Close();
            }
            catch (IOException ex)
            {

            }
        }
    }
}
