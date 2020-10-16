using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kawomat.Classes
{
    public class CoffeWithMilk : CoffeMaker
    {
        public CoffeWithMilk(BaseCoffe coffe) : base(coffe)
        {

        }
        public override coffeSize GetCoffeSize()
        {
            return coffce.GetCoffeSize();
        }

        public override string GetName()
        {
            return coffce.GetName() + " with milk";
        }

        public override double GetPrice()
        {
            return coffce.GetPrice() + 1.00;
        }

        public override int GetTimeToReady()
        {
            return coffce.GetTimeToReady() + 5;
        }

    }
}
