namespace TrainTicketSys
{
    partial class frmSellTicket
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
            this.mnuStripSellTicket = new System.Windows.Forms.MenuStrip();
            this.mnuSellTicketBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblSaleDate = new System.Windows.Forms.Label();
            this.txtSaleDate = new System.Windows.Forms.TextBox();
            this.lblSaleID = new System.Windows.Forms.Label();
            this.txtSaleID = new System.Windows.Forms.TextBox();
            this.cmbRoute = new System.Windows.Forms.ComboBox();
            this.cmbRates = new System.Windows.Forms.ComboBox();
            this.cmbSchedule = new System.Windows.Forms.ComboBox();
            this.radioSingle = new System.Windows.Forms.RadioButton();
            this.radioReturn = new System.Windows.Forms.RadioButton();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.grpDay = new System.Windows.Forms.GroupBox();
            this.grpRoute = new System.Windows.Forms.GroupBox();
            this.grpSchedule = new System.Windows.Forms.GroupBox();
            this.grpRates = new System.Windows.Forms.GroupBox();
            this.mnuStripSellTicket.SuspendLayout();
            this.grpDay.SuspendLayout();
            this.grpRoute.SuspendLayout();
            this.grpSchedule.SuspendLayout();
            this.grpRates.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStripSellTicket
            // 
            this.mnuStripSellTicket.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStripSellTicket.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSellTicketBack,
            this.mnuExit});
            this.mnuStripSellTicket.Location = new System.Drawing.Point(0, 0);
            this.mnuStripSellTicket.Name = "mnuStripSellTicket";
            this.mnuStripSellTicket.Size = new System.Drawing.Size(752, 29);
            this.mnuStripSellTicket.TabIndex = 3;
            this.mnuStripSellTicket.Text = "mnuAddRoutes";
            // 
            // mnuSellTicketBack
            // 
            this.mnuSellTicketBack.Name = "mnuSellTicketBack";
            this.mnuSellTicketBack.Size = new System.Drawing.Size(54, 25);
            this.mnuSellTicketBack.Text = "Back";
            this.mnuSellTicketBack.Click += new System.EventHandler(this.mnuSellTicketBack_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(46, 25);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(440, 356);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(300, 29);
            this.btnConfirm.TabIndex = 30;
            this.btnConfirm.Text = "Confirm Purchase";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Enabled = false;
            this.txtTotalCost.Location = new System.Drawing.Point(576, 283);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(164, 20);
            this.txtTotalCost.TabIndex = 24;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(436, 282);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(77, 21);
            this.lblTotalCost.TabIndex = 27;
            this.lblTotalCost.Text = "Total Cost";
            // 
            // lblSaleDate
            // 
            this.lblSaleDate.AutoSize = true;
            this.lblSaleDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleDate.Location = new System.Drawing.Point(436, 318);
            this.lblSaleDate.Name = "lblSaleDate";
            this.lblSaleDate.Size = new System.Drawing.Size(75, 21);
            this.lblSaleDate.TabIndex = 29;
            this.lblSaleDate.Text = "Sale Date";
            // 
            // txtSaleDate
            // 
            this.txtSaleDate.Enabled = false;
            this.txtSaleDate.Location = new System.Drawing.Point(576, 320);
            this.txtSaleDate.Name = "txtSaleDate";
            this.txtSaleDate.Size = new System.Drawing.Size(164, 20);
            this.txtSaleDate.TabIndex = 28;
            // 
            // lblSaleID
            // 
            this.lblSaleID.AutoSize = true;
            this.lblSaleID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleID.Location = new System.Drawing.Point(436, 244);
            this.lblSaleID.Name = "lblSaleID";
            this.lblSaleID.Size = new System.Drawing.Size(58, 21);
            this.lblSaleID.TabIndex = 32;
            this.lblSaleID.Text = "Sale ID";
            // 
            // txtSaleID
            // 
            this.txtSaleID.Enabled = false;
            this.txtSaleID.Location = new System.Drawing.Point(576, 246);
            this.txtSaleID.Name = "txtSaleID";
            this.txtSaleID.Size = new System.Drawing.Size(164, 20);
            this.txtSaleID.TabIndex = 31;
            // 
            // cmbRoute
            // 
            this.cmbRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoute.FormattingEnabled = true;
            this.cmbRoute.Location = new System.Drawing.Point(6, 19);
            this.cmbRoute.Name = "cmbRoute";
            this.cmbRoute.Size = new System.Drawing.Size(314, 21);
            this.cmbRoute.TabIndex = 33;
            this.cmbRoute.SelectedIndexChanged += new System.EventHandler(this.cmbRoute_SelectedIndexChanged);
            // 
            // cmbRates
            // 
            this.cmbRates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRates.FormattingEnabled = true;
            this.cmbRates.Location = new System.Drawing.Point(6, 19);
            this.cmbRates.Name = "cmbRates";
            this.cmbRates.Size = new System.Drawing.Size(164, 21);
            this.cmbRates.TabIndex = 34;
            this.cmbRates.SelectedIndexChanged += new System.EventHandler(this.cmbRates_SelectedIndexChanged);
            // 
            // cmbSchedule
            // 
            this.cmbSchedule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSchedule.FormattingEnabled = true;
            this.cmbSchedule.Location = new System.Drawing.Point(6, 19);
            this.cmbSchedule.Name = "cmbSchedule";
            this.cmbSchedule.Size = new System.Drawing.Size(164, 21);
            this.cmbSchedule.TabIndex = 36;
            this.cmbSchedule.SelectedIndexChanged += new System.EventHandler(this.cmbSchedule_SelectedIndexChanged);
            // 
            // radioSingle
            // 
            this.radioSingle.AutoSize = true;
            this.radioSingle.Location = new System.Drawing.Point(6, 46);
            this.radioSingle.Name = "radioSingle";
            this.radioSingle.Size = new System.Drawing.Size(54, 17);
            this.radioSingle.TabIndex = 37;
            this.radioSingle.TabStop = true;
            this.radioSingle.Text = "Single";
            this.radioSingle.UseVisualStyleBackColor = true;
            this.radioSingle.CheckedChanged += new System.EventHandler(this.radioSingle_CheckedChanged);
            // 
            // radioReturn
            // 
            this.radioReturn.AutoSize = true;
            this.radioReturn.Location = new System.Drawing.Point(113, 46);
            this.radioReturn.Name = "radioReturn";
            this.radioReturn.Size = new System.Drawing.Size(57, 17);
            this.radioReturn.TabIndex = 38;
            this.radioReturn.TabStop = true;
            this.radioReturn.Text = "Return";
            this.radioReturn.UseVisualStyleBackColor = true;
            this.radioReturn.CheckedChanged += new System.EventHandler(this.radioReturn_CheckedChanged);
            // 
            // cmbDay
            // 
            this.cmbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Location = new System.Drawing.Point(6, 19);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(164, 21);
            this.cmbDay.TabIndex = 39;
            this.cmbDay.SelectedIndexChanged += new System.EventHandler(this.cmbDay_SelectedIndexChanged);
            // 
            // grpDay
            // 
            this.grpDay.Controls.Add(this.cmbDay);
            this.grpDay.Location = new System.Drawing.Point(343, 32);
            this.grpDay.Name = "grpDay";
            this.grpDay.Size = new System.Drawing.Size(178, 53);
            this.grpDay.TabIndex = 41;
            this.grpDay.TabStop = false;
            this.grpDay.Text = "Day";
            this.grpDay.Visible = false;
            // 
            // grpRoute
            // 
            this.grpRoute.Controls.Add(this.cmbRoute);
            this.grpRoute.Location = new System.Drawing.Point(12, 32);
            this.grpRoute.Name = "grpRoute";
            this.grpRoute.Size = new System.Drawing.Size(325, 53);
            this.grpRoute.TabIndex = 42;
            this.grpRoute.TabStop = false;
            this.grpRoute.Text = "Route";
            // 
            // grpSchedule
            // 
            this.grpSchedule.Controls.Add(this.cmbSchedule);
            this.grpSchedule.Location = new System.Drawing.Point(12, 91);
            this.grpSchedule.Name = "grpSchedule";
            this.grpSchedule.Size = new System.Drawing.Size(177, 53);
            this.grpSchedule.TabIndex = 43;
            this.grpSchedule.TabStop = false;
            this.grpSchedule.Text = "Schedule";
            this.grpSchedule.Visible = false;
            // 
            // grpRates
            // 
            this.grpRates.Controls.Add(this.cmbRates);
            this.grpRates.Controls.Add(this.radioSingle);
            this.grpRates.Controls.Add(this.radioReturn);
            this.grpRates.Location = new System.Drawing.Point(12, 150);
            this.grpRates.Name = "grpRates";
            this.grpRates.Size = new System.Drawing.Size(180, 68);
            this.grpRates.TabIndex = 44;
            this.grpRates.TabStop = false;
            this.grpRates.Text = "Ticket Type";
            this.grpRates.Visible = false;
            // 
            // frmSellTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 393);
            this.Controls.Add(this.grpRates);
            this.Controls.Add(this.grpSchedule);
            this.Controls.Add(this.grpRoute);
            this.Controls.Add(this.grpDay);
            this.Controls.Add(this.lblSaleID);
            this.Controls.Add(this.txtSaleID);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblSaleDate);
            this.Controls.Add(this.txtSaleDate);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.mnuStripSellTicket);
            this.Name = "frmSellTicket";
            this.Text = "Train Ticket System - Sell Ticket";
            this.Load += new System.EventHandler(this.frmSellTicket_Load);
            this.mnuStripSellTicket.ResumeLayout(false);
            this.mnuStripSellTicket.PerformLayout();
            this.grpDay.ResumeLayout(false);
            this.grpRoute.ResumeLayout(false);
            this.grpSchedule.ResumeLayout(false);
            this.grpRates.ResumeLayout(false);
            this.grpRates.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStripSellTicket;
        private System.Windows.Forms.ToolStripMenuItem mnuSellTicketBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblSaleDate;
        private System.Windows.Forms.TextBox txtSaleDate;
        private System.Windows.Forms.Label lblSaleID;
        private System.Windows.Forms.TextBox txtSaleID;
        private System.Windows.Forms.ComboBox cmbRoute;
        private System.Windows.Forms.ComboBox cmbRates;
        private System.Windows.Forms.ComboBox cmbSchedule;
		private System.Windows.Forms.RadioButton radioSingle;
		private System.Windows.Forms.RadioButton radioReturn;
		private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.GroupBox grpDay;
        private System.Windows.Forms.GroupBox grpRoute;
        private System.Windows.Forms.GroupBox grpSchedule;
        private System.Windows.Forms.GroupBox grpRates;
    }
}