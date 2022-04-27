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
    public partial class FormAddCustomer : Form
    {
        public FormAddCustomer()
        {
            InitializeComponent();
        }

        public Customer customer = new Customer();

        private void btn_ok_Click(object sender, EventArgs e)
        {
            customer.name = txt_name.Text.ToString();
            customer.birthDay = txt_birthday.Text.ToString();
            customer.idCode = txt_idcode.Text.ToString();
            if (txt_phonenumber.Text.ToString() != "")
                customer.phoneNumber = Int32.Parse(txt_phonenumber.Text.ToString());
            else customer.phoneNumber = 0;
            if (txt_point.Text.ToString()!="")
                customer.point = Int32.Parse(txt_point.Text.ToString());
            else customer.point = 0;
            this.Close();
        }
    }
}
