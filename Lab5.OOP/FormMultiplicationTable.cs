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
    public partial class FormMultiplicationTable : Form
    {
        public FormMultiplicationTable()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();  // Закриває поточну форму
        }

        private void btnGenerateTable_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(numberTextBox.Text);  // Отримуємо число

            resultListBox.Items.Clear();  // Очищуємо попередні результати

            for (int i = 1; i <= 10; i++)  // Створюємо таблицю множення
            {
                resultListBox.Items.Add($"{number} x {i} = {number * i}");
            }
        }
    }
}
