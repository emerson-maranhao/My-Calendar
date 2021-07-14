using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace My_Calendar
{
    public partial class Form_Home : Form
    {
        int currentDay = Int32.Parse(DateTime.Now.ToString("dd"));
        int currentMonth = Int32.Parse(DateTime.Now.ToString("MM"));
        int currentYear = Int32.Parse(DateTime.Now.ToString("yyyy"));

        public Form_Home()
        {
            InitializeComponent();
        }
        private void Form_Home_Load(object sender, EventArgs e)
        {

            currentMonth = Int32.Parse(DateTime.Now.ToString("MM"));
            PopulateCalendar(currentYear, currentMonth);
            DateTimeFormatInfo mfi = new DateTimeFormatInfo();
            string monthName = mfi.GetMonthName(currentMonth).ToString();
            lb_Month.Text = monthName + " " + currentYear.ToString();

            lbDay.Text = currentDay.ToString();
            lbNameDay.Text = DateTime.Now.ToString("ddddd", new CultureInfo("en-US")).ToUpper();
        }
        private List<DateTime> GetAllDaysOfMonth(int year, int month)
        {
            if (month < 1)
            {
                year = year - 1;
                month = 12;
            }
            if (month > 12)
            {
                year = year + 1;
                month = 1;
            }
            return Enumerable.Range(1, DateTime.DaysInMonth(year, month))
                             // Days: 1, 2 ... 31 etc.
                             .Select(day => new DateTime(year, month, day))
                             // Map each day to a date
                             .ToList(); // Load dates into a list
        }
        private String GetFirstDayOfMonth(List<DateTime> days)
        {
            return days[0].DayOfWeek.ToString();
        }
        private void PopulateCalendar(int currentYear, int currentMonth)
        {

            int indice = 0;
            List<DateTime> currentMonthDays = GetAllDaysOfMonth(currentYear, currentMonth);
            List<DateTime> previousMonthDays = GetAllDaysOfMonth(currentYear, currentMonth - 1);
            List<DateTime> forwardMonthDays = GetAllDaysOfMonth(currentYear, currentMonth + 1);
            String day = GetFirstDayOfMonth(currentMonthDays);

            indice = GetColumnPositionFromDayOfWeek(day);

            int fim = 0;
            int x = 0;

            tableLayoutPanelDays.Controls.Clear();

            for (int k = 0; k < currentMonthDays.Count; k++)
            {
                x = k + indice;
                Button b = new Button();

                b.Dock = DockStyle.Fill;
                if (currentMonthDays[k].Day.ToString().Length < 2)
                {
                    b.Text = "0" + currentMonthDays[k].Day.ToString();

                }
                else
                {
                    b.Text = currentMonthDays[k].Day.ToString();
                }

                tableLayoutPanelDays.Controls.Add(b, x, 0);

                b.Click += new System.EventHandler(this.ChildClickFromTableLayoutPanelDays);
            }
            fim = x;


            int start = indice;
            int end = currentMonthDays.Count;

            for (int j = previousMonthDays.Count; j > previousMonthDays.Count - start; j--)
            {
                Button b = new Button();
                b.Dock = DockStyle.Fill;
                b.BackColor = System.Drawing.Color.Transparent;
                b.Text = previousMonthDays[j - 1].Day.ToString();
                tableLayoutPanelDays.Controls.Add(b, indice - 1, 0);
                indice--;

            }
            var i = 0;
            for (int y = tableLayoutPanelDays.Controls.Count + 1; y < 42 + 1; y++)
            {

                Button b = new Button();
                b.Dock = DockStyle.Fill;
                b.FlatAppearance.BorderSize = 0;
                b.BackColor = System.Drawing.Color.Transparent;
                //b.FlatStyle = FlatStyle.Flat;
                b.Text = forwardMonthDays[i].Day.ToString();
                tableLayoutPanelDays.Controls.Add(b);
                i++;
            }
        }
        private void ChildClickFromTableLayoutPanelDays(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            lbDay.Text = button.Text;
            var col = tableLayoutPanelDays.Controls.GetChildIndex(button);

            int pos = GetChildPositionFromTableLayoutPanelDays(button);
            String nameDay = GetNameFromDayOfWeek(pos);
            lbNameDay.Text = nameDay.ToUpper();

        }
        private int GetChildPositionFromTableLayoutPanelDays(Button button)
        {
            return tableLayoutPanelDays.GetPositionFromControl(button).Column;

        }
        private int GetColumnPositionFromDayOfWeek(String day)
        {
            int indice = 0;
            if (day.Equals("Sunday"))
            {
                indice = 0;

            }
            if (day.Equals("Monday"))
            {
                indice = 1;
            }

            if (day.Equals("Tuesday"))
            {
                indice = 2;

            }
            if (day.Equals("Wednesday"))
            {
                indice = 3;

            }
            if (day.Equals("Thursday"))
            {
                indice = 4;

            }
            if (day.Equals("Friday"))
            {
                indice = 5;

            }
            if (day.Equals("Saturday"))
            {
                indice = 6;

            }
            return indice;
        }
        private String GetNameFromDayOfWeek(int position)
        {
            String name = "";
            if (position == 0)
            {
                name = "Sunday";

            }
            if (position == 1)
            {
                name = "Monday";
            }

            if (position == 2)
            {
                name = "Tuesday";

            }
            if (position == 3)
            {
                name = "Wednesday";

            }
            if (position == 4)
            {
                name = "Thursday";

            }
            if (position == 5)
            {
                name = "Friday";

            }
            if (position == 6)
            {
                name = "Saturday";

            }
            return name;
        }
        private void PreviousMonth_Click(object sender, EventArgs e)
        {
            currentMonth = currentMonth - 1;

            if (currentMonth < 1)
            {
                currentMonth = 12;
                currentYear = currentYear - 1;
            }
            PopulateCalendar(currentYear, currentMonth);
            DateTimeFormatInfo mfi = new DateTimeFormatInfo();
            string monthName = mfi.GetMonthName(currentMonth).ToString();
            lb_Month.Text = monthName + " " + currentYear.ToString();


        }
        private void ForwardMonth_Click(object sender, EventArgs e)
        {
            currentMonth = currentMonth + 1;
            if (currentMonth > 12)
            {
                currentMonth = 1;
                currentYear = currentYear + 1;

            }
            PopulateCalendar(currentYear, currentMonth);
            DateTimeFormatInfo mfi = new DateTimeFormatInfo();
            string monthName = mfi.GetMonthName(currentMonth).ToString();
            lb_Month.Text = monthName + " " + currentYear.ToString();

        }

    }
}
