using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
namespace CarRentalManagement
{
    public partial class FormMainVehicle : Form
    {
        public FormMainVehicle(CarRentalManagement mySystem)
        {
            InitializeComponent();
            this.mysystem = mySystem;
        }
        
        public CarRentalManagement mysystem = new CarRentalManagement();
        DataTable dt_car = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            dt_car.Clear();
            dt_car.Columns.Add("GIA THUE", typeof(int));
            dt_car.Columns.Add("SUC CHUA", typeof(int));
            dt_car.Columns.Add("MAU XE", typeof(string));
            dt_car.Columns.Add("BIEN SO", typeof(string));
            dt_car.Columns.Add("HANG XE", typeof(string));
            dt_car.Columns.Add("CONGTOMET", typeof(int));
            dt_car.Columns.Add("TINH TRANG XE", typeof(string));
            dt_car.Columns.Add("LOAI XE", typeof(string));
        }
        private void btn_addcar_Click(object sender, EventArgs e)
        {
            FormAddVehicle new_window = new FormAddVehicle();
            new_window.ShowDialog();
            Car car = new_window.newCar;
            Truck truck = new_window.newTruck;
            if (car.brand != "" || car.ID != "" || car.color != "" || car.odometer != 0 
                || car.price != 0 || car.status != 0 || car.capacity != 0)
            {
                bool test = mysystem.listVehicle.AddVehicle(car);
                if (test == false) MessageBox.Show("XE DA TON TAI", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("XE DA DUOC THEM", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    string status = "";
                    if (car.status == 0) status = "CO SAN";
                    else if (car.status == 1) status = "DA DAT TRUOC";
                    else status = "DA DUOC THUE";
                    dt_car.Rows.Add(car.price, car.capacity, car.color, car.ID, car.brand, car.odometer, status, "XE OTO");
                }
            }
            else if (truck.brand != "" || truck.ID != "" || truck.color != "" || truck.odometer != 0 
                    || truck.price != 0 || truck.status != 0 || truck.payload != 0)
            {
                bool test = mysystem.listVehicle.AddVehicle(truck);
                if (test == false) MessageBox.Show("XE DA TON TAI", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("XE DA DUOC THEM", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    string status = "";
                    if (truck.status == 0) status = "CO SAN";
                    else if (truck.status == 1) status = "DA DAT TRUOC";
                    else status = "DA DUOC THUE";
                    dt_car.Rows.Add(truck.price, truck.payload, truck.color, truck.ID, truck.brand, 
                                    truck.odometer, status, "XE TAI");
                }
            }
            else
            {
                MessageBox.Show("THAO TAC KHONG DUOC THUC THI", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView1.DataSource = dt_car;
        }
        private void btn_removecar_Click(object sender, EventArgs e)
        {
            FormRemoveVehicle new_window = new FormRemoveVehicle();
            new_window.ShowDialog();
            string ID = new_window.ID;
            if (ID != "")
            {
                bool test = mysystem.listVehicle.Remove(ID);
                if (test == false) MessageBox.Show("KHONG TON TAI XE", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("XE DA DUOC XOA", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("THAO TAC KHONG DUOC THUC THI", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_repair_Click(object sender, EventArgs e)
        {
            FormResetVehicle new_window = new FormResetVehicle();
            new_window.ShowDialog();
            if (new_window.id != "")
            {
                int index = 0;
                while (index < mysystem.listVehicle.countOfCars)
                {
                    if (mysystem.listVehicle.car[index].ID == new_window.id) break;
                    index++;
                }
                if (index < mysystem.listVehicle.countOfCars)
                {
                    if (new_window.price != -1) mysystem.listVehicle.car[index].price = new_window.price;
                    if (new_window.color != "") mysystem.listVehicle.car[index].color = new_window.color;
                    if (new_window.brand != "") mysystem.listVehicle.car[index].brand = new_window.brand;
                    if (new_window.km != -1) mysystem.listVehicle.car[index].odometer = new_window.km;
                    if (new_window.status != -1) mysystem.listVehicle.car[index].status = new_window.status;
                    MessageBox.Show("THONG TIN XE DA DUOC THAY DOI", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    index = 0;
                    while (index < mysystem.listVehicle.countOfTrucks)
                    {
                        if (mysystem.listVehicle.truck[index].ID == new_window.id) break;
                        index++;
                    }
                    if (index < mysystem.listVehicle.countOfTrucks)
                    {
                        if (new_window.price != -1) mysystem.listVehicle.truck[index].price = new_window.price;
                        if (new_window.color != "") mysystem.listVehicle.truck[index].color = new_window.color;
                        if (new_window.brand != "") mysystem.listVehicle.truck[index].brand = new_window.brand;
                        if (new_window.km != -1) mysystem.listVehicle.truck[index].odometer = new_window.km;
                        if (new_window.status != -1) mysystem.listVehicle.truck[index].status = new_window.status;
                        MessageBox.Show("THONG TIN XE DA DUOC THAY DOI", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("XE KHONG TON TAI", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("THAO TAC KHONG DUOC THUC THI", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public CarRentalManagement ResetManagement()
        {
            return mysystem;
        }
        private void btn_service_Click(object sender, EventArgs e)
        {
            FormServiceVehicle new_window = new FormServiceVehicle();
            new_window.ShowDialog();
            if (new_window.id != "" && new_window.date != "")
            {
                int index = 0;
                while (index < mysystem.listVehicle.countOfCars)
                {
                    if (mysystem.listVehicle.car[index].ID == new_window.id) break;
                    index++;
                }
                if (index < mysystem.listVehicle.countOfCars)
                {
                    bool check1 = mysystem.listVehicle.car[index].ServiceEngine(new_window.date);
                    bool check2 = mysystem.listVehicle.car[index].ServiceTires(new_window.date);
                    bool check3 = mysystem.listVehicle.car[index].ServiceTransmission(new_window.date);
                    if(check1 == true || check2 == true || check3 == true)
                    {
                        MessageBox.Show("XE DA DUOC BAO DUONG", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("XE CHUA CAN BAO DUONG", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    index = 0;
                    while (index < mysystem.listVehicle.countOfTrucks)
                    {
                        if (mysystem.listVehicle.truck[index].ID == new_window.id) break;
                        index++;
                    }
                    if (index < mysystem.listVehicle.countOfTrucks)
                    {
                        bool check1 = mysystem.listVehicle.truck[index].ServiceEngine(new_window.date);
                        bool check2 = mysystem.listVehicle.truck[index].ServiceTires(new_window.date);
                        bool check3 = mysystem.listVehicle.truck[index].ServiceTransmission(new_window.date);
                        if (check1 == true || check2 == true || check3 == true)
                        {
                            MessageBox.Show("XE DA DUOC BAO DUONG", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("XE CHUA CAN BAO DUONG", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("XE KHONG TON TAI", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("THAO TAC KHONG DUOC THUC THI", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_serviceall_Click(object sender, EventArgs e)
        {
            FormServiceFleet new_window = new FormServiceFleet();
            new_window.ShowDialog();
            if (new_window.date != "")
            {
                int a = mysystem.ServiceFleet(new_window.date);
                MessageBox.Show(string.Format("SO XE DUOC BAO DUONG LA: {0}", a),"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("THAO TAC KHONG DUOC THUC THI", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            FormSearchVehicle new_window = new FormSearchVehicle();
            new_window.ShowDialog();
            if (new_window.type == 0)
            {
                List<Car> carCheck = new List<Car>(mysystem.listVehicle.car);
                if (new_window.price_min != -1)
                {
                    int i = 0;
                    while( i < carCheck.Count())
                    {
                        if (carCheck[i].price < new_window.price_min) carCheck.RemoveAt(i);
                        else i++;
                    }
                }
                if (new_window.price_max!= -1)
                {
                    int i = 0;
                    while (i < carCheck.Count())
                    {
                        if (carCheck[i].price > new_window.price_max) carCheck.RemoveAt(i);
                        else i++;
                    }
                }
                if (new_window.capa_min!=-1)
                {
                    int i = 0;
                    while( i < carCheck.Count())
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
                    dt_search.Rows.Add(carCheck[i].price, carCheck[i].capacity, carCheck[i].color, 
                                        carCheck[i].ID, carCheck[i].brand, carCheck[i].odometer, status, "XE OTO");
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
                //
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
                //
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
                    dt_search.Rows.Add(truckCheck[i].price, truckCheck[i].payload, truckCheck[i].color, 
                                        truckCheck[i].ID, truckCheck[i].brand, truckCheck[i].odometer, status, "XE TAI");
                }
                for (int i = 0; i < carCheck.Count(); i++)
                {
                    string status = "";
                    if (carCheck[i].status == 0) status = "CO SAN";
                    else if (carCheck[i].status == 1) status = "DA DAT TRUOC";
                    else status = "DA DUOC THUE";
                    dt_search.Rows.Add(carCheck[i].price, carCheck[i].capacity, carCheck[i].color, 
                                        carCheck[i].ID, carCheck[i].brand, carCheck[i].odometer, status, "XE OTO");
                }
                dataGridView1.DataSource = dt_search;
            }
        }
        private void btn_sevicehistory_Click(object sender, EventArgs e)
        {
            try
            {
                int numrow = -1;
                numrow = dataGridView1.CurrentCell.RowIndex;
                string id = dataGridView1.Rows[numrow].Cells[3].Value.ToString();
                string type = dataGridView1.Rows[numrow].Cells[7].Value.ToString();
                Car addcar = new Car();
                Truck addtruck = new Truck();
                if (type == "XE OTO")
                {
                    int index = 0;
                    while (index < mysystem.listVehicle.car.Count())
                    {
                        if (mysystem.listVehicle.car[index].ID == id)
                        {
                            addcar = mysystem.listVehicle.car[index];
                            break;
                        }
                        index++;
                    }
                    if (addcar.serviceHistory.record.Count() > 0)
                    {
                        DataTable dt_search = new DataTable();
                        dt_search.Clear();
                        dt_search.Columns.Add("ID", typeof(string));
                        dt_search.Columns.Add("engine", typeof(string));
                        dt_search.Columns.Add("transmission", typeof(string));
                        dt_search.Columns.Add("tires", typeof(string));
                        dt_search.Columns.Add("odometerOfEngine", typeof(int));
                        dt_search.Columns.Add("odometerOfTrasmission", typeof(int));
                        dt_search.Columns.Add("odometerOfTires", typeof(int));
                        dt_search.Columns.Add("date", typeof(string));
                        ///
                        string path = @"F:\C#\CarRentalManagement\CarRentalManagement\FileServiceHistory.json";
                        if (File.Exists(path)) File.Delete(path);
                        index = 0;
                        while (index < addcar.serviceHistory.record.Count())
                        {
                            string jsonresult = JsonConvert.SerializeObject(addcar.serviceHistory.record[index]);
                            using (var tw = new StreamWriter(path, true))
                            {
                                tw.WriteLine(jsonresult.ToString());
                            }
                            dt_search.Rows.Add(addcar.serviceHistory.record[index].ID, addcar.serviceHistory.record[index].engine, 
                                                addcar.serviceHistory.record[index].transmission, addcar.serviceHistory.record[index].tires, 
                                                addcar.serviceHistory.record[index].odometerOfEngine, addcar.serviceHistory.record[index].odometerOfTrasmission,
                                                addcar.serviceHistory.record[index].odometerOfTires, addcar.serviceHistory.record[index].date);
                            index++;
                        }
                        dataGridView1.DataSource = dt_search;
                    }
                    else
                    {
                        MessageBox.Show("XE CHUA BAO DUONG", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (type == "XE TAI")
                {
                    int index = 0;
                    while (index < mysystem.listVehicle.truck.Count())
                    {
                        if (mysystem.listVehicle.truck[index].ID == id)
                        {
                            addtruck = mysystem.listVehicle.truck[index];
                            break;
                        }
                        index++;
                    }
                    if (addtruck.serviceHistory.record.Count() > 0)
                    {
                        DataTable dt_search = new DataTable();
                        dt_search.Clear();
                        dt_search.Columns.Add("ID", typeof(string));
                        dt_search.Columns.Add("engine", typeof(string));
                        dt_search.Columns.Add("transmission", typeof(string));
                        dt_search.Columns.Add("tires", typeof(string));
                        dt_search.Columns.Add("odometerOfEngine", typeof(int));
                        dt_search.Columns.Add("odometerOfTrasmission", typeof(int));
                        dt_search.Columns.Add("odometerOfTires", typeof(int));
                        dt_search.Columns.Add("date", typeof(string));
                        ///
                        string path = @"F:\C#\Desktop\CarRentalManagement\CarRentalManagement\FileServiceHistory.json";
                        if (File.Exists(path)) File.Delete(path);
                        index = 0;
                        while (index < addtruck.serviceHistory.record.Count())
                        {
                            string jsonresult = JsonConvert.SerializeObject(addtruck.serviceHistory.record[index]);
                            using (var tw = new StreamWriter(path, true))
                            {
                                tw.WriteLine(jsonresult.ToString());
                            }
                            dt_search.Rows.Add(addtruck.serviceHistory.record[index].ID, addtruck.serviceHistory.record[index].engine, 
                                                addtruck.serviceHistory.record[index].transmission, addtruck.serviceHistory.record[index].tires, 
                                                addtruck.serviceHistory.record[index].odometerOfEngine, addtruck.serviceHistory.record[index].odometerOfTrasmission,
                                                addtruck.serviceHistory.record[index].odometerOfTires, addtruck.serviceHistory.record[index].date);
                            index++;
                        }
                        dataGridView1.DataSource = dt_search;
                    }
                    else
                    {
                        MessageBox.Show("XE CHUA BAO DUONG", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("VUI LONG CHON XE", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
