using System;
using System.Windows.Forms;

namespace Parking
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vehicleExit = new VehicleExit();
            vehicleExit.Show();
        }
    }
}
