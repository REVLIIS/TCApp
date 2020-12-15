namespace WindowsFormsApp1
{
    partial class FormMenu
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelWrapper = new System.Windows.Forms.Panel();
            this.menu_LabelTimes = new System.Windows.Forms.Label();
            this.labelRecents = new System.Windows.Forms.Label();
            this.panelMenuItem = new System.Windows.Forms.Panel();
            this.panelMenuTimes = new System.Windows.Forms.Panel();
            this.panelMenuRecents = new System.Windows.Forms.Panel();
            this.menu_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.menu_LabelItems = new System.Windows.Forms.Label();
            this.panelWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWrapper
            // 
            this.panelWrapper.BackColor = System.Drawing.SystemColors.Control;
            this.panelWrapper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWrapper.Controls.Add(this.menu_LabelItems);
            this.panelWrapper.Controls.Add(this.menu_LabelTimes);
            this.panelWrapper.Controls.Add(this.labelRecents);
            this.panelWrapper.Controls.Add(this.panelMenuItem);
            this.panelWrapper.Controls.Add(this.panelMenuTimes);
            this.panelWrapper.Controls.Add(this.panelMenuRecents);
            this.panelWrapper.Location = new System.Drawing.Point(0, 0);
            this.panelWrapper.Name = "panelWrapper";
            this.panelWrapper.Size = new System.Drawing.Size(850, 400);
            this.panelWrapper.TabIndex = 18;
            // 
            // menu_LabelTimes
            // 
            this.menu_LabelTimes.AutoSize = true;
            this.menu_LabelTimes.Font = new System.Drawing.Font("Kozuka Mincho Pro H", 18F, System.Drawing.FontStyle.Bold);
            this.menu_LabelTimes.Location = new System.Drawing.Point(11, 217);
            this.menu_LabelTimes.Name = "menu_LabelTimes";
            this.menu_LabelTimes.Size = new System.Drawing.Size(89, 33);
            this.menu_LabelTimes.TabIndex = 17;
            this.menu_LabelTimes.Text = "TIMES";
            // 
            // labelRecents
            // 
            this.labelRecents.AutoSize = true;
            this.labelRecents.Font = new System.Drawing.Font("Kozuka Mincho Pro H", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecents.Location = new System.Drawing.Point(698, 34);
            this.labelRecents.Name = "labelRecents";
            this.labelRecents.Size = new System.Drawing.Size(105, 33);
            this.labelRecents.TabIndex = 16;
            this.labelRecents.Text = "Recents";
            // 
            // panelMenuItem
            // 
            this.panelMenuItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenuItem.Location = new System.Drawing.Point(13, 58);
            this.panelMenuItem.Name = "panelMenuItem";
            this.panelMenuItem.Size = new System.Drawing.Size(630, 125);
            this.panelMenuItem.TabIndex = 13;
            // 
            // panelMenuTimes
            // 
            this.panelMenuTimes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenuTimes.Location = new System.Drawing.Point(13, 253);
            this.panelMenuTimes.Name = "panelMenuTimes";
            this.panelMenuTimes.Size = new System.Drawing.Size(630, 125);
            this.panelMenuTimes.TabIndex = 14;
            // 
            // panelMenuRecents
            // 
            this.panelMenuRecents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenuRecents.Location = new System.Drawing.Point(681, 78);
            this.panelMenuRecents.Name = "panelMenuRecents";
            this.panelMenuRecents.Size = new System.Drawing.Size(140, 301);
            this.panelMenuRecents.TabIndex = 15;
            // 
            // menu_LabelItems
            // 
            this.menu_LabelItems.AutoSize = true;
            this.menu_LabelItems.Font = new System.Drawing.Font("Kozuka Mincho Pro H", 18F, System.Drawing.FontStyle.Bold);
            this.menu_LabelItems.Location = new System.Drawing.Point(11, 24);
            this.menu_LabelItems.Name = "menu_LabelItems";
            this.menu_LabelItems.Size = new System.Drawing.Size(89, 33);
            this.menu_LabelItems.TabIndex = 18;
            this.menu_LabelItems.Text = "ITEMS";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.panelWrapper);
            this.Name = "FormMenu";
            this.Text = "FormWrapper";
            this.panelWrapper.ResumeLayout(false);
            this.panelWrapper.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelWrapper;
        private System.Windows.Forms.Label labelRecents;
        private System.Windows.Forms.Panel panelMenuItem;
        private System.Windows.Forms.Panel panelMenuTimes;
        private System.Windows.Forms.Panel panelMenuRecents;
        private System.Windows.Forms.Label menu_LabelTimes;
        private System.Windows.Forms.ToolTip menu_Tooltip;
        private System.Windows.Forms.Label menu_LabelItems;
    }
}