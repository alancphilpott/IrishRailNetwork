namespace TrainTicketSys
{
    partial class frmRevenueAnalysis
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
            this.mnuStripRevenueAnalysis = new System.Windows.Forms.MenuStrip();
            this.mnuRevenueAnalysisBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRevenueAnalysisExit = new System.Windows.Forms.ToolStripMenuItem();
            this.dateSpecificRevenueAnalysis = new System.Windows.Forms.Label();
            this.finishButtonRevenueAnalysis = new System.Windows.Forms.Button();
            this.listGrossList = new System.Windows.Forms.ListBox();
            this.datePeriodRevenueAnalysis = new System.Windows.Forms.Label();
            this.specificDateCalenderRevenueAnalysis = new System.Windows.Forms.MonthCalendar();
            this.timePeriodCalenderRevenueAnalysis = new System.Windows.Forms.MonthCalendar();
            this.mnuStripRevenueAnalysis.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStripRevenueAnalysis
            // 
            this.mnuStripRevenueAnalysis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStripRevenueAnalysis.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRevenueAnalysisBack,
            this.mnuRevenueAnalysisExit});
            this.mnuStripRevenueAnalysis.Location = new System.Drawing.Point(0, 0);
            this.mnuStripRevenueAnalysis.Name = "mnuStripRevenueAnalysis";
            this.mnuStripRevenueAnalysis.Size = new System.Drawing.Size(346, 29);
            this.mnuStripRevenueAnalysis.TabIndex = 3;
            this.mnuStripRevenueAnalysis.Text = "menuStrip1";
            // 
            // mnuRevenueAnalysisBack
            // 
            this.mnuRevenueAnalysisBack.Name = "mnuRevenueAnalysisBack";
            this.mnuRevenueAnalysisBack.Size = new System.Drawing.Size(54, 25);
            this.mnuRevenueAnalysisBack.Text = "Back";
            this.mnuRevenueAnalysisBack.Click += new System.EventHandler(this.mnuRevenueAnalysisBack_Click);
            // 
            // mnuRevenueAnalysisExit
            // 
            this.mnuRevenueAnalysisExit.Name = "mnuRevenueAnalysisExit";
            this.mnuRevenueAnalysisExit.Size = new System.Drawing.Size(46, 25);
            this.mnuRevenueAnalysisExit.Text = "Exit";
            this.mnuRevenueAnalysisExit.Click += new System.EventHandler(this.mnuRevenueAnalysisExit_Click);
            // 
            // dateSpecificRevenueAnalysis
            // 
            this.dateSpecificRevenueAnalysis.AutoSize = true;
            this.dateSpecificRevenueAnalysis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSpecificRevenueAnalysis.Location = new System.Drawing.Point(58, 52);
            this.dateSpecificRevenueAnalysis.Name = "dateSpecificRevenueAnalysis";
            this.dateSpecificRevenueAnalysis.Size = new System.Drawing.Size(102, 21);
            this.dateSpecificRevenueAnalysis.TabIndex = 17;
            this.dateSpecificRevenueAnalysis.Text = "Specific Date:";
            this.dateSpecificRevenueAnalysis.Click += new System.EventHandler(this.dateSpecificRevenueAnalysis_Click);
            // 
            // finishButtonRevenueAnalysis
            // 
            this.finishButtonRevenueAnalysis.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishButtonRevenueAnalysis.Location = new System.Drawing.Point(53, 635);
            this.finishButtonRevenueAnalysis.Name = "finishButtonRevenueAnalysis";
            this.finishButtonRevenueAnalysis.Size = new System.Drawing.Size(227, 29);
            this.finishButtonRevenueAnalysis.TabIndex = 15;
            this.finishButtonRevenueAnalysis.Text = "Finish";
            this.finishButtonRevenueAnalysis.UseVisualStyleBackColor = true;
            this.finishButtonRevenueAnalysis.Click += new System.EventHandler(this.finishButtonRevenueAnalysis_Click);
            // 
            // listGrossList
            // 
            this.listGrossList.FormattingEnabled = true;
            this.listGrossList.Items.AddRange(new object[] {
            "Gross Amount Show Here"});
            this.listGrossList.Location = new System.Drawing.Point(53, 490);
            this.listGrossList.Name = "listGrossList";
            this.listGrossList.Size = new System.Drawing.Size(227, 121);
            this.listGrossList.TabIndex = 14;
            this.listGrossList.SelectedIndexChanged += new System.EventHandler(this.listGrossList_SelectedIndexChanged);
            // 
            // datePeriodRevenueAnalysis
            // 
            this.datePeriodRevenueAnalysis.AutoSize = true;
            this.datePeriodRevenueAnalysis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePeriodRevenueAnalysis.Location = new System.Drawing.Point(58, 253);
            this.datePeriodRevenueAnalysis.Name = "datePeriodRevenueAnalysis";
            this.datePeriodRevenueAnalysis.Size = new System.Drawing.Size(95, 21);
            this.datePeriodRevenueAnalysis.TabIndex = 19;
            this.datePeriodRevenueAnalysis.Text = "Time Period:";
            this.datePeriodRevenueAnalysis.Click += new System.EventHandler(this.datePeriodRevenueAnalysis_Click);
            // 
            // specificDateCalenderRevenueAnalysis
            // 
            this.specificDateCalenderRevenueAnalysis.Location = new System.Drawing.Point(53, 82);
            this.specificDateCalenderRevenueAnalysis.Name = "specificDateCalenderRevenueAnalysis";
            this.specificDateCalenderRevenueAnalysis.TabIndex = 20;
            this.specificDateCalenderRevenueAnalysis.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.specificDateCalender_DateChanged);
            // 
            // timePeriodCalenderRevenueAnalysis
            // 
            this.timePeriodCalenderRevenueAnalysis.Location = new System.Drawing.Point(53, 283);
            this.timePeriodCalenderRevenueAnalysis.Name = "timePeriodCalenderRevenueAnalysis";
            this.timePeriodCalenderRevenueAnalysis.TabIndex = 21;
            this.timePeriodCalenderRevenueAnalysis.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.timePeriodCalender_DateChanged);
            // 
            // frmRevenueAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 696);
            this.Controls.Add(this.timePeriodCalenderRevenueAnalysis);
            this.Controls.Add(this.specificDateCalenderRevenueAnalysis);
            this.Controls.Add(this.datePeriodRevenueAnalysis);
            this.Controls.Add(this.dateSpecificRevenueAnalysis);
            this.Controls.Add(this.finishButtonRevenueAnalysis);
            this.Controls.Add(this.listGrossList);
            this.Controls.Add(this.mnuStripRevenueAnalysis);
            this.Name = "frmRevenueAnalysis";
            this.Text = "Train Ticket System - Revenue Analysis";
            this.Load += new System.EventHandler(this.frmRevenueAnalysis_Load);
            this.mnuStripRevenueAnalysis.ResumeLayout(false);
            this.mnuStripRevenueAnalysis.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStripRevenueAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuRevenueAnalysisBack;
        private System.Windows.Forms.ToolStripMenuItem mnuRevenueAnalysisExit;
        private System.Windows.Forms.Label dateSpecificRevenueAnalysis;
        private System.Windows.Forms.Button finishButtonRevenueAnalysis;
        private System.Windows.Forms.ListBox listGrossList;
        private System.Windows.Forms.Label datePeriodRevenueAnalysis;
        private System.Windows.Forms.MonthCalendar specificDateCalenderRevenueAnalysis;
        private System.Windows.Forms.MonthCalendar timePeriodCalenderRevenueAnalysis;
    }
}