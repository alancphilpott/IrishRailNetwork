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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mnuStripRevenueAnalysis = new System.Windows.Forms.MenuStrip();
            this.mnuRevenueAnalysisBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRevenueAnalysisExit = new System.Windows.Forms.ToolStripMenuItem();
            this.finishButtonRevenueAnalysis = new System.Windows.Forms.Button();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mnuStripRevenueAnalysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
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
            this.mnuStripRevenueAnalysis.Size = new System.Drawing.Size(752, 29);
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
            // finishButtonRevenueAnalysis
            // 
            this.finishButtonRevenueAnalysis.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishButtonRevenueAnalysis.Location = new System.Drawing.Point(513, 353);
            this.finishButtonRevenueAnalysis.Name = "finishButtonRevenueAnalysis";
            this.finishButtonRevenueAnalysis.Size = new System.Drawing.Size(227, 29);
            this.finishButtonRevenueAnalysis.TabIndex = 15;
            this.finishButtonRevenueAnalysis.Text = "Finish";
            this.finishButtonRevenueAnalysis.UseVisualStyleBackColor = true;
            this.finishButtonRevenueAnalysis.Click += new System.EventHandler(this.finishButtonRevenueAnalysis_Click);
            // 
            // chartRevenue
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend1);
            this.chartRevenue.Location = new System.Drawing.Point(12, 45);
            this.chartRevenue.Name = "chartRevenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Revenue";
            this.chartRevenue.Series.Add(series1);
            this.chartRevenue.Size = new System.Drawing.Size(384, 302);
            this.chartRevenue.TabIndex = 22;
            this.chartRevenue.Text = "chart1";
            // 
            // frmRevenueAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 394);
            this.Controls.Add(this.chartRevenue);
            this.Controls.Add(this.finishButtonRevenueAnalysis);
            this.Controls.Add(this.mnuStripRevenueAnalysis);
            this.Name = "frmRevenueAnalysis";
            this.Text = "Train Ticket System - Revenue Analysis";
            this.Load += new System.EventHandler(this.frmRevenueAnalysis_Load);
            this.mnuStripRevenueAnalysis.ResumeLayout(false);
            this.mnuStripRevenueAnalysis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStripRevenueAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuRevenueAnalysisBack;
        private System.Windows.Forms.ToolStripMenuItem mnuRevenueAnalysisExit;
        private System.Windows.Forms.Button finishButtonRevenueAnalysis;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
    }
}