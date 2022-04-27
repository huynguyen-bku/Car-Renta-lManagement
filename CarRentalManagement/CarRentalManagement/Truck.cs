using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement
{
    public class Truck : Vehicle
    {
        public int payload;

        public Truck()
        {
            this.price = 0;
            this.color = "";
            this.ID = "";
            this.brand = "";
            this.payload = 0;
            this.odometer = 0;
            this.status = 0;
        }
        public Truck(int price, string color, string IDcar, string brand, int payload, int odometer, int status)
        {
            this.price = price;
            this.color = color;
            this.ID = IDcar;
            this.brand = brand;
            this.payload = payload;
            this.odometer = odometer;
            this.status = status;
        }
        public Truck(Truck old)
        {
            this.price = old.price;
            this.color = old.color;
            this.ID = old.ID;
            this.brand = old.brand;
            this.payload = old.payload;
            this.odometer = old.odometer;
            this.status = old.status;
        }
        public bool ServiceEngine(string time)
        {
            serviceHistory.SetIDcar(ID);
            if (serviceHistory.count == 0)
            {
                serviceHistory.SetIDcar(ID);
                if (odometer >= 2000 && odometer < 6000)
                {
                    string t = "oil change";
                    serviceHistory.AddEngine(t, time, odometer);
                }
                else if (odometer >= 6000 && odometer < 10000)
                {
                    string t = "oil change, minor repair";
                    serviceHistory.AddEngine(t, time, odometer);
                }
                else if (odometer >= 10000)
                {
                    string t = "oil change, minor change, major repair";
                    serviceHistory.AddEngine(t, time, odometer);
                }
                else return false;
            }
            else
            {
                if (odometer - serviceHistory.record[serviceHistory.count - 1].odometerOfEngine >= 2000 
                    && odometer - serviceHistory.record[serviceHistory.count - 1].odometerOfEngine < 6000)
                {
                    string t = "oil change";
                    serviceHistory.AddEngine(t, time, odometer);
                }
                else if (odometer - serviceHistory.record[serviceHistory.count - 1].odometerOfEngine >= 6000 
                        && odometer - serviceHistory.record[serviceHistory.count - 1].odometerOfEngine < 10000)
                {
                    string t = "oil change, minor repair";
                    serviceHistory.AddEngine(t, time, odometer);
                }
                else if (odometer - serviceHistory.record[serviceHistory.count - 1].odometerOfEngine >= 10000)
                {
                    string t = "oil change, minor change, major repair";
                    serviceHistory.AddEngine(t, time, odometer);
                }
                else return false;
            }
            return true;
        }
        public bool ServiceTransmission(string time)
        {
            serviceHistory.SetIDcar(ID);
            if (serviceHistory.count == 0)
            {
                if ((odometer >= 4500) && (odometer < 9000))
                {
                    string t = "fluid change";
                    serviceHistory.AddTrans(t, time, odometer);
                }
                else if ((odometer >= 9000) && (odometer < 17500))
                {
                    string t = "fluid change, minor";
                    serviceHistory.AddTrans(t, time, odometer);
                }
                else if (odometer >= 17500)
                {
                    string t = "fluid change, minor, overhaul";
                    serviceHistory.AddTrans(t, time, odometer);
                }
                else return false;
            }
            else
            {
                if ((odometer - serviceHistory.record[serviceHistory.count - 1].odometerOfTrasmission >= 5000) 
                    && (odometer - serviceHistory.record[serviceHistory.count - 1].odometerOfTrasmission < 8000))
                {
                    string t = "fluid change";
                    serviceHistory.AddTrans(t, time, odometer);
                }
                else if ((odometer - serviceHistory.record[serviceHistory.count - 1].odometerOfTrasmission >= 8000) 
                        && (odometer - serviceHistory.record[serviceHistory.count - 1].odometerOfTrasmission < 16000))
                {
                    string t = "fluid change, minor";
                    serviceHistory.AddTrans(t, time, odometer);
                }
                else if (odometer - serviceHistory.record[serviceHistory.count - 1].odometerOfTrasmission >= 16000)
                {
                    string t = "fluid change, minor, overhaul";
                    serviceHistory.AddTrans(t, time, odometer);
                }
                else return false;
            }
            return true;
        }
        public bool ServiceTires(string time)
        {
            serviceHistory.SetIDcar(ID);
            if (serviceHistory.count == 0)
            {
                if ((odometer >= 10000) && (odometer < 20000))
                {
                    string t = "adjustment";
                    serviceHistory.AddTires(t, time, odometer);
                }
                else if (odometer >= 20000)
                {
                    string t = "replacement";
                    serviceHistory.AddTires(t, time, odometer);
                }
                else return false;
            }
            else
            {
                if ((odometer - serviceHistory.record[serviceHistory.count - 1].odometerOfTires >= 10000) 
                    && (odometer - serviceHistory.record[serviceHistory.count - 1].odometerOfTires < 20000))
                {
                    string t = "adjustment";
                    serviceHistory.AddTires(t, time, odometer);
                }
                else if (odometer - serviceHistory.record[serviceHistory.count - 1].odometerOfTires >= 20000)
                {
                    string t = "replacement";
                    serviceHistory.AddTires(t, time, odometer);
                }
                else return false;
            }
            return true;
        }
        ~Truck() { }
    }
}
