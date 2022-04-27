using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CarRentalManagement
{
    public class Vehicle
    {
        public int price;
        public string color;
        public string ID;
        public string brand;
        public int odometer;
        public int status;
        public ServiceHistory serviceHistory = new ServiceHistory();

        public Vehicle()
        {
            price = 0;
            color = "";
            ID = "";
            brand = "";
            status = 0;
            odometer = 0;
        }
        public Vehicle(int p, string co, string id, string br, int stt, int od)
        {
            price = p;
            color = co;
            ID = id;
            brand = br;
            status =stt;
            odometer = od;
        }
        ~Vehicle() { }
    }
}
