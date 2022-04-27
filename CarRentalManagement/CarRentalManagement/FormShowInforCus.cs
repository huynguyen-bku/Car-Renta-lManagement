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
    public partial class FormShowInforCus : Form
    {
        CarRentalManagement mysystem;
        public FormShowInforCus()
        {
            InitializeComponent();
        }
        public FormShowInforCus(CarRentalManagement mySystem)
        {
            InitializeComponent();
            this.mysystem = mySystem;
        }
        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            string id = txt_input.Text.ToString();
            foreach (Customer cus in mysystem.listCustonmer.customers)
            {
                if (cus.idCode == id)
                {
                    txt_name.Text = cus.name.ToString();
                    txt_birth.Text = cus.birthDay.ToString();
                    txt_phone.Text = cus.phoneNumber.ToString();
                    txt_point.Text = cus.point.ToString();
                }
            }
        }
    }
}
