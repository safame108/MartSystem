using System;
using BusinessLayer;
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
            ProductBL p = new ProductBL();
            dataGridView1.DataSource = p.Sales();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mail.google.com/mail/mu/mp/519/#tl/priority/%5Esmartlabel_personal");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
