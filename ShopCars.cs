using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_module2
{
    public class ShopCars
    {
        public ShopCars()
        {
            Allcars = new Car[9];
            var nissan = new EcoElectric("Nissan");
            Allcars[0] = nissan;
            var gully = new EcoTaxi("Gully");
            Allcars[1] = gully;
            var mazda = new StandartTaxi("Mazda");
            Allcars[2] = mazda;
            var honda = new Hybrid("Honda");
            Allcars[3] = honda;
            var mercedes = new Premium("Mercedes-Benz");
            Allcars[4] = mercedes;
            var bmw = new Premium("BMW");
            Allcars[5] = bmw;
            var teslaS = new PremiumElectric("Tesla S");
            Allcars[6] = teslaS;
            var teslaY = new PremiumElectric("Tesla Y");
            Allcars[7] = teslaY;
            var daewooL = new EcoTaxi("Daewoo Lanos");
            Allcars[8] = daewooL;
            var daewooS = new EcoTaxi("Daewoo Sens");
        }

        public Car[] Allcars { get; set; }
        public void ShoowAllCars()
        {
            Console.WriteLine("Welcom at ShopCars");
            for (int i = 0; i < Allcars.Length; i++)
            {
                Console.WriteLine($"{i + 1}-{Allcars[i].Name}, Cost:{Allcars[i].Cost} 000 $, consumption Fuel:{Allcars[i].СonsumptionFuel}L/Km");
            }

            Console.WriteLine();
        }
    }
}
