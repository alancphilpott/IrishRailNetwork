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

        // Called when the form is loaded
        private void frmCloseStation_Load(object sender, EventArgs e)
        {
            // Populating the Combo Boxes for selecting Stations
            DataSet ds = new DataSet();

            DataTable dt = Station.getActiveStations(ds, "name").Tables["Stations"];

            foreach (DataRow dr in dt.Rows)
            {
                cmbStations.Items.Add(String.Format("{0:00000}",dr["stationID"]) + " " + dr["name"]);
            }
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

            /*
            // Code Before
            grpUpdate.Visible = true;
            int ID = cmbStations.SelectedIndex + 1;

            grpUpdate.Visible = true;
            btnYes.Visible = true;
            btnNo.Visible = true;

            DataTable stationData = Station.getAStation(ID);

            // Populate The Text Boxes For Updating
            foreach (DataRow row in stationData.Rows)
            {
                txtStID.Text = ID.ToString();
                txtName.Text = row["name"].ToString();
                txtStreet.Text = row["street"].ToString();
                txtTown.Text = row["town"].ToString(); ;
                txtCounty.Text = row["county"].ToString();
                txtPhoneNo.Text = row["phoneNo"].ToString();
                txtStatus.Text = row["status"].ToString();
            }

            */
        }

        // If the user clicks no
        private void btnNo_Click(object sender, EventArgs e)
        {
            // Update Visibility
            grpUpdate.Visible = false;
        }

        // If the user clicks yes
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

            // Update Visibility
            grpUpdate.Visible = false;
        }
    }
}
