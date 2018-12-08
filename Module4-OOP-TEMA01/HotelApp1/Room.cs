using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp
{
    public class Room
    {
        public decimal valoare;
        public string moneda;

        public string Name { get; set; }
        public Rate DailyRate(decimal valoare, string moneda)
        {
            Rate newPret = new Rate() { Amount = valoare, Currency = moneda};
            return newPret;
        }
        public int Adults { get; set; }
        public int Children { get; set; }

        public void AddRoom(string nume, int nrAdulti, int nrCopii)
        {
            this.Name = nume;
            this.Adults = nrAdulti;
            this.Children = nrCopii;
        }

        public string Print()
        {
            return $"   Room {Name} / Capacity: {Adults} adults & {Children} children / DailyRate: {DailyRate(valoare,moneda).Amount} {DailyRate(valoare,moneda).Currency}";
        }

        public decimal GetPriceForDays(int numberOfDays)
        {
            if (numberOfDays != 0)
            {
                decimal cost = valoare * numberOfDays;
                return cost;
            }
            else
            {
                return 0;
            }
        }
    }
}
