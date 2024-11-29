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
    public partial class Speed : Form
    {
        public Speed()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (double.TryParse(textBox2.Text, out double V0) &&
                    double.TryParse(textBox3.Text, out double a) &&
                    double.TryParse(textBox4.Text, out double t))
                {
                    // Вычисление скорости V
                    double V = V0 + a * t;

                    // Вычисление пройденного расстояния S
                    double S = V0 * t + 0.5 * a * t * t;

                    // Формируем результат
                    string resultText = $"Конечная скорость V: {V:F2} м/с\r\nРасстояние S: {S:F2} м";

                    // Устанавливаем результат в textBox5
                    textBox5.Text = resultText;
                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите корректные числовые значения.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
