
using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Parking
{
    public partial class MasterPage : Form
    {
        private const string NewLine = "\n";

        public MasterPage()
        {
            InitializeComponent();
        }

        private void BtnGetSerialPortsClick(object sender, EventArgs e)
        {
            string[] arrayComPortsNames = null;
            int index = -1;
            string comPortName = null;

            arrayComPortsNames = SerialPort.GetPortNames();
            do
            {
                index += 1;
                rtbIncomingData.Text += arrayComPortsNames[index] + NewLine;

            } while (!(arrayComPortsNames[index] == comPortName || index == arrayComPortsNames.GetUpperBound(0)));
        }
    }
}
