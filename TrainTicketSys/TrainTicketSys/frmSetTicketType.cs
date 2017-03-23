using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

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

        private void frmSetTicketType_Load(object sender, EventArgs e)
        {
            
        }

        private void mnuSetTicketTypeBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Validation of Details Entered

            // Description Not Longer Than 25 Characters
            if (txtDescription.Text.Length > 25)
            {
                MessageBox.Show("Description Cannot Be Longer Than 25 Characters", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
                return;
            }

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

            // Check If TypeCode Is Unique
            Boolean alreadyExists = Rates.alreadyExists(txtTypeCode.Text);
            if (alreadyExists)
            {
                MessageBox.Show("That Type Code Already Exists");
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
                MessageBox.Show("Rate Created Successfully");

                // Reset UI
                txtTypeCode.Text = "";
                txtDescription.Text = "";
            }
        }
    }
}

