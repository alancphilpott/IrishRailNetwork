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
    public partial class frmScheduleTrain : Form
    {
        private Form Parent;

        public frmScheduleTrain()
        {
            InitializeComponent();
        }

        public frmScheduleTrain(Form Parent)
        {
            InitializeComponent();
            this.Parent = Parent;
        }

        private void mnuScheduleTrainBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parent.Show();
        }

        private void mnuScheduleTrainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void confirmButtonScheduleTrain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parent.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void numberBoxScheduleTrain_TextChanged(object sender, EventArgs e)
        {

        }

        private void departureBoxScheduleTrain_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
