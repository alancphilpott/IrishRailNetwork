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
    public partial class frmTrainTimetable : Form
    {
        private Form Parent;

        public frmTrainTimetable()
        {
            InitializeComponent();
        }

        public frmTrainTimetable(Form Parent)
        {
            InitializeComponent();
            this.Parent = Parent;
        }

        // Method On Load
        private void frmTrainTimetable_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = Routes.getActiveRoutes(ds, "departStation").Tables["Routes"];

            foreach (DataRow dr in dt.Rows)
            {
                cmbRoutes.Items.Add(String.Format("{0:00000}", dr["routeID"]) + " " + String.Format("From: " + "{0,-15}", dr["departStation"]) + "To: " + dr["arrivalStation"]);
            }
        }

        // Back Button Click
        private void mnuTrainTimetableBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Show();
        }

        // Exit Button Click
        private void mnuTrainTimetableExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // When A Route Is Selected
        private void cmbRoutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int routeID = Convert.ToInt32(cmbRoutes.Text.Substring(0, 5));

            DataSet DS = new DataSet();
            dgTimetable.DataSource = Schedules.getRouteSchedules(DS, routeID).Tables["Schedules"];

            dgTimetable.Visible = true;
            btnFinish.Visible = true;
        }
    }
}
