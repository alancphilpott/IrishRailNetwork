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
            this.keywordTrainTimetable = new System.Windows.Forms.Label();
            this.keywordBoxTrainTimetable = new System.Windows.Forms.TextBox();
            this.finishButtonTrainTimetable = new System.Windows.Forms.Button();
            this.listTimetableList = new System.Windows.Forms.ListBox();
            this.mnuStripTrainTimeTable.SuspendLayout();
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
            this.mnuStripTrainTimeTable.Size = new System.Drawing.Size(397, 29);
            this.mnuStripTrainTimeTable.TabIndex = 3;
            this.mnuStripTrainTimeTable.Text = "menuStrip1";
            // 
            // mnuTrainTimetableBack
            // 
            this.mnuTrainTimetableBack.Name = "mnuTrainTimetableBack";
            this.mnuTrainTimetableBack.Size = new System.Drawing.Size(54, 25);
            this.mnuTrainTimetableBack.Text = "Back";
            this.mnuTrainTimetableBack.Click += new System.EventHandler(this.mnuTrainTimetableBack_Click);
            // 
            // mnuTrainTimetableExit
            // 
            this.mnuTrainTimetableExit.Name = "mnuTrainTimetableExit";
            this.mnuTrainTimetableExit.Size = new System.Drawing.Size(46, 25);
            this.mnuTrainTimetableExit.Text = "Exit";
            this.mnuTrainTimetableExit.Click += new System.EventHandler(this.mnuTrainTimetableExit_Click);
            // 
            // keywordTrainTimetable
            // 
            this.keywordTrainTimetable.AutoSize = true;
            this.keywordTrainTimetable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keywordTrainTimetable.Location = new System.Drawing.Point(52, 67);
            this.keywordTrainTimetable.Name = "keywordTrainTimetable";
            this.keywordTrainTimetable.Size = new System.Drawing.Size(113, 21);
            this.keywordTrainTimetable.TabIndex = 17;
            this.keywordTrainTimetable.Text = "Filter Keyword:";
            // 
            // keywordBoxTrainTimetable
            // 
            this.keywordBoxTrainTimetable.Location = new System.Drawing.Point(185, 70);
            this.keywordBoxTrainTimetable.Name = "keywordBoxTrainTimetable";
            this.keywordBoxTrainTimetable.Size = new System.Drawing.Size(164, 20);
            this.keywordBoxTrainTimetable.TabIndex = 16;
            // 
            // finishButtonTrainTimetable
            // 
            this.finishButtonTrainTimetable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishButtonTrainTimetable.Location = new System.Drawing.Point(56, 238);
            this.finishButtonTrainTimetable.Name = "finishButtonTrainTimetable";
            this.finishButtonTrainTimetable.Size = new System.Drawing.Size(293, 29);
            this.finishButtonTrainTimetable.TabIndex = 15;
            this.finishButtonTrainTimetable.Text = "Finish";
            this.finishButtonTrainTimetable.UseVisualStyleBackColor = true;
            // 
            // listTimetableList
            // 
            this.listTimetableList.FormattingEnabled = true;
            this.listTimetableList.Items.AddRange(new object[] {
            "Train Timetable"});
            this.listTimetableList.Location = new System.Drawing.Point(56, 100);
            this.listTimetableList.Name = "listTimetableList";
            this.listTimetableList.Size = new System.Drawing.Size(293, 121);
            this.listTimetableList.TabIndex = 14;
            // 
            // frmTrainTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 324);
            this.Controls.Add(this.keywordTrainTimetable);
            this.Controls.Add(this.keywordBoxTrainTimetable);
            this.Controls.Add(this.finishButtonTrainTimetable);
            this.Controls.Add(this.listTimetableList);
            this.Controls.Add(this.mnuStripTrainTimeTable);
            this.Name = "frmTrainTimetable";
            this.Text = "Train Ticket System - Train Timtable";
            this.Load += new System.EventHandler(this.frmTrainTimetable_Load);
            this.mnuStripTrainTimeTable.ResumeLayout(false);
            this.mnuStripTrainTimeTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStripTrainTimeTable;
        private System.Windows.Forms.ToolStripMenuItem mnuTrainTimetableBack;
        private System.Windows.Forms.ToolStripMenuItem mnuTrainTimetableExit;
        private System.Windows.Forms.Label keywordTrainTimetable;
        private System.Windows.Forms.TextBox keywordBoxTrainTimetable;
        private System.Windows.Forms.Button finishButtonTrainTimetable;
        private System.Windows.Forms.ListBox listTimetableList;
    }
}