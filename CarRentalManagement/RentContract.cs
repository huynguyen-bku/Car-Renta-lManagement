using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement
{
    public class RentContract: Contract
    {
        public int downPayment;
        
        public RentContract(Customer renter, Car car,string beginDay, string endDay, int downPayment)
        {
            this.renter = renter;
            this.car = car;
            this.truck = null;
            this.beginDay = beginDay;
            this.endDay = endDay;
            this.downPayment = downPayment;
        }
        public RentContract(Customer renter, Truck truck,string beginDay, string endDay,int downPayment)
        {
            this.renter = renter;
            this.car = null;
            this.truck = truck;
            this.beginDay = beginDay;
            this.endDay = endDay;
            this.downPayment = downPayment;
        }
        public RentContract(RentContract contracts)
        {
            this.renter = contracts.renter;
            this.truck = contracts.truck;
            this.car = contracts.car;
            this.beginDay = contracts.beginDay;
            this.endDay = contracts.endDay;
            this.downPayment = contracts.downPayment;
        }
        public RentContract(BookContract bookContract,int downPayment)
        {
            this.renter = bookContract.renter;
            this.truck = bookContract.truck;
            this.car = bookContract.car;
            this.beginDay = bookContract.beginDay;
            this.endDay = bookContract.endDay;
            this.downPayment = downPayment;
        }
        public RentContract()
        {
            renter = new Customer();
            car = new Car();
            truck = new Truck();
            beginDay = "";
            endDay = "";
            this.downPayment = 0;
        }
    }
}
