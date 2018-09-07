using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Parking.Classes
{
    public class SerialPortCommunicate
    {
        private SerialPort oSerialPort;

        public int BaudRate = 9600;
        public int DataBits = 8;
        public int ReadTimeout = 5000;
        public int WriteTimeout = 500;
        public string PortName = "COM2";
        public string Handshake = "";
        public string Name = "user";
        public string DataReceived = "";
        public string sParity = "none";
        public int iStopBits = 1;

        public SerialPortCommunicate()
        {
            oSerialPort = new SerialPort();
            InitializePort();
        }

        private void InitializePort()
        {
            try
            {
                oSerialPort.PortName = this.PortName;
                oSerialPort.BaudRate = this.BaudRate;
                oSerialPort.DataBits = this.DataBits;
                oSerialPort.ReadTimeout = this.ReadTimeout;
                oSerialPort.WriteTimeout = this.WriteTimeout;

                oSerialPort.Handshake = System.IO.Ports.Handshake.None;
                oSerialPort.DataReceived +=
                    new System.IO.Ports.SerialDataReceivedEventHandler(PortDataReceived);


                if (this.sParity == "even")
                {
                    oSerialPort.Parity = Parity.Even;
                }
                else if (this.sParity == "odd")
                {
                    oSerialPort.Parity = Parity.Odd;
                }
                else if (this.sParity == "mark")
                {
                    oSerialPort.Parity = Parity.Mark;
                }
                else if (sParity == "space")
                {
                    oSerialPort.Parity = Parity.Space;
                }
                else
                {
                    oSerialPort.Parity = Parity.None;
                }

                if (iStopBits == 0)
                {
                    oSerialPort.StopBits = StopBits.None;
                }
                else if (iStopBits == 1.5)
                {
                    oSerialPort.StopBits = StopBits.OnePointFive;
                }
                else if (iStopBits == 2)
                {
                    oSerialPort.StopBits = StopBits.Two;
                }
                else
                {
                    oSerialPort.StopBits = StopBits.One;
                }
                //MessageBox.Show("Configured");

                //Connect();

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void PortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            var inputData = Read();
            if (inputData == "0")
            {
                var vehicleEntry = new VehicleEntry();
                vehicleEntry.Show();

            }
        }

        public void Connect()
        {
            try
            {
                if (!oSerialPort.IsOpen)
                {
                    oSerialPort.Open();
                    //MessageBox.Show("Connected");
                } // else already open 
            }
            catch (Exception e1)
            {
                //MessageBox.Show("Error: Connection is in use or is not available: \n\n" + e1);
            }
        }


        public void Disconnect()
        {
            try
            {
                if (oSerialPort.IsOpen)
                {
                    oSerialPort.Close();
                    //MessageBox.Show("Disconnected");
                } //else not open 
            }
            catch { }
        }

        public void Write(string sData /* string data to write to the port */ )
        {
            if (oSerialPort.IsOpen)
            {
                try
                {
                    oSerialPort.WriteLine(sData);
                    //oSerialPort.Write("\r\n");
                    //MessageBox.Show("Command Issued: " + sData);
                }
                catch { }
            }
        }

        public string Read()
        {
            try
            {
                //byte[] data = new byte[1024];
                //this.DataReceived = oSerialPort.Read(data, 0, data.Length).ToString();
                this.DataReceived = oSerialPort.ReadLine();
                //MessageBox.Show(this.DataReceived);
                return (this.DataReceived);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return "";
            }
        }
    }
}
