using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace TrainTicketSys
{
    public partial class frmAddStation : Form
    {
        private Form Parent;
        private String validationMessage;

        public frmAddStation()
        {
            InitializeComponent();
        }

        public frmAddStation(Form Parent)
        {
            InitializeComponent();
            this.Parent = Parent;
        }

        // Method When Form Is Loading
        private void frmAddStation_Load(object sender, EventArgs e)
        {
            // this.BackColor = System.Drawing.ColorTranslator.FromHtml("#477187");
            // this.ForeColor = System.Drawing.ColorTranslator.FromHtml("#032536");
            txtStID.Text = Station.nextStationID().ToString("00000");
        }

        // Clicking Back Button
        private void mnuAddStationBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Show();
        }

        // Clicking Exit Button
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Method To Reset The UI
        private void resetUI ()
        {
            txtStID.Text = Station.nextStationID().ToString("00000");
            txtStation.Text = "";
            txtStreet.Text = "";
            txtTown.Text = "";
            txtCounty.Text = "";
            txtPhoneNo.Text = "";
        }

        // Method For Validation
        private Boolean validation ()
        {
            Boolean valid = true;

            // No Empty Fields
            if (txtStation.Text.Equals("") || txtStreet.Text.Equals("") || txtTown.Text.Equals("") || txtCounty.Text.Equals("") || txtPhoneNo.Text.Equals(""))
            {
                MessageBox.Show("Please Enter All Fields","Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false; return valid;
            }

            // Phone Number Numbers Only
            foreach (char c in txtPhoneNo.Text)
            {
                if (c < '0' || c > '9' && valid)
                {
                    MessageBox.Show("Phone Number Must Be All Digits", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    valid = false; return valid;
                }
            }

            return valid;
        }

        // Create Station Button Clicked
        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Validation
            Boolean valid = validation();

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
                MessageBox.Show("Station Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset UI
                resetUI();
            }
        }
    }
}