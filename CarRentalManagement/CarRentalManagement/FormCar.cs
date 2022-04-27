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
    public partial class FormCar : Form
    {
        public FormCar(CarRentalManagement mySystem)
        {
            InitializeComponent();
            this.mysystem = mySystem;
        }

        CarRentalManagement mysystem = new CarRentalManagement();
        DataTable dt_car = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            dt_car.Clear();
            dt_car.Columns.Add("GIA THUE", typeof(int));
            dt_car.Columns.Add("SUC CHUA", typeof(int));
            dt_car.Columns.Add("MAU XE", typeof(string));
            dt_car.Columns.Add("BIEN SO", typeof(string));
            dt_car.Columns.Add("HANG XE", typeof(string));
            dt_car.Columns.Add("TINH TRANG XE", typeof(int));
            dt_car.Columns.Add("SO CONGTOMET", typeof(int));
            dt_car.Columns.Add("LOAI XE", typeof(string));
        }
        private void btn_listcars_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt_car;
        }
        private void btn_addcar_Click(object sender, EventArgs e)
        {
            FormAddCar new_window = new FormAddCar();
            new_window.ShowDialog();
            Car car = new_window.newcar;
            Truck truck = new_window.newtruck;
            if (truck != null)
            {
                bool test = mysystem.listVehicle.AddVehicle(truck);
                if (test == true) dt_car.Rows.Add(truck.price, truck.payload, truck.color, truck.ID, 
                                                truck.brand, truck.odometer, truck.status, "XE TAI");
            }
            else if (car != null)
            {
                bool test = mysystem.listVehicle.AddVehicle(car);
                if (test == true) dt_car.Rows.Add(car.price, car.capacity, car.color, car.ID, 
                                                car.brand, car.odometer, car.status, "XE OTO");
            }
            dataGridView1.DataSource = dt_car;
        }
        private void btn_removecar_Click(object sender, EventArgs e)
        {
            FormRemoveCar new_window = new FormRemoveCar();
            new_window.ShowDialog();
            string ID = new_window.ID;
            mysystem.listvehicle.Remove(ID);
        }
        private void btn_repair_Click(object sender, EventArgs e)
        {
            FormReset new_window = new FormReset();
            new_window.ShowDialog();
            if (new_window.id != "")
            {
                int index = 0;
                while (index < mysystem.listVehicle.countOfCars)
                {
                    if (mysystem.listVehicle.car[index].ID == new_window.id) break;
                }
                if (index < mysystem.listVehicle.countOfCars)
                {
                    if (new_window.price != -1) mysystem.listVehicle.car[index].price = new_window.price;
                    if (new_window.color != "") mysystem.listVehicle.car[index].color = new_window.color;
                    if (new_window.brand != "") mysystem.listVehicle.car[index].brand = new_window.brand;
                    if (new_window.km != -1) mysystem.listVehicle.car[index].odometer = new_window.km;
                    if (new_window.status != -1) mysystem.listVehicle.car[index].status = new_window.status;
                }
                else
                {
                    index = 0;
                    while (index < mysystem.listVehicle.countOfCars)
                    {
                        if (mysystem.listVehicle.truck[index].ID == new_window.id) break;
                    }
                    if (index < mysystem.listVehicle.countOfTrucks)
                    {
                        if (new_window.price != -1) mysystem.listVehicle.truck[index].price = new_window.price;
                        if (new_window.color != "") mysystem.listVehicle.truck[index].color = new_window.color;
                        if (new_window.brand != "") mysystem.listVehicle.truck[index].brand = new_window.brand;
                        if (new_window.km != -1) mysystem.listVehicle.truck[index].odometer = new_window.km;
                        if (new_window.status != -1) mysystem.listVehicle.truck[index].status = new_window.status;
                    }
                }
            }
        }
        private void FormCar_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        public CarRentalManagement ResetManagement()
        {
            return mysystem;
        }
    }
}
