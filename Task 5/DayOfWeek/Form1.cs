using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayOfWeek
{
    public partial class Form1 : Form
    {
        int MonthCode, CenturyCode, LeapYearCode, DayofWeek;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int YY, YearCode, date;
            MonthCode = 0; CenturyCode = 0; LeapYearCode = 0;

            date = Convert.ToInt32(textBox1.Text);
            YY = Convert.ToInt32(textBox2.Text);

            YearCode = (YY + (YY / 4)) % 7;

            /* Conditional Statement to determine Month Code
            January = 0
            February = 3
            March = 3
            April = 6
            May = 1
            June = 4
            July = 6
            August = 2
            September = 5
            October = 0
            November = 3
            December = 5
            */
            if (comboBox1.SelectedIndex == 0)
            {
                MonthCode = 0;
               
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                MonthCode = 3;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                MonthCode = 3;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                MonthCode = 6;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                MonthCode = 1;
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                MonthCode = 4;
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                MonthCode = 6;
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                MonthCode = 2;
            }
            else if (comboBox1.SelectedIndex == 8)
            {
                MonthCode = 5;
            }
            else if (comboBox1.SelectedIndex == 9)
            {
                MonthCode = 0;
            }
            else if (comboBox1.SelectedIndex == 10)
            {
                MonthCode = 3;
            }
            else if (comboBox1.SelectedIndex == 11)
            {
                MonthCode = 5;
            }

            /* Conditional Statement to determine the Century Code
             * 1700s = 4, 1800s = 2, 1900s = 0, 2000s = 6, 2100s = 4, 2200s = 2, 2300s = 0
            */
            if (comboBox2.SelectedIndex == 0)
            {
                CenturyCode = 4;
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                CenturyCode = 2;
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                CenturyCode = 0;
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                CenturyCode = 6;
            }
            else if (comboBox2.SelectedIndex == 4)
            {
                CenturyCode = 4;
            }
            else if (comboBox2.SelectedIndex == 5)
            {
                CenturyCode = 2;
            }
            else if (comboBox2.SelectedIndex == 6)
            {
                CenturyCode = 0;
            }

            /* Conditonal Statement to determine the Leap Year Code 
              LeapYear YES = 1
              LeapYear NO = 0
            */
            if (comboBox3.SelectedIndex == 0)
            {
                LeapYearCode = 0;
            }
            else if (comboBox3.SelectedIndex == 1)
            {
                LeapYearCode = 1;
            }

            DayofWeek = (YearCode + MonthCode + CenturyCode + date - LeapYearCode) % 7;

            // Condiitonal Statement to determine the Day of Week from result obtained
            if (DayofWeek == 0)
            {
                textBox3.Text = ("Sunday");
            }
            else if (DayofWeek == 1)
            {
                textBox3.Text = ("Monday");
            }
            else if (DayofWeek == 2)
            {
                textBox3.Text = ("Tuesday");
            }
            else if (DayofWeek == 3)
            {
                textBox3.Text = ("Wednesday");
            }
            else if (DayofWeek == 4)
            {
                textBox3.Text = ("Thursday");
            }
            else if (DayofWeek == 5)
            {
                textBox3.Text = ("Friday");
            }
            else if (DayofWeek == 6)
            {
                textBox3.Text = ("Saturday");
            }
        }
    }
}
