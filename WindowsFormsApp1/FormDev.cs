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
    public partial class FormDev : Form
    {
        CHALLENGE_APP FormMain;
        public FormDev(CHALLENGE_APP form)
        {
            FormMain = form;
            InitializeComponent();
        }

        private void Dev_QuerySubmit_Click(object sender, EventArgs e)
        {
            FormMain.execQuery(dev_QueryInput.Text);
        }
    }
}
