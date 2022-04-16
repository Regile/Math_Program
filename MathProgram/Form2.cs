using System;
using System.Numerics;
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
    public partial class Form2 : Form
    {
        Form1 f1;
        Form3 f3;
        public Form2()
        {
            InitializeComponent();
        }

        private void точкиНаПлоскостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f1 = new Form1();
            f1.Show();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(textBox1.Text);
            double y1 = Convert.ToDouble(textBox2.Text);
            double x2 = Convert.ToDouble(textBox3.Text);
            double y2 = Convert.ToDouble(textBox4.Text);

            Complex c1 = new Complex(x1, y1);
            Complex c2 = new Complex(x2, y2);

            if(radioButton1.Checked)
            {
                textBox5.Text = Convert.ToString(Complex.Multiply(c1, c2));
            }

            if (radioButton2.Checked)
            {
                textBox5.Text = Convert.ToString(Complex.Add(c1, c2));
            }
        }

        private void энергияТелаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3 = new Form3();
            f3.Show();

        }
    }
}
