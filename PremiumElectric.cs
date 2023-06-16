using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_module2
{
    public class PremiumElectric : Premium
    {
        public PremiumElectric(string neme)
          : base(neme)
        {
            СonsumptionFuel = 0;
        }

        public override double СonsumptionFuel { get; protected set; }
        public override Fuel GetFuel()
        {
            return new Electric();
        }
    }
}
