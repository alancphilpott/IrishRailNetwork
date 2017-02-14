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
            this.stationSellTicket = new System.Windows.Forms.Label();
            this.stationBoxSellTicket = new System.Windows.Forms.TextBox();
            this.routeIDSellTicket = new System.Windows.Forms.Label();
            this.routeIDBoxSellTicket = new System.Windows.Forms.TextBox();
            this.typeSellTicket = new System.Windows.Forms.Label();
            this.typeBoxSellTicket = new System.Windows.Forms.TextBox();
            this.costSellTicket = new System.Windows.Forms.Label();
            this.costBoxSellTicket = new System.Windows.Forms.TextBox();
            this.confirmButtonSellTicket = new System.Windows.Forms.Button();
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
            this.mnuStripSellTicket.Size = new System.Drawing.Size(442, 29);
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
            // stationSellTicket
            // 
            this.stationSellTicket.AutoSize = true;
            this.stationSellTicket.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stationSellTicket.Location = new System.Drawing.Point(62, 59);
            this.stationSellTicket.Name = "stationSellTicket";
            this.stationSellTicket.Size = new System.Drawing.Size(135, 21);
            this.stationSellTicket.TabIndex = 23;
            this.stationSellTicket.Text = "Departure Station:";
            // 
            // stationBoxSellTicket
            // 
            this.stationBoxSellTicket.Location = new System.Drawing.Point(202, 61);
            this.stationBoxSellTicket.Name = "stationBoxSellTicket";
            this.stationBoxSellTicket.Size = new System.Drawing.Size(164, 20);
            this.stationBoxSellTicket.TabIndex = 22;
            // 
            // routeIDSellTicket
            // 
            this.routeIDSellTicket.AutoSize = true;
            this.routeIDSellTicket.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routeIDSellTicket.Location = new System.Drawing.Point(62, 92);
            this.routeIDSellTicket.Name = "routeIDSellTicket";
            this.routeIDSellTicket.Size = new System.Drawing.Size(73, 21);
            this.routeIDSellTicket.TabIndex = 25;
            this.routeIDSellTicket.Text = "Route ID:";
            // 
            // routeIDBoxSellTicket
            // 
            this.routeIDBoxSellTicket.Location = new System.Drawing.Point(202, 94);
            this.routeIDBoxSellTicket.Name = "routeIDBoxSellTicket";
            this.routeIDBoxSellTicket.Size = new System.Drawing.Size(164, 20);
            this.routeIDBoxSellTicket.TabIndex = 24;
            // 
            // typeSellTicket
            // 
            this.typeSellTicket.AutoSize = true;
            this.typeSellTicket.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeSellTicket.Location = new System.Drawing.Point(62, 128);
            this.typeSellTicket.Name = "typeSellTicket";
            this.typeSellTicket.Size = new System.Drawing.Size(89, 21);
            this.typeSellTicket.TabIndex = 27;
            this.typeSellTicket.Text = "Ticket Type:";
            // 
            // typeBoxSellTicket
            // 
            this.typeBoxSellTicket.Location = new System.Drawing.Point(202, 130);
            this.typeBoxSellTicket.Name = "typeBoxSellTicket";
            this.typeBoxSellTicket.Size = new System.Drawing.Size(164, 20);
            this.typeBoxSellTicket.TabIndex = 26;
            // 
            // costSellTicket
            // 
            this.costSellTicket.AutoSize = true;
            this.costSellTicket.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costSellTicket.Location = new System.Drawing.Point(62, 164);
            this.costSellTicket.Name = "costSellTicket";
            this.costSellTicket.Size = new System.Drawing.Size(80, 21);
            this.costSellTicket.TabIndex = 29;
            this.costSellTicket.Text = "Total Cost:";
            // 
            // costBoxSellTicket
            // 
            this.costBoxSellTicket.Location = new System.Drawing.Point(202, 166);
            this.costBoxSellTicket.Name = "costBoxSellTicket";
            this.costBoxSellTicket.Size = new System.Drawing.Size(164, 20);
            this.costBoxSellTicket.TabIndex = 28;
            // 
            // confirmButtonSellTicket
            // 
            this.confirmButtonSellTicket.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButtonSellTicket.Location = new System.Drawing.Point(66, 216);
            this.confirmButtonSellTicket.Name = "confirmButtonSellTicket";
            this.confirmButtonSellTicket.Size = new System.Drawing.Size(300, 29);
            this.confirmButtonSellTicket.TabIndex = 30;
            this.confirmButtonSellTicket.Text = "Confirm Purchase";
            this.confirmButtonSellTicket.UseVisualStyleBackColor = true;
            // 
            // frmSellTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 290);
            this.Controls.Add(this.confirmButtonSellTicket);
            this.Controls.Add(this.costSellTicket);
            this.Controls.Add(this.costBoxSellTicket);
            this.Controls.Add(this.typeSellTicket);
            this.Controls.Add(this.typeBoxSellTicket);
            this.Controls.Add(this.routeIDSellTicket);
            this.Controls.Add(this.routeIDBoxSellTicket);
            this.Controls.Add(this.stationSellTicket);
            this.Controls.Add(this.stationBoxSellTicket);
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
        private System.Windows.Forms.Label stationSellTicket;
        private System.Windows.Forms.TextBox stationBoxSellTicket;
        private System.Windows.Forms.Label routeIDSellTicket;
        private System.Windows.Forms.TextBox routeIDBoxSellTicket;
        private System.Windows.Forms.Label typeSellTicket;
        private System.Windows.Forms.TextBox typeBoxSellTicket;
        private System.Windows.Forms.Label costSellTicket;
        private System.Windows.Forms.TextBox costBoxSellTicket;
        private System.Windows.Forms.Button confirmButtonSellTicket;
    }
}