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

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuListRoutesBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parent.Show();
        }
    }
}
