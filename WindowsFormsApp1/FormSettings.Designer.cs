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
            this.settings_LabelBrightness = new System.Windows.Forms.Label();
            this.settings_BrightnessSlider = new System.Windows.Forms.TrackBar();
            this.nightmode_checkbox = new System.Windows.Forms.CheckBox();
            this.panelWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settings_BrightnessSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelWrapper
            // 
            this.panelWrapper.BackColor = System.Drawing.SystemColors.Control;
            this.panelWrapper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWrapper.Controls.Add(this.settings_LabelBrightness);
            this.panelWrapper.Controls.Add(this.settings_BrightnessSlider);
            this.panelWrapper.Controls.Add(this.nightmode_checkbox);
            this.panelWrapper.Location = new System.Drawing.Point(0, 0);
            this.panelWrapper.Name = "panelWrapper";
            this.panelWrapper.Size = new System.Drawing.Size(850, 400);
            this.panelWrapper.TabIndex = 22;
            // 
            // settings_LabelBrightness
            // 
            this.settings_LabelBrightness.AutoSize = true;
            this.settings_LabelBrightness.Location = new System.Drawing.Point(50, 108);
            this.settings_LabelBrightness.Name = "settings_LabelBrightness";
            this.settings_LabelBrightness.Size = new System.Drawing.Size(58, 13);
            this.settings_LabelBrightness.TabIndex = 3;
            this.settings_LabelBrightness.Text = "Helderheid";
            // 
            // settings_BrightnessSlider
            // 
            this.settings_BrightnessSlider.Location = new System.Drawing.Point(50, 127);
            this.settings_BrightnessSlider.Name = "settings_BrightnessSlider";
            this.settings_BrightnessSlider.Size = new System.Drawing.Size(136, 45);
            this.settings_BrightnessSlider.TabIndex = 2;
            this.settings_BrightnessSlider.ValueChanged += new System.EventHandler(this.Settings_BrightnessSlider_ValueChanged);
            // 
            // nightmode_checkbox
            // 
            this.nightmode_checkbox.AutoSize = true;
            this.nightmode_checkbox.Location = new System.Drawing.Point(50, 50);
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
            ((System.ComponentModel.ISupportInitialize)(this.settings_BrightnessSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelWrapper;
        private System.Windows.Forms.CheckBox nightmode_checkbox;
        private System.Windows.Forms.Label settings_LabelBrightness;
        private System.Windows.Forms.TrackBar settings_BrightnessSlider;
    }
}