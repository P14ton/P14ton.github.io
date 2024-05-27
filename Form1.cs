using System;
using System.Windows.Forms;

namespace calculate
{
    public partial class Form1 : Form
    {
        double a = 0, b = 0, c = 0;
        char znak = '+';

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

        private void buttonNegate_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox1.Text[0] == '-')
                {
                    textBox1.Text = textBox1.Text.Remove(0, 1);
                }
                else
                {
                    textBox1.Text = '-' + textBox1.Text;
                }
            }
        }

        private void buttonOperator_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            znak = (sender as Button).Text[0];
            textBox1.Clear();
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);
            switch (znak)
            {
                case '+':
                    c = a + b;
                    break;
                case '-':
                    c = a - b;
                    break;
                case '/':
                    if (b != 0)
                    {
                        c = a / b;
                    }
                    else
                    {
                        MessageBox.Show("You cannot divide by zero!");
                        textBox1.Text = "error";
                        return;
                    }
                    break;
                case 'X':
                    c = a * b;
                    break;
            }
            textBox1.Text = c.ToString();
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Math.Sin(value).ToString();
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Math.Cos(value).ToString();
        }

        private void buttonTan_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Math.Tan(value).ToString();
        }
    }
}
