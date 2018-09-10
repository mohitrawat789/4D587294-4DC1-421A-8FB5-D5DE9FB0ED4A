using System;
using System.Windows.Forms;

namespace Parking.Entry.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
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
    }
}