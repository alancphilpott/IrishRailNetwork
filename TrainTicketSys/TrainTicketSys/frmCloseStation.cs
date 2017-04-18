using System;
using System.Data;
using System.Windows.Forms;

namespace TrainTicketSys
{
    public partial class frmCloseStation : Form
    {
        private Form Parent;

        public frmCloseStation()
        {
            InitializeComponent();
        }

        public frmCloseStation(Form Parent)
        {
            InitializeComponent();
            this.Parent = Parent;
        }

        // Called When The Form Is Loaded
        private void frmCloseStation_Load(object sender, EventArgs e)
        {
            loadStationsComboBox();
        }

        // Populating ComboBox for Selecting Stations
        private void loadStationsComboBox()
        {
            DataSet ds = new DataSet();
            DataTable dt = Station.getActiveStations(ds, "name").Tables["Stations"];

            cmbStations.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                cmbStations.Items.Add(String.Format("{0:00000}", dr["stationID"]) + " | " + dr["name"]);
            }
        }

        // Back Button Clicked
        private void mnuCloseStationBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Show();
        }

        // Exit Button Clicked
        private void mnuCloseStationExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // ComboBox Selection Is Made
        private void cmbStations_SelectedIndexChanged(object sender, EventArgs e)
        {
            Station aStation = new Station();
            aStation.getStation(Convert.ToInt32(cmbStations.Text.Substring(0,5)));

            grpUpdate.Visible = true;

            txtStID.Text = aStation.getStationID().ToString("00000");
            txtName.Text = aStation.getName();
            txtStreet.Text = aStation.getStreet();
            txtTown.Text = aStation.getTown();
            txtCounty.Text = aStation.getCounty();
            txtPhoneNo.Text = aStation.getPhoneNo();
            txtStatus.Text = aStation.getStatus().ToString();
        }

        // If The User Clicks No
        private void btnNo_Click(object sender, EventArgs e)
        {
            // Update Visibility
            grpUpdate.Visible = false;
        }

        // If The User Clicks Yes
        private void btnYes_Click(object sender, EventArgs e)
        {
            // Close Station Object
            Station.updateStation(
                Convert.ToInt32(txtStID.Text),
                txtName.Text,
                txtStreet.Text,
                txtTown.Text,
                txtCounty.Text,
                txtPhoneNo.Text,
                'C');

            // Terminate Route
            var routes = Routes.getRoutes(Convert.ToInt32(txtStID.Text));
            Routes.terminateRoute(Convert.ToInt32(txtStID.Text));

            // Terminate Schedule
            Schedules.terminateSchedules(routes);

            // Display Confirmation
            MessageBox.Show("Station Closed Successfully","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Reload ComboBox
            loadStationsComboBox();
            // Update Visibility
            grpUpdate.Visible = false;
        }
    }
}
