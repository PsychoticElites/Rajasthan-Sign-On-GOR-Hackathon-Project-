using System;
using System.Windows.Forms;

namespace Hackathon_Rajasthan
{
    public partial class Registry_Intermediate : Form
    {
        public Registry_Intermediate()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void reg_aadhar_TextChanged(object sender, EventArgs e)
        {

        }

        private void int_submit_Click(object sender, EventArgs e)
        {
            int varlength = inter_bid.Text.Length;
            int adlength = int_aadhar.TextLength;
            //string bmsID = inter_bid.Text;
            //string adharID = int_aadhar.Text;
            int parsedValue;
            Register r_obj = new Register();
            Intermediate_Error inter_obj = new Intermediate_Error();
            Error_Message e_obj = new Error_Message();
            if (varlength == 0)
            {
                MessageBox.Show("Check your Bhamashah ID\nअपने भामाशाह आईडी की जांच करें", "Check E-mail ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //if (int.TryParse(inter_bid.Text, out parsedValue))
            //{
            //    MessageBox.Show("Check your Bhamashah ID\nअपने भामाशाह आईडी की जांच करें", "Check E-mail ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            else if (adlength == 0)
            {
                MessageBox.Show("Check your Aadhar ID\n अपना आधार आईडी देखें", "Check Aadhar ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (interBankacc.TextLength == 0)
            {
                MessageBox.Show("Check your Bank Account Number \nअपना बैंक खाता नंबर जांचें", "Check Bank Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (intKno.TextLength == 0)
            {
                MessageBox.Show("Check your K NO. \nअपना K No. जांचें", "Check K No.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (varlength == 7)
            {
                r_obj.bmsID = inter_bid.Text;
                r_obj.adharID = int_aadhar.Text;
                r_obj.kNo = intKno.Text;
                r_obj.bankAccount = interBankacc.Text;
                MessageBox.Show(r_obj.bankAccount, interBankacc.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("DONE", "DONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Visible = false;
                r_obj.Show();
            }
            else if (varlength == 15)
            {
                inter_obj.ShowDialog();
            }
            else
            {

                e_obj.ShowDialog();
            }
            int aad_Val = int_aadhar.Text.Length;
            if(aad_Val != 12)
            {
                e_obj.ShowDialog();
            }
        }

        private void Registry_Intermediate_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
