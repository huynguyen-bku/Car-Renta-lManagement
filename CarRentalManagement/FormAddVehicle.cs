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
    public partial class FormAddVehicle : Form
    {
        public FormAddVehicle()
        {
            InitializeComponent();
        }

        public Truck newTruck = new Truck();
        public Car newCar = new Car();

        private void btn_OK_Click(object sender, EventArgs e)
        {
            int check = cmb_type.SelectedIndex;
            if (check == 1)
            {
                if (txt_price.Text != "") newTruck.price = Int32.Parse(txt_price.Text.ToString());
                else newTruck.price = 0;
                if (txt_capacity.Text != "") newTruck.payload = Int32.Parse(txt_capacity.Text.ToString());
                else newTruck.payload = 0;
                newTruck.color = txt_color.Text.ToString();
                newTruck.ID = txt_code.Text.ToString();
                newTruck.brand = txt_brand.Text.ToString();
                if (txt_km.Text != "") newTruck.odometer = Int32.Parse(txt_km.Text.ToString());
                else newTruck.odometer = 0;
                newTruck.status = cmb_status.SelectedIndex;
            }
            else 
            {
                if (txt_price.Text != "") newCar.price = Int32.Parse(txt_price.Text.ToString());
                else newCar.price = 0;
                if (txt_capacity.Text != "") newCar.capacity = Int32.Parse(txt_capacity.Text.ToString());
                else newCar.capacity = 0;
                newCar.color = txt_color.Text.ToString();
                newCar.ID = txt_code.Text.ToString();
                newCar.brand = txt_brand.Text.ToString();
                if (txt_km.Text != "") newCar.odometer = Int32.Parse(txt_km.Text.ToString());
                else newCar.odometer = 0;
                newCar.status = cmb_status.SelectedIndex;
            }
            this.Close();
        }
        private void FormAddCar_Load(object sender, EventArgs e)
        {
            cmb_type.SelectedIndex = 0;
            cmb_status.SelectedIndex = 0;
        }
    }
}
