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
    public partial class frmSetTicketType : Form
    {
        private Form Parent;

        public frmSetTicketType()
        {
            InitializeComponent();
        }

        public frmSetTicketType(Form Parent)
        {
            InitializeComponent();
            this.Parent = Parent;
        }

        private void frmSetTicketType_Load(object sender, EventArgs e)
        {
            txtTypeID.Text = Rates.nextTypeID().ToString("00000");
        }

        private void mnuSetTicketTypeBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
