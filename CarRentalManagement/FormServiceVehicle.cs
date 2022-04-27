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
    public partial class FormServiceVehicle : Form
    {
        public FormServiceVehicle()
        {
            InitializeComponent();
        }

        public string id = "";
        public string date = "";
        
        private void btn_ok_Click(object sender, EventArgs e)
        {
            id = txt_id.Text.ToString();
            date = txt_date.Text.ToString();
            this.Close();
        }
    }
}
