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
    public partial class FormReset : Form
    {
        public FormReset()
        {
            InitializeComponent();
        }

        public string id;
        public int price;
        public int capa;
        public string color;
        public string brand;
        public int km;
        public int status;
        nbvc
        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (txt_price.Text != "") price = Int32.Parse(txt_price.Text.ToString());
            else price = -1;
            if (txt_capa.Text != "") capa = Int32.Parse(txt_capa.Text.ToString());
            else capa = -1;
            color = txt_color.Text.ToString();
            id = txt_id.Text.ToString();
            brand = txt_brand.Text.ToString();
            if (txt_km.Text != "") km = Int32.Parse(txt_km.Text.ToString());
            else km = -1;
            if (txt_status.Text != "") status = Int32.Parse(txt_status.Text.ToString());
            else status = -1;
            this.Close();
        }
        private void FormReset_Load(object sender, EventArgs e)
        {
            txt_price.Text = "";
            txt_capa.Text = "";
            txt_color.Text = "";
            txt_id.Text = "";
            txt_brand.Text = "";
            txt_km.Text = "";
            txt_status.Text = "";
        }
    }
}
