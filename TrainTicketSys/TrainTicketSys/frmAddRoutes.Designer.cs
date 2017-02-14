namespace TrainTicketSys
{
    partial class frmAddRoutes
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
            this.mnuStripAddRoutes = new System.Windows.Forms.MenuStrip();
            this.mnuAddRoutesBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.routeIDAddRoute = new System.Windows.Forms.Label();
            this.routeIDBoxAddRoute = new System.Windows.Forms.TextBox();
            this.statusAddRoute = new System.Windows.Forms.Label();
            this.arrivalAddRoute = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.distanceAddRoute = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.statusBoxAddRoute = new System.Windows.Forms.ComboBox();
            this.departureAddRoute = new System.Windows.Forms.Label();
            this.txtDepSt = new System.Windows.Forms.ComboBox();
            this.txtArrSt = new System.Windows.Forms.ComboBox();
            this.mnuStripAddRoutes.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStripAddRoutes
            // 
            this.mnuStripAddRoutes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStripAddRoutes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddRoutesBack,
            this.mnuExit});
            this.mnuStripAddRoutes.Location = new System.Drawing.Point(0, 0);
            this.mnuStripAddRoutes.Name = "mnuStripAddRoutes";
            this.mnuStripAddRoutes.Size = new System.Drawing.Size(436, 29);
            this.mnuStripAddRoutes.TabIndex = 0;
            this.mnuStripAddRoutes.Text = "mnuAddRoutes";
            // 
            // mnuAddRoutesBack
            // 
            this.mnuAddRoutesBack.Name = "mnuAddRoutesBack";
            this.mnuAddRoutesBack.Size = new System.Drawing.Size(54, 25);
            this.mnuAddRoutesBack.Text = "Back";
            this.mnuAddRoutesBack.Click += new System.EventHandler(this.mnuAddRoutesBack_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(46, 25);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // routeIDAddRoute
            // 
            this.routeIDAddRoute.AutoSize = true;
            this.routeIDAddRoute.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routeIDAddRoute.Location = new System.Drawing.Point(51, 57);
            this.routeIDAddRoute.Name = "routeIDAddRoute";
            this.routeIDAddRoute.Size = new System.Drawing.Size(73, 21);
            this.routeIDAddRoute.TabIndex = 5;
            this.routeIDAddRoute.Text = "Route ID:";
            // 
            // routeIDBoxAddRoute
            // 
            this.routeIDBoxAddRoute.Location = new System.Drawing.Point(194, 60);
            this.routeIDBoxAddRoute.Name = "routeIDBoxAddRoute";
            this.routeIDBoxAddRoute.Size = new System.Drawing.Size(164, 20);
            this.routeIDBoxAddRoute.TabIndex = 4;
            // 
            // statusAddRoute
            // 
            this.statusAddRoute.AutoSize = true;
            this.statusAddRoute.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusAddRoute.Location = new System.Drawing.Point(51, 90);
            this.statusAddRoute.Name = "statusAddRoute";
            this.statusAddRoute.Size = new System.Drawing.Size(100, 21);
            this.statusAddRoute.TabIndex = 5;
            this.statusAddRoute.Text = "Route Status:";
            // 
            // arrivalAddRoute
            // 
            this.arrivalAddRoute.AutoSize = true;
            this.arrivalAddRoute.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrivalAddRoute.Location = new System.Drawing.Point(51, 153);
            this.arrivalAddRoute.Name = "arrivalAddRoute";
            this.arrivalAddRoute.Size = new System.Drawing.Size(111, 21);
            this.arrivalAddRoute.TabIndex = 5;
            this.arrivalAddRoute.Text = "Arrival Station:";
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(194, 190);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(164, 20);
            this.txtDistance.TabIndex = 4;
            // 
            // distanceAddRoute
            // 
            this.distanceAddRoute.AutoSize = true;
            this.distanceAddRoute.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceAddRoute.Location = new System.Drawing.Point(51, 187);
            this.distanceAddRoute.Name = "distanceAddRoute";
            this.distanceAddRoute.Size = new System.Drawing.Size(117, 21);
            this.distanceAddRoute.TabIndex = 5;
            this.distanceAddRoute.Text = "Route Distance:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(55, 228);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(303, 29);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm Details";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.confirmButtonAddRoutes_Click);
            // 
            // statusBoxAddRoute
            // 
            this.statusBoxAddRoute.FormattingEnabled = true;
            this.statusBoxAddRoute.Items.AddRange(new object[] {
            "Active",
            "Terminated"});
            this.statusBoxAddRoute.Location = new System.Drawing.Point(194, 93);
            this.statusBoxAddRoute.Name = "statusBoxAddRoute";
            this.statusBoxAddRoute.Size = new System.Drawing.Size(164, 21);
            this.statusBoxAddRoute.TabIndex = 9;
            this.statusBoxAddRoute.Text = "Choose Status";
            // 
            // departureAddRoute
            // 
            this.departureAddRoute.AutoSize = true;
            this.departureAddRoute.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureAddRoute.Location = new System.Drawing.Point(51, 122);
            this.departureAddRoute.Name = "departureAddRoute";
            this.departureAddRoute.Size = new System.Drawing.Size(135, 21);
            this.departureAddRoute.TabIndex = 7;
            this.departureAddRoute.Text = "Departure Station:";
            // 
            // txtDepSt
            // 
            this.txtDepSt.FormattingEnabled = true;
            this.txtDepSt.Items.AddRange(new object[] {
            "Stations"});
            this.txtDepSt.Location = new System.Drawing.Point(194, 125);
            this.txtDepSt.Name = "txtDepSt";
            this.txtDepSt.Size = new System.Drawing.Size(164, 21);
            this.txtDepSt.TabIndex = 11;
            this.txtDepSt.Text = "Choose Station";
            // 
            // txtArrSt
            // 
            this.txtArrSt.FormattingEnabled = true;
            this.txtArrSt.Items.AddRange(new object[] {
            "Stations"});
            this.txtArrSt.Location = new System.Drawing.Point(194, 156);
            this.txtArrSt.Name = "txtArrSt";
            this.txtArrSt.Size = new System.Drawing.Size(164, 21);
            this.txtArrSt.TabIndex = 12;
            this.txtArrSt.Text = "Choose Station";
            // 
            // frmAddRoutes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 303);
            this.Controls.Add(this.txtArrSt);
            this.Controls.Add(this.txtDepSt);
            this.Controls.Add(this.statusBoxAddRoute);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.departureAddRoute);
            this.Controls.Add(this.distanceAddRoute);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.arrivalAddRoute);
            this.Controls.Add(this.statusAddRoute);
            this.Controls.Add(this.routeIDAddRoute);
            this.Controls.Add(this.routeIDBoxAddRoute);
            this.Controls.Add(this.mnuStripAddRoutes);
            this.MainMenuStrip = this.mnuStripAddRoutes;
            this.Name = "frmAddRoutes";
            this.Text = "Train Ticket System - Add Route";
            this.mnuStripAddRoutes.ResumeLayout(false);
            this.mnuStripAddRoutes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStripAddRoutes;
        private System.Windows.Forms.ToolStripMenuItem mnuAddRoutesBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label routeIDAddRoute;
        private System.Windows.Forms.TextBox routeIDBoxAddRoute;
        private System.Windows.Forms.Label statusAddRoute;
        private System.Windows.Forms.Label arrivalAddRoute;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label distanceAddRoute;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ComboBox statusBoxAddRoute;
        private System.Windows.Forms.Label departureAddRoute;
        private System.Windows.Forms.ComboBox txtDepSt;
        private System.Windows.Forms.ComboBox txtArrSt;
    }
}