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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHALLENGE_APP));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pageWrapper = new System.Windows.Forms.Panel();
            this.main_textBoxInfo = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.main_Logo = new System.Windows.Forms.PictureBox();
            this.Divider = new System.Windows.Forms.Label();
            this.sideBtn_Dev = new FontAwesome.Sharp.IconButton();
            this.sideBtn_Menu = new FontAwesome.Sharp.IconButton();
            this.sideBtn_Add = new FontAwesome.Sharp.IconButton();
            this.sideBtn_Stats = new FontAwesome.Sharp.IconButton();
            this.sideBtn_Settings = new FontAwesome.Sharp.IconButton();
            this.dateLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.main_menuName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pageWrapper.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // pageWrapper
            // 
            this.pageWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(224)))), ((int)(((byte)(235)))));
            this.pageWrapper.Controls.Add(this.main_textBoxInfo);
            this.pageWrapper.Controls.Add(this.label1);
            this.pageWrapper.Location = new System.Drawing.Point(200, 29);
            this.pageWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.pageWrapper.Name = "pageWrapper";
            this.pageWrapper.Size = new System.Drawing.Size(984, 532);
            this.pageWrapper.TabIndex = 23;
            // 
            // main_textBoxInfo
            // 
            this.main_textBoxInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.main_textBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.main_textBoxInfo.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_textBoxInfo.Location = new System.Drawing.Point(642, 35);
            this.main_textBoxInfo.Name = "main_textBoxInfo";
            this.main_textBoxInfo.ReadOnly = true;
            this.main_textBoxInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.main_textBoxInfo.Size = new System.Drawing.Size(199, 335);
            this.main_textBoxInfo.TabIndex = 29;
            this.main_textBoxInfo.Text = resources.GetString("main_textBoxInfo.Text");
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(-5, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(990, 4);
            this.label1.TabIndex = 27;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(224)))), ((int)(((byte)(235)))));
            this.panelSideMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelSideMenu.Controls.Add(this.main_Logo);
            this.panelSideMenu.Controls.Add(this.Divider);
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
            this.panelSideMenu.Size = new System.Drawing.Size(200, 423);
            this.panelSideMenu.TabIndex = 24;
            // 
            // main_Logo
            // 
            this.main_Logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_Logo.Image = ((System.Drawing.Image)(resources.GetObject("main_Logo.Image")));
            this.main_Logo.Location = new System.Drawing.Point(12, 9);
            this.main_Logo.Name = "main_Logo";
            this.main_Logo.Size = new System.Drawing.Size(180, 85);
            this.main_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.main_Logo.TabIndex = 27;
            this.main_Logo.TabStop = false;
            this.main_Logo.Click += new System.EventHandler(this.Main_Logo_Click);
            // 
            // Divider
            // 
            this.Divider.BackColor = System.Drawing.Color.Lavender;
            this.Divider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Divider.Location = new System.Drawing.Point(196, -1);
            this.Divider.Margin = new System.Windows.Forms.Padding(0);
            this.Divider.Name = "Divider";
            this.Divider.Size = new System.Drawing.Size(4, 600);
            this.Divider.TabIndex = 26;
            this.Divider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sideBtn_Dev
            // 
            this.sideBtn_Dev.FlatAppearance.BorderSize = 0;
            this.sideBtn_Dev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideBtn_Dev.Font = new System.Drawing.Font("Vogue ExtraBold", 18F, System.Drawing.FontStyle.Bold);
            this.sideBtn_Dev.ForeColor = System.Drawing.Color.Lavender;
            this.sideBtn_Dev.IconChar = FontAwesome.Sharp.IconChar.Dev;
            this.sideBtn_Dev.IconColor = System.Drawing.Color.Lavender;
            this.sideBtn_Dev.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sideBtn_Dev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideBtn_Dev.Location = new System.Drawing.Point(0, 478);
            this.sideBtn_Dev.Name = "sideBtn_Dev";
            this.sideBtn_Dev.Size = new System.Drawing.Size(200, 80);
            this.sideBtn_Dev.TabIndex = 11;
            this.sideBtn_Dev.Text = "DEV";
            this.sideBtn_Dev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideBtn_Dev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sideBtn_Dev.UseVisualStyleBackColor = true;
            this.sideBtn_Dev.Click += new System.EventHandler(this.SideBtn_Dev_Click);
            // 
            // sideBtn_Menu
            // 
            this.sideBtn_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(113)))), ((int)(((byte)(198)))));
            this.sideBtn_Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sideBtn_Menu.FlatAppearance.BorderSize = 0;
            this.sideBtn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideBtn_Menu.Font = new System.Drawing.Font("Vogue ExtraBold", 18F, System.Drawing.FontStyle.Bold);
            this.sideBtn_Menu.ForeColor = System.Drawing.Color.Lavender;
            this.sideBtn_Menu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.sideBtn_Menu.IconColor = System.Drawing.Color.Lavender;
            this.sideBtn_Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sideBtn_Menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideBtn_Menu.Location = new System.Drawing.Point(0, 100);
            this.sideBtn_Menu.Name = "sideBtn_Menu";
            this.sideBtn_Menu.Size = new System.Drawing.Size(200, 80);
            this.sideBtn_Menu.TabIndex = 10;
            this.sideBtn_Menu.Text = "MENU";
            this.sideBtn_Menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideBtn_Menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sideBtn_Menu.UseVisualStyleBackColor = false;
            this.sideBtn_Menu.Click += new System.EventHandler(this.sideBtn_Menu_Click);
            // 
            // sideBtn_Add
            // 
            this.sideBtn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(113)))), ((int)(((byte)(198)))));
            this.sideBtn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sideBtn_Add.FlatAppearance.BorderSize = 0;
            this.sideBtn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideBtn_Add.Font = new System.Drawing.Font("Vogue ExtraBold", 18F, System.Drawing.FontStyle.Bold);
            this.sideBtn_Add.ForeColor = System.Drawing.Color.Lavender;
            this.sideBtn_Add.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.sideBtn_Add.IconColor = System.Drawing.Color.Lavender;
            this.sideBtn_Add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sideBtn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideBtn_Add.Location = new System.Drawing.Point(0, 181);
            this.sideBtn_Add.Name = "sideBtn_Add";
            this.sideBtn_Add.Size = new System.Drawing.Size(200, 80);
            this.sideBtn_Add.TabIndex = 9;
            this.sideBtn_Add.Text = "ADD";
            this.sideBtn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideBtn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sideBtn_Add.UseVisualStyleBackColor = false;
            this.sideBtn_Add.Click += new System.EventHandler(this.sideBtn_Add_Click);
            // 
            // sideBtn_Stats
            // 
            this.sideBtn_Stats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(113)))), ((int)(((byte)(198)))));
            this.sideBtn_Stats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sideBtn_Stats.FlatAppearance.BorderSize = 0;
            this.sideBtn_Stats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideBtn_Stats.Font = new System.Drawing.Font("Vogue ExtraBold", 18F, System.Drawing.FontStyle.Bold);
            this.sideBtn_Stats.ForeColor = System.Drawing.Color.Lavender;
            this.sideBtn_Stats.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.sideBtn_Stats.IconColor = System.Drawing.Color.Lavender;
            this.sideBtn_Stats.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sideBtn_Stats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideBtn_Stats.Location = new System.Drawing.Point(0, 262);
            this.sideBtn_Stats.Name = "sideBtn_Stats";
            this.sideBtn_Stats.Size = new System.Drawing.Size(200, 80);
            this.sideBtn_Stats.TabIndex = 8;
            this.sideBtn_Stats.Text = "STATS";
            this.sideBtn_Stats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideBtn_Stats.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sideBtn_Stats.UseVisualStyleBackColor = false;
            this.sideBtn_Stats.Click += new System.EventHandler(this.sideBtn_Stats_Click);
            // 
            // sideBtn_Settings
            // 
            this.sideBtn_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(113)))), ((int)(((byte)(198)))));
            this.sideBtn_Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sideBtn_Settings.FlatAppearance.BorderSize = 0;
            this.sideBtn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideBtn_Settings.Font = new System.Drawing.Font("Vogue ExtraBold", 18F, System.Drawing.FontStyle.Bold);
            this.sideBtn_Settings.ForeColor = System.Drawing.Color.Lavender;
            this.sideBtn_Settings.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.sideBtn_Settings.IconColor = System.Drawing.Color.Lavender;
            this.sideBtn_Settings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sideBtn_Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideBtn_Settings.Location = new System.Drawing.Point(0, 343);
            this.sideBtn_Settings.Name = "sideBtn_Settings";
            this.sideBtn_Settings.Size = new System.Drawing.Size(200, 80);
            this.sideBtn_Settings.TabIndex = 7;
            this.sideBtn_Settings.Text = "SETTINGS";
            this.sideBtn_Settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideBtn_Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sideBtn_Settings.UseVisualStyleBackColor = false;
            this.sideBtn_Settings.Click += new System.EventHandler(this.sideBtn_Settings_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.dateLabel.Font = new System.Drawing.Font("Vogue ExtraBold", 18F, System.Drawing.FontStyle.Bold);
            this.dateLabel.Location = new System.Drawing.Point(784, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(70, 29);
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
            // main_menuName
            // 
            this.main_menuName.AutoSize = true;
            this.main_menuName.Dock = System.Windows.Forms.DockStyle.Left;
            this.main_menuName.Font = new System.Drawing.Font("Vogue ExtraBold", 18F, System.Drawing.FontStyle.Bold);
            this.main_menuName.Location = new System.Drawing.Point(0, 0);
            this.main_menuName.Name = "main_menuName";
            this.main_menuName.Size = new System.Drawing.Size(65, 29);
            this.main_menuName.TabIndex = 26;
            this.main_menuName.Text = "MAIN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.main_menuName);
            this.panel1.Controls.Add(this.dateLabel);
            this.panel1.Location = new System.Drawing.Point(200, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 30);
            this.panel1.TabIndex = 27;
            // 
            // CHALLENGE_APP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(224)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1048, 423);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.pageWrapper);
            this.Name = "CHALLENGE_APP";
            this.Text = "Form1";
            this.pageWrapper.ResumeLayout(false);
            this.panelSideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.main_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Divider;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.RichTextBox main_textBoxInfo;
        private System.Windows.Forms.Label main_menuName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox main_Logo;
    }
}

