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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOperators_Click(object sender, EventArgs e)
        {
            FormOperators formOperators = new FormOperators();  // Створюємо нову форму
            formOperators.Show();  // Відображаємо форму
        }

        private void btnAgeCategory_Click(object sender, EventArgs e)
        {
            FormAgeCategory formAgeCategory = new FormAgeCategory();
            formAgeCategory.Show();
        }

        private void btnMultiplicationTable_Click(object sender, EventArgs e)
        {
            FormMultiplicationTable formMultiplicationTable = new FormMultiplicationTable();
            formMultiplicationTable.Show();
        }
    }
}
