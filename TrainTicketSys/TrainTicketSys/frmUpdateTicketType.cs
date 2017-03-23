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

        private void frmUpdateTicketType_Load(object sender, EventArgs e)
        {
            loadRatesComboBox();
        }

        public void loadRatesComboBox()
        {
            // Populating the Combo Boxes for Selecting Rates
            DataSet ds = new DataSet();
            DataTable dt = Rates.getRates(ds, "description").Tables["Rates"];

            cmbRates.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                cmbRates.Items.Add(dr["typeCode"] + " : " + dr["description"]);
            }
        }

        private void mnuUpdateTicketTypeBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parent.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbRates_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rates rate = new Rates();
            rate.getRate(cmbRates.Text.Substring(0, 2));

            grpRateDetails.Visible = true;

            txtTypeCode.Text = rate.getTypeCode();
            txtDescription.Text = rate.getDescription();
            nmbRatePicker.Text = rate.getRatePerKM().ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Validation of Details Entered

            // Description Not Empty
            if (txtDescription.Text.Equals(""))
            {
                MessageBox.Show("Description Cannot Be Empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
                return;
            }

            // Price Not 0
            if (nmbRatePicker.Text.Equals("0.00"))
            {
                MessageBox.Show("The Rate Cannot Be Free!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            /* USING TEXTBOX FOR RATE!!
            // Price Not Empty
            if (txtRatePerKM.Text.Equals(""))
            {
                MessageBox.Show("Rate Cannot Be Empty");
                return;
            }

            // Price Right Format
            char bDecimal = Convert.ToChar(txtRatePerKM.Text.Substring(0, 1));
            string aDecimal = txtRatePerKM.Text.Substring(3,5);

            if (Char.IsDigit(bDecimal))
            {
                foreach (Char c in aDecimal)
                {
                    if (!Char.IsDigit(c))
                    {
                        MessageBox.Show("Rate Per KM Needs To Be Numbers and in Format: \"0:00\"");
                        return;
                    }
                }
            }
            */

            else //Insert Data Into Database
            {
                // Update Station Object
                Rates.updateRate(
                    txtTypeCode.Text,
                    txtDescription.Text,
                    Convert.ToDecimal(nmbRatePicker.Text));

                // Display Confirmation
                MessageBox.Show("Rate Updated Successfully");
                // Reload ComboBox
                loadRatesComboBox();
                // Update Visibility
                grpRateDetails.Visible = false;
            }
        }
    }
}
