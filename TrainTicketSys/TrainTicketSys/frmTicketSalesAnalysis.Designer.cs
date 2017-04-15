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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mnuStripTicketSalesAnalysis = new System.Windows.Forms.MenuStrip();
            this.mnuTicketSalesAnalysisBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.finishButtonTicketSalesAnalysis = new System.Windows.Forms.Button();
            this.chartTickets = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mnuStripTicketSalesAnalysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTickets)).BeginInit();
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
            this.mnuStripTicketSalesAnalysis.Size = new System.Drawing.Size(752, 29);
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
            // finishButtonTicketSalesAnalysis
            // 
            this.finishButtonTicketSalesAnalysis.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishButtonTicketSalesAnalysis.Location = new System.Drawing.Point(513, 352);
            this.finishButtonTicketSalesAnalysis.Name = "finishButtonTicketSalesAnalysis";
            this.finishButtonTicketSalesAnalysis.Size = new System.Drawing.Size(227, 29);
            this.finishButtonTicketSalesAnalysis.TabIndex = 23;
            this.finishButtonTicketSalesAnalysis.Text = "Finish";
            this.finishButtonTicketSalesAnalysis.UseVisualStyleBackColor = true;
            // 
            // chartTickets
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTickets.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTickets.Legends.Add(legend1);
            this.chartTickets.Location = new System.Drawing.Point(12, 32);
            this.chartTickets.Name = "chartTickets";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Ticket Sales";
            this.chartTickets.Series.Add(series1);
            this.chartTickets.Size = new System.Drawing.Size(728, 313);
            this.chartTickets.TabIndex = 24;
            this.chartTickets.Text = "Ticket Sales Analysis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Type";
            // 
            // frmTicketSalesAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 393);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartTickets);
            this.Controls.Add(this.finishButtonTicketSalesAnalysis);
            this.Controls.Add(this.mnuStripTicketSalesAnalysis);
            this.Name = "frmTicketSalesAnalysis";
            this.Text = "Train Ticket System - Ticket Sales Analysis";
            this.Load += new System.EventHandler(this.frmTicketSalesAnalysis_Load);
            this.mnuStripTicketSalesAnalysis.ResumeLayout(false);
            this.mnuStripTicketSalesAnalysis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStripTicketSalesAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuTicketSalesAnalysisBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Button finishButtonTicketSalesAnalysis;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTickets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}