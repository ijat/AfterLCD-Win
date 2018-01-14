using System;
using System.IO.Ports;
using System.Threading;

namespace AfterLCD_client.Service
{
    class ArduinoSerial
    {
        private SerialPort SP;
        private static ArduinoSerial _in { get; set; }
        public static ArduinoSerial Instance { get { return _in; } set { _in = value; } }

        public int baud { get; set; }
        public string port { get; set; }

        public ArduinoSerial(string port, int baud)
        {
            this.baud = baud;
            this.port = port;
            SP = new SerialPort(port, baud);
        }

        public void Test(string line1, string line2)
        {
            //if (DetectArduino())
            //{
            SP.Open();
            SP.Write(line1 + "\n");
            SP.Write(line2);
            SP.Close();
            //}

        }

        private bool DetectArduino()
        {
            try
            {
                //The below setting are for the Hello handshake
                byte[] buffer = new byte[5];
                buffer[0] = Convert.ToByte(16);
                buffer[1] = Convert.ToByte(128);
                buffer[2] = Convert.ToByte(0);
                buffer[3] = Convert.ToByte(0);
                buffer[4] = Convert.ToByte(4);
                int intReturnASCII = 0;
                char charReturnValue = (Char)intReturnASCII;
                SP.Open();
                SP.Write(buffer, 0, 5);
                Thread.Sleep(1000);
                int count = SP.BytesToRead;
                string returnMessage = "";
                while (count > 0)
                {
                    intReturnASCII = SP.ReadByte();
                    returnMessage = returnMessage + Convert.ToChar(intReturnASCII);
                    count--;
                }

                SP.Close();
                if (returnMessage.Contains("HELLO FROM ARDUINO"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
