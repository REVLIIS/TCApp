namespace WindowsFormsApp1
{
    partial class FormDev
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
            this.dev_LabelQuery = new System.Windows.Forms.Label();
            this.dev_QuerySubmit = new System.Windows.Forms.Button();
            this.dev_QueryInput = new System.Windows.Forms.TextBox();
            this.panelWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWrapper
            // 
            this.panelWrapper.Controls.Add(this.dev_LabelQuery);
            this.panelWrapper.Controls.Add(this.dev_QuerySubmit);
            this.panelWrapper.Controls.Add(this.dev_QueryInput);
            this.panelWrapper.Location = new System.Drawing.Point(0, 0);
            this.panelWrapper.Name = "panelWrapper";
            this.panelWrapper.Size = new System.Drawing.Size(850, 400);
            this.panelWrapper.TabIndex = 0;
            // 
            // dev_LabelQuery
            // 
            this.dev_LabelQuery.AutoSize = true;
            this.dev_LabelQuery.Location = new System.Drawing.Point(113, 38);
            this.dev_LabelQuery.Name = "dev_LabelQuery";
            this.dev_LabelQuery.Size = new System.Drawing.Size(33, 13);
            this.dev_LabelQuery.TabIndex = 2;
            this.dev_LabelQuery.Text = "query";
            // 
            // dev_QuerySubmit
            // 
            this.dev_QuerySubmit.Location = new System.Drawing.Point(32, 54);
            this.dev_QuerySubmit.Name = "dev_QuerySubmit";
            this.dev_QuerySubmit.Size = new System.Drawing.Size(75, 23);
            this.dev_QuerySubmit.TabIndex = 1;
            this.dev_QuerySubmit.Text = "exec";
            this.dev_QuerySubmit.UseVisualStyleBackColor = true;
            this.dev_QuerySubmit.Click += new System.EventHandler(this.Dev_QuerySubmit_Click);
            // 
            // dev_QueryInput
            // 
            this.dev_QueryInput.Location = new System.Drawing.Point(113, 57);
            this.dev_QueryInput.Name = "dev_QueryInput";
            this.dev_QueryInput.Size = new System.Drawing.Size(193, 20);
            this.dev_QueryInput.TabIndex = 0;
            // 
            // FormDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.panelWrapper);
            this.Name = "FormDev";
            this.Text = "FormDev";
            this.panelWrapper.ResumeLayout(false);
            this.panelWrapper.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWrapper;
        private System.Windows.Forms.Label dev_LabelQuery;
        private System.Windows.Forms.Button dev_QuerySubmit;
        private System.Windows.Forms.TextBox dev_QueryInput;
    }
}