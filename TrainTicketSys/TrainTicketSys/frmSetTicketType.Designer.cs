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
            this.confirmButtonSetTicketType = new System.Windows.Forms.Button();
            this.rateSetTicketType = new System.Windows.Forms.Label();
            this.descriptionSetTicketType = new System.Windows.Forms.Label();
            this.IDSetTicketType = new System.Windows.Forms.Label();
            this.rateBoxSetTicketType = new System.Windows.Forms.TextBox();
            this.descriptionBoxSetTicketType = new System.Windows.Forms.TextBox();
            this.IDBoxSetTicketType = new System.Windows.Forms.TextBox();
            this.mnuStripSetTicketType.SuspendLayout();
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
            this.mnuStripSetTicketType.Size = new System.Drawing.Size(396, 29);
            this.mnuStripSetTicketType.TabIndex = 1;
            this.mnuStripSetTicketType.Text = "mnuAddRoutes";
            // 
            // mnuSetTicketTypeBack
            // 
            this.mnuSetTicketTypeBack.Name = "mnuSetTicketTypeBack";
            this.mnuSetTicketTypeBack.Size = new System.Drawing.Size(54, 25);
            this.mnuSetTicketTypeBack.Text = "Back";
            this.mnuSetTicketTypeBack.Click += new System.EventHandler(this.mnuSetTicketTypeBack_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(46, 25);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // confirmButtonSetTicketType
            // 
            this.confirmButtonSetTicketType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButtonSetTicketType.Location = new System.Drawing.Point(55, 171);
            this.confirmButtonSetTicketType.Name = "confirmButtonSetTicketType";
            this.confirmButtonSetTicketType.Size = new System.Drawing.Size(293, 29);
            this.confirmButtonSetTicketType.TabIndex = 12;
            this.confirmButtonSetTicketType.Text = "Confirm Details";
            this.confirmButtonSetTicketType.UseVisualStyleBackColor = true;
            // 
            // rateSetTicketType
            // 
            this.rateSetTicketType.AutoSize = true;
            this.rateSetTicketType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateSetTicketType.Location = new System.Drawing.Point(51, 117);
            this.rateSetTicketType.Name = "rateSetTicketType";
            this.rateSetTicketType.Size = new System.Drawing.Size(98, 21);
            this.rateSetTicketType.TabIndex = 9;
            this.rateSetTicketType.Text = "Rate per KM:";
            // 
            // descriptionSetTicketType
            // 
            this.descriptionSetTicketType.AutoSize = true;
            this.descriptionSetTicketType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionSetTicketType.Location = new System.Drawing.Point(51, 85);
            this.descriptionSetTicketType.Name = "descriptionSetTicketType";
            this.descriptionSetTicketType.Size = new System.Drawing.Size(92, 21);
            this.descriptionSetTicketType.TabIndex = 10;
            this.descriptionSetTicketType.Text = "Description:";
            // 
            // IDSetTicketType
            // 
            this.IDSetTicketType.AutoSize = true;
            this.IDSetTicketType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDSetTicketType.Location = new System.Drawing.Point(51, 54);
            this.IDSetTicketType.Name = "IDSetTicketType";
            this.IDSetTicketType.Size = new System.Drawing.Size(72, 21);
            this.IDSetTicketType.TabIndex = 11;
            this.IDSetTicketType.Text = "Ticket ID:";
            // 
            // rateBoxSetTicketType
            // 
            this.rateBoxSetTicketType.Location = new System.Drawing.Point(184, 118);
            this.rateBoxSetTicketType.Name = "rateBoxSetTicketType";
            this.rateBoxSetTicketType.Size = new System.Drawing.Size(164, 20);
            this.rateBoxSetTicketType.TabIndex = 6;
            // 
            // descriptionBoxSetTicketType
            // 
            this.descriptionBoxSetTicketType.Location = new System.Drawing.Point(184, 85);
            this.descriptionBoxSetTicketType.Name = "descriptionBoxSetTicketType";
            this.descriptionBoxSetTicketType.Size = new System.Drawing.Size(164, 20);
            this.descriptionBoxSetTicketType.TabIndex = 7;
            // 
            // IDBoxSetTicketType
            // 
            this.IDBoxSetTicketType.Location = new System.Drawing.Point(184, 54);
            this.IDBoxSetTicketType.Name = "IDBoxSetTicketType";
            this.IDBoxSetTicketType.Size = new System.Drawing.Size(164, 20);
            this.IDBoxSetTicketType.TabIndex = 8;
            // 
            // frmSetTicketType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 237);
            this.Controls.Add(this.confirmButtonSetTicketType);
            this.Controls.Add(this.rateSetTicketType);
            this.Controls.Add(this.descriptionSetTicketType);
            this.Controls.Add(this.IDSetTicketType);
            this.Controls.Add(this.rateBoxSetTicketType);
            this.Controls.Add(this.descriptionBoxSetTicketType);
            this.Controls.Add(this.IDBoxSetTicketType);
            this.Controls.Add(this.mnuStripSetTicketType);
            this.Name = "frmSetTicketType";
            this.Text = "Train Ticket System - Set Ticket Type";
            this.Load += new System.EventHandler(this.frmSetTicketType_Load);
            this.mnuStripSetTicketType.ResumeLayout(false);
            this.mnuStripSetTicketType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStripSetTicketType;
        private System.Windows.Forms.ToolStripMenuItem mnuSetTicketTypeBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Button confirmButtonSetTicketType;
        private System.Windows.Forms.Label rateSetTicketType;
        private System.Windows.Forms.Label descriptionSetTicketType;
        private System.Windows.Forms.Label IDSetTicketType;
        private System.Windows.Forms.TextBox rateBoxSetTicketType;
        private System.Windows.Forms.TextBox descriptionBoxSetTicketType;
        private System.Windows.Forms.TextBox IDBoxSetTicketType;
    }
}