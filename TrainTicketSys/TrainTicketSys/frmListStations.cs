using System;
using System.Data;
using System.Windows.Forms;

namespace TrainTicketSys
{
    public partial class frmListStations : Form
    {
        private Form Parent;

        public frmListStations()
        {
            InitializeComponent();
        }

        public frmListStations(Form Parent)
        {
            InitializeComponent();
            this.Parent = Parent;
        }

        // Called When The Form Is Loaded
        private void frmListStations_Load(object sender, EventArgs e)
        {

        }

        // Clicking on Back Button
        private void mnuListStationsBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Show();
        }

        // Clicking on Exit Button
        private void mnuListStationsExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        // When Search Button Is Clicked
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals(""))
            {
                DataSet DS = new DataSet();
                dgStations.DataSource = Station.getStations(DS,"stationID").Tables["Stations"];
                dgStations.Visible = true;
                btnPrint.Visible = true;
            }
            else
            {
                DataSet DS = new DataSet();
                dgStations.DataSource = Station.getStationsName(DS, txtSearch.Text).Tables["Stations"];
                dgStations.Visible = true;
                btnPrint.Visible = true;
            }
        }
    }
}
