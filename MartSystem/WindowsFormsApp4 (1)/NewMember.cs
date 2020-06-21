using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BusinessLayer;
using BuisnessObject;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class NewMember : Form
    {
        public NewMember()
        {
            InitializeComponent();
        }

        private void New_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeBO E = new EmployeeBO();
            EmployeeDetails ED = new EmployeeDetails();
            SignUp Signup = new SignUp();

            //DateTime d = new DateTime();
            E.EmployeeID = int.Parse(textBox1.Text);
            E.FirstName = textBox7.Text;
            E.LastName = textBox6.Text;
            E.ContactNumber = textBox8.Text;
            E.Address = textBox9.Text;
            //E.HireDate = (d.Date).ToString();
            E.AccNumber = textBox10.Text;

            ED.Job_ID = int.Parse(textBox5.Text);
            ED.Branch_ID = int.Parse(textBox4.Text);
            ED.Department_ID = int.Parse(textBox3.Text);
            ED.Employee_ID = int.Parse(textBox1.Text);

            Signup.ID = int.Parse(textBox1.Text);
            Signup.Username = textBox11.Text;
            Signup.Password = textBox2.Text;
            Signup.Email = textBox12.Text;

            EmployeeBL emd = new EmployeeBL();
            emd.AddEmployee(E, ED, Signup);

            this.Hide();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
