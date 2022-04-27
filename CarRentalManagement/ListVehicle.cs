using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement
{
    public class ListVehicle
    {
        public List<Car> car = new List<Car>();
        public List<Truck> truck = new List<Truck>();
        public int countOfAll;
        public int countOfCars;
        public int countOfTrucks;

        public ListVehicle()
        {
            car = new List<Car>();
            truck = new List<Truck>();
            countOfAll = 0;
            countOfCars = 0;
            countOfTrucks = 0;
        }
        private bool CheckAll(string ID)
        {
            bool check = false;
            for (int i = 0; i < car.Count(); i++)
            {
                if (car[i].ID == ID)
                {
                    check = true;
                    break;
                }
            }
            for (int i = 0; i < truck.Count(); i++)
            {
                if (truck[i].ID == ID)
                {
                    check = true;
                    break;
                }
            }
            if (check == true) return true;
            return false;
        }
        // Them xe co day du thong tin
        public bool AddVehicle(int price, string color, string id, string brand, 
                                int all, int status, int odometer, int type)
        {
            if (type == 0)
            {
                Car newCar = new Car(price, color, id, brand, all, status, odometer);
                bool checkCar = CheckAll(newCar.ID);
                if (checkCar == false)
                {
                    car.Add(newCar);
                    countOfAll++;
                    countOfCars++;
                    return true;
                }
                else return false;
            }
            else if (type == 1)
            {
                Truck newTruck = new Truck(price, color, id, brand, all, odometer, status);
                bool checkCar = CheckAll(newTruck.ID);
                if (checkCar == false)
                {
                    truck.Add(newTruck);
                    countOfTrucks++;
                    countOfAll++;
                    return true;
                }
                else return false;
            }
            return false;
        }
        // Them xe moi nhung chua co gia thue
        public bool AddVehicle(string color, string id, string brand,int all,int type)
        {
            if (type == 0)
            {
                Car newCar = new Car(0,color, id, brand, all, 0, 0);
                bool checkCar = CheckAll(newCar.ID);
                if (checkCar == false)
                {
                    car.Add(newCar);
                    countOfAll++;
                    countOfCars++;
                    return true;
                }
                else return false;
            }
            else if (type == 1)
            {
                Truck newTruck = new Truck(0, color, id, brand, all, 0, 0);
                bool checkCar = CheckAll(newTruck.ID);
                if (checkCar == false)
                {
                    truck.Add(newTruck);
                    countOfAll++;
                    countOfTrucks++;
                    return true;
                }
                else return false;
            }
            else return false;
        }
        // Them xe cu 
        public bool AddVehicle(string color, string id, string brand, 
                                int all, int status, int odometer, int type)
        {
            if (type == 0)
            {
                Car newCar = new Car(0, color, id, brand, all, status, odometer);
                bool checkCar = CheckAll(newCar.ID);
                if (checkCar == false)
                {
                    car.Add(newCar);
                    countOfAll++;
                    countOfCars++;
                    return true;
                }
                else return false;
            }
            else if (type == 1)
            {
                Truck newTruck = new Truck(0, color, id, brand, all, status, odometer);
                bool checkCar = CheckAll(newTruck.ID);
                if (checkCar == false)
                {
                    truck.Add(newTruck);
                    countOfAll++;
                    countOfTrucks++;
                    return true;
                }
                else return false;
            }
            else return false;
        }
        // Xoa 1 xe trong nhom
        public bool AddVehicle(Car newCar)
        {
            bool checkCar = CheckAll(newCar.ID);
            if (checkCar == false)
            {
                car.Add(newCar);
                countOfAll++;
                countOfCars++;
                return true;
            }
            else return false;
        }
        public bool AddVehicle(Truck newTruck)
        {
            bool checkCar = CheckAll(newTruck.ID);
            if (checkCar == false)
            {
                truck.Add(newTruck);
                countOfAll++;
                countOfTrucks++;
                return true;
            }
            else return false;
        }
        public bool Remove(string id)
        {
            bool check = false;
            int index = 0;
            while (index < truck.Count())
            {
                if (truck[index].ID == id)
                {
                    truck.RemoveAt(index);
                    countOfAll--;
                    countOfTrucks--;
                    check = true;
                    break;
                }
                index++;
            }
            index = 0;
            while (index < car.Count())
            {
                if (car[index].ID == id)
                {
                    car.RemoveAt(index);
                    countOfAll--;
                    countOfCars--;
                    check = true;
                    break;
                }
                index++;
            }
            return check;
        }
    }
}
