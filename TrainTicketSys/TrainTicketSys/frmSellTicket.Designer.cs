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
            this.confirmButtonSellTicket = new System.Windows.Forms.Button();
            this.lblRoute = new System.Windows.Forms.Label();
            this.lblRates = new System.Windows.Forms.Label();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblSaleDate = new System.Windows.Forms.Label();
            this.txtSaleDate = new System.Windows.Forms.TextBox();
            this.lblSaleID = new System.Windows.Forms.Label();
            this.txtSaleID = new System.Windows.Forms.TextBox();
            this.cmbRoute = new System.Windows.Forms.ComboBox();
            this.cmbRates = new System.Windows.Forms.ComboBox();
            this.cmbSchedule = new System.Windows.Forms.ComboBox();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.mnuStripSellTicket.SuspendLayout();
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
            // confirmButtonSellTicket
            // 
            this.confirmButtonSellTicket.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButtonSellTicket.Location = new System.Drawing.Point(233, 304);
            this.confirmButtonSellTicket.Name = "confirmButtonSellTicket";
            this.confirmButtonSellTicket.Size = new System.Drawing.Size(300, 29);
            this.confirmButtonSellTicket.TabIndex = 30;
            this.confirmButtonSellTicket.Text = "Confirm Purchase";
            this.confirmButtonSellTicket.UseVisualStyleBackColor = true;
            // 
            // lblRoute
            // 
            this.lblRoute.AutoSize = true;
            this.lblRoute.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoute.Location = new System.Drawing.Point(229, 108);
            this.lblRoute.Name = "lblRoute";
            this.lblRoute.Size = new System.Drawing.Size(83, 21);
            this.lblRoute.TabIndex = 23;
            this.lblRoute.Text = "Pick Route";
            // 
            // lblRates
            // 
            this.lblRates.AutoSize = true;
            this.lblRates.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRates.Location = new System.Drawing.Point(229, 178);
            this.lblRates.Name = "lblRates";
            this.lblRates.Size = new System.Drawing.Size(87, 21);
            this.lblRates.TabIndex = 25;
            this.lblRates.Text = "Ticket Type";
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Enabled = false;
            this.txtTotalCost.Location = new System.Drawing.Point(369, 215);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(164, 20);
            this.txtTotalCost.TabIndex = 24;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(229, 214);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(79, 21);
            this.lblTotalCost.TabIndex = 27;
            this.lblTotalCost.Text = "Total Cost";
            // 
            // lblSaleDate
            // 
            this.lblSaleDate.AutoSize = true;
            this.lblSaleDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleDate.Location = new System.Drawing.Point(229, 250);
            this.lblSaleDate.Name = "lblSaleDate";
            this.lblSaleDate.Size = new System.Drawing.Size(75, 21);
            this.lblSaleDate.TabIndex = 29;
            this.lblSaleDate.Text = "Sale Date";
            // 
            // txtSaleDate
            // 
            this.txtSaleDate.Enabled = false;
            this.txtSaleDate.Location = new System.Drawing.Point(369, 252);
            this.txtSaleDate.Name = "txtSaleDate";
            this.txtSaleDate.Size = new System.Drawing.Size(164, 20);
            this.txtSaleDate.TabIndex = 28;
            // 
            // lblSaleID
            // 
            this.lblSaleID.AutoSize = true;
            this.lblSaleID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleID.Location = new System.Drawing.Point(229, 71);
            this.lblSaleID.Name = "lblSaleID";
            this.lblSaleID.Size = new System.Drawing.Size(58, 21);
            this.lblSaleID.TabIndex = 32;
            this.lblSaleID.Text = "Sale ID";
            // 
            // txtSaleID
            // 
            this.txtSaleID.Enabled = false;
            this.txtSaleID.Location = new System.Drawing.Point(369, 73);
            this.txtSaleID.Name = "txtSaleID";
            this.txtSaleID.Size = new System.Drawing.Size(164, 20);
            this.txtSaleID.TabIndex = 31;
            // 
            // cmbRoute
            // 
            this.cmbRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoute.FormattingEnabled = true;
            this.cmbRoute.Location = new System.Drawing.Point(369, 108);
            this.cmbRoute.Name = "cmbRoute";
            this.cmbRoute.Size = new System.Drawing.Size(164, 21);
            this.cmbRoute.TabIndex = 33;
            // 
            // cmbRates
            // 
            this.cmbRates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRates.FormattingEnabled = true;
            this.cmbRates.Location = new System.Drawing.Point(369, 178);
            this.cmbRates.Name = "cmbRates";
            this.cmbRates.Size = new System.Drawing.Size(164, 21);
            this.cmbRates.TabIndex = 34;
            // 
            // cmbSchedule
            // 
            this.cmbSchedule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSchedule.FormattingEnabled = true;
            this.cmbSchedule.Location = new System.Drawing.Point(369, 141);
            this.cmbSchedule.Name = "cmbSchedule";
            this.cmbSchedule.Size = new System.Drawing.Size(164, 21);
            this.cmbSchedule.TabIndex = 36;
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchedule.Location = new System.Drawing.Point(229, 142);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(105, 21);
            this.lblSchedule.TabIndex = 35;
            this.lblSchedule.Text = "Pick Schedule";
            // 
            // frmSellTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 393);
            this.Controls.Add(this.cmbSchedule);
            this.Controls.Add(this.lblSchedule);
            this.Controls.Add(this.cmbRates);
            this.Controls.Add(this.cmbRoute);
            this.Controls.Add(this.lblSaleID);
            this.Controls.Add(this.txtSaleID);
            this.Controls.Add(this.confirmButtonSellTicket);
            this.Controls.Add(this.lblSaleDate);
            this.Controls.Add(this.txtSaleDate);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblRates);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.lblRoute);
            this.Controls.Add(this.mnuStripSellTicket);
            this.Name = "frmSellTicket";
            this.Text = "Train Ticket System - Sell Ticket";
            this.Load += new System.EventHandler(this.frmSellTicket_Load);
            this.mnuStripSellTicket.ResumeLayout(false);
            this.mnuStripSellTicket.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStripSellTicket;
        private System.Windows.Forms.ToolStripMenuItem mnuSellTicketBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Button confirmButtonSellTicket;
        private System.Windows.Forms.Label lblRoute;
        private System.Windows.Forms.Label lblRates;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblSaleDate;
        private System.Windows.Forms.TextBox txtSaleDate;
        private System.Windows.Forms.Label lblSaleID;
        private System.Windows.Forms.TextBox txtSaleID;
        private System.Windows.Forms.ComboBox cmbRoute;
        private System.Windows.Forms.ComboBox cmbRates;
        private System.Windows.Forms.ComboBox cmbSchedule;
        private System.Windows.Forms.Label lblSchedule;
    }
}