namespace WindowsFormsApp1
{
    partial class FormSettings
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
            this.panelWrapper = new System.Windows.Forms.Panel();
            this.nightmode_checkbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWrapper
            // 
            this.panelWrapper.BackColor = System.Drawing.Color.Transparent;
            this.panelWrapper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWrapper.Controls.Add(this.nightmode_checkbox);
            this.panelWrapper.Controls.Add(this.label1);
            this.panelWrapper.Location = new System.Drawing.Point(124, 135);
            this.panelWrapper.Margin = new System.Windows.Forms.Padding(4);
            this.panelWrapper.Name = "panelWrapper";
            this.panelWrapper.Size = new System.Drawing.Size(612, 198);
            this.panelWrapper.TabIndex = 22;
            // 
            // nightmode_checkbox
            // 
            this.nightmode_checkbox.AutoSize = true;
            this.nightmode_checkbox.Location = new System.Drawing.Point(246, 30);
            this.nightmode_checkbox.Name = "nightmode_checkbox";
            this.nightmode_checkbox.Size = new System.Drawing.Size(18, 17);
            this.nightmode_checkbox.TabIndex = 23;
            this.nightmode_checkbox.UseVisualStyleBackColor = true;
            this.nightmode_checkbox.CheckedChanged += new System.EventHandler(this.nightmode_checkbox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "TOGGLE NIGHTMODE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "SETTINGS FOR PANEL";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 690);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelWrapper);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSettings";
            this.Text = "formStats";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.panelWrapper.ResumeLayout(false);
            this.panelWrapper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelWrapper;
        private System.Windows.Forms.CheckBox nightmode_checkbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}