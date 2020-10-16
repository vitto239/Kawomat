using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kawomat.Classes
{
    public class SmallCofee : BaseCoffe
    {
        private readonly string coffeName = "small coffe";
        private readonly double coffePrice = 5.00;
        private readonly int timeToReady = 30;
        public override coffeSize GetCoffeSize()
        {
            return coffeSize.small;
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
