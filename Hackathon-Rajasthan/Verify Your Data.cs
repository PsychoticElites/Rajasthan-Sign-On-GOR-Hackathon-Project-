using Newtonsoft.Json;
using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Hackathon_Rajasthan
{

    public partial class Verify_Your_Data : Form
    {
        private string bankAccountNumber, kNumber;
        private string _password = null;
        //public string bankAccount, kNo;
        public Verify_Your_Data( string firstName,
            string userName,
            string bmsId,
            string adharId,
            string phoneNumber,
            string userEmail,
            string userPassword,
            string bankAccount,
            string kNo)
        {
            
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            AutoClosingMessageBox.Show("Please wait while we fetch your information from servers.", "Please Wait A Little...", 1000);
            _password = userPassword;
            verifyFname.Text = firstName;
            verifyUserName.Text = userName;
            verifyBmsId.Text = bmsId;
            verifyAdhar.Text = adharId;
            verifyPhone.Text = phoneNumber;
            verifyEmail.Text = userEmail;
            bankAccountNumber = bankAccount;
            kNumber = kNo;
            if (phoneNumber == "")
            {
                MessageBox.Show("We could not find you Phone Number. Please add it manually in the provided field.", "No Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verifyPhone.ReadOnly = false;

            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void verifySubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string registerUrl = "https://dmitra.000webhostapp.com/registration/registration/register.php";

                using (var wb = new WebClient())
                {
                    var data = new NameValueCollection();
                    data["user_name"] = verifyUserName.Text;
                    data["user_email"] = verifyEmail.Text;
                    data["user_password_new"] = _password;
                    data["user_password_repeat"] = _password;
                    data["register"] = "Register";
                    data["Name"] = verifyFname.Text;
                    data["BMSID"] = verifyBmsId.Text;
                    data["AdharID"] = verifyAdhar.Text;
                    data["PhoneNumber"] = verifyPhone.Text;
                    data["BankAccount"] = bankAccountNumber;
                    data["KNo"] = kNumber;

                    var response = wb.UploadValues(registerUrl, "POST", data);
                    Console.WriteLine("This is the shitnit : " + response);
                    //MessageBox.Show(response, "JSON Reply", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //string result = System.Text.Encoding.UTF8.GetString(response);
                    //Console.WriteLine("This is something amazhing : " + result);
                    var webPageResponse = Encoding.ASCII.GetString(response);
                    //resultShow.Text += "This is the data" + data + "\n";
                    //resultShow.Text += Encoding.ASCII.GetString(response);
                    //richTextBox1.Text += webPageResponse;

                    dynamic obj2 = JsonConvert.DeserializeObject(webPageResponse);
                    //richTextBox1.Text += "This is the JSON : \n" + obj2;
                    int errCode = obj2.error_code;
                    string message = obj2.message;

                    if (errCode == 0)
                    {
                        // Code 0 : Successfully Signed Up
                        // Move the user to NEXT page
                        //MessageBox.Show("You have registered", "Succesfful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AutoClosingMessageBox.Show("You have registered successfully. Please wait while we redirect you...", "Succesffully Registered", 1000);
                        PayBills pay_Obj = new PayBills(verifyUserName.Text, _password);
                        this.Visible = false;
                        pay_Obj.Show();
                    }

                    else if (errCode == 1)
                    {
                        // Code 1 : Registration Failed.
                        MessageBox.Show("Registration failed. Please try again after some time.", "Something Broke\n पंजीकरण विफल। कृपया कुछ समय बाद फिर से प्रयास करें", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else if (errCode == 2)
                    {
                        // Code 2 : Username/ E-mail address taken.
                        MessageBox.Show("Username or E-mail taken. Please try another Username / E-Mail.", "Username/ E-Mail Already Exists\n कृपया अन्य उपयोगकर्ता नाम / ई-मेल की कोशिश करें", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    else if (errCode == 3)
                    {
                        // Code 3 : No Database Connection.
                        MessageBox.Show("Seems like I couldn't connect to Database.", "No Database Connection\n डाटाबेस कनेक्शन में समस्या", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else if (errCode == 4)
                    {
                        // Code 4 : Unknown Error
                        MessageBox.Show("Houston, we have a problem! Please try again.", "Unknown Error Occured\n कृपया बाद में फिर से प्रयास करें", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }

            catch (Exception ex)
            {
                //resultShow.Text += ex;
                MessageBox.Show(string.Format("Some unhandled exception occured.\nError : {0}", ex), "Exception Occured!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label5_Click(object sender, EventArgs e)
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
            ActiveForm.Visible = true;
        }

        private void Verify_Your_Data_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://psychoticelites.com/");
        }
    }

    public class AutoClosingMessageBox
    {
        System.Threading.Timer _timeoutTimer;
        string _caption;
        AutoClosingMessageBox(string text, string caption, int timeout)
        {
            _caption = caption;
            _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                null, timeout, System.Threading.Timeout.Infinite);
            using (_timeoutTimer)
                MessageBox.Show(text, caption);
        }
        public static void Show(string text, string caption, int timeout)
        {
            new AutoClosingMessageBox(text, caption, timeout);
        }
        void OnTimerElapsed(object state)
        {
            IntPtr mbWnd = FindWindow("#32770", _caption); // lpClassName is #32770 for MessageBox
            if (mbWnd != IntPtr.Zero)
                SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
            _timeoutTimer.Dispose();
        }
        const int WM_CLOSE = 0x0010;
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
    }
}
