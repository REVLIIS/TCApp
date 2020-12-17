namespace WindowsFormsApp1
{
    partial class FormStatistics
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelWrapper = new System.Windows.Forms.Panel();
            this.statsNoResultLabel = new System.Windows.Forms.Label();
            this.statisticsGrid = new System.Windows.Forms.DataGridView();
            this.statisticsDateLabel = new System.Windows.Forms.Label();
            this.statisticsCalendar = new System.Windows.Forms.MonthCalendar();
            this.panelWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panelWrapper
            // 
            this.panelWrapper.BackColor = System.Drawing.SystemColors.Control;
            this.panelWrapper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWrapper.Controls.Add(this.statsNoResultLabel);
            this.panelWrapper.Controls.Add(this.statisticsGrid);
            this.panelWrapper.Controls.Add(this.statisticsDateLabel);
            this.panelWrapper.Controls.Add(this.statisticsCalendar);
            this.panelWrapper.Location = new System.Drawing.Point(0, 0);
            this.panelWrapper.Name = "panelWrapper";
            this.panelWrapper.Size = new System.Drawing.Size(850, 400);
            this.panelWrapper.TabIndex = 21;
            // 
            // statsNoResultLabel
            // 
            this.statsNoResultLabel.AutoSize = true;
            this.statsNoResultLabel.Location = new System.Drawing.Point(90, 103);
            this.statsNoResultLabel.Name = "statsNoResultLabel";
            this.statsNoResultLabel.Size = new System.Drawing.Size(133, 13);
            this.statsNoResultLabel.TabIndex = 5;
            this.statsNoResultLabel.Text = "Geen resultaten gevonden";
            this.statsNoResultLabel.Visible = false;
            // 
            // statisticsGrid
            // 
            this.statisticsGrid.AllowUserToAddRows = false;
            this.statisticsGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.statisticsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.statisticsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.statisticsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statisticsGrid.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.statisticsGrid.Location = new System.Drawing.Point(56, 91);
            this.statisticsGrid.Name = "statisticsGrid";
            this.statisticsGrid.ReadOnly = true;
            this.statisticsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.statisticsGrid.Size = new System.Drawing.Size(326, 162);
            this.statisticsGrid.TabIndex = 4;
            this.statisticsGrid.SelectionChanged += new System.EventHandler(this.StatisticsGrid_SelectionChanged);
            // 
            // statisticsDateLabel
            // 
            this.statisticsDateLabel.AutoSize = true;
            this.statisticsDateLabel.Font = new System.Drawing.Font("Kozuka Mincho Pro H", 18F, System.Drawing.FontStyle.Bold);
            this.statisticsDateLabel.Location = new System.Drawing.Point(50, 50);
            this.statisticsDateLabel.Name = "statisticsDateLabel";
            this.statisticsDateLabel.Size = new System.Drawing.Size(65, 33);
            this.statisticsDateLabel.TabIndex = 3;
            this.statisticsDateLabel.Text = "date";
            // 
            // statisticsCalendar
            // 
            this.statisticsCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.statisticsCalendar.ForeColor = System.Drawing.Color.Red;
            this.statisticsCalendar.Location = new System.Drawing.Point(474, 91);
            this.statisticsCalendar.MaxSelectionCount = 1;
            this.statisticsCalendar.Name = "statisticsCalendar";
            this.statisticsCalendar.TabIndex = 1;
            this.statisticsCalendar.TitleBackColor = System.Drawing.Color.Red;
            this.statisticsCalendar.TitleForeColor = System.Drawing.Color.Red;
            this.statisticsCalendar.TrailingForeColor = System.Drawing.Color.Red;
            this.statisticsCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.StatisticsCalendar_DateChanged);
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.panelWrapper);
            this.Name = "FormStatistics";
            this.Text = "formStatistics";
            this.panelWrapper.ResumeLayout(false);
            this.panelWrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelWrapper;
        private System.Windows.Forms.MonthCalendar statisticsCalendar;
        private System.Windows.Forms.Label statisticsDateLabel;
        private System.Windows.Forms.DataGridView statisticsGrid;
        private System.Windows.Forms.Label statsNoResultLabel;
    }
}