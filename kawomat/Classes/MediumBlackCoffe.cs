using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kawomat.Classes
{
    public class MediumCofee : BaseCoffe
    {
        private readonly string coffeName = "medium coffe";
        private readonly double coffePrice = 7.5;
        private readonly int timeToReady = 35;

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
