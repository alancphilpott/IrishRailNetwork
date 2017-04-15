using System;
using System.Data;
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

        // Method On Load
        private void frmRevenueAnalysis_Load(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();
            DataTable DT = Sales.getSalesAnalysis(DS).Tables["Sales"];

            foreach (DataRow dr in DT.Rows)
            {
                this.chartRevenue.Series["Revenue"].Points.AddXY(dr["TheMonth"], dr["TotalCost"]);
            }
        }

        // Back Button Click
        private void mnuRevenueAnalysisBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Show();
        }

        // Exit Button Click
        private void mnuRevenueAnalysisExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Finish Button Click
        private void finishButtonRevenueAnalysis_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Show();
        }
    }
}
