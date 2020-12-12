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
    public partial class FormSettings : Form
    {
        private CHALLENGE_APP FormMain;
        public FormSettings(CHALLENGE_APP form)
        {
            InitializeComponent();

            FormMain = form;

        }

        private void FormSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
