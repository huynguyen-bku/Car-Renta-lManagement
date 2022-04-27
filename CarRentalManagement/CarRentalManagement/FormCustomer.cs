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
    public partial class FormCustomer : Form
    {
        CarRentalManagement mysystem;

        public FormCustomer()
        {
            InitializeComponent();
        }       
        public FormCustomer(CarRentalManagement mySystem)
        {
            InitializeComponent();
            this.mysystem = mySystem;
        }

        DataTable dt_cus = new DataTable();

        private void btn_add_customer_Click(object sender, EventArgs e)
        {
            Formaddcustomer new_window = new Formaddcustomer();
            new_window.ShowDialog();
            Customer a = new_window.customer;
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
            FormDeleteCusbyID small_window = new FormDeleteCusbyID();
            small_window.ShowDialog();
            string id = small_window.id;
            dt_cus.AcceptChanges();
            foreach (DataRow row in dt_cus.Rows)
            {
                string id_1 = row["ID"].ToString();
                if (id == id_1) row.Delete();
            }
            dt_cus.AcceptChanges();
        }
        private void btn_adjust_info_cus_Click(object sender, EventArgs e)
        {
            FormAdjustInforCusmer small_window = new FormAdjustInforCusmer(this.mysystem, dt_cus);
            small_window.ShowDialog();
            //dt_cus = small_window.dt;
            dataGridView1.DataSource = dt_cus;
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            FormShowInforCus small_window = new FormShowInforCus(this.mysystem);
            small_window.ShowDialog();
        }
    }
}
