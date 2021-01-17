namespace WindowsFormsApp1
{
    partial class CHALLENGE_APP
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pageWrapper = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_main = new System.Windows.Forms.Label();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.Divider = new System.Windows.Forms.Label();
            this.logoPlaceholder = new System.Windows.Forms.Label();
            this.sideBtn_Dev = new FontAwesome.Sharp.IconButton();
            this.sideBtn_Menu = new FontAwesome.Sharp.IconButton();
            this.sideBtn_Add = new FontAwesome.Sharp.IconButton();
            this.sideBtn_Stats = new FontAwesome.Sharp.IconButton();
            this.sideBtn_Settings = new FontAwesome.Sharp.IconButton();
            this.dateLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pageWrapper.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // pageWrapper
            // 
            this.pageWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.pageWrapper.Controls.Add(this.label1);
            this.pageWrapper.Controls.Add(this.label_main);
            this.pageWrapper.Location = new System.Drawing.Point(267, 36);
            this.pageWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.pageWrapper.Name = "pageWrapper";
            this.pageWrapper.Size = new System.Drawing.Size(1312, 655);
            this.pageWrapper.TabIndex = 23;
            this.pageWrapper.Paint += new System.Windows.Forms.PaintEventHandler(this.pageWrapper_Paint);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(-7, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1319, 4);
            this.label1.TabIndex = 27;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_main
            // 
            this.label_main.AutoSize = true;
            this.label_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.label_main.Location = new System.Drawing.Point(536, 198);
            this.label_main.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_main.Name = "label_main";
            this.label_main.Size = new System.Drawing.Size(205, 76);
            this.label_main.TabIndex = 0;
            this.label_main.Text = "MAIN";
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.panelSideMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelSideMenu.Controls.Add(this.Divider);
            this.panelSideMenu.Controls.Add(this.logoPlaceholder);
            this.panelSideMenu.Controls.Add(this.sideBtn_Dev);
            this.panelSideMenu.Controls.Add(this.sideBtn_Menu);
            this.panelSideMenu.Controls.Add(this.sideBtn_Add);
            this.panelSideMenu.Controls.Add(this.sideBtn_Stats);
            this.panelSideMenu.Controls.Add(this.sideBtn_Settings);
            this.panelSideMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(267, 690);
            this.panelSideMenu.TabIndex = 24;
            // 
            // Divider
            // 
            this.Divider.BackColor = System.Drawing.Color.Lavender;
            this.Divider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Divider.Location = new System.Drawing.Point(261, -1);
            this.Divider.Margin = new System.Windows.Forms.Padding(0);
            this.Divider.Name = "Divider";
            this.Divider.Size = new System.Drawing.Size(5, 738);
            this.Divider.TabIndex = 26;
            this.Divider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoPlaceholder
            // 
            this.logoPlaceholder.AutoSize = true;
            this.logoPlaceholder.Location = new System.Drawing.Point(28, 50);
            this.logoPlaceholder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logoPlaceholder.Name = "logoPlaceholder";
            this.logoPlaceholder.Size = new System.Drawing.Size(205, 17);
            this.logoPlaceholder.TabIndex = 12;
            this.logoPlaceholder.Text = "logo temp (click for main menu)";
            this.logoPlaceholder.Click += new System.EventHandler(this.LogoPlaceholder_Click);
            // 
            // sideBtn_Dev
            // 
            this.sideBtn_Dev.FlatAppearance.BorderSize = 0;
            this.sideBtn_Dev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideBtn_Dev.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.sideBtn_Dev.ForeColor = System.Drawing.Color.Lavender;
            this.sideBtn_Dev.IconChar = FontAwesome.Sharp.IconChar.Dev;
            this.sideBtn_Dev.IconColor = System.Drawing.Color.Lavender;
            this.sideBtn_Dev.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sideBtn_Dev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideBtn_Dev.Location = new System.Drawing.Point(0, 588);
            this.sideBtn_Dev.Margin = new System.Windows.Forms.Padding(4);
            this.sideBtn_Dev.Name = "sideBtn_Dev";
            this.sideBtn_Dev.Size = new System.Drawing.Size(267, 98);
            this.sideBtn_Dev.TabIndex = 11;
            this.sideBtn_Dev.Text = "DEV";
            this.sideBtn_Dev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideBtn_Dev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sideBtn_Dev.UseVisualStyleBackColor = true;
            this.sideBtn_Dev.Click += new System.EventHandler(this.SideBtn_Dev_Click);
            // 
            // sideBtn_Menu
            // 
            this.sideBtn_Menu.FlatAppearance.BorderSize = 0;
            this.sideBtn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideBtn_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.sideBtn_Menu.ForeColor = System.Drawing.Color.Lavender;
            this.sideBtn_Menu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.sideBtn_Menu.IconColor = System.Drawing.Color.Lavender;
            this.sideBtn_Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sideBtn_Menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideBtn_Menu.Location = new System.Drawing.Point(0, 123);
            this.sideBtn_Menu.Margin = new System.Windows.Forms.Padding(4);
            this.sideBtn_Menu.Name = "sideBtn_Menu";
            this.sideBtn_Menu.Size = new System.Drawing.Size(267, 98);
            this.sideBtn_Menu.TabIndex = 10;
            this.sideBtn_Menu.Text = "MENU";
            this.sideBtn_Menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideBtn_Menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sideBtn_Menu.UseVisualStyleBackColor = true;
            this.sideBtn_Menu.Click += new System.EventHandler(this.sideBtn_Menu_Click);
            // 
            // sideBtn_Add
            // 
            this.sideBtn_Add.FlatAppearance.BorderSize = 0;
            this.sideBtn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideBtn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.sideBtn_Add.ForeColor = System.Drawing.Color.Lavender;
            this.sideBtn_Add.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.sideBtn_Add.IconColor = System.Drawing.Color.Lavender;
            this.sideBtn_Add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sideBtn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideBtn_Add.Location = new System.Drawing.Point(0, 222);
            this.sideBtn_Add.Margin = new System.Windows.Forms.Padding(4);
            this.sideBtn_Add.Name = "sideBtn_Add";
            this.sideBtn_Add.Size = new System.Drawing.Size(267, 98);
            this.sideBtn_Add.TabIndex = 9;
            this.sideBtn_Add.Text = "ADD";
            this.sideBtn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideBtn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sideBtn_Add.UseVisualStyleBackColor = true;
            this.sideBtn_Add.Click += new System.EventHandler(this.sideBtn_Add_Click);
            // 
            // sideBtn_Stats
            // 
            this.sideBtn_Stats.FlatAppearance.BorderSize = 0;
            this.sideBtn_Stats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideBtn_Stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.sideBtn_Stats.ForeColor = System.Drawing.Color.Lavender;
            this.sideBtn_Stats.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.sideBtn_Stats.IconColor = System.Drawing.Color.Lavender;
            this.sideBtn_Stats.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sideBtn_Stats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideBtn_Stats.Location = new System.Drawing.Point(0, 320);
            this.sideBtn_Stats.Margin = new System.Windows.Forms.Padding(4);
            this.sideBtn_Stats.Name = "sideBtn_Stats";
            this.sideBtn_Stats.Size = new System.Drawing.Size(267, 98);
            this.sideBtn_Stats.TabIndex = 8;
            this.sideBtn_Stats.Text = "STATS";
            this.sideBtn_Stats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideBtn_Stats.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sideBtn_Stats.UseVisualStyleBackColor = true;
            this.sideBtn_Stats.Click += new System.EventHandler(this.sideBtn_Stats_Click);
            // 
            // sideBtn_Settings
            // 
            this.sideBtn_Settings.FlatAppearance.BorderSize = 0;
            this.sideBtn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideBtn_Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.sideBtn_Settings.ForeColor = System.Drawing.Color.Lavender;
            this.sideBtn_Settings.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.sideBtn_Settings.IconColor = System.Drawing.Color.Lavender;
            this.sideBtn_Settings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sideBtn_Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideBtn_Settings.Location = new System.Drawing.Point(0, 418);
            this.sideBtn_Settings.Margin = new System.Windows.Forms.Padding(4);
            this.sideBtn_Settings.Name = "sideBtn_Settings";
            this.sideBtn_Settings.Size = new System.Drawing.Size(267, 98);
            this.sideBtn_Settings.TabIndex = 7;
            this.sideBtn_Settings.Text = "SETTINGS";
            this.sideBtn_Settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideBtn_Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sideBtn_Settings.UseVisualStyleBackColor = true;
            this.sideBtn_Settings.Click += new System.EventHandler(this.sideBtn_Settings_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.dateLabel.Location = new System.Drawing.Point(1480, 0);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(99, 36);
            this.dateLabel.TabIndex = 25;
            this.dateLabel.Text = "DATE";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // CHALLENGE_APP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(145)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(1579, 690);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.pageWrapper);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CHALLENGE_APP";
            this.Text = "Form1";
            this.pageWrapper.ResumeLayout(false);
            this.pageWrapper.PerformLayout();
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pageWrapper;
        private System.Windows.Forms.Panel panelSideMenu;
        private FontAwesome.Sharp.IconButton sideBtn_Menu;
        private FontAwesome.Sharp.IconButton sideBtn_Add;
        private FontAwesome.Sharp.IconButton sideBtn_Stats;
        private FontAwesome.Sharp.IconButton sideBtn_Settings;
        private System.Windows.Forms.Label dateLabel;
        private FontAwesome.Sharp.IconButton sideBtn_Dev;
        private System.Windows.Forms.Label label_main;
        private System.Windows.Forms.Label logoPlaceholder;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Divider;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

