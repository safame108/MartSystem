using System;
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
    public partial class MemberDetails : Form
    {
        public MemberDetails()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            NewMember newmemb = new NewMember();
            newmemb.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Products newProduct = new Products();
            newProduct.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Warning newwarn = new Warning();
            newwarn.Show();
            this.Hide();
        }
    }
}
