using System;
using System.Data;
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

        // Back Button Click
        private void mnuScheduleTrainBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parent.Show();
        }

        // Exit Button Click
        private void mnuScheduleTrainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Method On Form Load
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

        private Boolean validation ()
        {
            Boolean valid = true;

            // Route Chosen
            if (cmbRouteID.SelectedIndex == -1)
            {
                MessageBox.Show("Please Choose A Route", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false; return valid;
            }

            // Day of Week Chosen
            if (cmbDayOfWeek.SelectedIndex == -1)
            {
                MessageBox.Show("Please Choose The Day of Week", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false; return valid;
            }

            // Departure and Arrival Time Not The Same
            if (tpDepTime.Text.Equals(tpArrTime.Text))
            {
                MessageBox.Show("Please Choose A Different Departure and Arrival Time", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false; return valid;
            }
            return valid;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                int dayNum = getDayNum();

                Schedules schedule = new Schedules(
                    Convert.ToInt32(txtScheduleID.Text),
                    Convert.ToInt32(cmbRouteID.Text.Substring(0,5)),
                    dayNum,
                    tpDepTime.Text.Substring(0,5),
                    tpArrTime.Text.Substring(0,5)
                    );

                // Create The Schedule
                schedule.createSchedule();

                // Display Confirmation
                MessageBox.Show("Schedule Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset UI
                resetUI();
            }
        }

        public int getDayNum ()
        {
            String dayOfWeek = cmbDayOfWeek.Text;
            int dayNum = 0;

            switch (dayOfWeek)
            {
                case "Monday":
                    dayNum = 1;
                    break;
                case "Tuesday":
                    dayNum = 2;
                    break;
                case "Wednesday":
                    dayNum = 3;
                    break;
                case "Thursday":
                    dayNum = 4;
                    break;
                case "Friday":
                    dayNum = 5;
                    break;
                case "Saturday":
                    dayNum = 6;
                    break;
                case "Sunday":
                    dayNum = 7;
                    break;
            }
            return dayNum;
        }

        public void resetUI()
        {
            txtScheduleID.Text = Schedules.nextScheduleID().ToString("00000");
            cmbDayOfWeek.SelectedIndex = -1;
            cmbRouteID.SelectedIndex = -1;
            tpDepTime.Text = "00:00";
            tpArrTime.Text = "00:00";
        }
    }
}
