using System;
using System.Windows.Forms;

namespace TrainTicketSys
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        // For Adding A Station
        private void mnuAddStation_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmAddStation(this).Show();
        }

        // For Closing A Station
        private void mnuCloseStation_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmCloseStation(this).Show();
        }

        // For Listing All Stations
        private void mnuListStations_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmListStations(this).Show();
        }

        // ---------------------------------------------------------

        // For Adding A Route
        private void mnuAddRoutes_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmAddRoutes(this).Show();
        }

        // For Terminating A Route
        private void mnuTerminateRoute_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmTerminateRoute(this).Show();
        }

        // For Listing All Routes
        private void mnuListRoutes_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmListRoutes(this).Show();
        }

        // --------------------------------------------------------------
        
        // For Scheduling A Train
        private void mnuScheduleTrain_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmScheduleTrain(this).Show();
        }

        // For Showing A Train Timetable
        private void mnuShowTimetable_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmTrainTimetable(this).Show();
        }

        // --------------------------------------------------------------

        // For Setting Ticket Types
        private void mnuSetTicketType_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmSetTicketType(this).Show();
        }

        // For Updating Ticket Types
        private void mnuUpdateTicketType_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmUpdateTicketType(this).Show();
        }

        // For Selling A Ticket
        private void mnuSellTicket_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmSellTicket(this).Show();
        }

        // -----------------------------------------------------------------

        // For Providing A Revenue Analysis
        private void mnuRevenueAnalysis_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmRevenueAnalysis(this).Show();
        }

        // For Providing A Ticket Sales Analysis
        private void mnuTicketSalesAnalysis_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmTicketSalesAnalysis(this).Show();
        }

        private void ticketToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
