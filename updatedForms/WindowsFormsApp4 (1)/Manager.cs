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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MProductDetail newDetail = new MProductDetail();
            newDetail.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Sales newPay = new Sales();
            newPay.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            NewMember newMem = new NewMember();
            newMem.Show();
            this.Hide();
        }
    }
}
