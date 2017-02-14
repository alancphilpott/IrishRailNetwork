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
    public partial class frmSellTicket : Form
    {
        private Form Parent;

        public frmSellTicket()
        {
            InitializeComponent();
        }

        public frmSellTicket(Form Parent)
        {
            InitializeComponent();
            this.Parent = Parent;
        }

        private void frmSellTicket_Load(object sender, EventArgs e)
        {

        }

        private void mnuSellTicketBack_Click(object sender, EventArgs e)
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
