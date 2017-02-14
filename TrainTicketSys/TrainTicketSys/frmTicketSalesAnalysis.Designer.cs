namespace TrainTicketSys
{
    partial class frmTicketSalesAnalysis
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
            this.mnuStripTicketSalesAnalysis = new System.Windows.Forms.MenuStrip();
            this.mnuTicketSalesAnalysisBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.timePeriodCalenderTicketSalesAnalysis = new System.Windows.Forms.MonthCalendar();
            this.specificDateCalenderTicketSalesAnalysis = new System.Windows.Forms.MonthCalendar();
            this.datePeriodTicketSalesAnalysis = new System.Windows.Forms.Label();
            this.dateSpecificTicketSalesAnalysis = new System.Windows.Forms.Label();
            this.finishButtonTicketSalesAnalysis = new System.Windows.Forms.Button();
            this.listTicketSalesList = new System.Windows.Forms.ListBox();
            this.mnuStripTicketSalesAnalysis.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStripTicketSalesAnalysis
            // 
            this.mnuStripTicketSalesAnalysis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStripTicketSalesAnalysis.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTicketSalesAnalysisBack,
            this.mnuExit});
            this.mnuStripTicketSalesAnalysis.Location = new System.Drawing.Point(0, 0);
            this.mnuStripTicketSalesAnalysis.Name = "mnuStripTicketSalesAnalysis";
            this.mnuStripTicketSalesAnalysis.Size = new System.Drawing.Size(326, 29);
            this.mnuStripTicketSalesAnalysis.TabIndex = 2;
            this.mnuStripTicketSalesAnalysis.Text = "mnuAddRoutes";
            // 
            // mnuTicketSalesAnalysisBack
            // 
            this.mnuTicketSalesAnalysisBack.Name = "mnuTicketSalesAnalysisBack";
            this.mnuTicketSalesAnalysisBack.Size = new System.Drawing.Size(54, 25);
            this.mnuTicketSalesAnalysisBack.Text = "Back";
            this.mnuTicketSalesAnalysisBack.Click += new System.EventHandler(this.mnuTicketSalesAnalysisBack_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(46, 25);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // timePeriodCalenderTicketSalesAnalysis
            // 
            this.timePeriodCalenderTicketSalesAnalysis.Location = new System.Drawing.Point(45, 290);
            this.timePeriodCalenderTicketSalesAnalysis.Name = "timePeriodCalenderTicketSalesAnalysis";
            this.timePeriodCalenderTicketSalesAnalysis.TabIndex = 27;
            // 
            // specificDateCalenderTicketSalesAnalysis
            // 
            this.specificDateCalenderTicketSalesAnalysis.Location = new System.Drawing.Point(45, 89);
            this.specificDateCalenderTicketSalesAnalysis.Name = "specificDateCalenderTicketSalesAnalysis";
            this.specificDateCalenderTicketSalesAnalysis.TabIndex = 26;
            // 
            // datePeriodTicketSalesAnalysis
            // 
            this.datePeriodTicketSalesAnalysis.AutoSize = true;
            this.datePeriodTicketSalesAnalysis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePeriodTicketSalesAnalysis.Location = new System.Drawing.Point(50, 260);
            this.datePeriodTicketSalesAnalysis.Name = "datePeriodTicketSalesAnalysis";
            this.datePeriodTicketSalesAnalysis.Size = new System.Drawing.Size(95, 21);
            this.datePeriodTicketSalesAnalysis.TabIndex = 25;
            this.datePeriodTicketSalesAnalysis.Text = "Time Period:";
            // 
            // dateSpecificTicketSalesAnalysis
            // 
            this.dateSpecificTicketSalesAnalysis.AutoSize = true;
            this.dateSpecificTicketSalesAnalysis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSpecificTicketSalesAnalysis.Location = new System.Drawing.Point(50, 59);
            this.dateSpecificTicketSalesAnalysis.Name = "dateSpecificTicketSalesAnalysis";
            this.dateSpecificTicketSalesAnalysis.Size = new System.Drawing.Size(102, 21);
            this.dateSpecificTicketSalesAnalysis.TabIndex = 24;
            this.dateSpecificTicketSalesAnalysis.Text = "Specific Date:";
            // 
            // finishButtonTicketSalesAnalysis
            // 
            this.finishButtonTicketSalesAnalysis.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishButtonTicketSalesAnalysis.Location = new System.Drawing.Point(45, 642);
            this.finishButtonTicketSalesAnalysis.Name = "finishButtonTicketSalesAnalysis";
            this.finishButtonTicketSalesAnalysis.Size = new System.Drawing.Size(227, 29);
            this.finishButtonTicketSalesAnalysis.TabIndex = 23;
            this.finishButtonTicketSalesAnalysis.Text = "Finish";
            this.finishButtonTicketSalesAnalysis.UseVisualStyleBackColor = true;
            // 
            // listTicketSalesList
            // 
            this.listTicketSalesList.FormattingEnabled = true;
            this.listTicketSalesList.Items.AddRange(new object[] {
            "Number of Adult Tickets Sold.",
            "Number of Student Tickets Sold.",
            "Number of Child Tickets Sold."});
            this.listTicketSalesList.Location = new System.Drawing.Point(45, 497);
            this.listTicketSalesList.Name = "listTicketSalesList";
            this.listTicketSalesList.Size = new System.Drawing.Size(227, 121);
            this.listTicketSalesList.TabIndex = 22;
            // 
            // frmTicketSalesAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 711);
            this.Controls.Add(this.timePeriodCalenderTicketSalesAnalysis);
            this.Controls.Add(this.specificDateCalenderTicketSalesAnalysis);
            this.Controls.Add(this.datePeriodTicketSalesAnalysis);
            this.Controls.Add(this.dateSpecificTicketSalesAnalysis);
            this.Controls.Add(this.finishButtonTicketSalesAnalysis);
            this.Controls.Add(this.listTicketSalesList);
            this.Controls.Add(this.mnuStripTicketSalesAnalysis);
            this.Name = "frmTicketSalesAnalysis";
            this.Text = "Train Ticket System - Ticket Sales Analysis";
            this.Load += new System.EventHandler(this.frmTicketSalesAnalysis_Load);
            this.mnuStripTicketSalesAnalysis.ResumeLayout(false);
            this.mnuStripTicketSalesAnalysis.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStripTicketSalesAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuTicketSalesAnalysisBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.MonthCalendar timePeriodCalenderTicketSalesAnalysis;
        private System.Windows.Forms.MonthCalendar specificDateCalenderTicketSalesAnalysis;
        private System.Windows.Forms.Label datePeriodTicketSalesAnalysis;
        private System.Windows.Forms.Label dateSpecificTicketSalesAnalysis;
        private System.Windows.Forms.Button finishButtonTicketSalesAnalysis;
        private System.Windows.Forms.ListBox listTicketSalesList;
    }
}