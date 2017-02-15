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
            this.lblStation = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgStations = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.mnuStripCloseStation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStations)).BeginInit();
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
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStation.Location = new System.Drawing.Point(183, 45);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(107, 21);
            this.lblStation.TabIndex = 9;
            this.lblStation.Text = "Station Name:";
            this.lblStation.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(575, 352);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(165, 29);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(297, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(196, 20);
            this.txtSearch.TabIndex = 10;
            // 
            // dgStations
            // 
            this.dgStations.AllowUserToAddRows = false;
            this.dgStations.AllowUserToDeleteRows = false;
            this.dgStations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.edit});
            this.dgStations.Location = new System.Drawing.Point(12, 71);
            this.dgStations.Name = "dgStations";
            this.dgStations.ReadOnly = true;
            this.dgStations.Size = new System.Drawing.Size(728, 255);
            this.dgStations.TabIndex = 11;
            this.dgStations.Visible = false;
            this.dgStations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgStations_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(500, 41);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // edit
            // 
            this.edit.HeaderText = "Update";
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Text = "Update";
            this.edit.UseColumnTextForButtonValue = true;
            // 
            // frmCloseStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 393);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgStations);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblStation);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.mnuStripCloseStation);
            this.Name = "frmCloseStation";
            this.Text = "Train Ticket System - Close Station";
            this.Load += new System.EventHandler(this.frmCloseStation_Load);
            this.mnuStripCloseStation.ResumeLayout(false);
            this.mnuStripCloseStation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStripCloseStation;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseStationBack;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseStationExit;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgStations;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
    }
}