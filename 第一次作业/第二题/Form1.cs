using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第二题
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A = Convert.ToDouble(a.Text);
            double B = Convert.ToDouble(b.Text);
            res.Text = Convert.ToString(A + B);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double A = Convert.ToDouble(a.Text);
            double B = Convert.ToDouble(b.Text);
            res.Text = Convert.ToString(A - B);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double A = Convert.ToDouble(a.Text);
            double B = Convert.ToDouble(b.Text);
            res.Text = Convert.ToString(A * B);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double A = Convert.ToDouble(a.Text);
            double B = Convert.ToDouble(b.Text);
            if (B == 0) res.Text = "被除数不能为0";
            else res.Text = Convert.ToString(A / B);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double A = Convert.ToDouble(a.Text);
            double B = Convert.ToDouble(b.Text);
            switch (comboBox1.Text)
            {
                case "+": res.Text = Convert.ToString(A + B); break;
                case "-": res.Text = Convert.ToString(A - B); break;
                case "*": res.Text = Convert.ToString(A * B); break;
                case "/":
                    if (B == 0) res.Text = "被除数不能为0";
                    else res.Text = Convert.ToString(A / B);
                    break;
            }
        }
    }
}
