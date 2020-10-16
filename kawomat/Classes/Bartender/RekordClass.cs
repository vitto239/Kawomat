using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kawomat.Classes
{
    public class RekordClass
    {
        internal int rekordNumber { get; set; }
        internal int timeToServe { get; set; }
        internal BaseCoffe orderedCoffe { get; set; }
        internal int quantinity { get; set; }
        internal double singlePrice { get; set; }
        internal double orderPrice { get; set; }
    }
}
