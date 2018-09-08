using System;
using System.Windows.Forms;
using Parking.Classes;

namespace Parking
{
    public partial class Home : Form
    {
        private SerialPortCommunicate serialPortCommunicate;
        public Home()
        {
            InitializeComponent();
            //serialPortCommunicate = new SerialPortCommunicate();
            //serialPortCommunicate.Connect();
            var entrytest = new EntryTest();
            entrytest.Show();
        }

        private void BtnSettingsClick(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void SettingsToolStripMenuItemClick(object sender, EventArgs e)
        {
            var settings = new Settings();
            settings.Show();
        }

        private void EntryToolStripMenuItemClick(object sender, EventArgs e)
        {
            var vehicleEntry = new VehicleEntry();
            vehicleEntry.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
