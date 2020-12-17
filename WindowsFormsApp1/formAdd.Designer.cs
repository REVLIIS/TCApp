namespace WindowsFormsApp1
{
    partial class FormAdd
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
            this.addPreset_submit = new System.Windows.Forms.Button();
            this.addPreset_nameInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addPreset_countDown = new System.Windows.Forms.NumericUpDown();
            this.addPreset_MenuDropdown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelWrapper = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.addPreset_countDown)).BeginInit();
            this.panelWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPreset_submit
            // 
            this.addPreset_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPreset_submit.Location = new System.Drawing.Point(124, 128);
            this.addPreset_submit.Name = "addPreset_submit";
            this.addPreset_submit.Size = new System.Drawing.Size(122, 23);
            this.addPreset_submit.TabIndex = 2;
            this.addPreset_submit.Text = "Add menu_item";
            this.addPreset_submit.UseVisualStyleBackColor = true;
            this.addPreset_submit.Click += new System.EventHandler(this.addPreset_Submit_Click);
            // 
            // addPreset_nameInput
            // 
            this.addPreset_nameInput.Location = new System.Drawing.Point(122, 47);
            this.addPreset_nameInput.Name = "addPreset_nameInput";
            this.addPreset_nameInput.Size = new System.Drawing.Size(120, 20);
            this.addPreset_nameInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Menu";
            // 
            // addPreset_countDown
            // 
            this.addPreset_countDown.Location = new System.Drawing.Point(124, 74);
            this.addPreset_countDown.Name = "addPreset_countDown";
            this.addPreset_countDown.Size = new System.Drawing.Size(120, 20);
            this.addPreset_countDown.TabIndex = 5;
            // 
            // addPreset_MenuDropdown
            // 
            this.addPreset_MenuDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addPreset_MenuDropdown.FormattingEnabled = true;
            this.addPreset_MenuDropdown.Location = new System.Drawing.Point(125, 101);
            this.addPreset_MenuDropdown.Name = "addPreset_MenuDropdown";
            this.addPreset_MenuDropdown.Size = new System.Drawing.Size(121, 21);
            this.addPreset_MenuDropdown.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Preset naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Count down";
            // 
            // panelWrapper
            // 
            this.panelWrapper.BackColor = System.Drawing.SystemColors.Control;
            this.panelWrapper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWrapper.Controls.Add(this.addPreset_submit);
            this.panelWrapper.Controls.Add(this.addPreset_nameInput);
            this.panelWrapper.Controls.Add(this.label1);
            this.panelWrapper.Controls.Add(this.label3);
            this.panelWrapper.Controls.Add(this.label2);
            this.panelWrapper.Controls.Add(this.addPreset_countDown);
            this.panelWrapper.Controls.Add(this.addPreset_MenuDropdown);
            this.panelWrapper.Location = new System.Drawing.Point(0, 0);
            this.panelWrapper.Name = "panelWrapper";
            this.panelWrapper.Size = new System.Drawing.Size(850, 400);
            this.panelWrapper.TabIndex = 20;
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.panelWrapper);
            this.Name = "FormAdd";
            this.Text = "formAdd";
            ((System.ComponentModel.ISupportInitialize)(this.addPreset_countDown)).EndInit();
            this.panelWrapper.ResumeLayout(false);
            this.panelWrapper.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addPreset_submit;
        private System.Windows.Forms.TextBox addPreset_nameInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown addPreset_countDown;
        private System.Windows.Forms.ComboBox addPreset_MenuDropdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelWrapper;
    }
}