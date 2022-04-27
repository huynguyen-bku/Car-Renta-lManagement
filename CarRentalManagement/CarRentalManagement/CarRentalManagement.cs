using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement
{
    public class CarRentalManagement
    {
        public ListContractBook listcontractbook;
        public ListContractRent listcontractrent;
        public ListCustomer listcustonmer;
        public ListVehicle listvehicle;
        public Customer customer;

        public CarRentalManagement()
        {
            listContractBook = new ListContractBook();
            listContractRent = new ListContractRent();
            listCustonmer = new ListCustomer();
            listVehicle = new ListVehicle();
            customer = new Customer();
        }
        public int ServiceFleet(string time)
        {
            int total = 0;
            // sua doi xe car
            for (int i = 0; i < listVehicle.countOfCars; i++)
            {
                bool a = listVehicle.car[i].ServiceEngine(time);
                bool b = listVehicle.car[i].ServiceTires(time);
                bool c = listVehicle.car[i].ServiceTransmission(time);
                if(a==true || b==true|| c == true) total++;
            }
            for (int i = 0; i < listVehicle.countOfTrucks; i++)
            {
                bool a = listVehicle.truck[i].ServiceEngine(time);
                bool b = listVehicle.truck[i].ServiceTires(time);
                bool c = listVehicle.truck[i].ServiceTransmission(time);
                if (a == true || b == true || c == true) total++;
            }
            return total;
        }
    }
}
