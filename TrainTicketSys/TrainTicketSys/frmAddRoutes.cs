using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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

        private void frmAddRoutes_Load(object sender, EventArgs e)
        {
            // Setting the next Route ID
            txtRouteID.Text = Routes.nextRouteID().ToString("00000");

            // Populating the Combo Boxes for selecting Stations
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

        private void mnuAddRoutesBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parent.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Method To Reset The UI Text Boxes To Blank
        private void resetUI()
        {
            txtRouteID.Text = Routes.nextRouteID().ToString("00000");
            txtDistance.Text = "";
            
            cmbDepSt.Text = "Choose Departure Station";
            cmbArrSt.Text = "Choose Arrival Station";
        }

        // Validation and Creation of Route after clicking confirm
        private void confirmButtonAddRoutes_Click(object sender, EventArgs e)
        {
            Boolean valid = true;
            String validationMessage = "";

            // Validation of Details Entered

            // Not Empty
            if (txtDistance.Text.Equals(""))
            {
                validationMessage += " Please Enter All Fields. ";
                valid = false;
            }

            // Arrival and Departures Stations Chosen
            if (cmbDepSt.SelectedIndex == -1 || cmbArrSt.SelectedIndex == -1)
            {
                validationMessage += " Please Choose Both The Arrival and Departure Station. ";
                valid = false;
            }

            // Arrival and Departure Stations Not The Same
            if (cmbDepSt.Text.Equals(cmbArrSt.Text))
            {
                valid = false;
                validationMessage += " Please Choose A Different Departure and Arrival Station";
            }

            // Making sure that the distance is valid
            try
            {
                Convert.ToDecimal(txtDistance.Text);
            } catch (Exception ex)
            {
                valid = false;
                validationMessage += ex.Message + " Please Re-Enter Route Distance.";
            }

            if (!valid)
            {
                MessageBox.Show(validationMessage);
            }

            // Instantiate Route Object
            else
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
                MessageBox.Show("Route Created Successfully");

                // Reset UI
                resetUI();
            }
        }
    }
}
