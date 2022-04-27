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
    public partial class FormCompare : Form
    {
        public FormCompare(CarRentalManagement mysystem)
        {
            InitializeComponent();
            this.mysystem = mysystem;
        }

        CarRentalManagement mysystem = new CarRentalManagement();

        private void FormCompare_Load(object sender, EventArgs e)
        {

        }
        private void btn_tru_Click(object sender, EventArgs e)
        {
            int index1 = 0;
            while (index1 < mysystem.listCustonmer.customers.Count())
            {
                if (mysystem.listCustonmer.customers[index1].phoneNumber == Int32.Parse(txt_number_a.Text.ToString())) break;
                index1++;
            }
            int index2 = 0;
            while (index2 < mysystem.listCustonmer.customers.Count())
            {
                if (mysystem.listCustonmer.customers[index2].phoneNumber == Int32.Parse(txt_number_b.Text.ToString())) break;
                index2++;
            }
            if((index2 < mysystem.listCustonmer.customers.Count())&& (index1 < mysystem.listCustonmer.customers.Count()))
            {
                int a = mysystem.listCustonmer.customers[index1] - mysystem.listCustonmer.customers[index2];
                MessageBox.Show(string.Format("KET QUA LA: {0}", a), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("KHONG THUC THI", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_compare_Click(object sender, EventArgs e)
        {
            int index1 = 0;
            while (index1 < mysystem.listCustonmer.customers.Count())
            {
                if (mysystem.listCustonmer.customers[index1].phoneNumber == Int32.Parse(txt_number_a.Text.ToString())) break;
                index1++;
            }
            int index2 = 0;
            while (index2 < mysystem.listCustonmer.customers.Count())
            {
                if (mysystem.listCustonmer.customers[index2].phoneNumber == Int32.Parse(txt_number_b.Text.ToString())) break;
                index2++;
            }
            if ((index2 < mysystem.listCustonmer.customers.Count()) && (index1 < mysystem.listCustonmer.customers.Count()))
            {
                bool a = mysystem.listCustonmer.customers[index1] == mysystem.listCustonmer.customers[index2];
                if (a == true)
                    MessageBox.Show("HAI KHACH HANG CUNG TEN", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("HAI KHACH HANG KHONG CUNG TEN", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("KHONG THUC THI", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
