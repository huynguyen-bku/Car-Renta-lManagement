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
    public partial class FormRemoveContract : Form
    {
        public FormRemoveContract()
        {
            InitializeComponent();
        }

        public int phoneNumber = -1;

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txt_phonenumber.Text.ToString() != "") phoneNumber = Int32.Parse(txt_phonenumber.Text.ToString());
            this.Close();
        }
    }
}
