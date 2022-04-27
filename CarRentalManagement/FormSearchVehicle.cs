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
    public partial class FormSearchVehicle : Form
    {
        public CarRentalManagement check = new CarRentalManagement();
        public FormSearchVehicle()
        {
            InitializeComponent();
        }

        public int price_max = -1;
        public int price_min = -1;
        public int capa_min = -1;
        public int capa_max = -1;
        public string brand = "";
        public string color = "";
        public string id = "";
        public int type = -1;
        public int status = -1;
        
        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (txt_price_max.Text.ToString() != "") price_max = Int32.Parse(txt_price_max.Text.ToString());
            if (txt_price_min.Text.ToString() != "") price_min = Int32.Parse(txt_price_min.Text.ToString());
            if (txt_capa_min.Text.ToString() != "") capa_min = Int32.Parse(txt_capa_min.Text.ToString());
            if (txt_capa_max.Text.ToString() != "") capa_max = Int32.Parse(txt_capa_max.Text.ToString());
            brand = txt_brand.Text.ToString();
            color = txt_color.Text.ToString();
            id = txt_id.Text.ToString();
            if (cmb_type.Text.ToString() != "") type = cmb_type.SelectedIndex;
            if (cmb_status.Text.ToString() != "") status = cmb_status.SelectedIndex;
            this.Close();
        }
    }
}
