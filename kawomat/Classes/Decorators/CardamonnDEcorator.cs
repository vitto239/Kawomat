using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kawomat.Classes
{
    public class CoffeWithCardamone : CoffeMaker
    {
        public CoffeWithCardamone(BaseCoffe coffe) : base(coffe)
        {

        }
        public override coffeSize GetCoffeSize()
        {
            return coffce.GetCoffeSize();
        }

        public override string GetName()
        {
            return coffce.GetName() + " with cardamone";
        }

        public override double GetPrice()
        {
            return coffce.GetPrice() + 2.00;
        }

        public override int GetTimeToReady()
        {
            return coffce.GetTimeToReady() + 2;
        }

    }
}
