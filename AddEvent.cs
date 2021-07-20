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
    public partial class AddEvent : Form
    {
        int hour = 0;
        int min = 0;
        Calendar calendar;
        public AddEvent(Calendar c)
        {

            InitializeComponent();
            calendar = c;
        }

        private void AddEvent_Load(object sender, EventArgs e)
        {

            lbHour.Text = AddZeroBegin(hour);
            lbMin.Text = AddZeroBegin(min);

            btnHourUp.Text = char.ConvertFromUtf32(0x02C4);
            btnMinUp.Text = char.ConvertFromUtf32(0x02C4);
            btnHourDown.Text = char.ConvertFromUtf32(0x02C5);
            btnMinDown.Text = char.ConvertFromUtf32(0x02C5);
        }



        private void lbMinUp_Click(object sender, EventArgs e)
        {
            if (min < 59)
            {
                min = min + 1;
                lbMin.Text = min.ToString();
            }
            else
            {
                min = 00;
                lbMin.Text = min.ToString();

            }
        }


        private void lbMinDown_Click(object sender, EventArgs e)
        {
            if (min > 0)
            {
                min = min - 1;
                lbMin.Text = min.ToString();
            }
            else
            {
                min = 59;
                lbMin.Text = min.ToString();

            }

        }

        private void btnHourUp_Click(object sender, EventArgs e)
        {
            lbMin.BackColor = Color.White;

            lbHour.BackColor = Color.LightGray;
            if (hour < 23)
            {
                hour = hour + 1;

                lbHour.Text = AddZeroBegin(hour);
            }
            else
            {
                hour = 00;
                lbHour.Text = AddZeroBegin(hour);


            }
        }

        private void btnHourDown_Click(object sender, EventArgs e)
        {
            lbMin.BackColor = Color.White;

            lbHour.BackColor = Color.LightGray;
            if (hour > 0)
            {
                hour = hour - 1;
                lbHour.Text = AddZeroBegin(hour);
            }
            else
            {
                hour = 23;
                lbHour.Text = AddZeroBegin(hour);

            }
        }

        private void btnMinUp_Click(object sender, EventArgs e)
        {
            lbMin.BackColor = Color.LightGray;

            lbHour.BackColor = Color.White;

            if (min < 59)

            {
                

                min = min + 1;
                lbMin.Text = AddZeroBegin(min);
            }
            else
            {
                min = 00;
                lbMin.Text = AddZeroBegin(min);

            }
        }
        private void btnMinDown_Click(object sender, EventArgs e)
        {
            lbMin.BackColor = Color.LightGray;

            lbHour.BackColor = Color.White;
            if (min > 0)
            {
                min = min - 1;
                lbMin.Text = AddZeroBegin(min);
            }
            else
            {
                min = 59;
                lbMin.Text = AddZeroBegin(min);

            }
        }
        private string AddZeroBegin(int num)
        {
            string text = "";
            if (num.ToString().Length < 2)
            {
                text = "0" + num.ToString();
            }
            else
            {
                text = num.ToString();
            }
            return text;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (min > 0)
            {
                min = min - 1;
                lbMin.Text = AddZeroBegin(min);
            }
            else
            {
                min = 59;
                lbMin.Text = AddZeroBegin(min);

            }
        }



        private void lbHour_Click(object sender, EventArgs e)
        {
            lbMin.BackColor = Color.White;

            lbHour.BackColor = Color.LightGray;
        }

        private void lbMin_Click(object sender, EventArgs e)
        {
            lbHour.BackColor = Color.White;

            lbMin.BackColor = Color.LightGray;

        }

        private void btnSaveEvent_Click(object sender, EventArgs e)
        {
            if (tbDescription.Text.Length<1)
            {
                MessageBox.Show("Write a description to the event!");
               
            }
            else
            {
                calendar.AddNewEvent(lbHour.Text, lbMin.Text, tbDescription.Text);
                this.Close();
            }
            
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            calendar.Opacity = 100;

        }
    }

}
