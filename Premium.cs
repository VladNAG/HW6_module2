using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_module2
{
    public class Premium : Car
    {
        public Premium(string neme)
        {
            Name = neme;
            Random cost = new Random();
            Cost = cost.Next(40, 100);
            Random fuel = new Random();
            СonsumptionFuel = fuel.Next(10, 20);
        }

        public override int Cost { get; protected set; }
        public override string Name { get; protected set; }
        public override double СonsumptionFuel { get; protected set; }
        public override Fuel GetFuel()
        {
            return new Disel();
        }

        public override int CompareTo(Car? other)
        {
            if (other == null)
            {
                return 1;
            }

            if (СonsumptionFuel < other.СonsumptionFuel)
            {
                return -1;
            }

            if (СonsumptionFuel > other.СonsumptionFuel)
            {
                return 1;
            }

            return 0;
        }
    }
}