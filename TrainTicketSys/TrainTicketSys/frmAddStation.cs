using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace TrainTicketSys
{
    public partial class frmAddStation : Form
    {
        private Form Parent;
        OracleConnection con;

        public frmAddStation()
        {
            InitializeComponent();
        }

        public frmAddStation(Form Parent)
        {
            InitializeComponent();
            this.Parent = Parent;
        }

        private void frmAddStation_Load(object sender, EventArgs e)
        {
            txtStID.Text = Station.nextStationID().ToString("00000");
        }

        private void mnuAddStationBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Method To Reset The UI Text Boxes To Blank
        private void resetUI ()
        {
            txtStID.Text = Station.nextStationID().ToString("00000");
            txtStation.Text = "";
            txtStreet.Text = "";
            txtTown.Text = "";
            txtCounty.Text = "";
            txtPhoneNo.Text = "";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Boolean valid = true;
            
            // Validation of Details Entered

            // Not Empty
            if (txtStation.Text.Equals("") || txtStreet.Text.Equals("") || txtTown.Text.Equals("") || txtCounty.Text.Equals("") || txtPhoneNo.Text.Equals(""))
            {
                MessageBox.Show("Please Enter All Fields");
                valid = false;
            }

            // Expected Values
            if (txtPhoneNo.Text.Length > 16)
            {
                MessageBox.Show("Phone Number Must Not Exceed 16 Characters");
                valid = false;
            }
            foreach (char c in txtPhoneNo.Text)
            {
                if (c < '0' || c > '9')
                {
                    MessageBox.Show("Phone Number Must Be All Digits");
                    valid = false;
                }
            }

            // Instantiate Station Object
            if (valid)
            {
                Station station = new Station(
                    Convert.ToInt32(txtStID.Text),
                    txtStation.Text.ToUpper(),
                    txtStreet.Text.ToUpper(),
                    txtTown.Text.ToUpper(),
                    txtCounty.Text.ToUpper(),
                    txtPhoneNo.Text,
                    'A');

                station.createStation();

                // Display Confirmation
                MessageBox.Show("Station Created Successfully");

                // Reset UI
                resetUI();
            }
        }
    }
}