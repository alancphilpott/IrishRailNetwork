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

        private void frmCloseStation_Load(object sender, EventArgs e)
        {
            // Populating the Combo Boxes for selecting Stations
            DataSet ds = new DataSet();

            DataTable dt = Station.getStations(ds, "stationID").Tables["Stations"];

            foreach (DataRow dr in dt.Rows)
            {
                cmbStations.Items.Add(dr["stationID"] + " " + dr["name"]);
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
        }

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
            MessageBox.Show("Station Updated Successfully");

            // Update Visibility
            grpUpdate.Visible = false;
            cmbStations.Text = "Please Choose A Station";
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            // Update Visibility
            grpUpdate.Visible = false;
            cmbStations.Text = "Please Choose A Station";
        }
    }
}
