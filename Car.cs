using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_module2
{
    public abstract class Car : IComparable<Car>
    {
        public abstract int Cost { get; protected set; }
        public abstract string Name { get; protected set; }
        public abstract double СonsumptionFuel { get; protected set; }

        public abstract int CompareTo(Car? other);
        public abstract Fuel GetFuel();
    }
}
