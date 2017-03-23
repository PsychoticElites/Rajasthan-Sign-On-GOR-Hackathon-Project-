using System;
using System.Windows.Forms;

namespace Hackathon_Rajasthan
{
    public partial class PaymentAlternate : Form
    {
        public PaymentAlternate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
            ActiveForm.Activate();
        }

        private void PaymentAlternate_Load(object sender, EventArgs e)
        {

        }
    }
}
