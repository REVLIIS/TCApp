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
    public partial class FormMenu : Form
    {
        CHALLENGE_APP FormMain;

        public FormMenu(CHALLENGE_APP form)
        {
            InitializeComponent();

            FormMain = form;

            createButtons();
            fillRecentPanel();

            //panels moeten scrollbaar zijn
        }

        private void createButtons()
        {
            DataTable buttons = new DataTable();

            buttons = FormMain.execQuery("select * from menu_item");

            int top_items = 10;
            int left_items = 10;

            int top_times = 10;
            int left_times = 10;

            foreach (DataRow dr in buttons.Rows)
            {
                FormMain.devPrint("adding buttons" + (int)dr["id"]);

                Button button = new Button();
                button.Width = 100;
                button.Height = 75;

                if ((int)dr["menu_id"] == 1) //items
                {
                    button.Left = left_items;
                    button.Top = top_items;

                    left_items += button.Width + 10;

                    panelMenuItem.Controls.Add(button);

                }
                else if ((int)dr["menu_id"] == 2) //times
                {
                    button.Left = left_times;
                    button.Top = top_times;

                    left_times += button.Width + 10;

                    panelMenuTimes.Controls.Add(button);

                }

                button.Text = dr["name"].ToString();
                button.Font = new Font("Vogue", 10, FontStyle.Bold);

                button.Name = dr["count_down"].ToString() + "," + dr["id"].ToString();
                button.MouseClick += new MouseEventHandler(dynamicButton_Click);

                ToolTip toolTip1 = new ToolTip();
                menu_Tooltip.SetToolTip(button, "Zet de UV lamp aan voor "+dr["count_down"].ToString() + " seconden.");
            }
        }

        private void fillRecentPanel()
        {
            int top = 0;
            int limit = 5;
            DataTable recents = FormMain.execQuery("call sp_getRecentStatistics("+limit+")");

            foreach (DataRow dr in recents.Rows)
            {
                DataTable menu_items = FormMain.execQuery("SELECT id, name, count_down FROM menu_item WHERE id = "+ dr["menu_item_id"]);
                DataRowCollection menu_item = menu_items.Rows;

                Button button = new Button();
                button.Width = panelMenuRecents.Width;
                button.Height = panelMenuRecents.Height / limit;
                button.Top = top;
                top += button.Height;

                DateTime date = (DateTime)dr["date_of_use"];


                button.Text = date.Date.ToString("dd/MM/yyyy") + "\n" + dr["time_of_use"].ToString() + "\n" + menu_item[0]["name"];
                button.Font = new Font("Vogue", 10, FontStyle.Bold);

                panelMenuRecents.Controls.Add(button);


                button.Name = menu_item[0]["count_down"].ToString() + "," + menu_item[0]["id"].ToString();
                button.MouseClick += new MouseEventHandler(dynamicButton_Click);

                ToolTip toolTip1 = new ToolTip();
                menu_Tooltip.SetToolTip(button, "Zet de UV lamp aan voor " + menu_item[0]["count_down"].ToString() + " seconden.");
            }
        }

        private void dynamicButton_Click(object sender, EventArgs e)
        {
            string[] info = ((System.Windows.Forms.Button)sender).Name.Split(','); // [0]seconds [1]id

            FormMain.devMsgBox(info[0] + " seconds clicked");

            /*
                (int) seconds doorsturen naar arduino 

                if completed create statistic

                update recentpanel
                
            */

            Boolean completed = true; //maak check voor als steriliseer proces klaar is

            if (completed)
                insertStatistic(info[1]);
        }

        private void insertStatistic(string menu_item_id)
        {
            FormMain.devPrint(menu_item_id);
            FormMain.execQuery("CALL sp_insertStatistic (" + menu_item_id + ")");
        }
    }
}
