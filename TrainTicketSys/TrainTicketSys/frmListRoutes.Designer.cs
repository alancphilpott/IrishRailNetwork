namespace TrainTicketSys
{
    partial class frmListRoutes
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
            this.mnuStripListRoutes = new System.Windows.Forms.MenuStrip();
            this.mnuListRoutesBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgRoutes = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.mnuStripListRoutes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRoutes)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuStripListRoutes
            // 
            this.mnuStripListRoutes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStripListRoutes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuListRoutesBack,
            this.mnuExit});
            this.mnuStripListRoutes.Location = new System.Drawing.Point(0, 0);
            this.mnuStripListRoutes.Name = "mnuStripListRoutes";
            this.mnuStripListRoutes.Size = new System.Drawing.Size(624, 27);
            this.mnuStripListRoutes.TabIndex = 0;
            this.mnuStripListRoutes.Text = "mnuListRoutes";
            // 
            // mnuListRoutesBack
            // 
            this.mnuListRoutesBack.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuListRoutesBack.Name = "mnuListRoutesBack";
            this.mnuListRoutesBack.Size = new System.Drawing.Size(53, 23);
            this.mnuListRoutesBack.Text = "Back";
            this.mnuListRoutesBack.Click += new System.EventHandler(this.mnuListRoutesBack_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(47, 23);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyword.Location = new System.Drawing.Point(12, 45);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(179, 19);
            this.lblKeyword.TabIndex = 13;
            this.lblKeyword.Text = "Departure Station Name";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(197, 45);
            this.txtSearch.MaxLength = 20;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(164, 21);
            this.txtSearch.TabIndex = 12;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(456, 40);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(156, 31);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            // 
            // dgRoutes
            // 
            this.dgRoutes.AllowUserToAddRows = false;
            this.dgRoutes.AllowUserToDeleteRows = false;
            this.dgRoutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRoutes.Location = new System.Drawing.Point(12, 80);
            this.dgRoutes.Name = "dgRoutes";
            this.dgRoutes.ReadOnly = true;
            this.dgRoutes.Size = new System.Drawing.Size(600, 229);
            this.dgRoutes.TabIndex = 14;
            this.dgRoutes.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(367, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmListRoutes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblKeyword);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.mnuStripListRoutes);
            this.Controls.Add(this.dgRoutes);
            this.MainMenuStrip = this.mnuStripListRoutes;
            this.Name = "frmListRoutes";
            this.Text = "Train Ticket System - List Routes";
            this.mnuStripListRoutes.ResumeLayout(false);
            this.mnuStripListRoutes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRoutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStripListRoutes;
        private System.Windows.Forms.ToolStripMenuItem mnuListRoutesBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dgRoutes;
        private System.Windows.Forms.Button btnSearch;
    }
}