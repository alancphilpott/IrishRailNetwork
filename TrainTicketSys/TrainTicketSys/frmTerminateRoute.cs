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
    public partial class frmTerminateRoute : Form
    {
        private Form Parent;

        public frmTerminateRoute()
        {
            InitializeComponent();
        }

        public frmTerminateRoute(Form Parent)
        {
            InitializeComponent();
            this.Parent = Parent;
        }

        private void frmTerminateRoute_Load(object sender, EventArgs e)
        {

        }

        private void mnuTerminateRouteBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Show();
        }

        private void mnuTerminateRouteExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
