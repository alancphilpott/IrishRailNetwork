namespace TrainTicketSys
{
    partial class frmScheduleTrain
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
            this.mnuStripScheduleTrain = new System.Windows.Forms.MenuStrip();
            this.mnuScheduleTrainBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuScheduleTrainExit = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmButtonScheduleTrain = new System.Windows.Forms.Button();
            this.departureScheduleTrain = new System.Windows.Forms.Label();
            this.departureBoxScheduleTrain = new System.Windows.Forms.TextBox();
            this.numberScheduleTrain = new System.Windows.Forms.Label();
            this.numberBoxScheduleTrain = new System.Windows.Forms.TextBox();
            this.carriagesScheduleTrain = new System.Windows.Forms.Label();
            this.carriagesBoxScheduleTrain = new System.Windows.Forms.TextBox();
            this.timeScheduleTrain = new System.Windows.Forms.Label();
            this.timeBoxScheduleTrain = new System.Windows.Forms.TextBox();
            this.journeyTimeScheduleTrain = new System.Windows.Forms.Label();
            this.journeyTimeBoxScheduleTrain = new System.Windows.Forms.TextBox();
            this.routeIDScheduleTrain = new System.Windows.Forms.Label();
            this.routeIDBoxScheduleTrain = new System.Windows.Forms.TextBox();
            this.mnuStripScheduleTrain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStripScheduleTrain
            // 
            this.mnuStripScheduleTrain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStripScheduleTrain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuScheduleTrainBack,
            this.mnuScheduleTrainExit});
            this.mnuStripScheduleTrain.Location = new System.Drawing.Point(0, 0);
            this.mnuStripScheduleTrain.Name = "mnuStripScheduleTrain";
            this.mnuStripScheduleTrain.Size = new System.Drawing.Size(480, 29);
            this.mnuStripScheduleTrain.TabIndex = 0;
            this.mnuStripScheduleTrain.Text = "mnuScheduleTrain";
            // 
            // mnuScheduleTrainBack
            // 
            this.mnuScheduleTrainBack.Name = "mnuScheduleTrainBack";
            this.mnuScheduleTrainBack.Size = new System.Drawing.Size(54, 25);
            this.mnuScheduleTrainBack.Text = "Back";
            this.mnuScheduleTrainBack.Click += new System.EventHandler(this.mnuScheduleTrainBack_Click);
            // 
            // mnuScheduleTrainExit
            // 
            this.mnuScheduleTrainExit.Name = "mnuScheduleTrainExit";
            this.mnuScheduleTrainExit.Size = new System.Drawing.Size(46, 25);
            this.mnuScheduleTrainExit.Text = "Exit";
            this.mnuScheduleTrainExit.Click += new System.EventHandler(this.mnuScheduleTrainExit_Click);
            // 
            // confirmButtonScheduleTrain
            // 
            this.confirmButtonScheduleTrain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButtonScheduleTrain.Location = new System.Drawing.Point(70, 289);
            this.confirmButtonScheduleTrain.Name = "confirmButtonScheduleTrain";
            this.confirmButtonScheduleTrain.Size = new System.Drawing.Size(339, 29);
            this.confirmButtonScheduleTrain.TabIndex = 12;
            this.confirmButtonScheduleTrain.Text = "Confirm Details";
            this.confirmButtonScheduleTrain.UseVisualStyleBackColor = true;
            this.confirmButtonScheduleTrain.Click += new System.EventHandler(this.confirmButtonScheduleTrain_Click);
            // 
            // departureScheduleTrain
            // 
            this.departureScheduleTrain.AutoSize = true;
            this.departureScheduleTrain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureScheduleTrain.Location = new System.Drawing.Point(66, 54);
            this.departureScheduleTrain.Name = "departureScheduleTrain";
            this.departureScheduleTrain.Size = new System.Drawing.Size(135, 21);
            this.departureScheduleTrain.TabIndex = 11;
            this.departureScheduleTrain.Text = "Departure Station:";
            // 
            // departureBoxScheduleTrain
            // 
            this.departureBoxScheduleTrain.Location = new System.Drawing.Point(245, 57);
            this.departureBoxScheduleTrain.Name = "departureBoxScheduleTrain";
            this.departureBoxScheduleTrain.Size = new System.Drawing.Size(164, 20);
            this.departureBoxScheduleTrain.TabIndex = 10;
            this.departureBoxScheduleTrain.TextChanged += new System.EventHandler(this.departureBoxScheduleTrain_TextChanged);
            // 
            // numberScheduleTrain
            // 
            this.numberScheduleTrain.AutoSize = true;
            this.numberScheduleTrain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberScheduleTrain.Location = new System.Drawing.Point(66, 125);
            this.numberScheduleTrain.Name = "numberScheduleTrain";
            this.numberScheduleTrain.Size = new System.Drawing.Size(109, 21);
            this.numberScheduleTrain.TabIndex = 14;
            this.numberScheduleTrain.Text = "Train Number:";
            // 
            // numberBoxScheduleTrain
            // 
            this.numberBoxScheduleTrain.Location = new System.Drawing.Point(245, 128);
            this.numberBoxScheduleTrain.Name = "numberBoxScheduleTrain";
            this.numberBoxScheduleTrain.Size = new System.Drawing.Size(164, 20);
            this.numberBoxScheduleTrain.TabIndex = 13;
            this.numberBoxScheduleTrain.TextChanged += new System.EventHandler(this.numberBoxScheduleTrain_TextChanged);
            // 
            // carriagesScheduleTrain
            // 
            this.carriagesScheduleTrain.AutoSize = true;
            this.carriagesScheduleTrain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carriagesScheduleTrain.Location = new System.Drawing.Point(66, 161);
            this.carriagesScheduleTrain.Name = "carriagesScheduleTrain";
            this.carriagesScheduleTrain.Size = new System.Drawing.Size(159, 21);
            this.carriagesScheduleTrain.TabIndex = 16;
            this.carriagesScheduleTrain.Text = "Number of Carriages:";
            // 
            // carriagesBoxScheduleTrain
            // 
            this.carriagesBoxScheduleTrain.Location = new System.Drawing.Point(245, 164);
            this.carriagesBoxScheduleTrain.Name = "carriagesBoxScheduleTrain";
            this.carriagesBoxScheduleTrain.Size = new System.Drawing.Size(164, 20);
            this.carriagesBoxScheduleTrain.TabIndex = 15;
            this.carriagesBoxScheduleTrain.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // timeScheduleTrain
            // 
            this.timeScheduleTrain.AutoSize = true;
            this.timeScheduleTrain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeScheduleTrain.Location = new System.Drawing.Point(66, 196);
            this.timeScheduleTrain.Name = "timeScheduleTrain";
            this.timeScheduleTrain.Size = new System.Drawing.Size(121, 21);
            this.timeScheduleTrain.TabIndex = 18;
            this.timeScheduleTrain.Text = "Departure Time:";
            // 
            // timeBoxScheduleTrain
            // 
            this.timeBoxScheduleTrain.Location = new System.Drawing.Point(245, 199);
            this.timeBoxScheduleTrain.Name = "timeBoxScheduleTrain";
            this.timeBoxScheduleTrain.Size = new System.Drawing.Size(164, 20);
            this.timeBoxScheduleTrain.TabIndex = 17;
            // 
            // journeyTimeScheduleTrain
            // 
            this.journeyTimeScheduleTrain.AutoSize = true;
            this.journeyTimeScheduleTrain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.journeyTimeScheduleTrain.Location = new System.Drawing.Point(66, 231);
            this.journeyTimeScheduleTrain.Name = "journeyTimeScheduleTrain";
            this.journeyTimeScheduleTrain.Size = new System.Drawing.Size(106, 21);
            this.journeyTimeScheduleTrain.TabIndex = 20;
            this.journeyTimeScheduleTrain.Text = "Journey Time:";
            // 
            // journeyTimeBoxScheduleTrain
            // 
            this.journeyTimeBoxScheduleTrain.Location = new System.Drawing.Point(245, 234);
            this.journeyTimeBoxScheduleTrain.Name = "journeyTimeBoxScheduleTrain";
            this.journeyTimeBoxScheduleTrain.Size = new System.Drawing.Size(164, 20);
            this.journeyTimeBoxScheduleTrain.TabIndex = 19;
            // 
            // routeIDScheduleTrain
            // 
            this.routeIDScheduleTrain.AutoSize = true;
            this.routeIDScheduleTrain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routeIDScheduleTrain.Location = new System.Drawing.Point(66, 90);
            this.routeIDScheduleTrain.Name = "routeIDScheduleTrain";
            this.routeIDScheduleTrain.Size = new System.Drawing.Size(73, 21);
            this.routeIDScheduleTrain.TabIndex = 22;
            this.routeIDScheduleTrain.Text = "Route ID:";
            // 
            // routeIDBoxScheduleTrain
            // 
            this.routeIDBoxScheduleTrain.Location = new System.Drawing.Point(245, 93);
            this.routeIDBoxScheduleTrain.Name = "routeIDBoxScheduleTrain";
            this.routeIDBoxScheduleTrain.Size = new System.Drawing.Size(164, 20);
            this.routeIDBoxScheduleTrain.TabIndex = 21;
            // 
            // frmScheduleTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 356);
            this.Controls.Add(this.routeIDScheduleTrain);
            this.Controls.Add(this.routeIDBoxScheduleTrain);
            this.Controls.Add(this.journeyTimeScheduleTrain);
            this.Controls.Add(this.journeyTimeBoxScheduleTrain);
            this.Controls.Add(this.timeScheduleTrain);
            this.Controls.Add(this.timeBoxScheduleTrain);
            this.Controls.Add(this.carriagesScheduleTrain);
            this.Controls.Add(this.carriagesBoxScheduleTrain);
            this.Controls.Add(this.numberScheduleTrain);
            this.Controls.Add(this.numberBoxScheduleTrain);
            this.Controls.Add(this.confirmButtonScheduleTrain);
            this.Controls.Add(this.departureScheduleTrain);
            this.Controls.Add(this.departureBoxScheduleTrain);
            this.Controls.Add(this.mnuStripScheduleTrain);
            this.MainMenuStrip = this.mnuStripScheduleTrain;
            this.Name = "frmScheduleTrain";
            this.Text = "Train Ticket Sys - Schedule Train";
            this.mnuStripScheduleTrain.ResumeLayout(false);
            this.mnuStripScheduleTrain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStripScheduleTrain;
        private System.Windows.Forms.ToolStripMenuItem mnuScheduleTrainBack;
        private System.Windows.Forms.ToolStripMenuItem mnuScheduleTrainExit;
        private System.Windows.Forms.Button confirmButtonScheduleTrain;
        private System.Windows.Forms.Label departureScheduleTrain;
        private System.Windows.Forms.TextBox departureBoxScheduleTrain;
        private System.Windows.Forms.Label numberScheduleTrain;
        private System.Windows.Forms.TextBox numberBoxScheduleTrain;
        private System.Windows.Forms.Label carriagesScheduleTrain;
        private System.Windows.Forms.TextBox carriagesBoxScheduleTrain;
        private System.Windows.Forms.Label timeScheduleTrain;
        private System.Windows.Forms.TextBox timeBoxScheduleTrain;
        private System.Windows.Forms.Label journeyTimeScheduleTrain;
        private System.Windows.Forms.TextBox journeyTimeBoxScheduleTrain;
        private System.Windows.Forms.Label routeIDScheduleTrain;
        private System.Windows.Forms.TextBox routeIDBoxScheduleTrain;
    }
}