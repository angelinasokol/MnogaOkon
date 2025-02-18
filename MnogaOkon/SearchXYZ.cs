﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MnogaOkon
{
    public partial class SearchXYZ : Form
    {
        public SearchXYZ()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main fr2 = new Main();
            fr2.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A, B;
            if (!double.TryParse(textBox3.Text, out A) || !double.TryParse(textBox4.Text, out B))
            {
                MessageBox.Show("Пожалуйста, введите действительные числа для A и B.");
                return;
            }

            double X = 0, Y = 0, Z = 0;

            // Определите, какая формула была выбрана пользователем в ComboBox.
            switch (comboBox1.SelectedItem.ToString())
            {
                case "X = A + B":
                    X = A + B;
                    break;
                case "Y = A / B":
                    if (B == 0)
                    {
                        MessageBox.Show("Деление на ноль невозможно.");
                        return;
                    }
                    Y = A / B;
                    break;
                case "Z = A * B":
                    Z = A * B;
                    break;
                default:
                    MessageBox.Show("Пожалуйста, выберите формулу.");
                    return;
            }

            textBox2.Text = $"X = {X}\r\nY = {Y}\r\nZ = {Z}";
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
