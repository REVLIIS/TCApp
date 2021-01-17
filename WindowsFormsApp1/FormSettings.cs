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
        private FormAdd formadd;

        public FormSettings(CHALLENGE_APP form)
        {
            InitializeComponent();

            FormMain = form;
            
            if (FormMain.BackColor == Color.Black && FormMain.ForeColor == Color.White)
            {
                nightmode_checkbox.CheckState = CheckState.Checked;
                dark_mode();
            }
            else {
                nightmode_checkbox.CheckState = CheckState.Unchecked;
                light_mode();
            }

        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            
        }

        private void nightmode_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (nightmode_checkbox.Checked)
            {
                nightmode_checkbox.CheckState = CheckState.Checked;
                dark_mode();
            }
            else {
                nightmode_checkbox.CheckState = CheckState.Unchecked;
                light_mode();
            }
        }

        private void dark_mode() {
            FormMain.BackColor = Color.Black;
            FormMain.ForeColor = Color.White;
            BackColor = Color.Black;
            ForeColor = Color.White;
        }

        private void light_mode() {
            FormMain.BackColor = Color.White;
            FormMain.ForeColor = Color.Black;
            BackColor = Color.White;
            ForeColor = Color.Black; ;
        }

    }
}
