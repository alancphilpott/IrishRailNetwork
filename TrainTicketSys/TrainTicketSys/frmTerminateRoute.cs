using System;
using System.Data;
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

        // When Form Is Loading
        private void frmTerminateRoute_Load(object sender, EventArgs e)
        {
            // Populating the Combo Boxes for selecting Routes
            loadRoutesComboBox();
        }

        private void loadRoutesComboBox ()
        {
            DataSet ds = new DataSet();
            DataTable dt = Routes.getActiveRoutes(ds, "departStation").Tables["Routes"];

            cmbRoutes.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                cmbRoutes.Items.Add(String.Format("{0:00000}", dr["routeID"]) + " DEP: " + String.Format("{0,-20}", dr["departStation"]) + " ARR: " + dr["arrivalStation"]);
            }
        }

        // Back Button Clicked
        private void mnuTerminateRouteBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Show();
        }

        // Exit Button Clicked
        private void mnuTerminateRouteExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // When A Route Is Selected
        private void cmbRoutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Routes aRoute = new Routes();
            aRoute.getRoute(Convert.ToInt32(cmbRoutes.Text.Substring(0, 5)));

            // Populate The Text Boxes For Updating
            txtRouteID.Text = aRoute.getRouteID().ToString("00000");

            DataTable dt;

            dt = Station.getAStation(aRoute.getDepartStation());
            foreach (DataRow dr in dt.Rows)
                txtDepSt.Text = dr[0].ToString();

            dt = Station.getAStation(aRoute.getArrivalStation());
            foreach (DataRow dr in dt.Rows)
                txtArrSt.Text = dr[0].ToString();

            txtDistance.Text = aRoute.getDistance().ToString();
            txtStatus.Text = aRoute.getStatus().ToString();

            grpUpdate.Visible = true;
        }

        // No Button Clicked
        private void btnNo_Click(object sender, EventArgs e)
        {
            // Update Visibility
            grpUpdate.Visible = false;
            cmbRoutes.Text = "Choose Route";
        }

        // Yes Button Clicked
        private void btnYes_Click(object sender, EventArgs e)
        {
            // Terminate Route
            Routes.terminateRouteByRoute(Convert.ToInt32(txtRouteID.Text));

            // Terminate Schedule According To Route ID
            Schedules.terminateScheduleByRoute(Convert.ToInt32(txtRouteID.Text));

            // Display Confirmation
            MessageBox.Show("Route Terminated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Update Visibility
            grpUpdate.Visible = false;
            loadRoutesComboBox();
        }
    }
}
