using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp
{
    class Program
    {
        static void Main()
        {
            Rate valoare1 = new Rate();
            valoare1.AddRate(150, "RON");
            Rate valoare2 = new Rate();
            valoare2.AddRate(200, "RON");
            Rate valoare3 = new Rate();
            valoare3.AddRate(250, "RON");
            Rate valoare4 = new Rate();
            valoare4.AddRate(300, "RON");
            Rate valoare5 = new Rate();
            valoare5.AddRate(160, "RON");
            Rate valoare6 = new Rate();
            valoare6.AddRate(170, "RON");
            Rate valoare7 = new Rate();
            valoare7.AddRate(210, "RON");
            Rate valoare8 = new Rate();
            valoare8.AddRate(220, "RON");
            Rate valoare9 = new Rate();
            valoare9.AddRate(260, "RON");
            Rate valoare10 = new Rate();
            valoare10.AddRate(270, "RON");
            Rate valoare11 = new Rate();
            valoare11.AddRate(310, "RON");
            Rate valoare12 = new Rate();
            valoare12.AddRate(320, "RON");

            //Console.WriteLine("\n 'Rate' class objects are: ");
            //Console.WriteLine("\n {0} \n {1} \n {2} \n {3}", valoare1.Print(), valoare2.Print(), valoare3.Print(), valoare4.Print());

            Room camera1 = new Room() { valoare = valoare1.Amount, moneda = valoare1.Currency };
            camera1.AddRoom("Single", 1, 0);
            Room camera2 = new Room() { valoare = valoare2.Amount, moneda = valoare2.Currency };
            camera2.AddRoom("Dubla standard", 2, 0);
            Room camera3 = new Room() { valoare = valoare3.Amount, moneda = valoare3.Currency };
            camera3.AddRoom("Dubla extins", 2, 1);
            Room camera4 = new Room() { valoare = valoare4.Amount, moneda = valoare4.Currency };
            camera4.AddRoom("Dubla lux", 2, 2);
            Room camera5 = new Room() { valoare = valoare5.Amount, moneda = valoare5.Currency };
            camera5.AddRoom("Single", 1, 0);
            Room camera6 = new Room() { valoare = valoare6.Amount, moneda = valoare6.Currency };
            camera6.AddRoom("Single", 1, 0);
            Room camera7 = new Room() { valoare = valoare7.Amount, moneda = valoare7.Currency };
            camera7.AddRoom("Dubla standard", 2, 0);
            Room camera8 = new Room() { valoare = valoare8.Amount, moneda = valoare8.Currency };
            camera8.AddRoom("Dubla standard", 2, 0);
            Room camera9 = new Room() { valoare = valoare9.Amount, moneda = valoare9.Currency };
            camera9.AddRoom("Dubla extins", 2, 1);
            Room camera10 = new Room() { valoare = valoare10.Amount, moneda = valoare10.Currency };
            camera10.AddRoom("Dubla extins", 2, 1);
            Room camera11 = new Room() { valoare = valoare11.Amount, moneda = valoare11.Currency };
            camera11.AddRoom("Dubla lux", 2, 2);
            Room camera12 = new Room() { valoare = valoare12.Amount, moneda = valoare12.Currency };
            camera12.AddRoom("Dubla lux", 2, 2);

            //Console.WriteLine("\n 'Room' class objects are: ");
            //Console.WriteLine("\n {0} \n {1} \n {2} \n {3}\n {4} \n {5} \n {6} \n {7}\n {8} \n {9} \n {10} \n {11}", camera1.Print(), camera5.Print(), camera6.Print(), camera2.Print(), camera7.Print(), camera8.Print(), camera3.Print(), camera9.Print(), camera10.Print(), camera4.Print(), camera11.Print(), camera12.Print());

            Hotel hotel1 = new Hotel();
            hotel1.AddHotel("Hotel1", "Iasi", "5");
            hotel1.Rooms.Add(camera6);
            hotel1.Rooms.Add(camera8);
            hotel1.Rooms.Add(camera10);
            hotel1.Rooms.Add(camera12);
            Hotel hotel2 = new Hotel();
            hotel2.AddHotel("Hotel2", "Bacau", "3");
            hotel2.Rooms.Add(camera1);
            hotel2.Rooms.Add(camera2);
            hotel2.Rooms.Add(camera3);
            hotel2.Rooms.Add(camera4);
            Hotel hotel3 = new Hotel();
            hotel3.AddHotel("Hotel3", "Cluj", "4");
            hotel3.Rooms.Add(camera5);
            hotel3.Rooms.Add(camera7);
            hotel3.Rooms.Add(camera9);
            hotel3.Rooms.Add(camera11);

            Console.WriteLine("\n");
            Console.WriteLine("   'Hotel' class objects are: ");
            Console.WriteLine("\n");
            hotel1.Print();
            hotel2.Print();
            hotel3.Print();

            Console.WriteLine("\n");
            Console.WriteLine("   Which hotel do you prefer? (1, 2 or 3)");
            int nrHotel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("   For how many days do you want to calculate your stay?");
            int nrZile = Convert.ToInt32(Console.ReadLine());

            switch (nrHotel)
            {
                case 1:
                    Console.WriteLine("\n");
                    Console.WriteLine("   Your stay in {0}, {1} for {2} days costs: ", hotel1.Name, hotel1.City, nrZile);
                    Console.WriteLine($"      '{camera6.Name}' for {camera6.Adults} adults & {camera6.Children} children --> {camera6.GetPriceForDays(nrZile)} {valoare6.Currency}");
                    Console.WriteLine($"      '{camera8.Name}' for {camera8.Adults} adults & {camera8.Children} children --> {camera8.GetPriceForDays(nrZile)} {valoare8.Currency}");
                    Console.WriteLine($"      '{camera10.Name}' for {camera10.Adults} adults & {camera10.Children} children --> {camera10.GetPriceForDays(nrZile)} {valoare10.Currency}");
                    Console.WriteLine($"      '{camera12.Name}' for {camera12.Adults} adults & {camera12.Children} children --> {camera12.GetPriceForDays(nrZile)} {valoare12.Currency}");

                    Console.WriteLine("\n");
                    Console.WriteLine("   How many rooms do you need?");
                    int nrCamere1 = Convert.ToInt32(Console.ReadLine());
                    hotel1.GetPriceForNumberOfRooms(nrCamere1);

                    break;
                case 2:
                    Console.WriteLine("\n");
                    Console.WriteLine("   Your stay in {0}, {1} for {2} days costs: ", hotel2.Name, hotel2.City, nrZile);
                    Console.WriteLine($"      '{camera1.Name}' for {camera1.Adults} adults & {camera1.Children} children --> {camera1.GetPriceForDays(nrZile)} {valoare1.Currency}");
                    Console.WriteLine($"      '{camera2.Name}' for {camera2.Adults} adults & {camera2.Children} children --> {camera2.GetPriceForDays(nrZile)} {valoare2.Currency}");
                    Console.WriteLine($"      '{camera3.Name}' for {camera3.Adults} adults & {camera3.Children} children --> {camera3.GetPriceForDays(nrZile)} {valoare3.Currency}");
                    Console.WriteLine($"      '{camera4.Name}' for {camera4.Adults} adults & {camera4.Children} children --> {camera4.GetPriceForDays(nrZile)} {valoare4.Currency}");

                    Console.WriteLine("\n");
                    Console.WriteLine("   How many rooms do you need?");
                    int nrCamere2 = Convert.ToInt32(Console.ReadLine());
                    hotel2.GetPriceForNumberOfRooms(nrCamere2);

                    break;
                case 3:
                    Console.WriteLine("\n");
                    Console.WriteLine("   Your stay in {0}, {1} for {2} days costs: ", hotel3.Name, hotel3.City, nrZile);
                    Console.WriteLine($"      '{camera5.Name}' for {camera5.Adults} adults & {camera5.Children} children --> {camera5.GetPriceForDays(nrZile)} {valoare5.Currency}");
                    Console.WriteLine($"      '{camera7.Name}' for {camera7.Adults} adults & {camera7.Children} children --> {camera7.GetPriceForDays(nrZile)} {valoare7.Currency}");
                    Console.WriteLine($"      '{camera9.Name}' for {camera9.Adults} adults & {camera9.Children} children --> {camera9.GetPriceForDays(nrZile)} {valoare9.Currency}");
                    Console.WriteLine($"      '{camera11.Name}' for {camera11.Adults} adults & {camera11.Children} children --> {camera11.GetPriceForDays(nrZile)} {valoare11.Currency}");

                    Console.WriteLine("\n");
                    Console.WriteLine("   How many rooms do you need?");
                    int nrCamere3 = Convert.ToInt32(Console.ReadLine());
                    hotel3.GetPriceForNumberOfRooms(nrCamere3);

                    break;
            }
            Console.WriteLine("\n");
            Console.WriteLine("   Which is your budget?");
            int buget = Convert.ToInt32(Console.ReadLine());
            foreach (var cam in hotel1.Rooms)
            {
                if (buget >= cam.valoare)
                    Console.WriteLine($"   Within your price range: '{cam.Name}' for {cam.valoare} {cam.moneda}/day at {hotel1.Name}");
            }
            foreach (var cam in hotel2.Rooms)
            {
                if (buget >= cam.valoare)
                    Console.WriteLine($"   Within your price range: '{cam.Name}' for {cam.valoare} {cam.moneda}/day at {hotel2.Name}");
            }
            foreach (var cam in hotel3.Rooms)
            {
                if (buget >= cam.valoare)
                    Console.WriteLine($"   Within your price range: '{cam.Name}' for {cam.valoare} {cam.moneda}/day at {hotel3.Name}");
            }

            Console.ReadLine();
        }
    }
}
