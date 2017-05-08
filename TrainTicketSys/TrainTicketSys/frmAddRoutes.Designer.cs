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
            this.lblRouteID = new System.Windows.Forms.Label();
            this.txtRouteID = new System.Windows.Forms.TextBox();
            this.lblArrSt = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblDepSt = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbArrSt = new System.Windows.Forms.ComboBox();
            this.cmbDepSt = new System.Windows.Forms.ComboBox();
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
            this.mnuStripAddRoutes.Size = new System.Drawing.Size(624, 27);
            this.mnuStripAddRoutes.TabIndex = 0;
            this.mnuStripAddRoutes.Text = "mnuAddRoutes";
            // 
            // mnuAddRoutesBack
            // 
            this.mnuAddRoutesBack.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuAddRoutesBack.Name = "mnuAddRoutesBack";
            this.mnuAddRoutesBack.Size = new System.Drawing.Size(53, 23);
            this.mnuAddRoutesBack.Text = "Back";
            this.mnuAddRoutesBack.Click += new System.EventHandler(this.mnuAddRoutesBack_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(47, 23);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // lblRouteID
            // 
            this.lblRouteID.AutoSize = true;
            this.lblRouteID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRouteID.Location = new System.Drawing.Point(12, 293);
            this.lblRouteID.Name = "lblRouteID";
            this.lblRouteID.Size = new System.Drawing.Size(78, 19);
            this.lblRouteID.TabIndex = 5;
            this.lblRouteID.Text = "Route ID:";
            this.lblRouteID.Visible = false;
            // 
            // txtRouteID
            // 
            this.txtRouteID.BackColor = System.Drawing.SystemColors.Window;
            this.txtRouteID.Enabled = false;
            this.txtRouteID.Location = new System.Drawing.Point(96, 293);
            this.txtRouteID.Name = "txtRouteID";
            this.txtRouteID.Size = new System.Drawing.Size(111, 20);
            this.txtRouteID.TabIndex = 4;
            this.txtRouteID.Visible = false;
            // 
            // lblArrSt
            // 
            this.lblArrSt.AutoSize = true;
            this.lblArrSt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrSt.Location = new System.Drawing.Point(139, 142);
            this.lblArrSt.Name = "lblArrSt";
            this.lblArrSt.Size = new System.Drawing.Size(116, 19);
            this.lblArrSt.TabIndex = 5;
            this.lblArrSt.Text = "Arrival Station:";
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(302, 176);
            this.txtDistance.MaxLength = 9;
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(164, 20);
            this.txtDistance.TabIndex = 4;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistance.Location = new System.Drawing.Point(139, 177);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(120, 19);
            this.lblDistance.TabIndex = 5;
            this.lblDistance.Text = "Route Distance:";
            // 
            // btnCreate
            // 
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(302, 211);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(164, 29);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create Route";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.confirmButtonAddRoutes_Click);
            // 
            // lblDepSt
            // 
            this.lblDepSt.AutoSize = true;
            this.lblDepSt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepSt.Location = new System.Drawing.Point(139, 105);
            this.lblDepSt.Name = "lblDepSt";
            this.lblDepSt.Size = new System.Drawing.Size(139, 19);
            this.lblDepSt.TabIndex = 7;
            this.lblDepSt.Text = "Departure Station:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(226, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(171, 23);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Enter Route Details";
            // 
            // cmbArrSt
            // 
            this.cmbArrSt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArrSt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbArrSt.FormattingEnabled = true;
            this.cmbArrSt.Location = new System.Drawing.Point(302, 142);
            this.cmbArrSt.Name = "cmbArrSt";
            this.cmbArrSt.Size = new System.Drawing.Size(164, 21);
            this.cmbArrSt.TabIndex = 12;
            // 
            // cmbDepSt
            // 
            this.cmbDepSt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepSt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbDepSt.FormattingEnabled = true;
            this.cmbDepSt.Location = new System.Drawing.Point(302, 105);
            this.cmbDepSt.Name = "cmbDepSt";
            this.cmbDepSt.Size = new System.Drawing.Size(164, 21);
            this.cmbDepSt.TabIndex = 11;
            // 
            // frmAddRoutes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cmbArrSt);
            this.Controls.Add(this.cmbDepSt);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblDepSt);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.lblArrSt);
            this.Controls.Add(this.lblRouteID);
            this.Controls.Add(this.txtRouteID);
            this.Controls.Add(this.mnuStripAddRoutes);
            this.MainMenuStrip = this.mnuStripAddRoutes;
            this.Name = "frmAddRoutes";
            this.Text = "Train Ticket System - Add Route";
            this.Load += new System.EventHandler(this.frmAddRoutes_Load);
            this.mnuStripAddRoutes.ResumeLayout(false);
            this.mnuStripAddRoutes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStripAddRoutes;
        private System.Windows.Forms.ToolStripMenuItem mnuAddRoutesBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label lblRouteID;
        private System.Windows.Forms.TextBox txtRouteID;
        private System.Windows.Forms.Label lblArrSt;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblDepSt;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbArrSt;
        private System.Windows.Forms.ComboBox cmbDepSt;
    }
}