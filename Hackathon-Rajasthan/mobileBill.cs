using System;
using System.Windows.Forms;

namespace Hackathon_Rajasthan
{
    public partial class mobileBill : Form
    {
        public mobileBill(int mobileNumber, string emailId)
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            mobBill.Text = mobileNumber.ToString();
            emailBox.Text = emailId;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://rajasthan.gov.in/Pages/default.aspx");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://tourism.rajasthan.gov.in/");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://psychoticelites.com/");

        }

        private void loginBillsubmit_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (mobBill.Text=="")
            {
                MessageBox.Show("Check Mobile Number\n मोबाइल नंबर की जांच करें", "Check Mobile Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            //else if (int.TryParse(mobBill.Text, out parsedValue))
            //{
            //    MessageBox.Show("Check Mobile Number\n मोबाइल नंबर की जांच करें", "Check Mobile Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            else if(mobEmail.Text=="")
            {
                MessageBox.Show("Check E-Mail ID\n ईमेल आईडी की जांच करें", "Check E-mail ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Visible = false;
                PaymentAlternate p_alt = new PaymentAlternate();
                p_alt.Show();
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void mobileBill_Load(object sender, EventArgs e)
        {

        }
    }
}
