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
    public partial class FormRemoveCar : Form
    {
        public FormRemoveCar()
        {
            InitializeComponent();
        }

        public string ID;
        
        private void btn_ok_Click(object sender, EventArgs e)
        {
            ID = txt_id.Text.ToString();
        }
    }
}
