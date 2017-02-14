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
    public partial class frmRevenueAnalysis : Form
    {
        private Form Parent;

        public frmRevenueAnalysis()
        {
            InitializeComponent();
        }

        public frmRevenueAnalysis(Form Parent)
        {
            InitializeComponent();
            this.Parent = Parent;
        }

        private void frmRevenueAnalysis_Load(object sender, EventArgs e)
        {

        }

        private void mnuRevenueAnalysisBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Show();
        }

        private void mnuRevenueAnalysisExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void finishButtonRevenueAnalysis_Click(object sender, EventArgs e)
        {

        }

        private void listGrossList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void specificDateCalender_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void datePeriodRevenueAnalysis_Click(object sender, EventArgs e)
        {

        }

        private void dateSpecificRevenueAnalysis_Click(object sender, EventArgs e)
        {

        }

        private void timePeriodCalender_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
