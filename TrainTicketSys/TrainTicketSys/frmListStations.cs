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

        private void mnuListStationsBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Show();
        }

        private void mnuListStationsExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmListStations_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            if (keyword.Equals(""))
            {
                DataSet DS = new DataSet();
                dgStations.DataSource = Station.getStations(DS,"StationId").Tables["Stations"];
                dgStations.Visible = true;
                btnPrint.Visible = true;
            }
            else
            {
                DataSet DS = new DataSet();
                dgStations.DataSource = Station.getStationsName(DS, keyword).Tables["Stations"];
                dgStations.Visible = true;
                btnPrint.Visible = true;
            }
        }
    }
}
