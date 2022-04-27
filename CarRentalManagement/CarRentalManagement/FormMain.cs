using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalManagement;
namespace CarRentalManagement
{
    public partial class FormMain : Form
    {
        CarRentalManagement mySystem;
        public FormMain(CarRentalManagement carRentalManagement)
        {
            InitializeComponent();
            this.mySystem = carRentalManagement;
        }
        public FormMain()
        {
            InitializeComponent();
        }
        private void btn_ListVehicle_Click(object sender, EventArgs e)
        {
            FormCar listcar = new FormCar(mySystem);
            listcar.ShowDialog();
            mySystem = listcar.ResetManagement();
        }
        private void btn_listcustomer_Click(object sender, EventArgs e)
        {
            FormCustomer cus = new FormCustomer(this.mySystem);
            cus.ShowDialog();
        }
        public CarRentalManagement MySystem()
        {
            return mySystem;
        }
    }
}
