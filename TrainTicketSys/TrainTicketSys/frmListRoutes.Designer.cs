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
            this.keywordListRoutes = new System.Windows.Forms.Label();
            this.keywordBoxListRoutes = new System.Windows.Forms.TextBox();
            this.finishButtonListRoutes = new System.Windows.Forms.Button();
            this.listRoutesList = new System.Windows.Forms.ListBox();
            this.mnuStripListRoutes.SuspendLayout();
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
            this.mnuStripListRoutes.Size = new System.Drawing.Size(409, 29);
            this.mnuStripListRoutes.TabIndex = 0;
            this.mnuStripListRoutes.Text = "mnuListRoutes";
            // 
            // mnuListRoutesBack
            // 
            this.mnuListRoutesBack.Name = "mnuListRoutesBack";
            this.mnuListRoutesBack.Size = new System.Drawing.Size(54, 25);
            this.mnuListRoutesBack.Text = "Back";
            this.mnuListRoutesBack.Click += new System.EventHandler(this.mnuListRoutesBack_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(46, 25);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // keywordListRoutes
            // 
            this.keywordListRoutes.AutoSize = true;
            this.keywordListRoutes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keywordListRoutes.Location = new System.Drawing.Point(51, 42);
            this.keywordListRoutes.Name = "keywordListRoutes";
            this.keywordListRoutes.Size = new System.Drawing.Size(113, 21);
            this.keywordListRoutes.TabIndex = 13;
            this.keywordListRoutes.Text = "Filter Keyword:";
            // 
            // keywordBoxListRoutes
            // 
            this.keywordBoxListRoutes.Location = new System.Drawing.Point(184, 45);
            this.keywordBoxListRoutes.Name = "keywordBoxListRoutes";
            this.keywordBoxListRoutes.Size = new System.Drawing.Size(164, 20);
            this.keywordBoxListRoutes.TabIndex = 12;
            // 
            // finishButtonListRoutes
            // 
            this.finishButtonListRoutes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishButtonListRoutes.Location = new System.Drawing.Point(55, 213);
            this.finishButtonListRoutes.Name = "finishButtonListRoutes";
            this.finishButtonListRoutes.Size = new System.Drawing.Size(293, 29);
            this.finishButtonListRoutes.TabIndex = 11;
            this.finishButtonListRoutes.Text = "Finish";
            this.finishButtonListRoutes.UseVisualStyleBackColor = true;
            // 
            // listRoutesList
            // 
            this.listRoutesList.FormattingEnabled = true;
            this.listRoutesList.Items.AddRange(new object[] {
            "List of All Routes"});
            this.listRoutesList.Location = new System.Drawing.Point(55, 75);
            this.listRoutesList.Name = "listRoutesList";
            this.listRoutesList.Size = new System.Drawing.Size(293, 121);
            this.listRoutesList.TabIndex = 10;
            // 
            // frmListRoutes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 279);
            this.Controls.Add(this.keywordListRoutes);
            this.Controls.Add(this.keywordBoxListRoutes);
            this.Controls.Add(this.finishButtonListRoutes);
            this.Controls.Add(this.listRoutesList);
            this.Controls.Add(this.mnuStripListRoutes);
            this.MainMenuStrip = this.mnuStripListRoutes;
            this.Name = "frmListRoutes";
            this.Text = "Train Ticket System - List Routes";
            this.mnuStripListRoutes.ResumeLayout(false);
            this.mnuStripListRoutes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStripListRoutes;
        private System.Windows.Forms.ToolStripMenuItem mnuListRoutesBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label keywordListRoutes;
        private System.Windows.Forms.TextBox keywordBoxListRoutes;
        private System.Windows.Forms.Button finishButtonListRoutes;
        private System.Windows.Forms.ListBox listRoutesList;
    }
}