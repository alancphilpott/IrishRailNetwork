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
    public partial class frmTicketSalesAnalysis : Form
    {
        private Form Parent;

        public frmTicketSalesAnalysis()
        {
            InitializeComponent();
        }

        public frmTicketSalesAnalysis(Form Parent)
        {
            InitializeComponent();
            this.Parent = Parent;
        }

        private void frmTicketSalesAnalysis_Load(object sender, EventArgs e)
        {

        }

        private void mnuTicketSalesAnalysisBack_Click(object sender, EventArgs e)
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
