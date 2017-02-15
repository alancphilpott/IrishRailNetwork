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
            grpUpdate.Visible = true;
            btnUpdate.Visible = true;

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
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Boolean valid = true;

            // Validation of Details Entered

            // Not Empty
            if (txtName.Text.Equals("") || txtStreet.Text.Equals("") || txtTown.Text.Equals("") || txtCounty.Text.Equals("") || txtPhoneNo.Text.Equals(""))
            {
                MessageBox.Show("Please Enter All Fields");
                valid = false;
            }

            // Station Status Chosen
            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please Choose A Station Status");
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

            // Update Station Object
            if (valid)
            {
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
                grpUpdate.Visible = false;
                btnUpdate.Visible = false;
            }
        }
    }
}
