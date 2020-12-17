using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

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



        private void onButton_Click(object sender, EventArgs e)
        {
            SerialPort sp = new SerialPort("COM5", 9600);

            if (!sp.IsOpen)
                sp.Open();

            sp.Write("1");
            sp.Close();

            /*
            try
            {
                SerialPort sp = new SerialPort("COM5", 9600);

                if(!sp.IsOpen)
                    sp.Open();

                sp.Write("1");
                sp.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }
        private void offButton_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort sp = new SerialPort("COM5", 9600);

                if (!sp.IsOpen)
                    sp.Open();

                sp.Write("0");
                sp.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }







    }
}
