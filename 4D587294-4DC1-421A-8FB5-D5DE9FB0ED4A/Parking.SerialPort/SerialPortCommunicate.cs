using System;
using System.IO.Ports;
using Parking.Interfaces;

namespace Parking.PortCommunicate
{
    public class SerialPortCommunicate : ISerialPortCommunicate
    {
        private SerialPort sPort;

        public void Connect(string portName, int baudRate, Parity parity, int databits, StopBits stopBits)
        {
            sPort = new SerialPort(portName, baudRate, parity, databits, stopBits);
            try
            {
                sPort.Open();
                sPort.DataReceived += PortDataReceived;
                Console.WriteLine("Connected Port");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString(), "Error");
            }

        }

        private void PortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var dataReceived = sPort.ReadExisting();

            switch (dataReceived)
            {
                case "PARKING_ENTRY":
                    Console.WriteLine("Vehicle come to Entry Gate");
                    break;
                case "PARKING_EXIT":
                    Console.WriteLine("Vehicle come to Exit Gate");
                    break;
                default:
                    Console.WriteLine("Invalid Data");
                    break;
            }
        }
    }
}
