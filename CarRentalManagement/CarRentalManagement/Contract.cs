using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement
{
    public class Contract
    {
        public string code;
        public Customer renter;
        public Car car;
        public Truck truck;
        public string content;
        public string beginDay;
        public string endDay;

        // Tao hop dong thue xe 
        public Contract(string code, Customer renter, Car car, 
                        string content, string beginDay, string endDay)
        {
            this.code = code;
            this.renter = renter;
            this.car = car;
            this.truck = null;
            this.content = content;
            this.beginDay = beginDay;   
            this.endDay = endDay;
        }
        public Contract(string code, Customer renter, Truck truck, 
                        string content, string beginDay, string endDay)
        {
            this.code = code;
            this.renter = renter;
            this.car = null;
            this.truck = truck;
            this.content = content;
            this.beginDay = beginDay;
            this.endDay = endDay;
        }
        public Contract(Contract contracts)
        {
            this.code = contracts.code;
            this.renter = contracts.renter;
            this.truck = contracts.truck;
            this.car = contracts.car;
            this.content = contracts.content;
            this.beginDay = contracts.beginDay;
            this.endDay = contracts.endDay;
        }
        public Contract()
        {
            code = "";
            renter = null;
            car = null;
            truck = null;
            content = "";
            beginDay = "";
            endDay = "";
        }    
    }
}
