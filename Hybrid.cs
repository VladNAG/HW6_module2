using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_module2
{
    public class Hybrid : StandartTaxi
    {
        public Hybrid(string neme)
         : base(neme)
        {
            Random fuel = new Random();
            СonsumptionFuel = fuel.Next(4, 6);
        }

        public override double СonsumptionFuel { get; protected set; }

        public override Fuel GetFuel()
        {
            base.GetFuel();
            return new Electric();
        }
    }
}
