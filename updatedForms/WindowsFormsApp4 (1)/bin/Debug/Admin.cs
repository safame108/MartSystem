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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            NewMember newMember = new NewMember();
            newMember.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Products newProduct = new Products();
            newProduct.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Warning newWarnings = new Warning();
            newWarnings.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MemberDetails newDetails = new MemberDetails();
            newDetails.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
