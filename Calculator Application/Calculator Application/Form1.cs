using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Application
{
    public partial class Form1 : Form
    {
        private double firstnum, secondnum;
        private string clear = "";
        public delegate void CalculateTotal(Form1 form, double firstnum, double secondnum);
        public Form1()
        {
            InitializeComponent();
            // Set default operator to addition
            SignCB.SelectedItem = "+";
        }

        private void CalculateBT_Click(object sender, EventArgs e)
        {
            //If the user type a letter in the text box
            if (!Double.TryParse(FirstnumTB.Text, out firstnum))
            {
                MessageBox.Show("Please enter a valid number in the first input.");
                return;
            }

            if (!Double.TryParse(SecondNumTB.Text, out secondnum))
            {
                MessageBox.Show("Please enter a valid number in the second input.");
                return;
            }
            firstnum = Convert.ToDouble(FirstnumTB.Text);
            secondnum = Convert.ToDouble(SecondNumTB.Text);

            string selectedOperation = SignCB.SelectedItem?.ToString() ?? "+";
            if (selectedOperation == "+")
            {
                EventClass.GetSum(this, firstnum, secondnum);
            }
            else if (selectedOperation == "-")
            {
                EventClass.GetDifference(this, firstnum, secondnum);
            }
            else if (selectedOperation == "*")
            {
                EventClass.GetTimes(this, firstnum, secondnum);
            }
            else if (selectedOperation == "/")
            {
                EventClass.GetDivide(this, firstnum, secondnum);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FirstnumTB.Text = clear;
            SecondNumTB.Text = clear;
            AnserTB.Text = clear;
        }

        class EventClass
        {
            public static void GetSum(Form1 form, double firstnum, double secondnum)
            {
                double total = firstnum + secondnum;
                form.AnserTB.Text = total.ToString();
            }

            public static void GetDifference(Form1 form, double firstnum, double secondnum)
            {
                double total = firstnum - secondnum;
                form.AnserTB.Text = total.ToString();
            }

            public static void GetTimes(Form1 form, double firstnum, double secondnum)
            {
                double total = firstnum * secondnum;
                form.AnserTB.Text = total.ToString();
            }

            public static void GetDivide(Form1 form, double firstnum, double secondnum)
            {
                // Check for division by zero
                if (secondnum == 0)
                {
                    MessageBox.Show("Error: Cannot divide by zero.");
                    form.AnserTB.Text = "Error"; 
                }
                else
                {
                    double total = firstnum / secondnum;
                    form.AnserTB.Text = total.ToString(); 
                }
            }
        }
    }
}