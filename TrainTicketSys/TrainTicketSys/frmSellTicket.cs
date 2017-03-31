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

        private void frmSellTicket_Load(object sender, EventArgs e)
        {
            // Setting the next Schedule ID
            txtSaleID.Text = Sales.nextSaleID().ToString("00000");

            // Populating the Combo Boxes for selecting Routes
            DataSet dsRoutes = new DataSet();
            DataTable dtRoutes = Routes.getActiveRoutes(dsRoutes, "departStation").Tables["Routes"];

            foreach (DataRow dr in dtRoutes.Rows)
            {
                cmbRoute.Items.Add(String.Format("{0:00000}", dr["routeID"]) + " " + String.Format("From: " + "{0,-15}", dr["departStation"]) + "To: " + dr["arrivalStation"]);
            }

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

        private void mnuSellTicketBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parent.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
