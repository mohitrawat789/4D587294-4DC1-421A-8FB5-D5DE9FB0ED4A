using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking
{
    public partial class TicketEntryPage : Form
    {
        //private Process keyboardProc;

        public TicketEntryPage()
        {
            InitializeComponent();
        }

        private void TicketEntryPage_Load(object sender, EventArgs e)
        {
            //string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
            //string keyboardPath = Path.Combine(progFiles, "TabTip.exe");

            //this.keyboardProc = Process.Start(keyboardPath);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var vehicleNumber = tbxVehicleNumber.Text;
            Console.WriteLine(vehicleNumber);
        }
    }
}
