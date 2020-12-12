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
    public partial class FormAdd : Form 
    {
        private CHALLENGE_APP FormMain;

        public FormAdd(CHALLENGE_APP form)
        {
            InitializeComponent();

            FormMain = form;

            //add preset dropdown
            addPreset_MenuDropdown.DataSource = FormMain.execQuery("select * from menu");
            addPreset_MenuDropdown.DisplayMember = "name";
            addPreset_MenuDropdown.ValueMember = "id";

            //add preset nums
            addPreset_countDown.Minimum = 0;
            addPreset_countDown.Maximum = 86400;
        }

        private void addPreset_Submit_Click(object sender, EventArgs e) //add preset
        {
            string name = addPreset_nameInput.Text;
            int count_down = (int)addPreset_countDown.Value;
            int menu_id = (int)addPreset_MenuDropdown.SelectedValue;

            if (name == "")
            {
                MessageBox.Show("Incorrect name");
                return;
            }

            if (count_down < 0)
            {
                MessageBox.Show("Incorrect count_down");
                return;
            }

            addPreset_nameInput.Text = string.Empty;
            addPreset_countDown.Value = 0;
            FormMain.execQuery("INSERT INTO menu_item (name,count_down,menu_id) VALUES('" + name + "'," + count_down + "," + menu_id + " )");
        }
    }
}
