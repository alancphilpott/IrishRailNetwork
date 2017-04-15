namespace TrainTicketSys
{
    partial class frmScheduleTrain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuStripScheduleTrain = new System.Windows.Forms.MenuStrip();
            this.mnuScheduleTrainBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuScheduleTrainExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblNumCarriages = new System.Windows.Forms.Label();
            this.lblDepTime = new System.Windows.Forms.Label();
            this.lblArrTime = new System.Windows.Forms.Label();
            this.lblRouteID = new System.Windows.Forms.Label();
            this.tpDepTime = new System.Windows.Forms.DateTimePicker();
            this.lblScheduleID = new System.Windows.Forms.Label();
            this.cmbRouteID = new System.Windows.Forms.ComboBox();
            this.cmbDayOfWeek = new System.Windows.Forms.ComboBox();
            this.tpArrTime = new System.Windows.Forms.DateTimePicker();
            this.txtScheduleID = new System.Windows.Forms.TextBox();
            this.mnuStripScheduleTrain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStripScheduleTrain
            // 
            this.mnuStripScheduleTrain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStripScheduleTrain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuScheduleTrainBack,
            this.mnuScheduleTrainExit});
            this.mnuStripScheduleTrain.Location = new System.Drawing.Point(0, 0);
            this.mnuStripScheduleTrain.Name = "mnuStripScheduleTrain";
            this.mnuStripScheduleTrain.Size = new System.Drawing.Size(752, 29);
            this.mnuStripScheduleTrain.TabIndex = 0;
            this.mnuStripScheduleTrain.Text = "mnuScheduleTrain";
            // 
            // mnuScheduleTrainBack
            // 
            this.mnuScheduleTrainBack.Name = "mnuScheduleTrainBack";
            this.mnuScheduleTrainBack.Size = new System.Drawing.Size(54, 25);
            this.mnuScheduleTrainBack.Text = "Back";
            this.mnuScheduleTrainBack.Click += new System.EventHandler(this.mnuScheduleTrainBack_Click);
            // 
            // mnuScheduleTrainExit
            // 
            this.mnuScheduleTrainExit.Name = "mnuScheduleTrainExit";
            this.mnuScheduleTrainExit.Size = new System.Drawing.Size(46, 25);
            this.mnuScheduleTrainExit.Text = "Exit";
            this.mnuScheduleTrainExit.Click += new System.EventHandler(this.mnuScheduleTrainExit_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(386, 289);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(216, 23);
            this.btnCreate.TabIndex = 32;
            this.btnCreate.Text = "Create Schedule";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblNumCarriages
            // 
            this.lblNumCarriages.AutoSize = true;
            this.lblNumCarriages.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCarriages.Location = new System.Drawing.Point(207, 178);
            this.lblNumCarriages.Name = "lblNumCarriages";
            this.lblNumCarriages.Size = new System.Drawing.Size(100, 21);
            this.lblNumCarriages.TabIndex = 16;
            this.lblNumCarriages.Text = "Day of Week:";
            // 
            // lblDepTime
            // 
            this.lblDepTime.AutoSize = true;
            this.lblDepTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepTime.Location = new System.Drawing.Point(207, 215);
            this.lblDepTime.Name = "lblDepTime";
            this.lblDepTime.Size = new System.Drawing.Size(121, 21);
            this.lblDepTime.TabIndex = 18;
            this.lblDepTime.Text = "Departure Time:";
            // 
            // lblArrTime
            // 
            this.lblArrTime.AutoSize = true;
            this.lblArrTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrTime.Location = new System.Drawing.Point(207, 251);
            this.lblArrTime.Name = "lblArrTime";
            this.lblArrTime.Size = new System.Drawing.Size(97, 21);
            this.lblArrTime.TabIndex = 20;
            this.lblArrTime.Text = "Arrival Time:";
            // 
            // lblRouteID
            // 
            this.lblRouteID.AutoSize = true;
            this.lblRouteID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRouteID.Location = new System.Drawing.Point(207, 140);
            this.lblRouteID.Name = "lblRouteID";
            this.lblRouteID.Size = new System.Drawing.Size(110, 21);
            this.lblRouteID.TabIndex = 22;
            this.lblRouteID.Text = "Choose Route:";
            // 
            // tpDepTime
            // 
            this.tpDepTime.CustomFormat = "HH:mm";
            this.tpDepTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tpDepTime.Location = new System.Drawing.Point(386, 216);
            this.tpDepTime.Name = "tpDepTime";
            this.tpDepTime.ShowUpDown = true;
            this.tpDepTime.Size = new System.Drawing.Size(57, 20);
            this.tpDepTime.TabIndex = 23;
            // 
            // lblScheduleID
            // 
            this.lblScheduleID.AutoSize = true;
            this.lblScheduleID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduleID.Location = new System.Drawing.Point(207, 103);
            this.lblScheduleID.Name = "lblScheduleID";
            this.lblScheduleID.Size = new System.Drawing.Size(95, 21);
            this.lblScheduleID.TabIndex = 27;
            this.lblScheduleID.Text = "Schedule ID:";
            // 
            // cmbRouteID
            // 
            this.cmbRouteID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRouteID.FormattingEnabled = true;
            this.cmbRouteID.Location = new System.Drawing.Point(386, 143);
            this.cmbRouteID.Name = "cmbRouteID";
            this.cmbRouteID.Size = new System.Drawing.Size(216, 21);
            this.cmbRouteID.TabIndex = 28;
            // 
            // cmbDayOfWeek
            // 
            this.cmbDayOfWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDayOfWeek.FormattingEnabled = true;
            this.cmbDayOfWeek.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cmbDayOfWeek.Location = new System.Drawing.Point(386, 181);
            this.cmbDayOfWeek.Name = "cmbDayOfWeek";
            this.cmbDayOfWeek.Size = new System.Drawing.Size(216, 21);
            this.cmbDayOfWeek.TabIndex = 29;
            // 
            // tpArrTime
            // 
            this.tpArrTime.CustomFormat = "HH:mm";
            this.tpArrTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tpArrTime.Location = new System.Drawing.Point(386, 252);
            this.tpArrTime.Name = "tpArrTime";
            this.tpArrTime.ShowUpDown = true;
            this.tpArrTime.Size = new System.Drawing.Size(57, 20);
            this.tpArrTime.TabIndex = 30;
            // 
            // txtScheduleID
            // 
            this.txtScheduleID.Enabled = false;
            this.txtScheduleID.Location = new System.Drawing.Point(386, 106);
            this.txtScheduleID.Name = "txtScheduleID";
            this.txtScheduleID.Size = new System.Drawing.Size(216, 20);
            this.txtScheduleID.TabIndex = 31;
            // 
            // frmScheduleTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 393);
            this.Controls.Add(this.txtScheduleID);
            this.Controls.Add(this.tpArrTime);
            this.Controls.Add(this.cmbDayOfWeek);
            this.Controls.Add(this.cmbRouteID);
            this.Controls.Add(this.lblScheduleID);
            this.Controls.Add(this.tpDepTime);
            this.Controls.Add(this.lblRouteID);
            this.Controls.Add(this.lblArrTime);
            this.Controls.Add(this.lblDepTime);
            this.Controls.Add(this.lblNumCarriages);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.mnuStripScheduleTrain);
            this.MainMenuStrip = this.mnuStripScheduleTrain;
            this.Name = "frmScheduleTrain";
            this.Text = "Train Ticket Sys - Schedule Train";
            this.Load += new System.EventHandler(this.frmScheduleTrain_Load);
            this.mnuStripScheduleTrain.ResumeLayout(false);
            this.mnuStripScheduleTrain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStripScheduleTrain;
        private System.Windows.Forms.ToolStripMenuItem mnuScheduleTrainBack;
        private System.Windows.Forms.ToolStripMenuItem mnuScheduleTrainExit;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblNumCarriages;
        private System.Windows.Forms.Label lblDepTime;
        private System.Windows.Forms.Label lblArrTime;
        private System.Windows.Forms.Label lblRouteID;
        private System.Windows.Forms.DateTimePicker tpDepTime;
        private System.Windows.Forms.Label lblScheduleID;
        private System.Windows.Forms.ComboBox cmbRouteID;
        private System.Windows.Forms.ComboBox cmbDayOfWeek;
        private System.Windows.Forms.DateTimePicker tpArrTime;
        private System.Windows.Forms.TextBox txtScheduleID;
    }
}