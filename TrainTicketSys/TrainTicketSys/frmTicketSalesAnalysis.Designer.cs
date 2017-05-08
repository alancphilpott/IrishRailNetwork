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
            this.btnPrint = new System.Windows.Forms.Button();
            this.chartTickets = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblTicketType = new System.Windows.Forms.Label();
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
            this.mnuStripTicketSalesAnalysis.Size = new System.Drawing.Size(1008, 27);
            this.mnuStripTicketSalesAnalysis.TabIndex = 2;
            this.mnuStripTicketSalesAnalysis.Text = "mnuAddRoutes";
            // 
            // mnuTicketSalesAnalysisBack
            // 
            this.mnuTicketSalesAnalysisBack.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTicketSalesAnalysisBack.Name = "mnuTicketSalesAnalysisBack";
            this.mnuTicketSalesAnalysisBack.Size = new System.Drawing.Size(53, 23);
            this.mnuTicketSalesAnalysisBack.Text = "Back";
            this.mnuTicketSalesAnalysisBack.Click += new System.EventHandler(this.mnuTicketSalesAnalysisBack_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(47, 23);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(831, 496);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(165, 29);
            this.btnPrint.TabIndex = 23;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // chartTickets
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTickets.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTickets.Legends.Add(legend1);
            this.chartTickets.Location = new System.Drawing.Point(12, 42);
            this.chartTickets.Name = "chartTickets";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Ticket Sales";
            this.chartTickets.Series.Add(series1);
            this.chartTickets.Size = new System.Drawing.Size(984, 448);
            this.chartTickets.TabIndex = 24;
            this.chartTickets.Text = "Ticket Sales Analysis";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(12, 401);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(66, 19);
            this.lblAmount.TabIndex = 25;
            this.lblAmount.Text = "Amount";
            // 
            // lblTicketType
            // 
            this.lblTicketType.AutoSize = true;
            this.lblTicketType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketType.Location = new System.Drawing.Point(98, 471);
            this.lblTicketType.Name = "lblTicketType";
            this.lblTicketType.Size = new System.Drawing.Size(91, 19);
            this.lblTicketType.TabIndex = 26;
            this.lblTicketType.Text = "Ticket Type";
            // 
            // frmTicketSalesAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.lblTicketType);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.chartTickets);
            this.Controls.Add(this.btnPrint);
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
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTickets;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblTicketType;
    }
}