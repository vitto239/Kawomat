using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kawomat.Classes
{
    public class BillClass
    {
        private List<RekordClass> rekordList = new List<RekordClass>();
        private readonly int billNumber;
        private int rekordNumber = 1;
        public BillClass(int v)
        {
            this.billNumber = v;
        }
        internal int GetBillNumber()
        {
            return billNumber;
        }
        internal RekordClass Add(BaseCoffe coffeToMake, int quant)
        {
            var rek = new RekordClass();
            rek.orderedCoffe = coffeToMake;
            rek.quantinity = quant;
            rek.singlePrice = rek.orderedCoffe.GetPrice();
            rek.orderPrice = rek.singlePrice * rek.quantinity;
            rek.timeToServe = rek.orderedCoffe.GetTimeToReady() * rek.quantinity;
            rek.rekordNumber = rekordNumber++;
            rekordList.Add(rek);
            return rek;
        }
        internal List<RekordClass> GetItemsList() => rekordList;
    }
}
