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
    }
}
