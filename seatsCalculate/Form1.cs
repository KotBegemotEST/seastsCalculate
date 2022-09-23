using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seatsCalculate
{

   

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int field1 = 0;
        int field2 = 0;
        int field3 = 0;
        double summ = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Total_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            field1 = Int32.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            field2 = Int32.Parse(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            field3 = Int32.Parse(textBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (field1 != 0 )
            {
                int fieldOneSumm = (field1 * 15);
                label8.Text = "$" +  fieldOneSumm.ToString("n2");

                summ += (field1 * 15);
            }
            if (field2 != 0)
            {
                int fieldTwoSumm = (field2 * 12);
                label9.Text = "$" + fieldTwoSumm.ToString("n2");

                summ +=(field2 * 12);
            }
            if (field3 != 0)
            {
                int fieldThreeSumm = (field3 * 9);
                label10.Text = "$" + fieldThreeSumm.ToString("n2");

                summ +=(field3 * 9);
            }
            label11.Text = "$" + summ.ToString("n2");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";

            label8.Text = "$00.00";
            label9.Text = "$00.00";
            label10.Text = "$00.00";
            label11.Text = "$00.00";

            field1 = 0;
            field2 = 0;
            field3 = 0;
            summ = 0;
        }
    }
}
