using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaWindows.Barista
{    
    public abstract class Coffe
    {
        internal string nameCoffe { get; } = string.Empty;
        internal TimeSpan timetoServe { get; } = new TimeSpan(0, 0, 0);
        internal double priceCoffe { get; } = 0;        
        internal abstract TimeSpan GetTimeToServeCoffe();
        internal abstract double GetPriceCoffe();

    }
}
