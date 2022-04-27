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
    public partial class FormSearchCustomer : Form
    {
        CarRentalManagement mysystem;
        public FormSearchCustomer()
        {
            InitializeComponent();
        }
        public FormSearchCustomer(CarRentalManagement mySystem)
        {
            InitializeComponent();
            this.mysystem = mySystem;
        }

        public int  phoneNumer = -1;

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            if (txt_input.Text.ToString() != "") phoneNumer = Int32.Parse(txt_input.Text.ToString());
            this.Close();
        }

    }
}
