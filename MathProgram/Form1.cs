using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathProgram
{
    public partial class Form1 : Form
    {
        Form3 f3;
        Form2 f2;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void точкиНаПлоскостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private double Interval(int Ax, int Ay, int Bx, int By)
        {
            double res = Math.Sqrt(Math.Pow((Bx - Ax), 2) + Math.Pow((By - Ay), 2));
            return (res);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Ax = Convert.ToInt32(textBox2.Text);
            int Ay = Convert.ToInt32(textBox1.Text);

            int Bx = Convert.ToInt32(textBox3.Text);
            int By = Convert.ToInt32(textBox4.Text);

            textBox5.Text = Convert.ToString(Interval(Ax, Ay, Bx, By));
        }
        private void комплексныеЧислаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2 = new Form2();
            f2.Show();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void энергияТелаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3 = new Form3();
            f3.Show();
        }
    }
}
