// Name: Brendan Woods
// Assnment: Assignment #8

using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string opt1 = string.Empty;
        string opt2 = string.Empty;

        char operatior;

        double output = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            this.txtBox.Text = "";
            input += "0";
            this.txtBox.Text += input;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.txtBox.Text = "";
            input += "1";
            this.txtBox.Text += input;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.txtBox.Text = "";
            input += "2";
            this.txtBox.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.txtBox.Text = "";
            input += "3";
            this.txtBox.Text += input;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.txtBox.Text = "";
            input += "4";
            this.txtBox.Text += input;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.txtBox.Text = "";
            input += "5";
            this.txtBox.Text += input;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.txtBox.Text = "";
            input += "6";
            this.txtBox.Text += input;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.txtBox.Text = "";
            input += "7";
            this.txtBox.Text += input;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.txtBox.Text = "";
            input += "8";
            this.txtBox.Text += input;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.txtBox.Text = "";
            input += "9";
            this.txtBox.Text += input;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            this.txtBox.Text = "";
            input += ".";
            this.txtBox.Text += input;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operatior = '/';
            opt1 = input;
            input = string.Empty;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operatior = '*';
            opt1 = input;
            input = string.Empty;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            operatior = '-';
            opt1 = input;
            input = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            operatior = '+';
            opt1 = input;
            input = string.Empty;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double num1, num2;

            opt2 = input;

            double.TryParse(opt1, out num1);
            double.TryParse(opt2, out num2);

            if (operatior == '+')
            {
                output = num1 + num2;
                txtBox.Text = output.ToString();

            } else if (operatior == '-') {
                
                output = num1 - num2;
                txtBox.Text = output.ToString();
            
            } else if (operatior == '*') {
                
                output = num1 * num2;
                txtBox.Text = output.ToString();
            
            } else if (opt1 == "/") {
                
                if (num2 != 0)
                {
                    output = num1 / num2;
                    txtBox.Text = output.ToString();
                
                } else {
                    
                    txtBox.Text = "Error: Divide by 0";
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtBox.Text = "";

            this.input = string.Empty;
            this.opt1 = string.Empty;
            this.opt2 = string.Empty;
        }
    }
}

