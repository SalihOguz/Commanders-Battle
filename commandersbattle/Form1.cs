using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace commandersbattle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string ad1, ad2, ad3, ad4;

        private void button1_Click(object sender, EventArgs e)
        {
            ad1 = textBox1.Text;
            ad2 = textBox2.Text;
            ad3 = textBox3.Text;
            ad4 = textBox4.Text;
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ad1 = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ad2 = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ad3 = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            ad4 = textBox4.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }
    }
}
