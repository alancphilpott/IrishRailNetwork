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
            this.txtTypeID = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
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
            this.mnuStripSetTicketType.Size = new System.Drawing.Size(752, 29);
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
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(210, 274);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(293, 29);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "Create Ticket Type";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(206, 162);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(92, 21);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Description:";
            // 
            // lblTypeID
            // 
            this.lblTypeID.AutoSize = true;
            this.lblTypeID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeID.Location = new System.Drawing.Point(206, 131);
            this.lblTypeID.Name = "lblTypeID";
            this.lblTypeID.Size = new System.Drawing.Size(64, 21);
            this.lblTypeID.TabIndex = 11;
            this.lblTypeID.Text = "Type ID:";
            // 
            // txtTypeID
            // 
            this.txtTypeID.Enabled = false;
            this.txtTypeID.Location = new System.Drawing.Point(304, 131);
            this.txtTypeID.Name = "txtTypeID";
            this.txtTypeID.Size = new System.Drawing.Size(199, 20);
            this.txtTypeID.TabIndex = 8;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(304, 165);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(199, 80);
            this.txtDescription.TabIndex = 13;
            this.txtDescription.Text = "";
            // 
            // frmSetTicketType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 393);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTypeID);
            this.Controls.Add(this.txtTypeID);
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
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTypeID;
        private System.Windows.Forms.TextBox txtTypeID;
        private System.Windows.Forms.RichTextBox txtDescription;
    }
}