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

        private void confirmButtonScheduleTrain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parent.Show();
        }

        private void frmScheduleTrain_Load(object sender, EventArgs e)
        {
            txtScheduleID.Text = Schedules.nextScheduleID().ToString("00000");

            // Populating the Combo Boxes for selecting Routes
            DataSet ds = new DataSet();
            DataTable dt = Routes.getActiveRoutes(ds, "departStation").Tables["Routes"];

            foreach (DataRow dr in dt.Rows)
            {
                cmbRouteID.Items.Add(String.Format("{0:00000}", dr["routeID"]) + " " + String.Format("From: " + "{0,-15}", dr["departStation"]) + "To: " + dr["arrivalStation"]);
            }
        }
    }
}
