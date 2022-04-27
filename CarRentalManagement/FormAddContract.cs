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
    public partial class FormAddContract : Form
    {
        public FormAddContract(CarRentalManagement mysystem)
        {
            InitializeComponent();
            this.mysystem = mysystem;
        }

        private Customer renter = new Customer();
        private Car car = null;
        private Truck truck = null;
        private CarRentalManagement mysystem = new CarRentalManagement();
        
        private void btn_searhcustom_Click(object sender, EventArgs e)
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
                while (i < mysystem.listCustonmer.customers.Count())
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
                if (i == mysystem.listCustonmer.customers.Count()) MessageBox.Show("KHONG CO KHACH HANG", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView1.DataSource = dt_cus1;
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text.ToString();
            string date = txt_date.Text.ToString();
            string id = txt_code.Text.ToString();
            int phone = 0;
            if (txt_phone.Text.ToString() != "") phone = Int32.Parse(txt_phone.Text.ToString());
            int point = 0;
            if (txt_point.Text.ToString() != "") point = Int32.Parse(txt_point.Text.ToString());
            Customer add = new Customer(name, date, id, phone, point);
            renter = add;
        }
        private void btn_search_vehicle_Click(object sender, EventArgs e)
        {
            FormSearchVehicle new_window = new FormSearchVehicle();
            new_window.ShowDialog();
            if (new_window.type == 0)
            {
                List<Car> carCheck = new List<Car>(mysystem.listVehicle.car);
                if (new_window.price_min != -1)
                {
                    int i = 0;
                    while (i < carCheck.Count())
                    {
                        if (carCheck[i].price < new_window.price_min) carCheck.RemoveAt(i);
                        else i++;
                    }
                }
                if (new_window.price_max != -1)
                {
                    int i = 0;
                    while (i < carCheck.Count())
                    {
                        if (carCheck[i].price > new_window.price_max) carCheck.RemoveAt(i);
                        else i++;
                    }
                }
                if (new_window.capa_min != -1)
                {
                    int i = 0;
                    while (i < carCheck.Count())
                    {
                        if (carCheck[i].capacity < new_window.capa_min) carCheck.RemoveAt(i);
                        else i++;
                    }
                }
                if (new_window.capa_max != -1)
                {
                    int i = 0;
                    while (i < carCheck.Count())
                    {
                        if (carCheck[i].capacity < new_window.capa_max) carCheck.RemoveAt(i);
                        else i++;
                    }
                }
                if (new_window.brand != "")
                {
                    int i = 0;
                    while (i < carCheck.Count())
                    {
                        if (carCheck[i].brand != new_window.brand) carCheck.RemoveAt(i);
                        else i++;
                    }
                }
                if (new_window.color != "")
                {
                    int i = 0;
                    while (i < carCheck.Count())
                    {
                        if (carCheck[i].color != new_window.color) carCheck.RemoveAt(i);
                        else i++;
                    }
                }
                if (new_window.id != "")
                {
                    int i = 0;
                    while (i < carCheck.Count())
                    {
                        if (carCheck[i].ID != new_window.id) carCheck.RemoveAt(i);
                        else i++;
                    }
                }
                if (new_window.status != -1)
                {
                    int i = 0;
                    while (i < carCheck.Count())
                    {
                        if (carCheck[i].status != new_window.status) carCheck.RemoveAt(i);
                        else i++;
                    }
                }
                ///
                DataTable dt_search = new DataTable();
                dt_search.Clear();
                dt_search.Columns.Add("GIA THUE", typeof(int));
                dt_search.Columns.Add("SUC CHUA", typeof(int));
                dt_search.Columns.Add("MAU XE", typeof(string));
                dt_search.Columns.Add("BIEN SO", typeof(string));
                dt_search.Columns.Add("HANG XE", typeof(string));
                dt_search.Columns.Add("CONGTOMET", typeof(int));
                dt_search.Columns.Add("TINH TRANG XE", typeof(string));
                dt_search.Columns.Add("LOAI XE", typeof(string));

                for (int i = 0; i < carCheck.Count(); i++)
                {
                    string status = "";
                    if (carCheck[i].status == 0) status = "CO SAN";
                    else if (carCheck[i].status == 1) status = "DA DAT TRUOC";
                    else status = "DA DUOC THUE";
                    dt_search.Rows.Add(carCheck[i].price, carCheck[i].capacity, carCheck[i].color, carCheck[i].ID, carCheck[i].brand, carCheck[i].odometer, status, "XE OTO");
                }
                dataGridView1.DataSource = dt_search;
            }
            else if (new_window.type == 1)
            {
                List<Truck> truckCheck = new List<Truck>(mysystem.listVehicle.truck);
                if (new_window.price_min != -1)
                {
                    int i = 0;
                    while (i < truckCheck.Count())
                    {
                        if (truckCheck[i].price < new_window.price_min) truckCheck.RemoveAt(i);
                        else i++;
                    }
                }
                if (new_window.price_max != -1)
                {
                    int i = 0;
                    while (i < truckCheck.Count())
                    {
                        if (truckCheck[i].price > new_window.price_max) truckCheck.RemoveAt(i);
                        else i++;
                    }
                }
                if (new_window.capa_min != -1)
                {
                    int i = 0;
                    while (i < truckCheck.Count())
                    {
                        if (truckCheck[i].payload < new_window.capa_min) truckCheck.RemoveAt(i);
                        else i++;
                    }
                }
                if (new_window.capa_max != -1)
                {
                    int i = 0;
                    while (i < truckCheck.Count())
                    {
                        if (truckCheck[i].payload < new_window.capa_max) truckCheck.RemoveAt(i);
                        else i++;
                    }
                }
                if (new_window.brand != "")
                {
                    int i = 0;
                    while (i < truckCheck.Count())
                    {
                        if (truckCheck[i].brand != new_window.brand) truckCheck.RemoveAt(i);
                        else i++;
                    }
                }
                if (new_window.color != "")
                {
                    int i = 0;
                    while (i < truckCheck.Count())
                    {
                        if (truckCheck[i].color != new_window.color) truckCheck.RemoveAt(i);
                        else i++;
                    }
                }
                if (new_window.id != "")
                {
                    int i = 0;
                    while (i < truckCheck.Count())
                    {
                        if (truckCheck[i].ID != new_window.id) truckCheck.RemoveAt(i);
                        else i++;
                    }
                }
                if (new_window.status != -1)
                {
                    int i = 0;
                    while (i < truckCheck.Count())
                    {
                        if (truckCheck[i].status != new_window.status) truckCheck.RemoveAt(i);
                        else i++;
                    }
                }
                ///
                DataTable dt_search = new DataTable();
                dt_search.Clear();
                dt_search.Columns.Add("GIA THUE", typeof(int));
                dt_search.Columns.Add("SUC CHUA", typeof(int));
                dt_search.Columns.Add("MAU XE", typeof(string));
                dt_search.Columns.Add("BIEN SO", typeof(string));
                dt_search.Columns.Add("HANG XE", typeof(string));
                dt_search.Columns.Add("CONGTOMET", typeof(int));
                dt_search.Columns.Add("TINH TRANG XE", typeof(string));
                dt_search.Columns.Add("LOAI XE", typeof(string));
                for (int i = 0; i < truckCheck.Count(); i++)
                {
                    string status = "";
                    if (truckCheck[i].status == 0) status = "CO SAN";
                    else if (truckCheck[i].status == 1) status = "DA DAT TRUOC";
                    else status = "DA DUOC THUE";
                    dt_search.Rows.Add(truckCheck[i].price, truckCheck[i].payload, truckCheck[i].color, 
                                        truckCheck[i].ID, truckCheck[i].brand, truckCheck[i].odometer, status, "XE TAI");
                }
                dataGridView1.DataSource = dt_search;
            }
            else
            {
                List<Car> carCheck = new List<Car>(mysystem.listVehicle.car);
                if (new_window.price_min != -1)
                {
                    int i = 0;
                    while (i < carCheck.Count())
                    {
                        if (carCheck[i].price < new_window.price_min) carCheck.RemoveAt(i);
                        else i++;
                    }
                }
                if (new_window.price_max != -1)
                {
                    int i = 0;
                    while (i < carCheck.Count())
                    {
                        if (carCheck[i].price > new_window.price_max) carCheck.RemoveAt(i);
                        else i++;
                    }
                }
                if (new_window.capa_min != -1)
                {
                    int i = 0;
                    while (i < carCheck.Count())
                    {
                        if (carCheck[i].capacity < new_window.capa_min) carCheck.RemoveAt(i);
                        else i++;
                    }
                }
                if (new_window.capa_max != -1)
                {
                    int i = 0;
                    while (i < carCheck.Count())
                    {
                        if (carCheck[i].capacity < new_window.capa_max) carCheck.RemoveAt(i);
                        else i++;
                    }
                }
                if (new_window.brand != "")
                {
                    int i = 0;
                    while (i < carCheck.Count())
                    {
                        if (carCheck[i].brand != new_window.brand) carCheck.RemoveAt(i);
                        else i++;
                    }
                }
                if (new_window.color != "")
                {
                    int i = 0;
                    while (i < carCheck.Count())
                    {
                        if (carCheck[i].color != new_window.color) carCheck.RemoveAt(i);
                        else i++;
                    }
                }
                if (new_window.id != "")
                {
                    int i = 0;
                    while (i < carCheck.Count())
                    {
                        if (carCheck[i].ID != new_window.id) carCheck.RemoveAt(i);
                        else i++;
                    }
                }
                if (new_window.status != -1)
                {
                    int i = 0;
                    while (i < carCheck.Count())
                    {
                        if (carCheck[i].status != new_window.status) carCheck.RemoveAt(i);
                        else i++;
                    }
                }
                List<Truck> truckCheck = new List<Truck>(mysystem.listVehicle.truck);
                if (new_window.price_min != -1)
                {
                    int i = 0;
                    while (i < truckCheck.Count())
                    {
                        if (truckCheck[i].price < new_window.price_min) truckCheck.RemoveAt(i);
                        else i++;
                    }
                }
                if (new_window.price_max != -1)
                {
                    int i = 0;
                    while (i < truckCheck.Count())
                    {
                        if (truckCheck[i].price > new_window.price_max) truckCheck.RemoveAt(i);
                        else i++;
                    }
                }
                if (new_window.capa_min != -1)
                {
                    int i = 0;
                    while (i < truckCheck.Count())
                    {
                        if (truckCheck[i].payload < new_window.capa_min) truckCheck.RemoveAt(i);
                        else i++;
                    }
                }
                if (new_window.capa_max != -1)
                {
                    int i = 0;
                    while (i < truckCheck.Count())
                    {
                        if (truckCheck[i].payload < new_window.capa_max) truckCheck.RemoveAt(i);
                        else i++;
                    }
                }
                if (new_window.brand != "")
                {
                    int i = 0;
                    while (i < truckCheck.Count())
                    {
                        if (truckCheck[i].brand != new_window.brand) truckCheck.RemoveAt(i);
                        else i++;
                    }
                }
                if (new_window.color != "")
                {
                    int i = 0;
                    while (i < truckCheck.Count())
                    {
                        if (truckCheck[i].color != new_window.color) truckCheck.RemoveAt(i);
                        else i++;
                    }
                }
                if (new_window.id != "")
                {
                    int i = 0;
                    while (i < truckCheck.Count())
                    {
                        if (truckCheck[i].ID != new_window.id) truckCheck.RemoveAt(i);
                        else i++;
                    }
                }
                if (new_window.status != -1)
                {
                    int i = 0;
                    while (i < truckCheck.Count())
                    {
                        if (truckCheck[i].status != new_window.status) truckCheck.RemoveAt(i);
                        else i++;
                    }
                }
                ///
                DataTable dt_search = new DataTable();
                dt_search.Clear();
                dt_search.Columns.Add("GIA THUE", typeof(int));
                dt_search.Columns.Add("SUC CHUA", typeof(int));
                dt_search.Columns.Add("MAU XE", typeof(string));
                dt_search.Columns.Add("BIEN SO", typeof(string));
                dt_search.Columns.Add("HANG XE", typeof(string));
                dt_search.Columns.Add("SO CONGTOMET", typeof(int));
                dt_search.Columns.Add("TINH TRANG XE", typeof(string));
                dt_search.Columns.Add("LOAI XE", typeof(string));
                for (int i = 0; i < truckCheck.Count(); i++)
                {
                    string status = "";
                    if (truckCheck[i].status == 0) status = "CO SAN";
                    else if (truckCheck[i].status == 1) status = "DA DAT TRUOC";
                    else status = "DA DUOC THUE";
                    dt_search.Rows.Add(truckCheck[i].price, truckCheck[i].payload, truckCheck[i].color, truckCheck[i].ID, 
                                        truckCheck[i].brand, truckCheck[i].odometer, status, "XE TAI");
                }
                for (int i = 0; i < carCheck.Count(); i++)
                {
                    string status = "";
                    if (carCheck[i].status == 0) status = "CO SAN";
                    else if (carCheck[i].status == 1) status = "DA DAT TRUOC";
                    else status = "DA DUOC THUE";
                    dt_search.Rows.Add(carCheck[i].price, carCheck[i].capacity, carCheck[i].color, carCheck[i].ID, 
                                        carCheck[i].brand, carCheck[i].odometer, status, "XE OTO");
                }
                dataGridView1.DataSource = dt_search;
            }
        }
        private void btn_book_Click(object sender, EventArgs e)
        {
            BookContract new_contract;
            if (car != null)
            {
                int index = 0;
                while (index < mysystem.listVehicle.car.Count())
                {
                    if (mysystem.listVehicle.car[index].ID == car.ID)
                    {
                        mysystem.listVehicle.car[index].status = 1;
                        break;
                    }
                    index++;
                }
                new_contract = new BookContract(renter, car, txt_begin.Text.ToString(), txt_end.Text.ToString());
                mysystem.listContract.AddBookContract(new_contract);
                MessageBox.Show("DA TAO HOP DONG DAT TRUOC", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (truck != null)
            {
                int index = 0;
                while (index < mysystem.listVehicle.truck.Count())
                {
                    if (mysystem.listVehicle.truck[index].ID == truck.ID)
                    {
                        mysystem.listVehicle.truck[index].status = 1;
                        break;
                    }
                    index++;
                }
                new_contract = new BookContract(renter, truck, txt_begin.Text.ToString(), txt_end.Text.ToString());
                mysystem.listContract.AddBookContract(new_contract);
                MessageBox.Show("DA TAO HOP DONG DAT TRUOC", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("CHUA CHON XE", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            int numrow;
            numrow = dataGridView1.CurrentCell.RowIndex;
            string idvehicle = dataGridView1.Rows[numrow].Cells[3].Value.ToString();
            int index = 0;
            if (numrow == -1)
            {
                MessageBox.Show("CHUA CHON XE", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                while (index < mysystem.listVehicle.truck.Count())
                {
                    if (mysystem.listVehicle.truck[index].ID == idvehicle)
                    {
                        if (mysystem.listVehicle.truck[index].status == 1)
                        {
                            MessageBox.Show("XE DA DUOC DAT TRUOC", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if(mysystem.listVehicle.truck[index].status==2)
                        {
                            MessageBox.Show("XE DA DUOC THUE", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            truck = mysystem.listVehicle.truck[index];
                            MessageBox.Show("DAT DAT XE THANH CONG", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
                    index++;
                }
                if (index == mysystem.listVehicle.truck.Count())
                {
                    index = 0;
                    while (index < mysystem.listVehicle.car.Count())
                    {
                        if (mysystem.listVehicle.car[index].ID == idvehicle)
                        {
                            if (mysystem.listVehicle.car[index].status == 1)
                            {
                                MessageBox.Show("XE DA DUOC DAT TRUOC", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if ((mysystem.listVehicle.car[index].status == 1))
                            {
                                MessageBox.Show("XE DA DUOC THUE", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                car = mysystem.listVehicle.car[index];
                                MessageBox.Show("DA CHON XE OTO", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                        }
                    }
                    index++;
                }
            }
        }
        private void btn_rent_Click(object sender, EventArgs e)
        {
            RentContract new_contract;
            if (car != null)
            {
                int index = 0;
                while (index < mysystem.listVehicle.car.Count())
                {
                    if (mysystem.listVehicle.car[index].ID == car.ID)
                    {
                        mysystem.listVehicle.car[index].status = 2;
                        break;
                    }
                    index++;
                }
                new_contract = new RentContract(renter, car, txt_begin.Text.ToString(), 
                                                txt_end.Text.ToString(), Int32.Parse(txt_pay.Text.ToString()));
                mysystem.listContract.AddRentContract(new_contract);
                MessageBox.Show("DA TAO HOP DONG CHO THUE", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (truck != null)
            {
                int index = 0;
                while (index < mysystem.listVehicle.truck.Count())
                {
                    if (mysystem.listVehicle.truck[index].ID == truck.ID)
                    {
                        mysystem.listVehicle.truck[index].status = 2;
                        break;
                    }
                    index++;
                }
                if (txt_begin.Text.ToString() != "" && txt_end.Text.ToString() != "" && txt_pay.Text.ToString() != "")
                {
                    new_contract = new RentContract(renter, truck, txt_begin.Text.ToString(), 
                                                    txt_end.Text.ToString(), Int32.Parse(txt_pay.Text.ToString()));
                    mysystem.listContract.AddRentContract(new_contract);
                    MessageBox.Show("DA TAO HOP DONG CHO THUE", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("TAO HOP DONG KHONG THANH CONG", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("CHUA CHON XE", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
        public CarRentalManagement Reset()
        {
            return mysystem;
        }

        private void btn_confrimcus_Click(object sender, EventArgs e)
        {
            int numrow = -1;
            numrow = dataGridView1.CurrentCell.RowIndex;
            int phone = Int32.Parse(dataGridView1.Rows[numrow].Cells[3].Value.ToString());
            if (numrow == -1)
            {
                MessageBox.Show("CHUA CHON ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int i = 0;
                while (i < mysystem.listCustonmer.customers.Count())
                {
                    if (mysystem.listCustonmer.customers[i].phoneNumber == phone)
                    {
                        renter = mysystem.listCustonmer.customers[i];
                        MessageBox.Show("DA CHON KHACH HANG", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    i++;
                }
            }
        }
    }
}
