
using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Parking
{
    public partial class MasterPage : Form
    {
        public MasterPage()
        {
            InitializeComponent();
        }

        private void BtnGetSerialPortsClick(object sender, EventArgs e)
        {
            const int index = -1;
            var arrayComPortsNames = SerialPort.GetPortNames();

            SetPortNames(index, arrayComPortsNames, null);
            SetBaudRate();
            SetDataBits();
            SetStopBits();
            SetParityBits();
            SetHandShake();
        }

        #region Helper Methods

        private void SetHandShake()
        {
            //Handshake
            cboHandShaking.Items.Add("None");
            cboHandShaking.Items.Add("XOnXOff");
            cboHandShaking.Items.Add("RequestToSend");
            cboHandShaking.Items.Add("RequestToSendXOnXOff");

            //get the first item print it in the text 
            cboHandShaking.Text = cboHandShaking.Items[0].ToString();
        }

        private void SetParityBits()
        {
            //Parity 
            cboParity.Items.Add("None");
            cboParity.Items.Add("Even");
            cboParity.Items.Add("Mark");
            cboParity.Items.Add("Odd");
            cboParity.Items.Add("Space");

            //get the first item print in the text

            cboParity.Text = cboParity.Items[0].ToString();
        }

        private void SetStopBits()
        {
            //Stop Bits
            cboStopBits.Items.Add("One");
            cboStopBits.Items.Add("OnePointFive");
            cboStopBits.Items.Add("Two");
            //get the first item print in the text
            cboStopBits.Text = cboStopBits.Items[0].ToString();
        }

        private void SetDataBits()
        {
            //Data Bits
            cboDataBits.Items.Add(7);
            cboDataBits.Items.Add(8);
            //get the first item print it in the text 
            cboDataBits.Text = cboDataBits.Items[0].ToString();
        }

        private void SetBaudRate()
        {
            cboBaudRate.Items.Add(300);
            cboBaudRate.Items.Add(600);
            cboBaudRate.Items.Add(1200);
            cboBaudRate.Items.Add(2400);
            cboBaudRate.Items.Add(9600);
            cboBaudRate.Items.Add(14400);
            cboBaudRate.Items.Add(19200);
            cboBaudRate.Items.Add(38400);
            cboBaudRate.Items.Add(57600);
            cboBaudRate.Items.Add(115200);
            cboBaudRate.Items.ToString();

            //get first item print in text
            cboBaudRate.Text = cboBaudRate.Items[0].ToString();
        }

        /// <summary>
        /// Set port names
        /// </summary>
        /// <param name="index"></param>
        /// <param name="arrayComPortsNames"></param>
        /// <param name="comPortName"></param>
        private void SetPortNames(int index, string[] arrayComPortsNames, string comPortName)
        {
            do
            {
                index += 1;
                cboPorts.Items.Add(arrayComPortsNames[index]);
            } while (!(arrayComPortsNames[index] == comPortName || index == arrayComPortsNames.GetUpperBound(0)));

            //want to get first out
            if (index == arrayComPortsNames.GetUpperBound(0))
            {
                comPortName = arrayComPortsNames[0];
            }

            cboPorts.Text = comPortName;
        }

        #endregion

        private void BtnSaveClick(object sender, EventArgs e)
        {

        }
    }
}
