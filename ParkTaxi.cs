using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_module2
{
    public class ParkTaxi
    {
        private int costcars = 0;
        public ParkTaxi(ShopCars shop)
        {
            try
            {
                Console.WriteLine("How many cars do you want to buy?");
                int countcar = int.Parse(Console.ReadLine());
                Parkcars = new Car[countcar];
                Console.WriteLine("Choose car and enter namber!!");
                for (int i = 0; i < Parkcars.Length; i++)
                {
                    int nambercar = int.Parse(Console.ReadLine());
                    if (nambercar <= shop.Allcars.Length)
                    {
                        Parkcars[i] = shop.Allcars[nambercar - 1];
                    }
                    else
                    {
                        Console.WriteLine("You enter not corect format, try egain, use numbers from 1 to 9!!");
                        nambercar = int.Parse(Console.ReadLine());
                        Parkcars[i] = shop.Allcars[nambercar - 1];
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("You enter not corect format, try egain, use numbers from 1 to 9!!");
            }
        }

        public Car[] Parkcars { get; protected set; }

        public void ShowParkTaxi()
        {
            Console.WriteLine();
            Parkcars.Reverse();
            Console.WriteLine("All cars your Taxi -Park sorted by fuel consumption:");
            for (int i = 0; i < Parkcars.Length; i++)
            {
                Console.WriteLine($"{i + 1}-{Parkcars[i].Name}, Cost:{Parkcars[i].Cost} 000 $, consumption Fuel:{Parkcars[i].СonsumptionFuel}L/Km");
                costcars += Parkcars[i].Cost;
            }

            Console.WriteLine();
            Console.WriteLine($"The total cost of your Taxi-Park:{costcars} 000 $");
        }

        public void SouchbyClassCar()
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Choose class car: 1 - Eco, 2 - Standart, 3 - Premium");
                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Class Eco:");
                        foreach (Car car in Parkcars)
                        {
                            if (car is EcoTaxi)
                            {
                                Console.WriteLine(car.Name);
                                car.GetFuel();
                            }
                        }

                        break;
                    case 2:
                        Console.WriteLine("Class Standart:");
                        foreach (Car car in Parkcars)
                        {
                            if (car is StandartTaxi)
                            {
                                Console.WriteLine(car.Name);
                                car.GetFuel();
                            }
                        }

                        break;
                    case 3:
                        Console.WriteLine("Class Premium:");
                        foreach (Car car in Parkcars)
                        {
                            if (car is Premium)
                            {
                                Console.WriteLine(car.Name);
                                car.GetFuel();
                            }
                        }

                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("You enter not corect format, try egain, use numbers from 1 to 3!!");
            }
        }
    }
}
