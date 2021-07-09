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

namespace My_Calendar
{
    public partial class Form_Home : Form
    {
        int month = Int32.Parse(DateTime.Now.ToString("MM"));
        public Form_Home()
        {
            InitializeComponent();
        }

        private void Form_Home_Load(object sender, EventArgs e)
        {

            month = Int32.Parse(DateTime.Now.ToString("MM"));
            PopulateCalendar(GetDaysOfMonth(2021, month));
            DateTimeFormatInfo mfi = new DateTimeFormatInfo();
            string monthName = mfi.GetMonthName(month).ToString();
            lb_Month.Text = monthName;

        }

        public List<DateTime> GetDaysOfMonth(int year, int month)
        {
            return Enumerable.Range(1, DateTime.DaysInMonth(year, month))
                             // Days: 1, 2 ... 31 etc.
                             .Select(day => new DateTime(year, month, day))
                             // Map each day to a date
                             .ToList(); // Load dates into a list
        }
        //(List<DateTime> days
        public String getDayOfWeekFirst(List<DateTime> days)
        {
            //var days = GetDaysOfMonth(2021, 7);
            return days[0].DayOfWeek.ToString();
        }

        public void PopulateCalendar(List<DateTime> days)
        {
            tableLayoutPanelDays.Controls.Clear();


            int indice = 0;
            String day=getDayOfWeekFirst(days);
            if (day.Equals("Sunday"))
            {
                indice = 0;

            }
            if (day.Equals("Monday")){
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

            for (int k = 0; k < days.Count; k++)
            {
                int x = k+indice;
                
                Button b = new Button();

                b.Dock = DockStyle.Fill;
                b.Text = days[k].Day.ToString();

                

                tableLayoutPanelDays.Controls.Add(b,x,0);
             
            }

        }
        

        private void btn_PreviousMonth_Click(object sender, EventArgs e)
        {
            month = month - 1;
            PopulateCalendar(GetDaysOfMonth(2021, month));
            System.Globalization.DateTimeFormatInfo mfi = new System.Globalization.DateTimeFormatInfo();
            string monthName = mfi.GetMonthName(month).ToString();
            lb_Month.Text = monthName;
        }

        private void btn_ForwardMonth_Click(object sender, EventArgs e)
        {
            month = month + 1;
            PopulateCalendar(GetDaysOfMonth(2021, month));
            System.Globalization.DateTimeFormatInfo mfi = new System.Globalization.DateTimeFormatInfo();
            string monthName = mfi.GetMonthName(month).ToString();
            lb_Month.Text = monthName;

        }

        
    }
           

      

      
    
    
}
