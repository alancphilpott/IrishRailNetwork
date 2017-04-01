﻿using System;
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
        private DateTime localDate = DateTime.Now;

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
            // Setting the next Schedule ID
            txtSaleID.Text = Sales.nextSaleID().ToString("00000");

            // Populating the Combo Boxes for selecting Routes
            DataSet dsRoutes = new DataSet();
            DataTable dtRoutes = Routes.getActiveRoutes(dsRoutes, "departStation").Tables["Routes"];

            foreach (DataRow dr in dtRoutes.Rows)
            {
                cmbRoute.Items.Add(String.Format("{0:00000}", dr["routeID"]) + " " + String.Format("From: " + "{0,-15}", dr["departStation"]) + "To: " + dr["arrivalStation"]);
            }

			// Populate ComboBox for choosing day
			string[] days = {"1 Monday","2 Tuesday","3 Wednesday","4 Thursday","5 Friday","6 Saturday","7 Sunday"};
			foreach (string s in days)
				cmbDay.Items.Add(s);

            // Populating the Combo Boxes for Selecting Rates
            DataSet dsRates = new DataSet();
            DataTable dtRates = Rates.getRates(dsRates, "description").Tables["Rates"];

            cmbRates.Items.Clear();

            foreach (DataRow dr in dtRates.Rows)
            {
                cmbRates.Items.Add(dr["typeCode"] + " : " + dr["description"]);
            }

            // Set The Date for The Sale Based on Today's Date
            string date = localDate.ToString();
            txtSaleDate.Text = date.Substring(0, 10);
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

        private void cmbRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update Visibility
            grpDay.Visible = true;
            cmbSchedule.SelectedIndex = -1;
            cmbRates.SelectedIndex = -1;
            cmbDay.SelectedIndex = -1;
            grpSchedule.Visible = false;
            grpRates.Visible = false;

            // If the route was changed after selecting all items
            radioReturn.Checked = false;
            radioSingle.Checked = false;
        }

        private void cmbDay_SelectedIndexChanged(object sender, EventArgs e)
		{
            // Update Visibility
            cmbSchedule.SelectedIndex = -1;
            grpSchedule.Visible = true;

            cmbRates.SelectedIndex = -1;
            radioSingle.Checked = false;
            radioReturn.Checked = false;
            grpRates.Visible = false;

            // Populate With Relevant Schedules
            if (cmbDay.SelectedIndex != -1)
            {
                cmbSchedule.Items.Clear();

                DataSet DS = new DataSet();
                DataTable dtSchedules = Schedules.getScheduleByDay(DS, Convert.ToInt32(cmbRoute.Text.Substring(0, 5)), Convert.ToInt32(cmbDay.Text.Substring(0, 1))).Tables["Schedules"];

                foreach (DataRow dr in dtSchedules.Rows)
                {
                    cmbSchedule.Items.Add(dr["scheduleID"] + " : Dep: " + dr["depTime"] + " : Arr: " + dr["arrTime"]);
                }
            }
		}

        private void cmbSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpRates.Visible = true;
        }
    }
}
