using System;
using System.Windows.Forms;

namespace Hackathon_Rajasthan
{
    public partial class ElectricityBill : Form
    {
        public ElectricityBill(string emailID, string kNumber, int phoneNumber)
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            elecKno.Text = kNumber;
            elecMob.Text = phoneNumber.ToString();
            elecEmail.Text = emailID;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void reg_submit_Click(object sender, EventArgs e)
        {
            Visible = false;
            PaymentAlternate p_obj = new PaymentAlternate();
            p_obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
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

        private void ElectricityBill_Load(object sender, EventArgs e)
        {

        }

        private void elecKno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
