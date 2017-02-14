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
    public partial class frmTrainTimetable : Form
    {
        private Form Parent;

        public frmTrainTimetable()
        {
            InitializeComponent();
        }

        public frmTrainTimetable(Form Parent)
        {
            InitializeComponent();
            this.Parent = Parent;
        }

        private void frmTrainTimetable_Load(object sender, EventArgs e)
        {

        }

        private void mnuTrainTimetableBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Show();
        }

        private void mnuTrainTimetableExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
