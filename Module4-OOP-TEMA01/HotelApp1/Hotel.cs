using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp
{
    public class Hotel
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Stars { get; set; }
        public List<Room> Rooms = new List<Room>();

        public void AddHotel(string numeHotel, string numeOras, string nrStele)
        {
            this.Name = numeHotel;
            this.City = numeOras;
            this.Stars = nrStele;
        }
        public void DeleteHotel(string numeHotel)
        {
            //obiectele exista atat timp cat sunt instantiate... cum fac sa le sterg?
        }
        public void GetPriceForNumberOfRooms(int numberOfRooms)
        {
            decimal pretCamere = 0;
            foreach (var cam in Rooms)
            {
                pretCamere = cam.valoare * numberOfRooms;
                Console.WriteLine($"   {numberOfRooms} '{cam.Name}' room(s) cost {pretCamere} {cam.moneda}/day");
            }
        }
        public void Print()
        {
            Console.WriteLine("   {0},{1} rated with {2} stars, offers:", Name, City, Stars);
            foreach (var cam in Rooms)
                Console.WriteLine("      {0} - capacity: {1} adults & {2} children - daily rate: {3} {4}.", cam.Name, cam.Adults, cam.Children, cam.valoare, cam.moneda);
            Console.WriteLine("\n");
        }
    }
}
