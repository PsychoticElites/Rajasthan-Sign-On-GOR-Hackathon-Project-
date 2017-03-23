using System;
using System.Windows.Forms;

namespace Hackathon_Rajasthan
{
    public partial class InitialScreen : Form
    {
        public InitialScreen()
        {
            InitializeComponent();
        }

        private void button_newreg_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Registry_Intermediate obj = new Registry_Intermediate();
            obj.Show();
        }

        private void button_oldreg_Click(object sender, EventArgs e)
        {
            ExisitngUser obj = new ExisitngUser();
            obj.Show();
        }

        private void InitialScreen_Load(object sender, EventArgs e)
        {
            //Application.Exit();
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:bhamashah@rajasthan.gov.in");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            AboutPage about_Obj = new AboutPage();
            about_Obj.Show();
        }
    }
}
