namespace TrainTicketSys
{
    partial class frmTrainTimetable
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
            this.mnuStripTrainTimeTable = new System.Windows.Forms.MenuStrip();
            this.mnuTrainTimetableBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTrainTimetableExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRouteID = new System.Windows.Forms.Label();
            this.cmbRoutes = new System.Windows.Forms.ComboBox();
            this.dgTimetable = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.mnuStripTrainTimeTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTimetable)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuStripTrainTimeTable
            // 
            this.mnuStripTrainTimeTable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStripTrainTimeTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTrainTimetableBack,
            this.mnuTrainTimetableExit});
            this.mnuStripTrainTimeTable.Location = new System.Drawing.Point(0, 0);
            this.mnuStripTrainTimeTable.Name = "mnuStripTrainTimeTable";
            this.mnuStripTrainTimeTable.Size = new System.Drawing.Size(624, 27);
            this.mnuStripTrainTimeTable.TabIndex = 3;
            this.mnuStripTrainTimeTable.Text = "menuStrip1";
            // 
            // mnuTrainTimetableBack
            // 
            this.mnuTrainTimetableBack.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTrainTimetableBack.Name = "mnuTrainTimetableBack";
            this.mnuTrainTimetableBack.Size = new System.Drawing.Size(53, 23);
            this.mnuTrainTimetableBack.Text = "Back";
            this.mnuTrainTimetableBack.Click += new System.EventHandler(this.mnuTrainTimetableBack_Click);
            // 
            // mnuTrainTimetableExit
            // 
            this.mnuTrainTimetableExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTrainTimetableExit.Name = "mnuTrainTimetableExit";
            this.mnuTrainTimetableExit.Size = new System.Drawing.Size(47, 23);
            this.mnuTrainTimetableExit.Text = "Exit";
            this.mnuTrainTimetableExit.Click += new System.EventHandler(this.mnuTrainTimetableExit_Click);
            // 
            // lblRouteID
            // 
            this.lblRouteID.AutoSize = true;
            this.lblRouteID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRouteID.Location = new System.Drawing.Point(12, 44);
            this.lblRouteID.Name = "lblRouteID";
            this.lblRouteID.Size = new System.Drawing.Size(113, 19);
            this.lblRouteID.TabIndex = 17;
            this.lblRouteID.Text = "Choose Route:";
            // 
            // cmbRoutes
            // 
            this.cmbRoutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoutes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbRoutes.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoutes.FormattingEnabled = true;
            this.cmbRoutes.Location = new System.Drawing.Point(131, 44);
            this.cmbRoutes.Name = "cmbRoutes";
            this.cmbRoutes.Size = new System.Drawing.Size(294, 21);
            this.cmbRoutes.TabIndex = 18;
            this.cmbRoutes.SelectedIndexChanged += new System.EventHandler(this.cmbRoutes_SelectedIndexChanged);
            // 
            // dgTimetable
            // 
            this.dgTimetable.AllowUserToAddRows = false;
            this.dgTimetable.AllowUserToDeleteRows = false;
            this.dgTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTimetable.Location = new System.Drawing.Point(16, 86);
            this.dgTimetable.Name = "dgTimetable";
            this.dgTimetable.ReadOnly = true;
            this.dgTimetable.Size = new System.Drawing.Size(596, 223);
            this.dgTimetable.TabIndex = 19;
            this.dgTimetable.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(456, 40);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(156, 31);
            this.btnPrint.TabIndex = 20;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // frmTrainTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgTimetable);
            this.Controls.Add(this.cmbRoutes);
            this.Controls.Add(this.lblRouteID);
            this.Controls.Add(this.mnuStripTrainTimeTable);
            this.Name = "frmTrainTimetable";
            this.Text = "Train Ticket System - Train Timetable";
            this.Load += new System.EventHandler(this.frmTrainTimetable_Load);
            this.mnuStripTrainTimeTable.ResumeLayout(false);
            this.mnuStripTrainTimeTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTimetable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStripTrainTimeTable;
        private System.Windows.Forms.ToolStripMenuItem mnuTrainTimetableBack;
        private System.Windows.Forms.ToolStripMenuItem mnuTrainTimetableExit;
        private System.Windows.Forms.Label lblRouteID;
        private System.Windows.Forms.ComboBox cmbRoutes;
        private System.Windows.Forms.DataGridView dgTimetable;
        private System.Windows.Forms.Button btnPrint;
    }
}