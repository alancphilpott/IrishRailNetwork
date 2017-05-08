using System;
using System.Data;
using System.Windows.Forms;

namespace TrainTicketSys
{
    public partial class frmSellTicket : Form
    {
        private Form Parent;
        private DateTime localDate = DateTime.Now;

        public frmSellTicket()
        {
            InitializeComponent();
        }

        public frmSellTicket(Form Parent)
        {
            InitializeComponent();
            this.Parent = Parent;
        }

        // Method on Load
        private void frmSellTicket_Load(object sender, EventArgs e)
        {
            // Setting the next Sale ID
            txtSaleID.Text = Sales.nextSaleID().ToString("00000");

            // Populating the Combo Boxes for selecting Routes
            DataSet dsRoutes = new DataSet();
            DataTable dtRoutes = Routes.getActiveRoutes(dsRoutes, "departStation").Tables["Routes"];

            foreach (DataRow dr in dtRoutes.Rows)
            {
                cmbRoute.Items.Add(String.Format("{0:00000}", dr["routeID"]) + " " + String.Format("From: " + "{0,-15}", dr["departStation"]) + "To: " + dr["arrivalStation"]);
            }

			// Populate ComboBox for choosing day
			string[] days = {"1 Monday","2 Tuesday","3 Wednesday","4 Thursday","5 Friday","6 Saturday","7 Sunday"};
			foreach (string s in days)
				cmbDay.Items.Add(s);

            // Populating the Combo Boxes for Selecting Rates
            DataSet dsRates = new DataSet();
            DataTable dtRates = Rates.getRates(dsRates, "description").Tables["Rates"];

            cmbRates.Items.Clear();

            foreach (DataRow dr in dtRates.Rows)
            {
                cmbRates.Items.Add(dr["typeCode"] + " : " + dr["description"]);
            }

            // Set The Date for The Sale Based on Today's Date
            string date = localDate.ToString();
            txtSaleDate.Text = date.Substring(0, 10);
        }

        // Back Button Click
        private void mnuSellTicketBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parent.Show();
        }

        // Exit Button Click
		private void mnuExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

        // When A Route Is Selected
        private void cmbRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update Visibility
            grpDay.Visible = true;
            cmbSchedule.SelectedIndex = -1;
            cmbRates.SelectedIndex = -1;
            cmbDay.SelectedIndex = -1;
            grpSchedule.Visible = false;
            grpRates.Visible = false;

            // If the route was changed after selecting all items
            radioReturn.Checked = false;
            radioSingle.Checked = false;
        }

        // When A Day Is Selected
        private void cmbDay_SelectedIndexChanged(object sender, EventArgs e)
		{
            // Update Visibility
            cmbSchedule.SelectedIndex = -1;
            grpSchedule.Visible = true;
            cmbRates.SelectedIndex = -1;
            radioSingle.Checked = false;
            radioReturn.Checked = false;
            grpRates.Visible = false;

            // Populate With Relevant Schedules
            if (cmbDay.SelectedIndex != -1)
            {
                cmbSchedule.Items.Clear();

                DataSet DS = new DataSet();
                DataTable dtSchedules = Schedules.getScheduleByDay(DS, Convert.ToInt32(cmbRoute.Text.Substring(0, 5)), Convert.ToInt32(cmbDay.Text.Substring(0, 1))).Tables["Schedules"];

                foreach (DataRow dr in dtSchedules.Rows)
                {
                    cmbSchedule.Items.Add(dr["scheduleID"] + " : Dep: " + dr["depTime"] + " : Arr: " + dr["arrTime"]);
                }
            }
		}

        // When A Schedule Is Selected
        private void cmbSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update Visibility
            grpRates.Visible = true;
            radioSingle.Checked = true;
        }

        // Variables For Determining The Price of Ticket
        double distance, rateCost, totalCost;

        // When A Rate Is Selected
        private void cmbRates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRoute.SelectedIndex != -1 && cmbDay.SelectedIndex != -1 && cmbSchedule.SelectedIndex != -1 && cmbRates.SelectedIndex != -1 && (radioSingle.Checked == true || radioReturn.Checked == true))
            {
                DataTable dtRoute = Routes.getARoute(Convert.ToInt32(cmbRoute.Text.Substring(0, 5)));
                foreach (DataRow dr in dtRoute.Rows)
                    distance = Convert.ToDouble(dr["distance"]);

                Rates rate = new Rates();
                rate.getRate(cmbRates.Text.Substring(0, 2));
                rateCost = Convert.ToDouble(rate.getRatePerKM());

                if (radioSingle.Checked == true)
                    totalCost = rateCost * distance;
                else
                    totalCost = (rateCost * distance) * 1.7;

                txtTotalCost.Text = totalCost.ToString("F");
            }
        }

        // Confirm Button Click
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cmbRoute.SelectedIndex == -1 || cmbDay.SelectedIndex == -1 || cmbSchedule.SelectedIndex == -1 ||
                cmbRates.SelectedIndex == -1)
            {
                MessageBox.Show("Please Choose All Required Data", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string returnOrSingle = "";
            if (radioSingle.Checked)
                returnOrSingle = "Single";
            else
                returnOrSingle = "Return";

            string messageToDisplay = "Proceed With Sale? Please Confirm Details: " +
                "\nRoute: " + cmbRoute.Text +
                "\nDay: " + cmbDay.Text +
                "\nSchedule: " + cmbSchedule.Text +
                "\nTicket Type: " + cmbRates.Text + " " + returnOrSingle +
                "\nTotal Cost: €" + txtTotalCost.Text;

            DialogResult result = MessageBox.Show(messageToDisplay, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {

                Sales sale = new Sales(
                    Convert.ToInt32(txtSaleID.Text),
                    Convert.ToInt32(cmbSchedule.Text.Substring(0, 1)),
                    cmbRates.Text.Substring(0, 2),
                    Convert.ToDecimal(txtTotalCost.Text),
                    txtSaleDate.Text);

                sale.createSale();

                // Display Confirmation
                MessageBox.Show("Sale Made Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset UI
                txtSaleID.Text = Sales.nextSaleID().ToString("00000");
                cmbRoute.SelectedIndex = -1;
                grpRates.Visible = false;
                grpSchedule.Visible = false;
                grpDay.Visible = false;
                txtTotalCost.Text = "";

                // Set The Date for The Sale Based on Today's Date
                string date = localDate.ToString();
                txtSaleDate.Text = date.Substring(0, 10);
            }
            else
            {
                // Update Visibility
                grpDay.Visible = true;
                cmbSchedule.SelectedIndex = -1;
                cmbRates.SelectedIndex = -1;
                cmbDay.SelectedIndex = -1;
                grpSchedule.Visible = false;
                grpRates.Visible = false;

                // If the route was changed after selecting all items
                radioReturn.Checked = false;
                radioSingle.Checked = false;
            }
        }

        // Return Radio Checked
        private void radioReturn_CheckedChanged(object sender, EventArgs e)
        {
            cmbRates.SelectedIndex = -1;
            txtTotalCost.Text = "";
        }

        // Single Radio Checked
        private void radioSingle_CheckedChanged(object sender, EventArgs e)
        {
            cmbRates.SelectedIndex = -1;
            txtTotalCost.Text = "";
        }
    }
}