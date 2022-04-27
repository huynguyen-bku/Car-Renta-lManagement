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
    public partial class FormMainCustomer : Form
    {
        CarRentalManagement mysystem = new CarRentalManagement();
        public FormMainCustomer()
        {
            InitializeComponent();
        }       
        public FormMainCustomer(CarRentalManagement mySystem)
        {
            InitializeComponent();
            this.mysystem = mySystem;

        }

        DataTable dt_cus = new DataTable();

        private void btn_add_customer_Click(object sender, EventArgs e)
        {
            FormAddCustomer new_window = new FormAddCustomer();
            new_window.ShowDialog();
            Customer a = new_window.customer;
            if (a.birthDay != "" && a.name != "" && a.phoneNumber != 0 && a.idCode != "")
            {
                bool is_exist = mysystem.listCustonmer.AddNewCustomer(a);
                if (!is_exist)
                {
                    MessageBox.Show("Khach hang da ton tai", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (a.name == "" || a.birthDay == "" || a.idCode == "")
                        MessageBox.Show("Nhap khong thanh cong", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        dt_cus.Rows.Add(a.name, a.birthDay, a.idCode, a.phoneNumber, a.point);
                        dataGridView1.DataSource = dt_cus;
                    }
                }
            }
            else
            {
                MessageBox.Show("Nhap khong thanh cong", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormCustomer_Load(object sender, EventArgs e)
        {
            dt_cus.Clear();
            dt_cus.Columns.Add("HO TEN", typeof(string));
            dt_cus.Columns.Add("NGAY SINH", typeof(string));
            dt_cus.Columns.Add("ID", typeof(string));
            dt_cus.Columns.Add("SO DIEN THOAI", typeof(string));
            dt_cus.Columns.Add("DIEM", typeof(string));
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            FormRemoveCustomer small_window = new FormRemoveCustomer();
            small_window.ShowDialog();
            string id = small_window.id;
            bool check = mysystem.listCustonmer.RemoveCustomer(id);
            if (check == true)
            {
                MessageBox.Show("DA XOA", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("KHONG CO KHACH HANG", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_adjust_info_cus_Click(object sender, EventArgs e)
        {
            FormResetCustomer small_window = new FormResetCustomer(this.mysystem, dt_cus);
            small_window.ShowDialog();
            //dt_cus = small_window.dt;
            dataGridView1.DataSource = dt_cus;
            
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            FormSearchCustomer small_window = new FormSearchCustomer(this.mysystem);
            small_window.ShowDialog();
            DataTable dt_cus1 = new DataTable();
            dt_cus1.Clear();
            dt_cus1.Columns.Add("HO TEN", typeof(string));
            dt_cus1.Columns.Add("NGAY SINH", typeof(string));
            dt_cus1.Columns.Add("ID", typeof(string));
            dt_cus1.Columns.Add("SO DIEN THOAI", typeof(string));
            dt_cus1.Columns.Add("DIEM", typeof(string));
            if (small_window.phoneNumer == -1)
            {
                int i = 0;
                while (i<mysystem.listCustonmer.customers.Count())
                {
                    dt_cus1.Rows.Add(mysystem.listCustonmer.customers[i].name, mysystem.listCustonmer.customers[i].birthDay, 
                                    mysystem.listCustonmer.customers[i].idCode, mysystem.listCustonmer.customers[i].phoneNumber, 
                                    mysystem.listCustonmer.customers[i].point);
                    i++;
                }
            }
            else
            {
                int i = 0;
                while (i < mysystem.listCustonmer.customers.Count())
                {
                    if (mysystem.listCustonmer.customers[i].phoneNumber == small_window.phoneNumer)
                    {
                        dt_cus1.Rows.Add(mysystem.listCustonmer.customers[i].name, mysystem.listCustonmer.customers[i].birthDay,
                                        mysystem.listCustonmer.customers[i].idCode, mysystem.listCustonmer.customers[i].phoneNumber, 
                                        mysystem.listCustonmer.customers[i].point);
                        break;
                    }
                    i++;
                }
                if (i == mysystem.listCustonmer.customers.Count()) MessageBox.Show("KHONG CO KHACH HANG", "Message", 
                                                                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView1.DataSource = dt_cus1;
        }
        public CarRentalManagement Reset()
        {
            return mysystem;
        }
        private void btn_compare_Click(object sender, EventArgs e)
        {
            FormCompare new_window = new FormCompare(mysystem);
            new_window.ShowDialog();
        }
        public CarRentalManagement reset()
        {
            return mysystem;
        }
    }
}
