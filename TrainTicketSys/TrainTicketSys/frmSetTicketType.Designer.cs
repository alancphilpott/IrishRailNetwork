namespace TrainTicketSys
{
    partial class frmSetTicketType
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
            this.mnuStripSetTicketType = new System.Windows.Forms.MenuStrip();
            this.mnuSetTicketTypeBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTypeID = new System.Windows.Forms.Label();
            this.txtTypeCode = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.nmbRatePicker = new System.Windows.Forms.NumericUpDown();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mnuStripSetTicketType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbRatePicker)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuStripSetTicketType
            // 
            this.mnuStripSetTicketType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStripSetTicketType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSetTicketTypeBack,
            this.mnuExit});
            this.mnuStripSetTicketType.Location = new System.Drawing.Point(0, 0);
            this.mnuStripSetTicketType.Name = "mnuStripSetTicketType";
            this.mnuStripSetTicketType.Size = new System.Drawing.Size(624, 27);
            this.mnuStripSetTicketType.TabIndex = 1;
            this.mnuStripSetTicketType.Text = "mnuAddRoutes";
            // 
            // mnuSetTicketTypeBack
            // 
            this.mnuSetTicketTypeBack.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuSetTicketTypeBack.Name = "mnuSetTicketTypeBack";
            this.mnuSetTicketTypeBack.Size = new System.Drawing.Size(53, 23);
            this.mnuSetTicketTypeBack.Text = "Back";
            this.mnuSetTicketTypeBack.Click += new System.EventHandler(this.mnuSetTicketTypeBack_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(47, 23);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(273, 223);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(175, 29);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "Create Ticket Type";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(166, 155);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(94, 19);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Description:";
            // 
            // lblTypeID
            // 
            this.lblTypeID.AutoSize = true;
            this.lblTypeID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeID.Location = new System.Drawing.Point(166, 124);
            this.lblTypeID.Name = "lblTypeID";
            this.lblTypeID.Size = new System.Drawing.Size(91, 19);
            this.lblTypeID.TabIndex = 11;
            this.lblTypeID.Text = "Type Code:";
            // 
            // txtTypeCode
            // 
            this.txtTypeCode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeCode.Location = new System.Drawing.Point(273, 126);
            this.txtTypeCode.MaxLength = 2;
            this.txtTypeCode.Name = "txtTypeCode";
            this.txtTypeCode.Size = new System.Drawing.Size(175, 21);
            this.txtTypeCode.TabIndex = 8;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(166, 189);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(100, 19);
            this.lblRate.TabIndex = 14;
            this.lblRate.Text = "Rate Per KM:";
            // 
            // nmbRatePicker
            // 
            this.nmbRatePicker.DecimalPlaces = 2;
            this.nmbRatePicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmbRatePicker.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nmbRatePicker.Location = new System.Drawing.Point(273, 187);
            this.nmbRatePicker.Name = "nmbRatePicker";
            this.nmbRatePicker.Size = new System.Drawing.Size(60, 21);
            this.nmbRatePicker.TabIndex = 15;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(273, 155);
            this.txtDescription.MaxLength = 25;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(175, 21);
            this.txtDescription.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Set Ticket Type";
            // 
            // frmSetTicketType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.nmbRatePicker);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTypeID);
            this.Controls.Add(this.txtTypeCode);
            this.Controls.Add(this.mnuStripSetTicketType);
            this.Name = "frmSetTicketType";
            this.Text = "Train Ticket System - Set Ticket Type";
            this.Load += new System.EventHandler(this.frmSetTicketType_Load);
            this.mnuStripSetTicketType.ResumeLayout(false);
            this.mnuStripSetTicketType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbRatePicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStripSetTicketType;
        private System.Windows.Forms.ToolStripMenuItem mnuSetTicketTypeBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTypeID;
        private System.Windows.Forms.TextBox txtTypeCode;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.NumericUpDown nmbRatePicker;
		private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
    }
}