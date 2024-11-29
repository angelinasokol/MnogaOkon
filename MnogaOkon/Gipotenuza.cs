using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MnogaOkon
{
    public partial class Gipotenuza : Form
    {
        public Gipotenuza()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получите значения катетов из текстовых полей
            if (double.TryParse(textBox2.Text, out double sideA) && double.TryParse(textBox3.Text, out double sideB))
            {
                // Проверьте, что введенные значения положительны
                if (sideA > 0 && sideB > 0)
                {
                    // Вычислите гипотенузу
                    double hypotenuse = Math.Sqrt(sideA * sideA + sideB * sideB);

                    // Выведите результат на метку
                    textBox4.Text = $"Гипотенуза C = {hypotenuse:F2}";
                }
                else
                {
                    MessageBox.Show("Значения катетов должны быть положительными числами.");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения для катетов.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main fr2 = new Main();
            fr2.Show();
            Hide();
        }
        private void найтиГипотенузуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gipotenuza fr2 = new Gipotenuza();
            fr2.Show();
            Hide();
        }

        private void найтиСкоростьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Speed fr2 = new Speed();
            fr2.Show();
            Hide();
        }

        private void вычислитьYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchY fr2 = new SearchY();
            fr2.Show();
            Hide();
        }

        private void вычислитьXYZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchXYZ fr2 = new SearchXYZ();
            fr2.Show();
            Hide();
        }

        private void вЫЙТИToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
