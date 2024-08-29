using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsFormApp
{
    public partial class CalculatorWindowsFormApp : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;
        public CalculatorWindowsFormApp()
        {
            InitializeComponent();
        }

        private void zero_Click(object sender, EventArgs e)
        {
            inputButton('0');
        }

        private void one_Click(object sender, EventArgs e)
        {
            inputButton('1');
        }

        private void two_Click(object sender, EventArgs e)
        {
            inputButton('2');
        }

        private void three_Click(object sender, EventArgs e)
        {
            inputButton('3');
        }

        private void four_Click(object sender, EventArgs e)
        {
            inputButton('4');
        }

        private void five_Click(object sender, EventArgs e)
        {
            inputButton('5');
        }

        private void six_Click(object sender, EventArgs e)
        {
            inputButton('6');
        }

        private void seven_Click(object sender, EventArgs e)
        {
            inputButton('7');
        }

        private void eight_Click(object sender, EventArgs e)
        {
            inputButton('8');
        }

        private void nine_Click(object sender, EventArgs e)
        {
            inputButton('9');
        }

        private void period_Click(object sender, EventArgs e)
        {
            inputButton('.');
        }

        //meant to be "slash", but too late now
        private void dash_Click(object sender, EventArgs e)
        {
            operationEnd('/');
        }

        private void star_Click(object sender, EventArgs e)
        {
            operationEnd('*');
        }

        private void plus_Click(object sender, EventArgs e)
        {
            operationEnd('+');
        }

        private void minus_Click(object sender, EventArgs e)
        {
            operationEnd('-');
        }
        private void exponent_Click(object sender, EventArgs e)
        {
            operationEnd('^');
        }

        private void sine_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            operand1 = "1";
            operation = 's';
            input = "";
            this.display.Text = "sin";
        }

        private void cosine_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            operand1 = "1";
            operation = 'c';
            input = "";
            this.display.Text = "cos";
        }

        private void tangent_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            operand1 = "1";
            operation = 't';
            input = "";
            this.display.Text = "tan";
        }

        //COME BACK TO THIS

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '.':
                    inputButton(e.KeyChar);
                    break;
                case '+':
                case '-':
                case '*':
                case '/':
                case '^':
                    operationEnd(e.KeyChar);
                    break;
            }
        }

        private void enter_Click(object sender, EventArgs e)
        {
            operand2 = input;
            lblExpression.Text += " " + input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                display.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                display.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                display.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    display.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("You already know it doesn't work");
                }
            }
            else if (operation == '^')
            {
                result = Math.Pow(num1, num2);
                display.Text = result.ToString();
            }
            else if (operation == 's')
            {
                result = Math.Sin(num2);
                display.Text = result.ToString();
            }
            else if (operation == 'c')
            {
                result = Math.Cos(num2);
                display.Text = result.ToString();
            }
            else if (operation == 't')
            {
                result = Math.Tan(num2);
                display.Text = result.ToString();
            }
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void operationEnd(char c)
        {
            operand1 = input;
            operation = c;
            lblExpression.Text = input + " " + operation;
            input = string.Empty;
        }

        private void inputButton(char c)
        {
            this.display.Text = "";
            input += c;
            this.display.Text += input;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            this.lblExpression.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            try
            {
                if (input.Length > 0)
                {
                    input = input.Remove(input.Length - 1);
                    display.Text = input;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong and I don't know why. Here's a bunch of text");
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.C)
            {
                this.display.Text = "";
                this.lblExpression.Text = "";
                this.input = string.Empty;
                this.operand1 = string.Empty;
                this.operand2 = string.Empty;
            }
        }

       
    }
}
