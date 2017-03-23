using Newtonsoft.Json;
using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Hackathon_Rajasthan
{
    public partial class ExisitngUser : Form
    {
        public ExisitngUser()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void ExisitngUser_Load(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        

        private void login_submit_Click(object sender, EventArgs e)
        {
            //Intermediate_Error obj = new Intermediate_Error();

            /* variable "passVar" is storing "login_password" Text value on clicking "Submit" button
               then it is changing the value of "showPass" label so that current value of
               password is displayed in label.

               "login.pass.Text" is fetching the value of password field and storing it in "passVar" variable.
           */

            string loginUrl = "https://dmitra.000webhostapp.com/registration/registration/index.php";
            string userPassword = login_password.Text;
            string userName = login_user.Text;

            using (var wb = new WebClient())
            {
                var data = new NameValueCollection();
                data["user_name"] = userName;
                data["user_password"] = userPassword;
                data["login"] = "Log in";

                var response = wb.UploadValues(loginUrl, "POST", data);
                var webPageResponse = Encoding.ASCII.GetString(response);
                //resultShow.Text += "This is the data" + data + "\n";
                //resultShow.Text += Encoding.ASCII.GetString(response);

                dynamic obj2 = JsonConvert.DeserializeObject(webPageResponse);
                int errCode = obj2.error_code;
                string message = obj2.message;

                if (errCode == 0)
                {
                    // Code 0 : Successfully Logged In
                    // Move the user to NEXT page
                    PayBills pay_Obj = new PayBills(userName, userPassword);
                    this.Visible = false;
                    pay_Obj.Show();
                }

                else if (errCode == 1)
                {
                    // Code 1 : Login Failed.
                    MessageBox.Show("Please check your login credentials again.", "Wrong Username Or Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void login_bhamaid_TextChanged(object sender, EventArgs e)
        {

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

        private void login_user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
