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
    public partial class frmAddRoutes : Form
    {
        private Form Parent;

        public frmAddRoutes()
        {
            InitializeComponent();
        }

        public frmAddRoutes(Form Parent)
        {
            InitializeComponent();
            this.Parent = Parent;
        }

        private void mnuAddRoutesBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parent.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void confirmButtonAddRoutes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parent.Show();
        }
    }
}
