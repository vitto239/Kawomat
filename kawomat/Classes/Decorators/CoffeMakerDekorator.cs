using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kawomat.Classes
{    public class CoffeMaker : BaseCoffe
    {
        protected BaseCoffe coffce;
        public CoffeMaker(BaseCoffe baseCoffe)
        {
            coffce = baseCoffe;
        }
        public override coffeSize GetCoffeSize()
        {
            return coffce.GetCoffeSize();
        }

        public override string GetName()
        {
            return coffce.GetName();
        }

        public override double GetPrice()
        {
            return coffce.GetPrice();
        }

        public override int GetTimeToReady()
        {
            return coffce.GetTimeToReady();
        }
    }
}
