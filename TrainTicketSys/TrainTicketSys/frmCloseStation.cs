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
    public partial class frmCloseStation : Form
    {
        private Form Parent;

        public frmCloseStation()
        {
            InitializeComponent();
        }

        public frmCloseStation(Form Parent)
        {
            InitializeComponent();
            this.Parent = Parent;
        }

        private void frmCloseStation_Load(object sender, EventArgs e)
        {

        }

        private void mnuCloseStationBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Show();
        }

        private void mnuCloseStationExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgStations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int column = e.ColumnIndex + 1;
            int ID;

            ID = Convert.ToInt32(dgStations.Rows[row].Cells[column].Value);
            MessageBox.Show("ID = " + ID);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            if (keyword.Equals(""))
            {
                DataSet DS = new DataSet();
                dgStations.DataSource = Station.getStations(DS).Tables["Stations"];
                dgStations.Visible = true;
                btnPrint.Visible = true;
            }
            else
            {
                DataSet DS = new DataSet();
                dgStations.DataSource = Station.getStations(DS, keyword).Tables["Stations"];
                dgStations.Visible = true;
                btnPrint.Visible = true;
            }
        }
    }
}
