﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 a = new Form5();

                a.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();

            a.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 a = new Form5();

            a.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();

            a.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();

            a.Show();
            this.Close();
        }
    }
}
