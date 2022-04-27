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
    public partial class FormResetVehicle : Form
    {
        public FormResetVehicle()
        {
            InitializeComponent();
        }

        public string id = "";
        public int price = -1;
        public int capa = -1;
        public string color = "";
        public string brand = "";
        public int km = -1;
        public int status = -1;
        
        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (txt_price.Text != "") price = Int32.Parse(txt_price.Text.ToString());
            if (txt_capa.Text != "") capa = Int32.Parse(txt_capa.Text.ToString());
            color = txt_color.Text.ToString();
            id = txt_id.Text.ToString();
            brand = txt_brand.Text.ToString();
            if (txt_km.Text != "") km = Int32.Parse(txt_km.Text.ToString());
            if (cmb_status.Text.ToString() != "") status = cmb_status.SelectedIndex;
            this.Close();
        }
    }
}
