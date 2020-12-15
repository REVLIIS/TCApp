﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormSettings : Form
    {
        private CHALLENGE_APP FormMain;

        public FormSettings(CHALLENGE_APP form)
        {
            InitializeComponent();

            FormMain = form;
            FormMain.themeHandler(this.Controls);

            nightmode_checkbox.Checked = FormMain.darkmode; //save setting globally
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {

        }

        private void nightmode_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            FormMain.darkmode = nightmode_checkbox.Checked;
            FormMain.themeHandler(this.Controls);
        }
    }
}
