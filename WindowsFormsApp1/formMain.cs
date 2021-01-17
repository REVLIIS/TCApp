using FontAwesome.Sharp;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CHALLENGE_APP : Form
    {
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=challenge");

        Boolean devmode = true;
        private IconButton currentBtn;
        private Form currentForm;

        public CHALLENGE_APP()
        {
            InitializeComponent();
            startTimer();

            if(!devmode)
                sideBtn_Dev.Hide();
        }

        private async void startTimer()
        {
            dateLabel.Text = DateTime.Now.ToString("g");
            timer1.Tick += new EventHandler(dateTimer_Tick);

            await Task.Delay( (60 - DateTime.Now.Second) * 1000); //when new min starts

            dateLabel.Text = DateTime.Now.ToString("g");

            timer1.Interval = 60000; //update every 60 sec
            timer1.Start();

        } 

        private void printOutput(DataTable dt)
        {
            int numberOfResults = dt.Rows.Count;

            var columns = dt.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToList();
            string colstring = "";

            foreach (string col in columns) colstring += col + ", ";

            devPrint(colstring.Trim(' ').Trim(','));

            foreach (DataRow dr in dt.Rows)
            {
                string row = "";
                foreach (string col in columns) row += dr[col] + " ";

                devPrint(row);
            }
        }

        public DataTable execQuery(string query)
        {
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            DataTable dt = new DataTable();

            try
            {
                databaseConnection.Open();

                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {
                    dt.Load(myReader);
                    printOutput(dt);
                }
                else
                    devPrint("no rows for query: '"+query+"' executed.");
                    
            }

            catch (Exception _e)
            {
                MessageBox.Show("Query error " + _e.Message);
            }

            databaseConnection.Close();
            return dt;
        }

        private void dateTimer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToString("g");
        }

        #region dev
        public void devPrint(string msg)
        {
            if (!devmode)
                return;

            Console.WriteLine(msg);
        }

        public void devMsgBox(string msg)
        {
            if(!devmode)
                return;

            MessageBox.Show(msg);
        }
        #endregion

        #region side button markup
        private void ActivateButton(object senderBtn, Color color)
        {
            resetButton();

            currentBtn = (IconButton)senderBtn;

            currentBtn.BackColor = Color.FromArgb(37, 36, 81);
            currentBtn.ForeColor = color;
            currentBtn.IconColor = color;
        }

        private void resetButton()
        {
            if (currentBtn == null)
                return;

            currentBtn.BackColor = Color.FromArgb(35, 38, 45); //sidebar bg color
            currentBtn.ForeColor = Color.Lavender; //text color
            currentBtn.IconColor = Color.Lavender; //icon color
        }
        #endregion

        #region side button clicks
        private void sideBtn_Menu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            openChildForm(new FormMenu(this));
        }


        private void sideBtn_Add_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            openChildForm(new FormAdd(this));
        }

        private void sideBtn_Stats_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            openChildForm(new FormStatistics(this));
        }

        private void sideBtn_Settings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            openChildForm(new FormSettings(this));
        }
        #endregion

        private struct RGBColors //temp colorscheme
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void openChildForm(Form childForm)
        {
            devPrint("opening new form start");

            if (currentForm != null)
                currentForm.Close();

            currentForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            //childForm.BackColor = Color.Transparent; werkt niet

            pageWrapper.Controls.Add(childForm);
            pageWrapper.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();

            devPrint("done opening childform");
        }

        private void SideBtn_Dev_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            openChildForm(new FormDev(this));
        }

        private void LogoPlaceholder_Click(object sender, EventArgs e)
        {
            currentForm.Close();
            resetButton();
        }

        private void pageWrapper_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
