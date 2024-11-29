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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.ContextMenuStrip = contextMenuStrip1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Gipotenuza fr2 = new Gipotenuza();
            fr2.Show();
            Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Speed fr2 = new Speed();
            fr2.Show();
            Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SearchY fr2 = new SearchY();
            fr2.Show();
            Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SearchXYZ fr2 = new SearchXYZ();
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

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Gipotenuza fr2 = new Gipotenuza();
            fr2.Show();
            Hide();
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Speed fr2 = new Speed();
            fr2.Show();
            Hide();
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SearchY fr2 = new SearchY();
            fr2.Show();
            Hide();
        }

        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            SearchXYZ fr2 = new SearchXYZ();
            fr2.Show();
            Hide();
        }

        private void вЫЙТИToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void всеЗадачиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Обработчики событий для MenuStrip
    }

}
