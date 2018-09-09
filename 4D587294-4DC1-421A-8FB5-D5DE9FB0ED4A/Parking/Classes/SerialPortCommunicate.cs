using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Parking.Classes
{
    public class SerialPortCommunicate
    {
        SerialPort sport;

        public SerialPortCommunicate()
        {
            //oSerialPort = new SerialPort();
            //InitializePort();
        }

        public void InitializePort()
        {


        }

        public void Connect(string portName, int baudRate, Parity parity, int databits, StopBits stopBits)
        {
            sport = new SerialPort(portName, baudRate, parity, databits, stopBits);
            try
            {
                sport.Open();
                sport.DataReceived += PortDataReceived;
                MessageBox.Show("Connected Port");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
            }

        }

        private void PortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            var dataReceived = sport.ReadExisting();

            if (dataReceived == "PARKING_ENTRY")
            {
                //VehicleEntryTask();
                MessageBox.Show("Vehicle come to Entry Gate");
            }

            else if (dataReceived == "PARKING_EXIT")
            {
                MessageBox.Show("Vehicle come to Exit Gate");
                //VehicleExitTask();
            }
            else
            {
                MessageBox.Show("Invalid Data");
            }
            //txtReceived.AppendText("[" + dtn + "] " + "Received: " + sport.ReadExisting() + "\n");

        }

        public static void VehicleExitTask()
        {
            var vehicleExit = new VehicleExit();
            vehicleExit.Show();
        }

        public static void VehicleEntryTask()
        {
            var vehicleEntry = new VehicleEntry();
            vehicleEntry.Show();
        }
    }
}
