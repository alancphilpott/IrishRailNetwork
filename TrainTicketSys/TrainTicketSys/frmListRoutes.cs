using System;
using System.Data;
using System.Windows.Forms;

namespace TrainTicketSys
{
    public partial class frmListRoutes : Form
    {
        private Form Parent;

        public frmListRoutes()
        {
            InitializeComponent();
        }

        public frmListRoutes(Form Parent)
        {
            InitializeComponent();
            this.Parent = Parent;
        }

        // Exit Button Clicked
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Back Button Clicked
        private void mnuListRoutesBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parent.Show();
        }

        // Search Button Clicked
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals(""))
            {
                DataSet DS = new DataSet();
                dgRoutes.DataSource = Routes.getRoutes(DS, "departStation").Tables["Routes"];
                dgRoutes.Visible = true;
                btnPrint.Visible = true;
            }
            else
            {
                DataSet DS = new DataSet();
                dgRoutes.DataSource = Routes.getRoutesDepartStation(DS, txtSearch.Text).Tables["Routes"];
                dgRoutes.Visible = true;
                btnPrint.Visible = true;
            }
        }
    }
}
