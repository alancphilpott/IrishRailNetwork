namespace TrainTicketSys
{
    partial class frmTerminateRoute
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
            this.mnuStripTerminateRoute = new System.Windows.Forms.MenuStrip();
            this.mnuTerminateRouteBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTerminateRouteExit = new System.Windows.Forms.ToolStripMenuItem();
            this.routeIDBoxTerminateRoute = new System.Windows.Forms.ComboBox();
            this.routeIDTerminateRoute = new System.Windows.Forms.Label();
            this.confirmButtonTerminateRoute = new System.Windows.Forms.Button();
            this.mnuStripTerminateRoute.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStripTerminateRoute
            // 
            this.mnuStripTerminateRoute.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStripTerminateRoute.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTerminateRouteBack,
            this.mnuTerminateRouteExit});
            this.mnuStripTerminateRoute.Location = new System.Drawing.Point(0, 0);
            this.mnuStripTerminateRoute.Name = "mnuStripTerminateRoute";
            this.mnuStripTerminateRoute.Size = new System.Drawing.Size(446, 29);
            this.mnuStripTerminateRoute.TabIndex = 2;
            this.mnuStripTerminateRoute.Text = "menuStrip1";
            // 
            // mnuTerminateRouteBack
            // 
            this.mnuTerminateRouteBack.Name = "mnuTerminateRouteBack";
            this.mnuTerminateRouteBack.Size = new System.Drawing.Size(54, 25);
            this.mnuTerminateRouteBack.Text = "Back";
            this.mnuTerminateRouteBack.Click += new System.EventHandler(this.mnuTerminateRouteBack_Click);
            // 
            // mnuTerminateRouteExit
            // 
            this.mnuTerminateRouteExit.Name = "mnuTerminateRouteExit";
            this.mnuTerminateRouteExit.Size = new System.Drawing.Size(46, 25);
            this.mnuTerminateRouteExit.Text = "Exit";
            this.mnuTerminateRouteExit.Click += new System.EventHandler(this.mnuTerminateRouteExit_Click);
            // 
            // routeIDBoxTerminateRoute
            // 
            this.routeIDBoxTerminateRoute.FormattingEnabled = true;
            this.routeIDBoxTerminateRoute.Items.AddRange(new object[] {
            "Routes"});
            this.routeIDBoxTerminateRoute.Location = new System.Drawing.Point(211, 53);
            this.routeIDBoxTerminateRoute.Name = "routeIDBoxTerminateRoute";
            this.routeIDBoxTerminateRoute.Size = new System.Drawing.Size(164, 21);
            this.routeIDBoxTerminateRoute.TabIndex = 13;
            this.routeIDBoxTerminateRoute.Text = "Choose Route";
            // 
            // routeIDTerminateRoute
            // 
            this.routeIDTerminateRoute.AutoSize = true;
            this.routeIDTerminateRoute.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routeIDTerminateRoute.Location = new System.Drawing.Point(78, 54);
            this.routeIDTerminateRoute.Name = "routeIDTerminateRoute";
            this.routeIDTerminateRoute.Size = new System.Drawing.Size(73, 21);
            this.routeIDTerminateRoute.TabIndex = 12;
            this.routeIDTerminateRoute.Text = "Route ID:";
            // 
            // confirmButtonTerminateRoute
            // 
            this.confirmButtonTerminateRoute.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButtonTerminateRoute.Location = new System.Drawing.Point(82, 91);
            this.confirmButtonTerminateRoute.Name = "confirmButtonTerminateRoute";
            this.confirmButtonTerminateRoute.Size = new System.Drawing.Size(293, 29);
            this.confirmButtonTerminateRoute.TabIndex = 11;
            this.confirmButtonTerminateRoute.Text = "Confirm";
            this.confirmButtonTerminateRoute.UseVisualStyleBackColor = true;
            // 
            // frmTerminateRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 162);
            this.Controls.Add(this.routeIDBoxTerminateRoute);
            this.Controls.Add(this.routeIDTerminateRoute);
            this.Controls.Add(this.confirmButtonTerminateRoute);
            this.Controls.Add(this.mnuStripTerminateRoute);
            this.Name = "frmTerminateRoute";
            this.Text = "Train Ticket System - Terminate Route";
            this.Load += new System.EventHandler(this.frmTerminateRoute_Load);
            this.mnuStripTerminateRoute.ResumeLayout(false);
            this.mnuStripTerminateRoute.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStripTerminateRoute;
        private System.Windows.Forms.ToolStripMenuItem mnuTerminateRouteBack;
        private System.Windows.Forms.ToolStripMenuItem mnuTerminateRouteExit;
        private System.Windows.Forms.ComboBox routeIDBoxTerminateRoute;
        private System.Windows.Forms.Label routeIDTerminateRoute;
        private System.Windows.Forms.Button confirmButtonTerminateRoute;
    }
}