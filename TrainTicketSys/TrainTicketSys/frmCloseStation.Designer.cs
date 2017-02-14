namespace TrainTicketSys
{
    partial class frmCloseStation
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
            this.mnuStripCloseStation = new System.Windows.Forms.MenuStrip();
            this.mnuCloseStationBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCloseStationExit = new System.Windows.Forms.ToolStripMenuItem();
            this.nameBoxCloseStation = new System.Windows.Forms.ComboBox();
            this.nameCloseStation = new System.Windows.Forms.Label();
            this.confirmButtonCloseStation = new System.Windows.Forms.Button();
            this.mnuStripCloseStation.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStripCloseStation
            // 
            this.mnuStripCloseStation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStripCloseStation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCloseStationBack,
            this.mnuCloseStationExit});
            this.mnuStripCloseStation.Location = new System.Drawing.Point(0, 0);
            this.mnuStripCloseStation.Name = "mnuStripCloseStation";
            this.mnuStripCloseStation.Size = new System.Drawing.Size(752, 29);
            this.mnuStripCloseStation.TabIndex = 2;
            this.mnuStripCloseStation.Text = "menuStripCloseStation";
            // 
            // mnuCloseStationBack
            // 
            this.mnuCloseStationBack.Name = "mnuCloseStationBack";
            this.mnuCloseStationBack.Size = new System.Drawing.Size(54, 25);
            this.mnuCloseStationBack.Text = "Back";
            this.mnuCloseStationBack.Click += new System.EventHandler(this.mnuCloseStationBack_Click);
            // 
            // mnuCloseStationExit
            // 
            this.mnuCloseStationExit.Name = "mnuCloseStationExit";
            this.mnuCloseStationExit.Size = new System.Drawing.Size(46, 25);
            this.mnuCloseStationExit.Text = "Exit";
            this.mnuCloseStationExit.Click += new System.EventHandler(this.mnuCloseStationExit_Click);
            // 
            // nameBoxCloseStation
            // 
            this.nameBoxCloseStation.FormattingEnabled = true;
            this.nameBoxCloseStation.Items.AddRange(new object[] {
            "Stations"});
            this.nameBoxCloseStation.Location = new System.Drawing.Point(356, 157);
            this.nameBoxCloseStation.Name = "nameBoxCloseStation";
            this.nameBoxCloseStation.Size = new System.Drawing.Size(164, 21);
            this.nameBoxCloseStation.TabIndex = 10;
            this.nameBoxCloseStation.Text = "Choose Station";
            // 
            // nameCloseStation
            // 
            this.nameCloseStation.AutoSize = true;
            this.nameCloseStation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameCloseStation.Location = new System.Drawing.Point(223, 158);
            this.nameCloseStation.Name = "nameCloseStation";
            this.nameCloseStation.Size = new System.Drawing.Size(107, 21);
            this.nameCloseStation.TabIndex = 9;
            this.nameCloseStation.Text = "Station Name:";
            this.nameCloseStation.Click += new System.EventHandler(this.label1_Click);
            // 
            // confirmButtonCloseStation
            // 
            this.confirmButtonCloseStation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButtonCloseStation.Location = new System.Drawing.Point(227, 195);
            this.confirmButtonCloseStation.Name = "confirmButtonCloseStation";
            this.confirmButtonCloseStation.Size = new System.Drawing.Size(293, 29);
            this.confirmButtonCloseStation.TabIndex = 8;
            this.confirmButtonCloseStation.Text = "Confirm";
            this.confirmButtonCloseStation.UseVisualStyleBackColor = true;
            // 
            // frmCloseStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 393);
            this.Controls.Add(this.nameBoxCloseStation);
            this.Controls.Add(this.nameCloseStation);
            this.Controls.Add(this.confirmButtonCloseStation);
            this.Controls.Add(this.mnuStripCloseStation);
            this.Name = "frmCloseStation";
            this.Text = "Train Ticket System - Close Station";
            this.Load += new System.EventHandler(this.frmCloseStation_Load);
            this.mnuStripCloseStation.ResumeLayout(false);
            this.mnuStripCloseStation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStripCloseStation;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseStationBack;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseStationExit;
        private System.Windows.Forms.ComboBox nameBoxCloseStation;
        private System.Windows.Forms.Label nameCloseStation;
        private System.Windows.Forms.Button confirmButtonCloseStation;
    }
}