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
    public partial class FormDeleteCusbyID : Form
    {
        public FormDeleteCusbyID()
        {
            InitializeComponent();
        }

        public string id = "";
        
        private void btn_ok_Click(object sender, EventArgs e)
        {
            id = txt_input.Text.ToString();
            this.Close();
        }
    }
}
