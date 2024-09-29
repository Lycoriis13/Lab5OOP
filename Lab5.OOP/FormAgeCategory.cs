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
    public partial class FormAgeCategory : Form
    {
        public FormAgeCategory()
        {
            InitializeComponent();
        }

        private void btnCheckAge_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(ageTextBox.Text);  // Отримуємо вік користувача

            if (age < 12)
                resultLabel.Text = "Дитина";
            else if (age < 18)
                resultLabel.Text = "Підліток";
            else
                resultLabel.Text = "Дорослий";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();  // Закриває поточну форму
        }
    }
}
