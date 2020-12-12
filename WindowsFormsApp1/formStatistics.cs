using System;
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
    public partial class FormStatistics : Form
    {
        CHALLENGE_APP FormMain;

        public FormStatistics(CHALLENGE_APP form)
        {
            InitializeComponent();

            FormMain = form;
        }

        private void LabelStatistics_Click(object sender, EventArgs e)
        {
            FormMain.execQuery("");
        }
    }
}
