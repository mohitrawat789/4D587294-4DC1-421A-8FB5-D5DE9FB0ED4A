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

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Hide();
            var settings = new Settings();
            settings.Show();
        }
    }
}
