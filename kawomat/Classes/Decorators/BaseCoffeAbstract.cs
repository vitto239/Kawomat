using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kawomat.Classes
{
    public enum coffeSize
    {
        small, medium,big
    }
    public abstract class BaseCoffe
    {
        public abstract double GetPrice();
        public abstract string GetName();
        public abstract int GetTimeToReady();
        public abstract coffeSize GetCoffeSize();

    }
}
