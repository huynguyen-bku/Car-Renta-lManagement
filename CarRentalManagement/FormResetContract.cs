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
    public partial class FormResetContract : Form
    {
        public FormResetContract()
        {
            InitializeComponent();
        }

        public int old_number = -1;
        public string name = "";
        public string date = "";
        public string id = "";
        public int phoneNumber = -1;

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txt_oldphone.Text.ToString() != "") old_number = Int32.Parse(txt_oldphone.Text.ToString());
            name = txt_name.Text.ToString();
            date = txt_date.Text.ToString();
            id = txt_id.Text.ToString();
            if (txt_phone.Text.ToString() != "") phoneNumber = Int32.Parse(txt_phone.Text.ToString());
            this.Close();
        }
    }
}
