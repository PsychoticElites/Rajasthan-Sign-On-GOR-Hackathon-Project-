using Newtonsoft.Json;
using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Hackathon_Rajasthan
{
    public partial class PayBills : Form
    {
        private string nameOfUser, passwordOfUser;
        public PayBills(string userName, string Password)
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            nameOfUser = userName;
            passwordOfUser = Password;
            
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void loginPhedbill_Click(object sender, EventArgs e)
        {
            //phedbill p_obj = new phedbill();
            //p_obj.Show();
        }

        private void loginElectricitybill_Click(object sender, EventArgs e)
        {
            string infoFetchUrl = "https://dmitra.000webhostapp.com/registration/registration/userDataFetcher.php";

            using (var wb = new WebClient())
            {
                var data = new NameValueCollection();
                data["userName"] = nameOfUser;
                data["passWord"] = passwordOfUser;

                var response = wb.UploadValues(infoFetchUrl, "POST", data);
                Console.WriteLine("This is the shitnit : " + response);
                //MessageBox.Show(response, "JSON Reply", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //string result = System.Text.Encoding.UTF8.GetString(response);
                //Console.WriteLine("This is something amazhing : " + result);
                var webPageResponse = Encoding.ASCII.GetString(response);
                dynamic obj2 = JsonConvert.DeserializeObject(webPageResponse);
                int PhoneNumber = obj2.PhoneNumber;
                string user_email = obj2.user_email;
                string KNo = obj2.KNo;
                //string First_name = obj2.First_name;
                ElectricityBill e_obj = new ElectricityBill(user_email, KNo, PhoneNumber);
                e_obj.Show();
            }
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

        private void PayBills_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void loginMobBill_Click(object sender, EventArgs e)
        {
            string infoFetchUrl = "https://dmitra.000webhostapp.com/registration/registration/userDataFetcher.php";

            using (var wb = new WebClient())
            {
                var data = new NameValueCollection();
                data["userName"] = nameOfUser;
                data["passWord"] = passwordOfUser;

                var response = wb.UploadValues(infoFetchUrl, "POST", data);
                Console.WriteLine("This is the shitnit : " + response);
                //MessageBox.Show(response, "JSON Reply", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //string result = System.Text.Encoding.UTF8.GetString(response);
                //Console.WriteLine("This is something amazhing : " + result);
                var webPageResponse = Encoding.ASCII.GetString(response);
                dynamic obj2 = JsonConvert.DeserializeObject(webPageResponse);
                int PhoneNumber = obj2.PhoneNumber;
                string user_email = obj2.user_email;
                //string First_name = obj2.First_name;

                mobileBill m_obj = new mobileBill(PhoneNumber, user_email);
                m_obj.Show();
            }
        }
    }
}
