using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement
{
    public class BookContract: Contract
    {
        public BookContract(Customer renter, Car car, string beginDay, string endDay)
        {
            this.renter = renter;
            this.car = car;
            this.truck = null;
            this.beginDay = beginDay;
            this.endDay = endDay;
        }
        public BookContract(Customer renter, Truck truck, string beginDay, string endDay)
        {
            this.renter = renter;
            this.car = null;
            this.truck = truck;
            this.beginDay = beginDay;
            this.endDay = endDay;
        }
        public BookContract(Contract contracts)
        {
            this.renter = contracts.renter;
            this.truck = contracts.truck;
            this.car = contracts.car;
            this.beginDay = contracts.beginDay;
            this.endDay = contracts.endDay;
        }
        public BookContract()
        {
            renter = new Customer();
            car = new Car();
            truck = new Truck();
            beginDay = "";
            endDay = "";
        }
    }
}
