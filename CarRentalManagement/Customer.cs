using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement
{
    public class Customer
    {
        public string name;
        public string birthDay;
        public string idCode;
        public int phoneNumber;
        public int point;

        public Customer(string name ,string birthDay, string idCode, 
                        int phoneNumber, int point)
        {
            this.name = name;
            this.birthDay = birthDay;
            this.idCode = idCode;
            this.phoneNumber = phoneNumber;
            this.point = point;
        }
        public Customer()
        {
            this.name = "";
            this.birthDay = "";
            this.idCode = "";
            this.phoneNumber = 0;
            this.point = 0;
        }
        public Customer(Customer a)
        {
            this.name = a.name;
            this.birthDay = a.birthDay;
            this.idCode = a.idCode;
            this.phoneNumber = a.phoneNumber;
            this.point = a.point;
        }
        public static int operator -(Customer a, Customer b)
        {
            return a.point - b.point;
        }
        public static bool operator ==(Customer a, Customer b)
        {
            if (a.name == b.name) return true;
            else return false;
        }
        public static bool operator !=(Customer a, Customer b)
        {
            if (a.name == b.name) return false;
            else return true;
        }
        ~Customer() { }
    }
}
