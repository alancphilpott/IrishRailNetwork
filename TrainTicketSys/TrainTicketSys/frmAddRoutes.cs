using System;
using System.Data;
using System.Windows.Forms;

namespace TrainTicketSys
{
    public partial class frmAddRoutes : Form
    {
        private Form Parent;

        public frmAddRoutes()
        {
            InitializeComponent();
        }

        public frmAddRoutes(Form Parent)
        {
            InitializeComponent();
            this.Parent = Parent;
        }

        // Called When The Form Is Loaded
        private void frmAddRoutes_Load(object sender, EventArgs e)
        {
            // Setting The Next Route ID
            txtRouteID.Text = Routes.nextRouteID().ToString("00000");

            // Populating the Combo Boxes for Selecting Stations
            DataSet ds = new DataSet();
            DataTable dt = Station.getActiveStations(ds,"stationID").Tables["Stations"];

            foreach (DataRow dr in dt.Rows)
            {
                ComboboxItem item = new ComboboxItem
                {
                    Text = dr["name"].ToString(),
                    Value = Convert.ToInt32(dr["stationID"])
                };

                cmbDepSt.Items.Add(item);
                cmbArrSt.Items.Add(item);
            }
        }

        // Back Button Clicked
        private void mnuAddRoutesBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parent.Show();
        }

        // Exit Button Clicked
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Method To Reset The UI Text Boxes To Blank
        private void resetUI()
        {
            txtRouteID.Text = Routes.nextRouteID().ToString("00000");
            txtDistance.Text = "";
            cmbDepSt.SelectedIndex = -1;
            cmbArrSt.SelectedIndex = -1;
        }

        // Method For Validation
        private Boolean validation ()
        {
            Boolean valid = true;

            // Not Empty
            if (txtDistance.Text.Equals(""))
            {
                MessageBox.Show("Please Enter All Fields", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false; return valid;
            }

            // Arrival and Departures Stations Chosen
            if (cmbDepSt.SelectedIndex == -1 || cmbArrSt.SelectedIndex == -1)
            {
                MessageBox.Show("Please Choose Both The Arrival and Departure Station", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false; return valid;
            }

            // Arrival and Departure Stations Not The Same
            if (cmbDepSt.Text.Equals(cmbArrSt.Text))
            {
                MessageBox.Show("Please Choose A Different Departure and Arrival Station", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false; return valid;
            }

            // Making Sure The Distance Is Valid
            try
            {
                Convert.ToDecimal(txtDistance.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Re-Enter Route Distance", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false; return valid;
            }
            return valid;
        }

        // Confirm Button Clicked
        private void confirmButtonAddRoutes_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                Routes route = new Routes(
                    Convert.ToInt32(txtRouteID.Text),
                    (cmbDepSt.SelectedItem as ComboboxItem).Value,
                    (cmbArrSt.SelectedItem as ComboboxItem).Value,
                    Convert.ToDouble(txtDistance.Text),
                    'A'
                    );

                route.createRoute();

                // Display Confirmation
                MessageBox.Show("Route Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset UI
                resetUI();
            }
        }
    }
}
