using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createTaskButton_Click(object sender, EventArgs e)
        {
            if (firstNameBox.Text.Length == 0 || lastNameBox.Text.Length == 0 || patronymicBox.Text.Length == 0 || !classBox.Items.Contains(classBox.Text))
            {
                MessageBox.Show("Введите все данные корректно.");
                return;
            }
            if (!easyRadioButton.Checked && !hardRadioButton.Checked)
            {
                MessageBox.Show("Выберите сложность.");
                return;
            }
            string info = firstNameBox.Text + " " + lastNameBox.Text + " " + patronymicBox.Text;
            Form2 form2 = new Form2(info, classBox.Text, numOfTasks.Value, easyRadioButton.Checked, hardRadioButton.Checked);
            form2.Show();
        }
    }
}
