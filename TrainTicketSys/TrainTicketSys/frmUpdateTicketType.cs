using System;
using System.Data;
using System.Windows.Forms;

namespace TrainTicketSys
{
    public partial class frmUpdateTicketType : Form
    {
        private Form Parent;

        public frmUpdateTicketType()
        {
            InitializeComponent();
        }

        public frmUpdateTicketType(Form Parent)
        {
            InitializeComponent();
            this.Parent = Parent;
        }

        // Method on Load
        private void frmUpdateTicketType_Load(object sender, EventArgs e)
        {
            loadRatesComboBox();
        }

        // Populating the Combo Boxes for Selecting Rates
        public void loadRatesComboBox()
        {
            DataSet ds = new DataSet();
            DataTable dt = Rates.getRates(ds, "description").Tables["Rates"];

            cmbRates.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                cmbRates.Items.Add(dr["typeCode"] + " : " + dr["description"]);
            }
        }

        // Back Button Click
        private void mnuUpdateTicketTypeBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parent.Show();
        }

        // Exit Button Click
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // When A Rate Is Selected
        private void cmbRates_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rates rate = new Rates();
            rate.getRate(cmbRates.Text.Substring(0, 2));

            grpRateDetails.Visible = true;

            txtTypeCode.Text = rate.getTypeCode();
            txtDescription.Text = rate.getDescription();
            nmbRatePicker.Text = rate.getRatePerKM().ToString();
        }

        private Boolean validation ()
        {
            Boolean valid = true;
            
            // Description Not Empty
            if (txtDescription.Text.Equals(""))
            {
                MessageBox.Show("Description Cannot Be Empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus(); valid = false; return valid;
            }

            // Price Not 0
            if (nmbRatePicker.Text.Equals("0.00"))
            {
                MessageBox.Show("The Rate Cannot Be Free!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false; return valid;
            }
            return valid;
        }

        // Update Button Click
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validation()) //Insert Data Into Database
            {
                // Update Station Object
                Rates.updateRate(
                    txtTypeCode.Text,
                    txtDescription.Text,
                    Convert.ToDecimal(nmbRatePicker.Text));

                // Display Confirmation
                MessageBox.Show("Rate Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Reload ComboBox
                loadRatesComboBox();
                // Update Visibility
                grpRateDetails.Visible = false;
            }
        }
    }
}
