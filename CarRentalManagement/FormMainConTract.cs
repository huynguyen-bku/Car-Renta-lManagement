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
    public partial class FormMainConTract : Form
    {
        public FormMainConTract(CarRentalManagement mysystem)
        {
            InitializeComponent();
            this.mysystem = mysystem;
        }

        public CarRentalManagement mysystem = new CarRentalManagement();

        private void FormConTract_Load(object sender, EventArgs e)
        {

        }
        public CarRentalManagement ResetManagement()
        {
            return mysystem;
        }
        private void btn_create_Click(object sender, EventArgs e)
        {
            FormAddContract new_window = new FormAddContract(mysystem);
            new_window.ShowDialog();
            mysystem = new_window.Reset();
        }
        private void btn_repair_book_Click(object sender, EventArgs e)
        {
            FormResetContract new_windown = new FormResetContract();
            new_windown.ShowDialog();
            if (new_windown.old_number != -1)
            {
                int index = 0;
                while (index < mysystem.listContract.bookContracts.Count())
                {
                    if (mysystem.listContract.bookContracts[index].renter.phoneNumber == new_windown.phoneNumber)
                    {
                        if (new_windown.name != "") mysystem.listContract.bookContracts[index].renter.name = new_windown.name;
                        if (new_windown.date != "") mysystem.listContract.bookContracts[index].renter.birthDay = new_windown.date;
                        if (new_windown.id != "") mysystem.listContract.bookContracts[index].renter.idCode = new_windown.id;
                        if (new_windown.phoneNumber != -1) mysystem.listContract.bookContracts[index].renter.phoneNumber = new_windown.phoneNumber;
                    }
                    index++;
                }
            }
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            FormRemoveContract new_windown = new FormRemoveContract();
            new_windown.ShowDialog();
            if (new_windown.phoneNumber != -1)
            {
                DataTable dt_search = new DataTable();
                dt_search.Clear();
                dt_search.Columns.Add("TEN", typeof(string));
                dt_search.Columns.Add("SO DT", typeof(int));
                dt_search.Columns.Add("BIEN SO XE", typeof(string));
                dt_search.Columns.Add("LOAI HOP DONG", typeof(string));
                /////
                int index = 0;
                while (index < mysystem.listContract.bookContracts.Count())
                {
                    if (mysystem.listContract.bookContracts[index].renter.phoneNumber == new_windown.phoneNumber)
                    {
                        if (mysystem.listContract.bookContracts[index].truck!= null)
                            dt_search.Rows.Add(mysystem.listContract.bookContracts[index].renter.name, 
                                                mysystem.listContract.bookContracts[index].renter.phoneNumber, 
                                                mysystem.listContract.bookContracts[index].truck.ID, "BOOK");
                        if (mysystem.listContract.bookContracts[index].car != null)
                            dt_search.Rows.Add(mysystem.listContract.bookContracts[index].renter.name, 
                                                mysystem.listContract.bookContracts[index].renter.phoneNumber, 
                                                mysystem.listContract.bookContracts[index].car.ID, "BOOK");
                        break;
                    }
                    index++;
                }
                if(index == mysystem.listContract.bookContracts.Count())
                {
                    RentContract check = mysystem.listContract.SearchRentContracts(new_windown.phoneNumber);
                    if (check == null)
                    {
                        MessageBox.Show("KHONG TON TAI HOP DONG", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (check.truck != null) dt_search.Rows.Add(check.renter.name, check.renter.phoneNumber, check.truck.ID, "RENT");
                        if (check.car != null) dt_search.Rows.Add(check.renter.name, check.renter.phoneNumber, check.car.ID, "RENT");
                    }
                }
                dataGridView2.DataSource = dt_search;
            }
            else
            {
                DataTable dt_search = new DataTable();
                dt_search.Clear();
                dt_search.Columns.Add("TEN", typeof(string));
                dt_search.Columns.Add("SO DT", typeof(int));
                dt_search.Columns.Add("BIEN SO XE", typeof(string));
                dt_search.Columns.Add("LOAI HOP DONG", typeof(string));
                /////
                int index = 0;
                while (index < mysystem.listContract.bookContracts.Count())
                {
                    if (mysystem.listContract.bookContracts[index].truck != null)
                        dt_search.Rows.Add(mysystem.listContract.bookContracts[index].renter.name, 
                                            mysystem.listContract.bookContracts[index].renter.phoneNumber, 
                                            mysystem.listContract.bookContracts[index].truck.ID, "BOOK");
                    if (mysystem.listContract.bookContracts[index].car != null)
                        dt_search.Rows.Add(mysystem.listContract.bookContracts[index].renter.name, 
                                            mysystem.listContract.bookContracts[index].renter.phoneNumber, 
                                            mysystem.listContract.bookContracts[index].car.ID, "BOOK");
                    index++;
                }
                index = 0;
                while (index < mysystem.listContract.bookContracts.Count())
                {
                    RentContract check = mysystem.listContract.SearchRentContracts(new_windown.phoneNumber);
                    if (check.truck != null) dt_search.Rows.Add(check.renter.name, check.renter.phoneNumber, 
                                                                check.truck.ID, "RENT");
                    if (check.car != null) dt_search.Rows.Add(check.renter.name, check.renter.phoneNumber, 
                                                                check.car.ID, "RENT");
                    index++;
                }
                dataGridView2.DataSource = dt_search;
            }
        }
        private void btn_ChangeContract_Click(object sender, EventArgs e)
        {
            
            FormChangeContract new_window = new FormChangeContract();
            new_window.ShowDialog();
            if (new_window.downPayment != -1 && new_window.phoneNumber != -1)
            {
                int index = 0;
                while (index < mysystem.listContract.bookContracts.Count())
                {
                    if (mysystem.listContract.bookContracts[index].renter.phoneNumber == new_window.phoneNumber)
                    {
                        if (mysystem.listContract.bookContracts[index].car != null)
                        {
                            int i = 0;
                            while (i < mysystem.listVehicle.car.Count())
                            {
                                if(mysystem.listVehicle.car[i].ID== mysystem.listContract.bookContracts[index].car.ID)
                                {
                                    mysystem.listVehicle.car[i].status = 2;
                                    break;
                                }
                                i++;
                            }
                            mysystem.listContract.bookContracts[index].car.status = 2;
                        }
                        else
                        {
                            int i = 0;
                            while (i < mysystem.listVehicle.truck.Count())
                            {
                                if (mysystem.listVehicle.truck[i].ID == mysystem.listContract.bookContracts[index].truck.ID)
                                {
                                    mysystem.listVehicle.truck[i].status = 2;
                                    break;
                                }
                                i++;
                            }
                            mysystem.listContract.bookContracts[index].truck.status = 2;
                        }
                        RentContract add = new RentContract(mysystem.listContract.bookContracts[index], new_window.downPayment);
                        mysystem.listContract.bookContracts.RemoveAt(index);
                        mysystem.listContract.AddRentContract(add);
                        break;
                    }
                    index++;
                }
            }
        }
        private void btn_remove_Click(object sender, EventArgs e)
        {
            FormRemoveContract new_windown = new FormRemoveContract();
            new_windown.ShowDialog();
            int index = 0;
            if (new_windown.phoneNumber != -1)
            {
                while (index < mysystem.listContract.bookContracts.Count())
                {
                    if (mysystem.listContract.bookContracts[index].renter.phoneNumber == new_windown.phoneNumber)
                    {
                        if (mysystem.listContract.bookContracts[index].car != null)
                        {
                            int i = 0;
                            while (i < mysystem.listVehicle.car.Count())
                            {
                                if (mysystem.listVehicle.car[i].ID == mysystem.listContract.bookContracts[index].car.ID)
                                {
                                    mysystem.listVehicle.car[i].status = 0;
                                    break;
                                }
                                i++;
                            }
                        }
                        else
                        {
                            int i = 0;
                            while (i < mysystem.listVehicle.truck.Count())
                            {
                                if (mysystem.listVehicle.truck[i].ID == mysystem.listContract.bookContracts[index].truck.ID)
                                {
                                    mysystem.listVehicle.truck[i].status = 0;
                                    break;
                                }
                                i++;
                            }
                        }
                        mysystem.listContract.bookContracts.RemoveAt(index);
                        MessageBox.Show("HOP DONG DA DUOC XOA", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    index++;
                }
                if (index == mysystem.listContract.bookContracts.Count())
                {
                    if (mysystem.listContract.SearchRentContracts(new_windown.phoneNumber) != null)
                    {
                        RentContract check = new RentContract(mysystem.listContract.SearchRentContracts(new_windown.phoneNumber));
                        if (check.car != null)
                        {
                            int i = 0;
                            while (i < mysystem.listVehicle.car.Count())
                            {
                                if (mysystem.listVehicle.car[i].ID == check.car.ID)
                                {
                                    mysystem.listVehicle.car[i].status = 0;
                                    break;
                                }
                                i++;
                            }
                        }
                        else
                        {
                            int i = 0;
                            while (i < mysystem.listVehicle.truck.Count())
                            {
                                if (mysystem.listVehicle.truck[i].ID == check.truck.ID)
                                {
                                    mysystem.listVehicle.truck[i].status = 0;
                                    break;
                                }
                                i++;
                            }
                        }
                        mysystem.listContract.RemoveRentContract(new_windown.phoneNumber);
                        MessageBox.Show("HOP DONG DA DUOC XOA", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("KHONG TON TAI HOP DONG", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("KHONG TON TAI HOP DONG", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
