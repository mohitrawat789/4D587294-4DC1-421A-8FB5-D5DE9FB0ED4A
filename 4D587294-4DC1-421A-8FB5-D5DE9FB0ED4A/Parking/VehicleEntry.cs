using System;
using System.Windows.Forms;
using Parking.Classes;

namespace Parking
{
    public partial class VehicleEntry : Form
    {
        private readonly ParkingDatabaseFactory parkingDatabaseFactory;

        public VehicleEntry()
        {
            InitializeComponent();
            parkingDatabaseFactory = new ParkingDatabaseFactory();
        }

        private void PrintButtonClick(object sender, EventArgs e)
        {
            parkingDatabaseFactory.SaveVehicleEntrySettings(txtVehicleEntryNumber.Text);

            MessageBox.Show("Data Saved and Print");
            Hide();
        }
    }
}
