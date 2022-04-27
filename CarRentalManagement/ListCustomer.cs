using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement
{
    public class ListCustomer
    {
        public List<Customer> customers = new List<Customer>();
        public int count;

        public ListCustomer()
        {
            customers = new List<Customer>();
            count = 0;
        }
        public void AddNewCustomer(string name, string birthDay, 
                                    string idCode, int phoneNumber, int point)
        {
            Customer newCustomer = new Customer(name, birthDay, idCode, phoneNumber, point);
            bool check = false;
            if (customers.Count()>0)
            {
                for (int i = 0; i < customers.Count; i++)
                {
                    if (customers[i].idCode == idCode)
                    {
                        check = true;
                        break;
                    }
                }
            }
            if (!check)
            {
                customers.Add(newCustomer);
                count++;
            }
            else Console.WriteLine("NGUOI DUNG DA TON TAI");
        }
        public bool AddNewCustomer(Customer a)
        {
            
            if (count > 0)
            {
                for (int i = 0; i < customers.Count; i++)
                {
                    if (customers[i].idCode == a.idCode) return false;
                }
            }
            customers.Add(a);
            count++;
            return true;
        }
        public bool RemoveCustomer(string idCode)
        {
            int index = 0;
            if (count > 0)
            {
                while (index < customers.Count())
                {
                    if (customers[index].idCode == idCode)
                    {
                        customers.RemoveAt(index);
                        return true;
                    }
                    index++;
                }
            }
            return false;
        }
    }
}
