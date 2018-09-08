﻿
using System;
using System.Windows.Forms;
using Parking.Classes;

namespace Parking
{
    public partial class Settings : Form
    {
        private readonly ParkingDatabaseFactory parkingDatabaseFactory;

        public Settings()
        {
            InitializeComponent();
            parkingDatabaseFactory = new ParkingDatabaseFactory();
        }

        private void BtnSaveClick(object sender, EventArgs e)
        {
            parkingDatabaseFactory.UpdateMasterSettings(txtCompanyName.Text,
                                                      txtParkingPlaceCode.Text,
                                                      txtParkingPlaceName.Text,
                                                      txtTwoWheelerParkingChargesPerHour.Text,
                                                      txtFourWheelerParkingChargesPerHour.Text,
                                                      txtLostTicketPenalty.Text,
                                                      txtPLCBoardPortNumber.Text);
            LoadSettings();
            Hide();
        }

        private void SettingsLoad(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void LoadSettings()
        {
            var dr = parkingDatabaseFactory.GetMasterSettings();
            txtCompanyName.Text = dr[0].ToString();
            txtParkingPlaceCode.Text = dr[1].ToString();
            txtParkingPlaceName.Text = dr[2].ToString();
            txtTwoWheelerParkingChargesPerHour.Text = dr[3].ToString();
            txtFourWheelerParkingChargesPerHour.Text = dr[4].ToString();
            txtLostTicketPenalty.Text = dr[5].ToString();
            txtPLCBoardPortNumber.Text = dr[6].ToString();
        }
    }
}
