using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalManagement
{
    public partial class FormChangeContract : Form
    {
        public FormChangeContract()
        {
            InitializeComponent();
        }

        public int phoneNumber = -1;
        public int downPayment = -1;

        private void btn_ok_Click(object sender, EventArgs e)
        {
            phoneNumber = Int32.Parse(txt_phonenumber.Text.ToString());
            downPayment = Int32.Parse(txt_pay.Text.ToString());
            this.Close();
        }
    }
}
