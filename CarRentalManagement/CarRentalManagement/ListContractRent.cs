using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement
{
    public class ListContractRent
    {
        private List<Contract> contract = new List<Contract>();
        public int count;

        public ListContractRent()
        {
            contract = new List<Contract>();
            count = 0;
        }
        public void AddContract(Contract a)
        {
            Contract newContract = new Contract(a);
            bool check = false;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (contract[i].code == a.code)
                    {
                        check = true;
                        break;
                    }
                }
            }
            if (check == false)
            {
                contract.Add(newContract);
                count++;
            }
            else Console.WriteLine("XE DA TON TAI");

        }
        public void RemoveContract(string code)
        {
            bool check = false;
            int index = 0;
            if (count > 0)
            {

                while (index < count)
                {
                    if (contract[index].code == code)
                    {
                        check = true;
                        break;
                    }
                    index++;
                }
            }
            if (check)
            {
                contract.RemoveAt(index);
                count--;
            }
            else Console.WriteLine("XE KHONG TON TAI");
        }
    }
}
