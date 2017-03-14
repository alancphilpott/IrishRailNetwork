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
    public partial class frmScheduleTrain : Form
    {
        private Form Parent;

        public frmScheduleTrain()
        {
            InitializeComponent();
        }

        public frmScheduleTrain(Form Parent)
        {
            InitializeComponent();
            this.Parent = Parent;
        }

        private void mnuScheduleTrainBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parent.Show();
        }

        private void mnuScheduleTrainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmScheduleTrain_Load(object sender, EventArgs e)
        {
            // Setting the next Schedule ID
            txtScheduleID.Text = Schedules.nextScheduleID().ToString("00000");

            // Populating the Combo Boxes for selecting Routes
            DataSet ds = new DataSet();
            DataTable dt = Routes.getActiveRoutes(ds, "departStation").Tables["Routes"];

            foreach (DataRow dr in dt.Rows)
            {
                cmbRouteID.Items.Add(String.Format("{0:00000}", dr["routeID"]) + " " + String.Format("From: " + "{0,-15}", dr["departStation"]) + "To: " + dr["arrivalStation"]);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Boolean valid = true;
            String validationMessage = "";

            // Validation of Details Entered
            
            // Station Status Chosen
            if (cmbRouteID.SelectedIndex == -1)
            {
                validationMessage += " Please Choose A Route. ";
                valid = false;
            }

            // Number of Carriages Chosen
            if (cmbNumCarriages.SelectedIndex == -1)
            {
                validationMessage += " Please Choose The Number of Carriages. ";
                valid = false;
            }

            // Departure and Arrival Time Not The Same
            if (tpDepTime.Text.Equals(tpArrTime.Text))
            {
                valid = false;
                validationMessage += " Please Choose A Different Departure and Arrival Time. ";
            }

            /*
            // Station Status
            char routeStatus;
            if (cmbStatus.SelectedIndex == 0)
            {
                routeStatus = 'A';
            }
            else
            {
                routeStatus = 'T';
            }
            */

            if (!valid)
            {
                MessageBox.Show(validationMessage);
            }
            // Instantiate Route Object
            else
            {
                Schedules schedule = new Schedules(
                    Convert.ToInt32(txtScheduleID.Text),
                    Convert.ToInt32(cmbRouteID.Text.Substring(0,5)),
                    Convert.ToInt32(cmbNumCarriages.Text),
                    tpDepTime.Text,
                    tpArrTime.Text
                    );

                schedule.createSchedule();

                // Display Confirmation
                MessageBox.Show("Schedule Created Successfully");

                // Reset UI
                resetUI();
            }
        }

        public void resetUI()
        {
            txtScheduleID.Text = Schedules.nextScheduleID().ToString("00000");
        }
    }
}
