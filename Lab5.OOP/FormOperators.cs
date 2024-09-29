using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5.OOP
{
    public partial class FormOperators : Form
    {
        public FormOperators()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);  // Отримуємо перше число
            double num2 = Convert.ToDouble(textBox2.Text);  // Отримуємо друге число
            double result = num1 + num2;  // Додаємо числа
            resultTextBox.Text = result.ToString();  // Виводимо результат
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {

            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = num1 - num2;
            resultTextBox.Text = result.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = num1 * num2;
            resultTextBox.Text = result.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            if (num2 != 0)
            {
                double result = num1 / num2;
                resultTextBox.Text = result.ToString();
            }
            else
            {
                resultTextBox.Text = "Ділення на нуль неможливе!";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();  // Закриває поточну форму
        }
    }
}
