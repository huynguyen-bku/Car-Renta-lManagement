using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement
{
    public class ListContract
    {
        public List<BookContract> bookContracts = new List<BookContract>();
        private List<RentContract> rentContracts = new List<RentContract>();
        public RentContract SearchRentContracts(int phoneNumber)
        {
            RentContract check = null;
            int index = 0;
            while (index < rentContracts.Count())
            {
                if (rentContracts[index].renter.phoneNumber == phoneNumber)
                {
                     check = rentContracts[index];
                    break;
                }
                index++;
            }
            return check;
        }
        public ListContract()
        {
            bookContracts = new List<BookContract>();
            rentContracts = new List<RentContract>();
        }
        public bool AddBookContract(BookContract a)
        {
            bool check = false;
            if (bookContracts.Count() > 0)
            {
                for (int i = 0; i < bookContracts.Count(); i++)
                {
                    if (bookContracts[i].renter.phoneNumber == a.renter.phoneNumber)
                    {
                        check = true;
                        break;
                    }
                }
            }
            if (check == false)
            {
                bookContracts.Add(a);
                return true;
            }
            else return false;
        }
        public bool AddRentContract(RentContract a)
        {
            bool check = false;
            if (rentContracts.Count() > 0)
            {
                for (int i = 0; i < bookContracts.Count(); i++)
                {
                    if (rentContracts[i].renter.phoneNumber == a.renter.phoneNumber)
                    {
                        check = true;
                        break;
                    }
                }
            }
            if (check == false)
            {
                rentContracts.Add(a);
                return true;
            }
            else return false;
        }
        public bool RemoveBookContract(int phoneNumber)
        {
            int index = 0;
            while(index<bookContracts.Count())
            {
                if (rentContracts[index].renter.phoneNumber == phoneNumber)
                {
                    bookContracts.RemoveAt(index);
                    return true;
                }
            }
            return false;
        }
        public bool RemoveRentContract(int phoneNumber)
        {
            int index = 0;
            while (index < rentContracts.Count())
            {
                if (rentContracts[index].renter.phoneNumber == phoneNumber)
                {
                    rentContracts.RemoveAt(index);
                    return true;
                }
            }
            return false;
        }
    }
}
