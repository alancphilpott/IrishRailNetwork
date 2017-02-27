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
            this.lblStation = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgStations = new System.Windows.Forms.DataGridView();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.btnYes = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.txtStID = new System.Windows.Forms.TextBox();
            this.lblStID = new System.Windows.Forms.Label();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnNo = new System.Windows.Forms.Button();
            this.mnuStripCloseStation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStations)).BeginInit();
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
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStation.Location = new System.Drawing.Point(183, 45);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(107, 21);
            this.lblStation.TabIndex = 9;
            this.lblStation.Text = "Station Name:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(297, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(196, 20);
            this.txtSearch.TabIndex = 10;
            // 
            // dgStations
            // 
            this.dgStations.AllowUserToAddRows = false;
            this.dgStations.AllowUserToDeleteRows = false;
            this.dgStations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.edit});
            this.dgStations.Location = new System.Drawing.Point(12, 92);
            this.dgStations.Name = "dgStations";
            this.dgStations.ReadOnly = true;
            this.dgStations.Size = new System.Drawing.Size(728, 234);
            this.dgStations.TabIndex = 11;
            this.dgStations.Visible = false;
            this.dgStations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgStations_CellContentClick);
            // 
            // edit
            // 
            this.edit.HeaderText = "Close";
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Text = "Close";
            this.edit.UseColumnTextForButtonValue = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(499, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(51, 21);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpUpdate
            // 
            this.grpUpdate.Controls.Add(this.btnNo);
            this.grpUpdate.Controls.Add(this.btnYes);
            this.grpUpdate.Controls.Add(this.lblWarning);
            this.grpUpdate.Controls.Add(this.txtStID);
            this.grpUpdate.Controls.Add(this.lblStID);
            this.grpUpdate.Controls.Add(this.txtCounty);
            this.grpUpdate.Controls.Add(this.lblCounty);
            this.grpUpdate.Controls.Add(this.cmbStatus);
            this.grpUpdate.Controls.Add(this.lblStatus);
            this.grpUpdate.Controls.Add(this.txtPhoneNo);
            this.grpUpdate.Controls.Add(this.lblPhoneNo);
            this.grpUpdate.Controls.Add(this.txtTown);
            this.grpUpdate.Controls.Add(this.lblTown);
            this.grpUpdate.Controls.Add(this.txtStreet);
            this.grpUpdate.Controls.Add(this.lblStreet);
            this.grpUpdate.Controls.Add(this.txtName);
            this.grpUpdate.Controls.Add(this.lblName);
            this.grpUpdate.Location = new System.Drawing.Point(12, 72);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(728, 276);
            this.grpUpdate.TabIndex = 13;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "Update Station Information";
            this.grpUpdate.Visible = false;
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(484, 227);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(99, 27);
            this.btnYes.TabIndex = 12;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Visible = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.Location = new System.Drawing.Point(50, 186);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(533, 21);
            this.lblWarning.TabIndex = 16;
            this.lblWarning.Text = "This station will be set to closed. Are you sure you wish to close this station?";
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
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Active",
            "Closed"});
            this.cmbStatus.Location = new System.Drawing.Point(183, 117);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(164, 21);
            this.cmbStatus.TabIndex = 11;
            this.cmbStatus.Text = "Choose Status";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(50, 118);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(107, 21);
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
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(366, 227);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(99, 27);
            this.btnNo.TabIndex = 17;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Visible = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // frmCloseStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 393);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblStation);
            this.Controls.Add(this.mnuStripCloseStation);
            this.Controls.Add(this.grpUpdate);
            this.Controls.Add(this.dgStations);
            this.Name = "frmCloseStation";
            this.Text = "Train Ticket System - Close Station";
            this.Load += new System.EventHandler(this.frmCloseStation_Load);
            this.mnuStripCloseStation.ResumeLayout(false);
            this.mnuStripCloseStation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStations)).EndInit();
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStripCloseStation;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseStationBack;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseStationExit;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgStations;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpUpdate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.TextBox txtStID;
        private System.Windows.Forms.Label lblStID;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnNo;
    }
}