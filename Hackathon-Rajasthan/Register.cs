using Newtonsoft.Json;
using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Hackathon_Rajasthan
{
    public partial class Register : Form
    {
        // Let's declare 2 Public String that can be accessed from anywhere and put the values in them
        // as opposed to pass the values as parameters. This "may" not be the best or the "safest" approach, but
        // it removes the requirement of extra required textFields.
        public string bmsID, adharID, kNo, bankAccount;
        
        public Register()
        {
            //Console.Write("Testing {0}\n", adharID);
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            //bmsHidden.Text = bmsID;
            //adharHidden.Text = adharID;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void reg_submit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            /*
            Edit this section and make it work so that it contacts the API services
            of Bhamashah and generates useful result.
            */

            /*
             This is a naive way of connecting with the website and fetching the information. The correct and more safer way would be to
             check whether the connection has been made or not at all. Check the status response code and verfiy the data.
             Check this resource : https://msdn.microsoft.com/en-us/library/hh674188.aspx#Anchor_3
             This should explain the response code usage and working and stuff.

            I am grabbing the First Name, adhar ID and Phone Number from Bhamashah.
            Username = FirstName + adharID[Last 4 Digits]
             */

            /*
             * If the passwords don't match, show an error. Otherwise, just move on to grab shit from internet.
             */
            //Console.WriteLine("This is the value : " + bms2);
            string regPassword = reg_pass.Text;
            string confPassword = reg_confpas.Text;
            //if (reg_pass.Text.Length != 25 || reg_confpas.TextLength != 25)
            //{
            //    MessageBox.Show("Verify your Password \n पासवर्ड जांचें ", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            if (regEmail.Text == "")
            {
                MessageBox.Show("Check E-Mail ID\n ईमेल आईडी की जांच करें", "Check E-mail ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }// EMAIL VALIDATION
            else
            {
                //if (regPassword != confPassword)
                //{
                //    MessageBox.Show("Password does not Match \n पासवर्ड मैच नहीं कर रहा है", "Password Verification Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    this.Visible = false;
                //    InitialScreen iniScreen1 = new InitialScreen();
                //    iniScreen1.Show();
                //}
                string emailCheckUrl = "https://dmitra.000webhostapp.com/registration/registration/info_checker.php";


                //string json_url = "https://dmitra.000webhostapp.com/jsonreply.json";
                string clientId = "ad7288a4-7764-436d-a727-783a977f1fe1";
                string bankAccountNumber = bankAccount.ToString();
                MessageBox.Show(bankAccountNumber, bankAccount, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                string json_url = string.Format("https://apitest.sewadwaar.rajasthan.gov.in/app/live/Service/getAccountDetails/{0}?client_id={1}", bankAccountNumber.Trim(), clientId);

                Console.WriteLine(json_url);
                using (WebClient wc = new WebClient())
                {

                    var json = wc.DownloadString(json_url);
                    string jsonClean = json.Replace("[", "").Replace("]", "");
                    MessageBox.Show(jsonClean, "new", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //MessageBox.Show(jsonClean, "JSON Reply", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dynamic obj = JsonConvert.DeserializeObject(jsonClean);
                    string firstName = obj.name;
                    string emailId = regEmail.Text;
                    string phoneNumber = obj.mobileNo;

                    if (obj.msg == "No Data Found for given account number")
                    {
                        MessageBox.Show("Please check your Bank Account Number.", "No Data Found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //this.Visible = false;
                        //InitialScreen iniScreen = new InitialScreen();
                        //iniScreen.Show();
                    }


                    string adharId = obj.aadharId;
                    //string emailId = obj.email_id;
                    // UserName =  First Name + Last 4 Digits of Adhar ID <-- Unique
                    string userName = firstName + adharId.Substring(adharId.Length - 4);
                    Console.WriteLine("This is my password : " + regPassword);


                    try
                    {

                        using (var wb = new WebClient())
                        {
                            var data = new NameValueCollection();
                            //data["user_name"] = userName;
                            data["emailId"] = emailId;
                            //data["user_password_new"] = phoneNumber;
                            //data["user_password_repeat"] = phoneNumber;
                            //data["register"] = "Register";

                            var response = wb.UploadValues(emailCheckUrl, "POST", data);
                            var webPageResponse = Encoding.ASCII.GetString(response);
                            //resultShow.Text += "This is the data" + data + "\n";
                            //resultShow.Text += Encoding.ASCII.GetString(response);

                            dynamic obj2 = JsonConvert.DeserializeObject(webPageResponse);
                            int errCode = obj2.error_code;
                            string message = obj2.message;

                            if (errCode == 0)
                            {
                                // Code 0 : Successfully Signed Up
                                // Move the user to NEXT page
                                /*
                                 *  string firstName,
                                    string userName,
                                    string bmsId,
                                    string adharId,
                                    string phoneNumber,
                                    string userEmail,
                                    string userPassword
                                 */
                                Verify_Your_Data v_obj = new Verify_Your_Data(firstName, userName, bmsID, adharID, phoneNumber, emailId, regPassword, bankAccount, kNo);
                                this.Visible = false;
                                v_obj.Show();
                            }

                            else if (errCode == 1)
                            {
                                // Code 1 : Registration Failed.
                                MessageBox.Show("E-mail taken. Please try another E-Mail.\n अन्य ई-मेल का प्रयास करें।", "E-Mail Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            else
                            {
                                // Code 2 : Username/ E-mail address taken.
                                MessageBox.Show("Oops! Seems like something broke!. Try again later.\n बाद में फिर से प्रयास करें", "Houston, we have a problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                        }
                    }

                    catch (Exception ex)
                    {
                        //resultShow.Text += ex;
                        MessageBox.Show(string.Format("Some unhandled exception occured.\nError : {0}", ex), "Exception Occured!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
        }
        private void Register_Load(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void resultShow_TextChanged(object sender, EventArgs e)
        {

        }

        private void reg_confpas_TextChanged(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
            ActiveForm.Activate();
        }

        private void reg_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://psychoticelites.com/");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void regEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
