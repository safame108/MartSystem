﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MProductDetail newPro = new MProductDetail();
            newPro.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            NewMember newMEMB = new NewMember();
            newMEMB.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Salary_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
