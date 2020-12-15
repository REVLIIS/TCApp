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
            this.labelSettings = new System.Windows.Forms.Label();
            this.panelWrapper = new System.Windows.Forms.Panel();
            this.nightmode_checkbox = new System.Windows.Forms.CheckBox();
            this.panelWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSettings
            // 
            this.labelSettings.AutoSize = true;
            this.labelSettings.Location = new System.Drawing.Point(22, 35);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(142, 13);
            this.labelSettings.TabIndex = 0;
            this.labelSettings.Text = "SETTINGS geen wireframe..";
            // 
            // panelWrapper
            // 
            this.panelWrapper.BackColor = System.Drawing.SystemColors.Control;
            this.panelWrapper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWrapper.Controls.Add(this.nightmode_checkbox);
            this.panelWrapper.Controls.Add(this.labelSettings);
            this.panelWrapper.Location = new System.Drawing.Point(0, 0);
            this.panelWrapper.Name = "panelWrapper";
            this.panelWrapper.Size = new System.Drawing.Size(850, 400);
            this.panelWrapper.TabIndex = 22;
            // 
            // nightmode_checkbox
            // 
            this.nightmode_checkbox.AutoSize = true;
            this.nightmode_checkbox.Location = new System.Drawing.Point(25, 91);
            this.nightmode_checkbox.Name = "nightmode_checkbox";
            this.nightmode_checkbox.Size = new System.Drawing.Size(78, 17);
            this.nightmode_checkbox.TabIndex = 1;
            this.nightmode_checkbox.Text = "Dark mode";
            this.nightmode_checkbox.UseVisualStyleBackColor = true;
            this.nightmode_checkbox.CheckedChanged += new System.EventHandler(this.nightmode_checkbox_CheckedChanged);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.panelWrapper);
            this.Name = "FormSettings";
            this.Text = "formStats";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.panelWrapper.ResumeLayout(false);
            this.panelWrapper.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.Panel panelWrapper;
        private System.Windows.Forms.CheckBox nightmode_checkbox;
    }
}