﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_1_19PyzhovDK
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ab = new Form1();
            ab.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 abo = new Form2();
            abo.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 abob = new Form3();
            abob.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 abobu = new Form4();
            abobu.ShowDialog();
        }
    }
}
