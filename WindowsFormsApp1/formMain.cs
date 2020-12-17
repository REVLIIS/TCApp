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
        public bool darkmode = false;

        
        public CHALLENGE_APP()
        {
            InitializeComponent();
            startTimer();

            if(!devmode)
                sideBtn_Dev.Hide();

            themeHandler(this.Controls);

            //this.BackColor = lightColors.backGround;

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
        private void ActivateButton(object senderBtn)
        {
            resetButton();

            currentBtn = (IconButton)senderBtn;
            currentBtn.BackColor = darkmode ? Color.FromArgb(95, 95, 95) : Color.FromArgb(138, 164, 226); //37, 36, 81
        }


        private void resetButton()
        {
            if (currentBtn == null)
                return;

            currentBtn.BackColor = darkmode ? darkColors.buttonSide : lightColors.buttonSide;
                                                   //currentBtn.BackColor = Color.FromArgb(35, 38, 45); //sidebar bg color
        }
        #endregion

        #region side button clicks
        private void sideBtn_Menu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new FormMenu(this), (sender as Button).Text);
        }


        private void sideBtn_Add_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new FormAdd(this), (sender as Button).Text);
        }

        private void sideBtn_Stats_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new FormStatistics(this), (sender as Button).Text);
        }

        private void sideBtn_Settings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new FormSettings(this), (sender as Button).Text);
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


        public struct darkColors
        {
            public static Color buttonSide = Color.FromArgb(40, 40, 40);
            public static Color backGround = Color.FromArgb(71, 71, 71);
            public static Color buttonInside = Color.FromArgb(193, 193, 193);
            public static Color text = Color.FromArgb(255, 255, 255);
            public static Color element = Color.FromArgb(222, 220, 220);
        }

        public struct lightColors
        {
            public static Color buttonSide = Color.FromArgb(79, 113, 198);//(230, 230, 230);
            public static Color backGround = Color.FromArgb(211, 224, 235); //230, 230, 250
            public static Color buttonInside = Color.FromArgb(50, 119, 179); //150, 150, 150
            public static Color text = Color.FromArgb(0, 0, 0);
            public static Color element = Color.FromArgb(40, 40, 40);
        }


        private void openChildForm(Form childForm, string menuName)
        {
            devPrint("opening new form start");

            if (currentForm != null)
                currentForm.Close();

            currentForm = childForm;

            main_menuName.Text = menuName;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            //childForm.Dock = DockStyle.Fill;
            childForm.Top = 2; //make seperator visible top
            //childForm.BackColor = Color.Transparent; werkt niet

            pageWrapper.Controls.Add(childForm);
            pageWrapper.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();

            devPrint("done opening childform");
        }

        private void SideBtn_Dev_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new FormDev(this), (sender as Button).Text);
        }

        public void getColors()
        {

        }

        public void themeHandler(Control.ControlCollection container)
        {
            foreach (Control component in container)
            {
                if(component.HasChildren)
                    themeHandler(component.Controls);

                //als colorscheme af is verbeter deze rommel

                if (component is Panel)
                {
                    component.BackColor = darkmode ? darkColors.backGround : lightColors.backGround;
                }
                else if (component is Button)
                {
                    component.BackColor = darkmode ? (component.Name.StartsWith("sideBtn")) ? darkColors.buttonSide : darkColors.buttonInside : 
                                                     (component.Name.StartsWith("sideBtn")) ? lightColors.buttonSide : lightColors.buttonInside;
                    component.ForeColor = darkmode ? (component.Name.StartsWith("sideBtn")) ? darkColors.text : lightColors.text :
                                                     (component.Name.StartsWith("sideBtn")) ? lightColors.text : darkColors.text;


                }
                else if (component is TextBox)
                {
                    component.BackColor = darkmode ? darkColors.backGround : lightColors.backGround;
                }
                else if (component is Label)
                {
                    component.BackColor = darkmode ? darkColors.backGround : lightColors.backGround;
                    component.ForeColor = darkmode ? darkColors.text : lightColors.text;
                }
                else if(component is CheckBox)
                {
                    component.BackColor = darkmode ? darkColors.backGround : lightColors.backGround;
                    component.ForeColor = darkmode ? darkColors.text : lightColors.text;
                }
                else if (component is MonthCalendar)
                {
                    component.BackColor = darkmode ? darkColors.backGround : lightColors.backGround;
                    component.ForeColor = darkmode ? darkColors.text : lightColors.text;
                }
                else if(component is ComboBox)
                {
                    component.BackColor = darkmode ? darkColors.backGround : lightColors.backGround;
                    component.ForeColor = darkmode ? darkColors.text : lightColors.text;
                }
                else if(component is TextBox)
                {
                    component.BackColor = darkmode ? darkColors.backGround : lightColors.backGround;
                    component.ForeColor = darkmode ? darkColors.text : lightColors.text;
                }
                else if(component is NumericUpDown)
                {
                    component.BackColor = darkmode ? darkColors.backGround : lightColors.backGround;
                    component.ForeColor = darkmode ? darkColors.text : lightColors.text;
                }
                else if (component is DataGridView)
                {
                    //component.BackColor = darkmode ? darkColors.backGround : lightColors.backGround;
                    //component.ForeColor = darkmode ? darkColors.text : lightColors.text;
                }
                else
                    devPrint("elem not found "+component.GetType());
                
            }

            if (currentBtn != null)
                ActivateButton(currentBtn);
        }

        private void Main_Logo_Click(object sender, EventArgs e)
        {
            if (currentForm == null)
                return;

            main_menuName.Text = "MAIN";
            currentForm.Close();
            resetButton();
        }
    }
}
