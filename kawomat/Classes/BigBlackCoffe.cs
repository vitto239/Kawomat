using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kawomat.Classes
{
    public class BigCofee : BaseCoffe
    {
        private readonly string coffeName = "big coffe";
        private readonly double coffePrice = 9.0;
        private readonly int timeToReady = 40;

        public override coffeSize GetCoffeSize()
        {
            return coffeSize.medium;
        }

        public override string GetName()
        {
            return coffeName;
        }

        public override double GetPrice()
        {
            return coffePrice;
        }

        public override int GetTimeToReady()
        {
            return timeToReady;
        }
    }
}
