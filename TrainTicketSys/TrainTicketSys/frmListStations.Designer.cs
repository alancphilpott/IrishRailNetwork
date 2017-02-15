namespace TrainTicketSys
{
    partial class frmListStations
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
            this.mnuStripListStations = new System.Windows.Forms.MenuStrip();
            this.mnuListStationsBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListStationsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgStations = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.mnuStripListStations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStations)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuStripListStations
            // 
            this.mnuStripListStations.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStripListStations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuListStationsBack,
            this.mnuListStationsExit});
            this.mnuStripListStations.Location = new System.Drawing.Point(0, 0);
            this.mnuStripListStations.Name = "mnuStripListStations";
            this.mnuStripListStations.Size = new System.Drawing.Size(752, 29);
            this.mnuStripListStations.TabIndex = 3;
            this.mnuStripListStations.Text = "mnuStripListStations";
            // 
            // mnuListStationsBack
            // 
            this.mnuListStationsBack.Name = "mnuListStationsBack";
            this.mnuListStationsBack.Size = new System.Drawing.Size(54, 25);
            this.mnuListStationsBack.Text = "Back";
            this.mnuListStationsBack.Click += new System.EventHandler(this.mnuListStationsBack_Click);
            // 
            // mnuListStationsExit
            // 
            this.mnuListStationsExit.Name = "mnuListStationsExit";
            this.mnuListStationsExit.Size = new System.Drawing.Size(46, 25);
            this.mnuListStationsExit.Text = "Exit";
            this.mnuListStationsExit.Click += new System.EventHandler(this.mnuListStationsExit_Click);
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyword.Location = new System.Drawing.Point(209, 45);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(113, 21);
            this.lblKeyword.TabIndex = 9;
            this.lblKeyword.Text = "Filter Keyword:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(328, 48);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(164, 20);
            this.txtSearch.TabIndex = 8;
            // 
            // dgStations
            // 
            this.dgStations.AllowUserToAddRows = false;
            this.dgStations.AllowUserToDeleteRows = false;
            this.dgStations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStations.Location = new System.Drawing.Point(12, 81);
            this.dgStations.Name = "dgStations";
            this.dgStations.ReadOnly = true;
            this.dgStations.Size = new System.Drawing.Size(728, 255);
            this.dgStations.TabIndex = 10;
            this.dgStations.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(584, 350);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(156, 31);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(512, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmListStations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 393);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgStations);
            this.Controls.Add(this.lblKeyword);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.mnuStripListStations);
            this.Name = "frmListStations";
            this.Text = "Train Ticket System - List Stations";
            this.Load += new System.EventHandler(this.frmListStations_Load);
            this.mnuStripListStations.ResumeLayout(false);
            this.mnuStripListStations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStripListStations;
        private System.Windows.Forms.ToolStripMenuItem mnuListStationsBack;
        private System.Windows.Forms.ToolStripMenuItem mnuListStationsExit;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgStations;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSearch;
    }
}