using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

            populateStatsPanel( DateTime.Now.Date.ToShortDateString());

            statisticsDateLabel.Text = DateTime.Now.ToString("d MMMM, yyyy");

            statisticsCalendar.MaxDate = DateTime.Now; //no statistics for future days
        }

        private void StatisticsCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime date = statisticsCalendar.SelectionRange.Start;

            populateStatsPanel(date.ToShortDateString() );

            statisticsDateLabel.Text = date.ToString("d MMMM, yyyy");
        }

        private void populateStatsPanel(string date)
        {
            DateTime dt = DateTime.ParseExact(date, "d-MM-yyyy", CultureInfo.InvariantCulture);
            date = dt.ToString("yyyy-MM-dd");

            DataTable stats = FormMain.execQuery("SELECT stats.id, stats.date_of_use, stats.time_of_use, mi.name FROM statistic AS stats LEFT JOIN menu_item AS mi ON stats.menu_item_id = mi.id where stats.date_of_use = '"+date+"' order by time_of_use DESC;");

            if (stats.Rows.Count == 0) // no stats found
            {
                statisticsGrid.DataSource = null;
                statsNoResultLabel.Visible = true;
                return;
            }

            statsNoResultLabel.Visible = false;

            statisticsGrid.DataSource = stats;
            statisticsGrid.Columns["date_of_use"].Visible = false;

            statisticsGrid.Columns["time_of_use"].HeaderText = "Tijd";
            statisticsGrid.Columns["name"].HeaderText = "Naam";

            statisticsGrid.RowHeadersVisible = false;

        }
    }
}
