using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_module2
{
    public static class Starter
    {
        public static void Start()
        {
            var shopcars = new ShopCars();
            shopcars.ShoowAllCars();
            var parktaxi = new ParkTaxi(shopcars);
            parktaxi.ShowParkTaxi();
            parktaxi.SouchbyClassCar();
        }
    }
}
