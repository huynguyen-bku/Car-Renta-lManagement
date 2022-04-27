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
        public FormMain(CarRentalManagement carRentalManagement)
        {
            InitializeComponent();
            mySystem = carRentalManagement;
        }

        CarRentalManagement mySystem = new CarRentalManagement();

        private void btn_ListVehicle_Click(object sender, EventArgs e)
        {
            FormMainVehicle vehicle = new FormMainVehicle(mySystem);
            vehicle.ShowDialog();
            mySystem = vehicle.ResetManagement();
        }
        private void btn_listcustomer_Click(object sender, EventArgs e)
        {
            FormMainCustomer customer = new FormMainCustomer(mySystem);
            customer.ShowDialog();
            mySystem = customer.Reset();
        }
        public CarRentalManagement MySystem()
        {
            return mySystem;
        }
        private void btn_listcontract_Click(object sender, EventArgs e)
        {
            FormMainConTract conTract = new FormMainConTract(mySystem);
            conTract.ShowDialog();
            mySystem = conTract.ResetManagement();
        }
    }
}
