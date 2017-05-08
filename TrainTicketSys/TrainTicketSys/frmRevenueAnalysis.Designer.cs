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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mnuStripRevenueAnalysis = new System.Windows.Forms.MenuStrip();
            this.mnuRevenueAnalysisBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRevenueAnalysisExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrint = new System.Windows.Forms.Button();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.mnuStripRevenueAnalysis.Size = new System.Drawing.Size(1008, 27);
            this.mnuStripRevenueAnalysis.TabIndex = 3;
            this.mnuStripRevenueAnalysis.Text = "menuStrip1";
            // 
            // mnuRevenueAnalysisBack
            // 
            this.mnuRevenueAnalysisBack.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuRevenueAnalysisBack.Name = "mnuRevenueAnalysisBack";
            this.mnuRevenueAnalysisBack.Size = new System.Drawing.Size(53, 23);
            this.mnuRevenueAnalysisBack.Text = "Back";
            this.mnuRevenueAnalysisBack.Click += new System.EventHandler(this.mnuRevenueAnalysisBack_Click);
            // 
            // mnuRevenueAnalysisExit
            // 
            this.mnuRevenueAnalysisExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuRevenueAnalysisExit.Name = "mnuRevenueAnalysisExit";
            this.mnuRevenueAnalysisExit.Size = new System.Drawing.Size(47, 23);
            this.mnuRevenueAnalysisExit.Text = "Exit";
            this.mnuRevenueAnalysisExit.Click += new System.EventHandler(this.mnuRevenueAnalysisExit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(836, 496);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(160, 29);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.finishButtonRevenueAnalysis_Click);
            // 
            // chartRevenue
            // 
            chartArea6.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend6);
            this.chartRevenue.Location = new System.Drawing.Point(12, 43);
            this.chartRevenue.Name = "chartRevenue";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Revenue";
            this.chartRevenue.Series.Add(series6);
            this.chartRevenue.Size = new System.Drawing.Size(984, 447);
            this.chartRevenue.TabIndex = 22;
            this.chartRevenue.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Month";
            // 
            // frmRevenueAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartRevenue);
            this.Controls.Add(this.btnPrint);
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
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}