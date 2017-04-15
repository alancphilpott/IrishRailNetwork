using System;
using System.Windows.Forms;

namespace TrainTicketSys
{
    public partial class frmSetTicketType : Form
    {
        private Form Parent;

        public frmSetTicketType()
        {
            InitializeComponent();
        }

        public frmSetTicketType(Form Parent)
        {
            InitializeComponent();
            this.Parent = Parent;
        }

        // Method on Load
        private void frmSetTicketType_Load(object sender, EventArgs e)
        {
            
        }

        // Back Button Click
        private void mnuSetTicketTypeBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Show();
        }

        // Exit Button Click
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Validation Method
        private Boolean validation ()
        {
            Boolean valid = true;

            // Type Code Not Empty
            if (txtTypeCode.Text.Equals(""))
            {
                MessageBox.Show("Type Code Cannot Be Empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus(); valid = false; return valid;
            }

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

        // Create Button Click
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                // Check If TypeCode Is Unique
                Boolean alreadyExists = Rates.alreadyExists(txtTypeCode.Text);
                if (alreadyExists)
                {
                    MessageBox.Show("That Type Code Already Exists", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else //Insert Data Into Database
                {
                    Rates rate = new Rates(
                        txtTypeCode.Text,
                        txtDescription.Text,
                        Convert.ToDecimal(nmbRatePicker.Text)
                        );

                    rate.createRate(); // Create The Rate

                    // Display Confirmation
                    MessageBox.Show("Rate Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reset UI
                    txtTypeCode.Text = "";
                    txtDescription.Text = "";
                    nmbRatePicker.Text = "0.00";
                }
            }
        }
    }
}

