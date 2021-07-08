using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Calendar
{
    public partial class Form_Home : Form
    {
        public Form_Home()
        {
            InitializeComponent();
        }

        private void Form_Home_Load(object sender, EventArgs e)
        {
           
        
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

        public void populateCalendar(List<DateTime> days)
        {
            int indice = 0;
            String day=getDayOfWeekFirst(days);
            if (day.Equals("Monday")){
                indice = 0;
            }
            if (day.Equals("Sunday")){
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
            if (day.Equals("Saturday"))
            {
                indice = 5;
            }

            for (int k = indice; k < days.Count; k++)
            {
                Button b = new Button();

                b.Dock = DockStyle.Fill;
                b.Text = days[k].Day.ToString();
               
                    tableLayoutPanel1.Controls.Add(b,k,1);
             
            }

        }
            

        private void button10_Click(object sender, EventArgs e)
        {
            
            populateCalendar(GetDaysOfMonth(2021,7));
        }
    }
           

      

      
    
    
}
