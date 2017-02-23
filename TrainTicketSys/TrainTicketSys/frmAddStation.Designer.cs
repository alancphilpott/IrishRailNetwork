namespace TrainTicketSys
{
    partial class frmAddStation
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
            this.mnuStripAddStation = new System.Windows.Forms.MenuStrip();
            this.mnuAddStationBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddStationExit = new System.Windows.Forms.ToolStripMenuItem();
            this.txtStation = new System.Windows.Forms.TextBox();
            this.lblStation = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStID = new System.Windows.Forms.Label();
            this.txtStID = new System.Windows.Forms.TextBox();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.mnuStripAddStation.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStripAddStation
            // 
            this.mnuStripAddStation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStripAddStation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddStationBack,
            this.mnuAddStationExit});
            this.mnuStripAddStation.Location = new System.Drawing.Point(0, 0);
            this.mnuStripAddStation.Name = "mnuStripAddStation";
            this.mnuStripAddStation.Size = new System.Drawing.Size(752, 29);
            this.mnuStripAddStation.TabIndex = 1;
            this.mnuStripAddStation.Text = "mnuStripAddStation";
            // 
            // mnuAddStationBack
            // 
            this.mnuAddStationBack.Name = "mnuAddStationBack";
            this.mnuAddStationBack.Size = new System.Drawing.Size(54, 25);
            this.mnuAddStationBack.Text = "Back";
            this.mnuAddStationBack.Click += new System.EventHandler(this.mnuAddStationBack_Click);
            // 
            // mnuAddStationExit
            // 
            this.mnuAddStationExit.Name = "mnuAddStationExit";
            this.mnuAddStationExit.Size = new System.Drawing.Size(46, 25);
            this.mnuAddStationExit.Text = "Exit";
            this.mnuAddStationExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // txtStation
            // 
            this.txtStation.Location = new System.Drawing.Point(367, 136);
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(164, 20);
            this.txtStation.TabIndex = 2;
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStation.Location = new System.Drawing.Point(234, 133);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(108, 21);
            this.lblStation.TabIndex = 0;
            this.lblStation.Text = "Station Name:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(234, 198);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(54, 21);
            this.lblStreet.TabIndex = 0;
            this.lblStreet.Text = "Street:";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.Location = new System.Drawing.Point(234, 229);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(51, 21);
            this.lblTown.TabIndex = 0;
            this.lblTown.Text = "Town:";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(234, 261);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(63, 21);
            this.lblCounty.TabIndex = 0;
            this.lblCounty.Text = "County:";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(367, 198);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(164, 20);
            this.txtStreet.TabIndex = 4;
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(367, 229);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(164, 20);
            this.txtTown.TabIndex = 5;
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(367, 262);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(164, 20);
            this.txtCounty.TabIndex = 6;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(238, 336);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(293, 29);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create Station";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(234, 166);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(109, 21);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Station Status:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Active",
            "Closed"});
            this.cmbStatus.Location = new System.Drawing.Point(367, 165);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(164, 21);
            this.cmbStatus.TabIndex = 3;
            this.cmbStatus.Text = "Choose Status";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(294, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(182, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Enter Station Details";
            // 
            // lblStID
            // 
            this.lblStID.AutoSize = true;
            this.lblStID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStID.Location = new System.Drawing.Point(234, 101);
            this.lblStID.Name = "lblStID";
            this.lblStID.Size = new System.Drawing.Size(81, 21);
            this.lblStID.TabIndex = 0;
            this.lblStID.Text = "Station ID:";
            // 
            // txtStID
            // 
            this.txtStID.Enabled = false;
            this.txtStID.Location = new System.Drawing.Point(367, 103);
            this.txtStID.Name = "txtStID";
            this.txtStID.Size = new System.Drawing.Size(108, 20);
            this.txtStID.TabIndex = 1;
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNo.Location = new System.Drawing.Point(234, 292);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(82, 21);
            this.lblPhoneNo.TabIndex = 0;
            this.lblPhoneNo.Text = "Phone No:";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(367, 293);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(164, 20);
            this.txtPhoneNo.TabIndex = 7;
            // 
            // frmAddStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 393);
            this.Controls.Add(this.lblPhoneNo);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.lblStID);
            this.Controls.Add(this.txtStID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblCounty);
            this.Controls.Add(this.lblTown);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblStation);
            this.Controls.Add(this.txtCounty);
            this.Controls.Add(this.txtTown);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtStation);
            this.Controls.Add(this.mnuStripAddStation);
            this.Name = "frmAddStation";
            this.Text = "Train Ticket System - Add Station";
            this.Load += new System.EventHandler(this.frmAddStation_Load);
            this.mnuStripAddStation.ResumeLayout(false);
            this.mnuStripAddStation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStripAddStation;
        private System.Windows.Forms.ToolStripMenuItem mnuAddStationExit;
        private System.Windows.Forms.ToolStripMenuItem mnuAddStationBack;
        private System.Windows.Forms.TextBox txtStation;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStID;
        private System.Windows.Forms.TextBox txtStID;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.TextBox txtPhoneNo;
    }
}