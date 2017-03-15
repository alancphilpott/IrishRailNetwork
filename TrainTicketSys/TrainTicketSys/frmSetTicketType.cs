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
            txtTypeID.Text = Rates.nextTypeID().ToString("00000");
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
            Boolean valid = true;
            string validationMessage = "";

            // Validation of Details Entered

            // Description Not Longer Than 25 Characters
            if (txtDescription.Text.Length > 25)
            {
                validationMessage += " Description Cannot Be Longer Than 25 Characters. ";
                valid = false;
            }

            // Description Not Empty
            if (txtDescription.Text.Equals(""))
            {
                validationMessage += " Description Must Not Be Empty";
                valid = false;
            }

            if (!valid)
                MessageBox.Show(validationMessage);
            else
            {
                Rates rate = new Rates(
                    Convert.ToInt32(txtTypeID.Text),
                    txtDescription.Text
                    );

                rate.createRate();

                // Display Confirmation
                MessageBox.Show("Schedule Created Successfully");

                // Reset UI
                txtTypeID.Text = Rates.nextTypeID().ToString("00000");
            }
        }
    }
}
