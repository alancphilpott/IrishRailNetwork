namespace TrainTicketSys
{
    partial class frmUpdateTicketType
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
            this.mnuStripUpdateTicketType = new System.Windows.Forms.MenuStrip();
            this.mnuUpdateTicketTypeBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblRatePerKM = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblTypeCode = new System.Windows.Forms.Label();
            this.txtTypeCode = new System.Windows.Forms.TextBox();
            this.cmbRates = new System.Windows.Forms.ComboBox();
            this.grpRateDetails = new System.Windows.Forms.GroupBox();
            this.nmbRatePicker = new System.Windows.Forms.NumericUpDown();
            this.lblUpdateTicketType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mnuStripUpdateTicketType.SuspendLayout();
            this.grpRateDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbRatePicker)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuStripUpdateTicketType
            // 
            this.mnuStripUpdateTicketType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStripUpdateTicketType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUpdateTicketTypeBack,
            this.mnuExit});
            this.mnuStripUpdateTicketType.Location = new System.Drawing.Point(0, 0);
            this.mnuStripUpdateTicketType.Name = "mnuStripUpdateTicketType";
            this.mnuStripUpdateTicketType.Size = new System.Drawing.Size(624, 27);
            this.mnuStripUpdateTicketType.TabIndex = 2;
            this.mnuStripUpdateTicketType.Text = "mnuAddRoutes";
            // 
            // mnuUpdateTicketTypeBack
            // 
            this.mnuUpdateTicketTypeBack.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuUpdateTicketTypeBack.Name = "mnuUpdateTicketTypeBack";
            this.mnuUpdateTicketTypeBack.Size = new System.Drawing.Size(53, 23);
            this.mnuUpdateTicketTypeBack.Text = "Back";
            this.mnuUpdateTicketTypeBack.Click += new System.EventHandler(this.mnuUpdateTicketTypeBack_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(47, 23);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(159, 131);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(165, 29);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update Rate";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblRatePerKM
            // 
            this.lblRatePerKM.AutoSize = true;
            this.lblRatePerKM.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRatePerKM.Location = new System.Drawing.Point(40, 91);
            this.lblRatePerKM.Name = "lblRatePerKM";
            this.lblRatePerKM.Size = new System.Drawing.Size(100, 19);
            this.lblRatePerKM.TabIndex = 17;
            this.lblRatePerKM.Text = "Rate Per KM:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(40, 62);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(94, 19);
            this.lblDescription.TabIndex = 18;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(159, 64);
            this.txtDescription.MaxLength = 25;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(164, 21);
            this.txtDescription.TabIndex = 15;
            // 
            // lblTypeCode
            // 
            this.lblTypeCode.AutoSize = true;
            this.lblTypeCode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeCode.Location = new System.Drawing.Point(40, 30);
            this.lblTypeCode.Name = "lblTypeCode";
            this.lblTypeCode.Size = new System.Drawing.Size(91, 19);
            this.lblTypeCode.TabIndex = 21;
            this.lblTypeCode.Text = "Type Code:";
            // 
            // txtTypeCode
            // 
            this.txtTypeCode.Enabled = false;
            this.txtTypeCode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeCode.Location = new System.Drawing.Point(159, 32);
            this.txtTypeCode.MaxLength = 2;
            this.txtTypeCode.Name = "txtTypeCode";
            this.txtTypeCode.Size = new System.Drawing.Size(164, 21);
            this.txtTypeCode.TabIndex = 20;
            // 
            // cmbRates
            // 
            this.cmbRates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRates.FormattingEnabled = true;
            this.cmbRates.Location = new System.Drawing.Point(302, 86);
            this.cmbRates.Name = "cmbRates";
            this.cmbRates.Size = new System.Drawing.Size(189, 21);
            this.cmbRates.TabIndex = 22;
            this.cmbRates.SelectedIndexChanged += new System.EventHandler(this.cmbRates_SelectedIndexChanged);
            // 
            // grpRateDetails
            // 
            this.grpRateDetails.Controls.Add(this.nmbRatePicker);
            this.grpRateDetails.Controls.Add(this.lblTypeCode);
            this.grpRateDetails.Controls.Add(this.txtDescription);
            this.grpRateDetails.Controls.Add(this.txtTypeCode);
            this.grpRateDetails.Controls.Add(this.lblDescription);
            this.grpRateDetails.Controls.Add(this.btnUpdate);
            this.grpRateDetails.Controls.Add(this.lblRatePerKM);
            this.grpRateDetails.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRateDetails.Location = new System.Drawing.Point(129, 123);
            this.grpRateDetails.Name = "grpRateDetails";
            this.grpRateDetails.Size = new System.Drawing.Size(362, 186);
            this.grpRateDetails.TabIndex = 23;
            this.grpRateDetails.TabStop = false;
            this.grpRateDetails.Text = "Update Rate";
            this.grpRateDetails.Visible = false;
            // 
            // nmbRatePicker
            // 
            this.nmbRatePicker.DecimalPlaces = 2;
            this.nmbRatePicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmbRatePicker.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.nmbRatePicker.Location = new System.Drawing.Point(159, 94);
            this.nmbRatePicker.Name = "nmbRatePicker";
            this.nmbRatePicker.Size = new System.Drawing.Size(60, 21);
            this.nmbRatePicker.TabIndex = 22;
            // 
            // lblUpdateTicketType
            // 
            this.lblUpdateTicketType.AutoSize = true;
            this.lblUpdateTicketType.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateTicketType.Location = new System.Drawing.Point(233, 48);
            this.lblUpdateTicketType.Name = "lblUpdateTicketType";
            this.lblUpdateTicketType.Size = new System.Drawing.Size(172, 23);
            this.lblUpdateTicketType.TabIndex = 24;
            this.lblUpdateTicketType.Text = "Update Ticket Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Choose Ticket Type:";
            // 
            // frmUpdateTicketType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUpdateTicketType);
            this.Controls.Add(this.grpRateDetails);
            this.Controls.Add(this.cmbRates);
            this.Controls.Add(this.mnuStripUpdateTicketType);
            this.Name = "frmUpdateTicketType";
            this.Text = "Train Ticket System - Update Ticket Type";
            this.Load += new System.EventHandler(this.frmUpdateTicketType_Load);
            this.mnuStripUpdateTicketType.ResumeLayout(false);
            this.mnuStripUpdateTicketType.PerformLayout();
            this.grpRateDetails.ResumeLayout(false);
            this.grpRateDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbRatePicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStripUpdateTicketType;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateTicketTypeBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblRatePerKM;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblTypeCode;
        private System.Windows.Forms.TextBox txtTypeCode;
        private System.Windows.Forms.ComboBox cmbRates;
        private System.Windows.Forms.GroupBox grpRateDetails;
        private System.Windows.Forms.NumericUpDown nmbRatePicker;
        private System.Windows.Forms.Label lblUpdateTicketType;
        private System.Windows.Forms.Label label1;
    }
}