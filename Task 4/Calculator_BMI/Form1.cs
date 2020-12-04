using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHeight.Text = "";
            txtWeight.Text = "";
            txtResult.Text = "";
            radKg.Checked  = false;
            radLbs.Checked = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(txtWeight.Text);
            double height = Convert.ToDouble(txtHeight.Text);
            double result = 0.00;
            string result2 = "";

            if (radKg.Checked)
            {
                result = weight / (height * height);
            }
            else if (radLbs.Checked)
            {
                weight = weight / 2.205;
                result = weight / (height * height);
            }

            if (result < 18.5)
            {
                result2 = "- Underweight.";
            }
            else if (result < 25)
            {
                result2 = "- Normal Weight.";
            }
            else if (result < 30)
            {
                result2 = "- Overweight.";
            }
            else if (result >= 30)
            {
                result2 = "- Obese.";
            }

            txtResult.Text = "Your BMI is: " + result.ToString("#.#") + "\r\n" + result2;
        }
    }
}
