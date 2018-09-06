using System;
using System.Windows.Forms;

namespace Parking
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            
        }

        private void BtnSettingsClick(object sender, EventArgs e)
        {
            Hide();
            var masterPage = new MasterPage();
            masterPage.Show();
        }
    }
}
