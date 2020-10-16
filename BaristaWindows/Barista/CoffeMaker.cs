using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaWindows.Barista
{
    public enum SugarPresent
    {
        None,Single,Double
    }
    public enum CoffeSize
    {
        SingleCup, DoubleCup
    }
    public class CoffeMaker
    {
        private (string nameCoffe, int timetoServe, int priceCoffe)[] coffeMenuTable;

        public CoffeMaker()
        {
            coffeMenuTable = new[] { (nameCoffe:"black coffe",timetoServe:30,priceCoffe:6),
                                     (nameCoffe:"espresso coffe",timetoServe:20,priceCoffe:7),
                                     (nameCoffe:"cappuccino coffe",timetoServe:40,priceCoffe:9),
                                     (nameCoffe:"latte macchiato coffe",timetoServe:45,priceCoffe:10),
                                     (nameCoffe:"espresso macchiato",timetoServe:25,priceCoffe:8),
            };  
        }
    }
}
