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
    public partial class frmTerminateRoute : Form
    {
        private Form Parent;

        public frmTerminateRoute()
        {
            InitializeComponent();
        }

        public frmTerminateRoute(Form Parent)
        {
            InitializeComponent();
            this.Parent = Parent;
        }

        private void frmTerminateRoute_Load(object sender, EventArgs e)
        {
            // Populating the Combo Boxes for selecting Routes
            DataSet ds = new DataSet();

            DataTable dt = Routes.getActiveRoutes(ds, "routeID").Tables["Routes"];

            foreach (DataRow dr in dt.Rows)
            {
                cmbRoutes.Items.Add(String.Format("{0:00000}", dr["routeID"]) + " " + String.Format("{0,-20}",dr["departStation"]) + " " + dr["arrivalStation"]);
            }
        }

        private void mnuTerminateRouteBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Show();
        }

        private void mnuTerminateRouteExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbRoutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpUpdate.Visible = true;
            int ID = cmbRoutes.SelectedIndex + 1;

            grpUpdate.Visible = true;
            btnYes.Visible = true;
            btnNo.Visible = true;

            DataTable routeData = Routes.getARoute(ID);

            // Populate The Text Boxes For Updating
            foreach (DataRow row in routeData.Rows)
            {
                txtRouteID.Text = ID.ToString();
                txtDepSt.Text = row["departStation"].ToString();
                txtArrSt.Text = row["arrivalStation"].ToString();
                txtDistance.Text = row["distance"].ToString();
                txtStatus.Text = row["status"].ToString();
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            // Update Visibility
            grpUpdate.Visible = false;
            cmbRoutes.Text = "Choose Route";
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            // Station Status
            char routeStatus = 'T';

            // Update Station Object
            Routes.updateRoute(
                Convert.ToInt32(txtRouteID.Text),
                txtDepSt.Text,
                txtArrSt.Text,
                Convert.ToDouble(txtDistance.Text),
                routeStatus);

            // Display Confirmation
            MessageBox.Show("Station Updated Successfully");

            // Update Visibility
            grpUpdate.Visible = false;
            cmbRoutes.Text = "Choose Route";
        }
    }
}
