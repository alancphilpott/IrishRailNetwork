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

        // Method Called When The Search Button Is Clicked
        private void btnSearch_Click(object sender, EventArgs e)
        {
            grpUpdate.Visible = false;

            string keyword = txtSearch.Text;

            if (keyword.Equals(""))
            {
                DataSet DS = new DataSet();
                dgStations.DataSource = Station.getStations(DS).Tables["Stations"];
                dgStations.Visible = true;
            }
            else
            {
                DataSet DS = new DataSet();
                dgStations.DataSource = Station.getStations(DS, keyword).Tables["Stations"];
                dgStations.Visible = true;
            }
        }

        // Method Called When The Update Button In A Row Is Clicked
        private void dgStations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;
            int columnID = e.ColumnIndex + 1;
            int ID = Convert.ToInt32(dgStations.Rows[rowID].Cells[columnID].Value);

            dgStations.Visible = false;
            lblStation.Visible = false;
            txtSearch.Visible = false;
            btnSearch.Visible = false;
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
                cmbStatus.Text = row["status"].ToString();
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            // Station Status
            char stStatus;
            if (cmbStatus.Text.Equals("A") || cmbStatus.Text.Equals("Active"))
            {
                stStatus = 'A';
            }
            else
            {
                stStatus = 'C';
            }

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
            lblStation.Visible = true;
            txtSearch.Visible = true;
            btnSearch.Visible = true;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            // Update Visibility
            grpUpdate.Visible = false;
            lblStation.Visible = true;
            txtSearch.Visible = true;
            btnSearch.Visible = true;
        }
    }
}
