namespace TrainTicketSys
{
    partial class frmCloseStation
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
            this.mnuStripCloseStation = new System.Windows.Forms.MenuStrip();
            this.mnuCloseStationBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCloseStationExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.txtStID = new System.Windows.Forms.TextBox();
            this.lblStID = new System.Windows.Forms.Label();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbStations = new System.Windows.Forms.ComboBox();
            this.mnuStripCloseStation.SuspendLayout();
            this.grpUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStripCloseStation
            // 
            this.mnuStripCloseStation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStripCloseStation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCloseStationBack,
            this.mnuCloseStationExit});
            this.mnuStripCloseStation.Location = new System.Drawing.Point(0, 0);
            this.mnuStripCloseStation.Name = "mnuStripCloseStation";
            this.mnuStripCloseStation.Size = new System.Drawing.Size(752, 29);
            this.mnuStripCloseStation.TabIndex = 2;
            this.mnuStripCloseStation.Text = "menuStripCloseStation";
            // 
            // mnuCloseStationBack
            // 
            this.mnuCloseStationBack.Name = "mnuCloseStationBack";
            this.mnuCloseStationBack.Size = new System.Drawing.Size(54, 25);
            this.mnuCloseStationBack.Text = "Back";
            this.mnuCloseStationBack.Click += new System.EventHandler(this.mnuCloseStationBack_Click);
            // 
            // mnuCloseStationExit
            // 
            this.mnuCloseStationExit.Name = "mnuCloseStationExit";
            this.mnuCloseStationExit.Size = new System.Drawing.Size(46, 25);
            this.mnuCloseStationExit.Text = "Exit";
            this.mnuCloseStationExit.Click += new System.EventHandler(this.mnuCloseStationExit_Click);
            // 
            // grpUpdate
            // 
            this.grpUpdate.Controls.Add(this.txtStatus);
            this.grpUpdate.Controls.Add(this.btnNo);
            this.grpUpdate.Controls.Add(this.btnYes);
            this.grpUpdate.Controls.Add(this.lblWarning);
            this.grpUpdate.Controls.Add(this.txtStID);
            this.grpUpdate.Controls.Add(this.lblStID);
            this.grpUpdate.Controls.Add(this.txtCounty);
            this.grpUpdate.Controls.Add(this.lblCounty);
            this.grpUpdate.Controls.Add(this.lblStatus);
            this.grpUpdate.Controls.Add(this.txtPhoneNo);
            this.grpUpdate.Controls.Add(this.lblPhoneNo);
            this.grpUpdate.Controls.Add(this.txtTown);
            this.grpUpdate.Controls.Add(this.lblTown);
            this.grpUpdate.Controls.Add(this.txtStreet);
            this.grpUpdate.Controls.Add(this.lblStreet);
            this.grpUpdate.Controls.Add(this.txtName);
            this.grpUpdate.Controls.Add(this.lblName);
            this.grpUpdate.Location = new System.Drawing.Point(12, 105);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(728, 276);
            this.grpUpdate.TabIndex = 13;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "Update Station Information";
            this.grpUpdate.Visible = false;
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(131, 115);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 18;
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(518, 243);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(99, 27);
            this.btnNo.TabIndex = 17;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(623, 243);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(99, 27);
            this.btnYes.TabIndex = 12;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.Location = new System.Drawing.Point(414, 219);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(308, 21);
            this.lblWarning.TabIndex = 16;
            this.lblWarning.Text = "Are you sure you wish to close this station?";
            // 
            // txtStID
            // 
            this.txtStID.Enabled = false;
            this.txtStID.Location = new System.Drawing.Point(131, 42);
            this.txtStID.Name = "txtStID";
            this.txtStID.Size = new System.Drawing.Size(100, 20);
            this.txtStID.TabIndex = 15;
            // 
            // lblStID
            // 
            this.lblStID.AutoSize = true;
            this.lblStID.Location = new System.Drawing.Point(51, 45);
            this.lblStID.Name = "lblStID";
            this.lblStID.Size = new System.Drawing.Size(57, 13);
            this.lblStID.TabIndex = 14;
            this.lblStID.Text = "Station ID:";
            // 
            // txtCounty
            // 
            this.txtCounty.Enabled = false;
            this.txtCounty.Location = new System.Drawing.Point(330, 81);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(100, 20);
            this.txtCounty.TabIndex = 13;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(250, 84);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(43, 13);
            this.lblCounty.TabIndex = 12;
            this.lblCounty.Text = "County:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(50, 118);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(76, 13);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Station Status:";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Enabled = false;
            this.txtPhoneNo.Location = new System.Drawing.Point(543, 81);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNo.TabIndex = 9;
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Location = new System.Drawing.Point(463, 84);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(58, 13);
            this.lblPhoneNo.TabIndex = 8;
            this.lblPhoneNo.Text = "Phone No:";
            // 
            // txtTown
            // 
            this.txtTown.Enabled = false;
            this.txtTown.Location = new System.Drawing.Point(131, 81);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(100, 20);
            this.txtTown.TabIndex = 5;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(51, 84);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(37, 13);
            this.lblTown.TabIndex = 4;
            this.lblTown.Text = "Town:";
            // 
            // txtStreet
            // 
            this.txtStreet.Enabled = false;
            this.txtStreet.Location = new System.Drawing.Point(543, 42);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(100, 20);
            this.txtStreet.TabIndex = 3;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(463, 45);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(38, 13);
            this.lblStreet.TabIndex = 2;
            this.lblStreet.Text = "Street:";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(330, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(250, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Station Name:";
            // 
            // cmbStations
            // 
            this.cmbStations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStations.FormattingEnabled = true;
            this.cmbStations.Location = new System.Drawing.Point(12, 45);
            this.cmbStations.Name = "cmbStations";
            this.cmbStations.Size = new System.Drawing.Size(195, 21);
            this.cmbStations.TabIndex = 14;
            this.cmbStations.SelectedIndexChanged += new System.EventHandler(this.cmbStations_SelectedIndexChanged);
            // 
            // frmCloseStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 393);
            this.Controls.Add(this.cmbStations);
            this.Controls.Add(this.mnuStripCloseStation);
            this.Controls.Add(this.grpUpdate);
            this.Name = "frmCloseStation";
            this.Text = "Train Ticket System - Close Station";
            this.Load += new System.EventHandler(this.frmCloseStation_Load);
            this.mnuStripCloseStation.ResumeLayout(false);
            this.mnuStripCloseStation.PerformLayout();
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStripCloseStation;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseStationBack;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseStationExit;
        private System.Windows.Forms.GroupBox grpUpdate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.TextBox txtStID;
        private System.Windows.Forms.Label lblStID;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.ComboBox cmbStations;
        private System.Windows.Forms.TextBox txtStatus;
    }
}