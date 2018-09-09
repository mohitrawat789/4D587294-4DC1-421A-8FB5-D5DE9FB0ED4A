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

        private void OkButtonClick(object sender, EventArgs e)
        {
            parkingDatabaseFactory.SaveVehicleEntry(txtVehicleNumber.Text);
            MessageBox.Show("VehicleEnteredSuccessfully");
            Hide();
        }

        private void TxtVehicleEntryNumberTextChanged(object sender, EventArgs e)
        {

        }

        private void BtnOneClick(object sender, EventArgs e)
        {
            txtVehicleNumber.Text += btnOne.Text;
        }

        private void BtnTwoClick(object sender, EventArgs e)
        {
            txtVehicleNumber.Text += btnTwo.Text;
        }

        private void BtnThreeClick(object sender, EventArgs e)
        {
            txtVehicleNumber.Text += btnThree.Text;
        }

        private void BtnFourClick(object sender, EventArgs e)
        {
            txtVehicleNumber.Text += btnFour.Text;
        }

        private void BtnFiveClick(object sender, EventArgs e)
        {
            txtVehicleNumber.Text += btnFive.Text;
        }

        private void BtnSixClick(object sender, EventArgs e)
        {
            txtVehicleNumber.Text += btnSix.Text;
        }

        private void BtnSevenClick(object sender, EventArgs e)
        {
            txtVehicleNumber.Text += btnSeven.Text;
        }

        private void BtnEigthClick(object sender, EventArgs e)
        {
            txtVehicleNumber.Text += btnEigth.Text;
        }

        private void BtnNineClick(object sender, EventArgs e)
        {
            txtVehicleNumber.Text += btnNine.Text;
        }

        private void BtnZeroClick(object sender, EventArgs e)
        {
            txtVehicleNumber.Text += btnZero.Text;
        }

        private void BtnBackSpaceClick(object sender, EventArgs e)
        {
            var length = txtVehicleNumber.Text.Length;
            if (length > 0)
            {
                txtVehicleNumber.Text = txtVehicleNumber.Text.Remove(length - 1);
            }
        }
    }
}
