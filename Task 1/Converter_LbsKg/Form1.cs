using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter_LbsKg
{
    public partial class Form1 : Form
    {
        double Lbs, Kg;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lbs = 0; Kg = 0;
            if (comboBox1.SelectedIndex == 0)
            {
                Kg = Convert.ToDouble(textBox1.Text);
                Lbs = Kg / 2.2;
                textBox1.Text = Lbs.ToString();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Lbs = Convert.ToDouble(textBox1.Text);
                Kg = Lbs * 2.2;
                textBox1.Text = Kg.ToString();
            }
            else
            {
                textBox1.Text = "NOT VALID";
            }
        }
    }
}
