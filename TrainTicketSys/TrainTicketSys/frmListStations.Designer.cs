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
            this.listStationsList = new System.Windows.Forms.ListBox();
            this.finishButtonListStations = new System.Windows.Forms.Button();
            this.keywordListStations = new System.Windows.Forms.Label();
            this.keywordBoxListStations = new System.Windows.Forms.TextBox();
            this.mnuStripListStations.SuspendLayout();
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
            this.mnuStripListStations.Size = new System.Drawing.Size(424, 29);
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
            // listStationsList
            // 
            this.listStationsList.FormattingEnabled = true;
            this.listStationsList.Items.AddRange(new object[] {
            "List of All Stations"});
            this.listStationsList.Location = new System.Drawing.Point(70, 76);
            this.listStationsList.Name = "listStationsList";
            this.listStationsList.Size = new System.Drawing.Size(293, 121);
            this.listStationsList.TabIndex = 4;
            // 
            // finishButtonListStations
            // 
            this.finishButtonListStations.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishButtonListStations.Location = new System.Drawing.Point(70, 214);
            this.finishButtonListStations.Name = "finishButtonListStations";
            this.finishButtonListStations.Size = new System.Drawing.Size(293, 29);
            this.finishButtonListStations.TabIndex = 6;
            this.finishButtonListStations.Text = "Finish";
            this.finishButtonListStations.UseVisualStyleBackColor = true;
            // 
            // keywordListStations
            // 
            this.keywordListStations.AutoSize = true;
            this.keywordListStations.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keywordListStations.Location = new System.Drawing.Point(66, 43);
            this.keywordListStations.Name = "keywordListStations";
            this.keywordListStations.Size = new System.Drawing.Size(113, 21);
            this.keywordListStations.TabIndex = 9;
            this.keywordListStations.Text = "Filter Keyword:";
            this.keywordListStations.Click += new System.EventHandler(this.label1_Click);
            // 
            // keywordBoxListStations
            // 
            this.keywordBoxListStations.Location = new System.Drawing.Point(199, 46);
            this.keywordBoxListStations.Name = "keywordBoxListStations";
            this.keywordBoxListStations.Size = new System.Drawing.Size(164, 20);
            this.keywordBoxListStations.TabIndex = 8;
            // 
            // frmListStations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 276);
            this.Controls.Add(this.keywordListStations);
            this.Controls.Add(this.keywordBoxListStations);
            this.Controls.Add(this.finishButtonListStations);
            this.Controls.Add(this.listStationsList);
            this.Controls.Add(this.mnuStripListStations);
            this.Name = "frmListStations";
            this.Text = "Train Ticket System - List Stations";
            this.Load += new System.EventHandler(this.frmListStations_Load);
            this.mnuStripListStations.ResumeLayout(false);
            this.mnuStripListStations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStripListStations;
        private System.Windows.Forms.ToolStripMenuItem mnuListStationsBack;
        private System.Windows.Forms.ToolStripMenuItem mnuListStationsExit;
        private System.Windows.Forms.ListBox listStationsList;
        private System.Windows.Forms.Button finishButtonListStations;
        private System.Windows.Forms.Label keywordListStations;
        private System.Windows.Forms.TextBox keywordBoxListStations;
    }
}