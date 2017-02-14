namespace TrainTicketSys
{
    partial class frmMainMenu
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
            this.mnuStripMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuStations = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddStation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCloseStation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListStations = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddRoutes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTerminateRoute = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListRoutes = new System.Windows.Forms.ToolStripMenuItem();
            this.financeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuScheduleTrain = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShowTimetable = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetTicketType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateTicketType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSellTicket = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRevenueAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTicketSalesAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mnuStripMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStripMainMenu
            // 
            this.mnuStripMainMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStations,
            this.ticketToolStripMenuItem,
            this.financeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salesToolStripMenuItem,
            this.mnuExit});
            this.mnuStripMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuStripMainMenu.Name = "mnuStripMainMenu";
            this.mnuStripMainMenu.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.mnuStripMainMenu.Size = new System.Drawing.Size(1008, 31);
            this.mnuStripMainMenu.TabIndex = 0;
            this.mnuStripMainMenu.Text = "mnuMainMenu";
            // 
            // mnuStations
            // 
            this.mnuStations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddStation,
            this.mnuCloseStation,
            this.mnuListStations});
            this.mnuStations.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mnuStations.Name = "mnuStations";
            this.mnuStations.Size = new System.Drawing.Size(77, 25);
            this.mnuStations.Text = "Stations";
            // 
            // mnuAddStation
            // 
            this.mnuAddStation.BackColor = System.Drawing.SystemColors.Control;
            this.mnuAddStation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mnuAddStation.Name = "mnuAddStation";
            this.mnuAddStation.Size = new System.Drawing.Size(170, 26);
            this.mnuAddStation.Text = "Add Station";
            this.mnuAddStation.Click += new System.EventHandler(this.mnuAddStation_Click);
            // 
            // mnuCloseStation
            // 
            this.mnuCloseStation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mnuCloseStation.Name = "mnuCloseStation";
            this.mnuCloseStation.Size = new System.Drawing.Size(170, 26);
            this.mnuCloseStation.Text = "Close Station";
            this.mnuCloseStation.Click += new System.EventHandler(this.mnuCloseStation_Click);
            // 
            // mnuListStations
            // 
            this.mnuListStations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mnuListStations.Name = "mnuListStations";
            this.mnuListStations.Size = new System.Drawing.Size(170, 26);
            this.mnuListStations.Text = "List Stations";
            this.mnuListStations.Click += new System.EventHandler(this.mnuListStations_Click);
            // 
            // ticketToolStripMenuItem
            // 
            this.ticketToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddRoutes,
            this.mnuTerminateRoute,
            this.mnuListRoutes});
            this.ticketToolStripMenuItem.Name = "ticketToolStripMenuItem";
            this.ticketToolStripMenuItem.Size = new System.Drawing.Size(70, 25);
            this.ticketToolStripMenuItem.Text = "Routes";
            this.ticketToolStripMenuItem.Click += new System.EventHandler(this.ticketToolStripMenuItem_Click);
            // 
            // mnuAddRoutes
            // 
            this.mnuAddRoutes.Name = "mnuAddRoutes";
            this.mnuAddRoutes.Size = new System.Drawing.Size(193, 26);
            this.mnuAddRoutes.Text = "Add Routes";
            this.mnuAddRoutes.Click += new System.EventHandler(this.mnuAddRoutes_Click);
            // 
            // mnuTerminateRoute
            // 
            this.mnuTerminateRoute.Name = "mnuTerminateRoute";
            this.mnuTerminateRoute.Size = new System.Drawing.Size(193, 26);
            this.mnuTerminateRoute.Text = "Terminate Route";
            this.mnuTerminateRoute.Click += new System.EventHandler(this.mnuTerminateRoute_Click);
            // 
            // mnuListRoutes
            // 
            this.mnuListRoutes.Name = "mnuListRoutes";
            this.mnuListRoutes.Size = new System.Drawing.Size(193, 26);
            this.mnuListRoutes.Text = "List Routes";
            this.mnuListRoutes.Click += new System.EventHandler(this.mnuListRoutes_Click);
            // 
            // financeToolStripMenuItem
            // 
            this.financeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuScheduleTrain,
            this.mnuShowTimetable});
            this.financeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financeToolStripMenuItem.Name = "financeToolStripMenuItem";
            this.financeToolStripMenuItem.Size = new System.Drawing.Size(92, 25);
            this.financeToolStripMenuItem.Text = "Schedules";
            // 
            // mnuScheduleTrain
            // 
            this.mnuScheduleTrain.Name = "mnuScheduleTrain";
            this.mnuScheduleTrain.Size = new System.Drawing.Size(191, 26);
            this.mnuScheduleTrain.Text = "Schedule Train";
            this.mnuScheduleTrain.Click += new System.EventHandler(this.mnuScheduleTrain_Click);
            // 
            // mnuShowTimetable
            // 
            this.mnuShowTimetable.Name = "mnuShowTimetable";
            this.mnuShowTimetable.Size = new System.Drawing.Size(191, 26);
            this.mnuShowTimetable.Text = "Show Timetable";
            this.mnuShowTimetable.Click += new System.EventHandler(this.mnuShowTimetable_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSetTicketType,
            this.mnuUpdateTicketType,
            this.mnuSellTicket});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(69, 25);
            this.toolStripMenuItem1.Text = "Tickets";
            // 
            // mnuSetTicketType
            // 
            this.mnuSetTicketType.Name = "mnuSetTicketType";
            this.mnuSetTicketType.Size = new System.Drawing.Size(210, 26);
            this.mnuSetTicketType.Text = "Set Ticket Type";
            this.mnuSetTicketType.Click += new System.EventHandler(this.mnuSetTicketType_Click);
            // 
            // mnuUpdateTicketType
            // 
            this.mnuUpdateTicketType.Name = "mnuUpdateTicketType";
            this.mnuUpdateTicketType.Size = new System.Drawing.Size(210, 26);
            this.mnuUpdateTicketType.Text = "Update Ticket Type";
            this.mnuUpdateTicketType.Click += new System.EventHandler(this.mnuUpdateTicketType_Click);
            // 
            // mnuSellTicket
            // 
            this.mnuSellTicket.Name = "mnuSellTicket";
            this.mnuSellTicket.Size = new System.Drawing.Size(210, 26);
            this.mnuSellTicket.Text = "Sell Ticket";
            this.mnuSellTicket.Click += new System.EventHandler(this.mnuSellTicket_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRevenueAnalysis,
            this.mnuTicketSalesAnalysis});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(58, 25);
            this.salesToolStripMenuItem.Text = "Sales";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // mnuRevenueAnalysis
            // 
            this.mnuRevenueAnalysis.Name = "mnuRevenueAnalysis";
            this.mnuRevenueAnalysis.Size = new System.Drawing.Size(221, 26);
            this.mnuRevenueAnalysis.Text = "Revenue Analysis";
            this.mnuRevenueAnalysis.Click += new System.EventHandler(this.mnuRevenueAnalysis_Click);
            // 
            // mnuTicketSalesAnalysis
            // 
            this.mnuTicketSalesAnalysis.Name = "mnuTicketSalesAnalysis";
            this.mnuTicketSalesAnalysis.Size = new System.Drawing.Size(221, 26);
            this.mnuTicketSalesAnalysis.Text = "Ticket Sales Analysis";
            this.mnuTicketSalesAnalysis.Click += new System.EventHandler(this.mnuTicketSalesAnalysis_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(46, 25);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 112);
            this.label1.TabIndex = 1;
            this.label1.Text = "Iarnród Éireann";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(228, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 112);
            this.label2.TabIndex = 2;
            this.label2.Text = "Irish Rail";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnuStripMainMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.mnuStripMainMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMainMenu";
            this.Text = "Train Ticket System - Main Menu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.mnuStripMainMenu.ResumeLayout(false);
            this.mnuStripMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStripMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuStations;
        private System.Windows.Forms.ToolStripMenuItem mnuAddStation;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseStation;
        private System.Windows.Forms.ToolStripMenuItem mnuListStations;
        private System.Windows.Forms.ToolStripMenuItem ticketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAddRoutes;
        private System.Windows.Forms.ToolStripMenuItem mnuTerminateRoute;
        private System.Windows.Forms.ToolStripMenuItem mnuListRoutes;
        private System.Windows.Forms.ToolStripMenuItem financeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuScheduleTrain;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuShowTimetable;
        private System.Windows.Forms.ToolStripMenuItem mnuSetTicketType;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateTicketType;
        private System.Windows.Forms.ToolStripMenuItem mnuSellTicket;
        private System.Windows.Forms.ToolStripMenuItem mnuRevenueAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuTicketSalesAnalysis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

