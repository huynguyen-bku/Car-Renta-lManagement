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
    public partial class FormAdjustInforCusmer : Form
    {
        public FormAdjustInforCusmer()
        {
            InitializeComponent();
        }

        CarRentalManagement mysystem;
        DataTable dt;

        public FormAdjustInforCusmer(CarRentalManagement mySystem, DataTable dt_cus)
        {
            InitializeComponent();
            this.mysystem = mySystem;
            this.dt = dt_cus;
        }

        private void btn_input_Click(object sender, EventArgs e)
        {
            string id = txt_input.Text.ToString();

            foreach(Customer cus in mysystem.listCustonmer.customers)
            {
                if  (cus.idCode == id)
                {
                    txt_old_name.Text = cus.name.ToString();
                    txt_old_birth.Text = cus.birthDay.ToString();
                    txt_old_phone.Text = cus.phoneNumber.ToString();
                    txt_old_point.Text = cus.point.ToString();
                }
            }
        }

        private void btn_oke_Click(object sender, EventArgs e)
        {
            string id = txt_input.Text.ToString();
            foreach (Customer cus in mysystem.listCustonmer.customers)
            {
                if (cus.idCode == id)
                {
                    if (txt_new_name.Text.ToString()!="")
                        cus.name = txt_new_name.Text.ToString();
                    if(txt_new_birth.Text.ToString()!="")
                        cus.birthDay = txt_new_birth.Text.ToString();
                    if (txt_new_phone.Text.ToString() != "")
                        cus.phoneNumber = Int32.Parse(txt_new_phone.Text.ToString());
                    if (txt_new_point.Text.ToString() != "")
                       cus.point = Int32.Parse(txt_new_point.Text.ToString());
                }
            }
            foreach (DataRow row in dt.Rows)
            {
                if (row["ID"].ToString() == id)
                {
                    if (txt_new_name.Text.ToString() != "")
                        row["HO TEN"] = txt_new_name.Text.ToString();
                    if (txt_new_birth.Text.ToString() != "")
                        row["NGAY SINH"] = txt_new_birth.Text.ToString();
                    if (txt_new_phone.Text.ToString() != "")
                        row["SO DIEN THOAI"] = txt_new_phone.Text.ToString();
                    if (txt_new_point.Text.ToString() != "")
                        row["DIEM"] = txt_new_name.Text.ToString();
                }
            }
            this.Close();
        }
    }
}
