using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kawomat.Classes
{
    public class CoffeWithWhisky : CoffeMaker
    {
        public CoffeWithWhisky(BaseCoffe coffe) : base(coffe)
        {

        }
        public override coffeSize GetCoffeSize()
        {
            return coffce.GetCoffeSize();
        }

        public override string GetName()
        {
            return coffce.GetName() + " with whisky";
        }

        public override double GetPrice()
        {
            return coffce.GetPrice() + 4.00;
        }

        public override int GetTimeToReady()
        {
            return coffce.GetTimeToReady() + 4;
        }

    }
}
