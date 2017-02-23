using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainTicketSys
{
    public partial class frmAddRoutes : Form
    {
        private Form Parent;

        public frmAddRoutes()
        {
            InitializeComponent();
        }

        public frmAddRoutes(Form Parent)
        {
            InitializeComponent();
            this.Parent = Parent;
        }

        private void frmAddRoutes_Load(object sender, EventArgs e)
        {
            // Setting the next Route ID
            txtRouteID.Text = Routes.nextRouteID().ToString("00000");

            // Populating the Combo Boxes for selecting Stations
            DataSet ds = new DataSet();

            DataTable dt = Station.getStations(ds).Tables["Stations"];

            foreach(DataRow dr in dt.Rows)
            {
                cmbDepSt.Items.Add(dr["Station"]);
                cmbArrSt.Items.Add(dr["Station"]);
            }
        }

        private void mnuAddRoutesBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parent.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void confirmButtonAddRoutes_Click(object sender, EventArgs e)
        {
            Boolean valid = true;
            String validationMessage = "";

            // Validation of Details Entered

            // Not Empty
            if (txtDistance.Text.Equals(""))
            {
                validationMessage += "Please Enter All Fields ";
                valid = false;
            }

            // Station Status Chosen
            if (cmbStatus.SelectedIndex == -1 || cmbDepSt.SelectedIndex == -1 || cmbArrSt.SelectedIndex == -1)
            {
                validationMessage += "Please Choose A Route Status ";
                valid = false;
            }

            foreach (char c in txtDistance.Text)
            {
                if (c < 'A' || c > 'Z')
                {
                    MessageBox.Show("Phone Number Must Be All Digits");
                    valid = false;
                }
            }

            // Station Status
            char stStatus;
            if (cmbStatus.SelectedIndex == 0)
            {
                stStatus = 'A';
            }
            else
            {
                stStatus = 'C';
            }

            if (!valid)
            {
                MessageBox.Show(validationMessage);
            }
            // Instantiate Station Object
            else
            {
                Station station = new Station(
                    Convert.ToInt32(txtStID.Text),
                    txtStation.Text,
                    txtStreet.Text,
                    txtTown.Text,
                    txtCounty.Text,
                    txtPhoneNo.Text,
                    stStatus);

                station.createStation();

                // Display Confirmation
                MessageBox.Show("Station Created Successfully");

                // Reset UI
                resetUI();
            }
    }
}
