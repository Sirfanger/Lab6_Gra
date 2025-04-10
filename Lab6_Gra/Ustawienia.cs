using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Gra
{
    public partial class Ustawienia : Form
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int czas { get; private set; }

        public int dydlefy { get; private set; }

        public int krokodyle { get; private set; }

        public int szopy { get; private set; }
        public Ustawienia()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            X = int.Parse(textBox1.Text);
            Y = int.Parse(textBox2.Text);
            dydlefy = int.Parse(textBox4.Text);
            krokodyle = int.Parse(textBox3.Text);
            czas = int.Parse(textBox5.Text);
            szopy = int.Parse(textBox6.Text);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //X = int.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Y = int.Parse(textBox2.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //dydlefy = int.Parse(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //krokodyle = int.Parse(textBox3.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //czas = int.Parse(textBox5.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
