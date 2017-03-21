using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Right now close station is operating via the user selecting the station status.
 * Should the user be able to set the station to active as well as closed?
 */

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

        private void mnuCloseStationBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Show();
        }

        private void mnuCloseStationExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loadStationsComboBox ()
        {
            // Populating the Combo Boxes for selecting Stations
            DataSet ds = new DataSet();
            DataTable dt = Station.getActiveStations(ds, "name").Tables["Stations"];

            cmbStations.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                cmbStations.Items.Add(String.Format("{0:00000}", dr["stationID"]) + " " + dr["name"]);
            }
        }

        // Called when a selection is made in the ComboBox
        private void cmbStations_SelectedIndexChanged(object sender, EventArgs e)
        {
            Station aStation = new Station();
            aStation.getStation(Convert.ToInt32(cmbStations.Text.Substring(0,5)));

            grpUpdate.Visible = true;
            btnYes.Visible = true;
            btnNo.Visible = true;

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
            // Station Status
            char stStatus = 'C';

            // Update Station Object
            Station.updateStation(
                Convert.ToInt32(txtStID.Text),
                txtName.Text,
                txtStreet.Text,
                txtTown.Text,
                txtCounty.Text,
                txtPhoneNo.Text,
                stStatus);

            // Display Confirmation
            MessageBox.Show("Station Closed Successfully");
            // Reload ComboBox
            loadStationsComboBox();
            // Update Visibility
            grpUpdate.Visible = false;
        }
    }
}
