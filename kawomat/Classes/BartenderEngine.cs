using System;
using System.Collections.Generic;

namespace kawomat.Classes
{
    internal class RekordClass
    {
        internal int rekordNumber { get; set; }
        internal int timeToServe { get; set; }
        internal BaseCoffe orderedCoffe { get; set; }
        internal int quantinity { get; set; }
        internal double singlePrice { get; set; }
        internal double orderPrice { get; set; }
    }
    internal class BillClass
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
    internal sealed class BartenderEngine
    {
        private int billNumber = 1;
        private BillClass newBill;

        private static readonly Lazy<BartenderEngine> lazyBartender
        = new Lazy<BartenderEngine>(() => new BartenderEngine());
        public static BartenderEngine Instance
            => lazyBartender.Value;
        private BartenderEngine() { }
        internal void CloseActualBill()
        {
            newBill = null;
        }
        internal void CreateBill()
        {
            if (newBill == null)
            {
                if (billNumber > 100) { billNumber = 1; }
                newBill = new BillClass(billNumber++);
            }
        }
        internal int GetActualBillNumber()
        {
            return newBill.GetBillNumber();
        }
        internal BillClass GetActualBill() => newBill;
        internal List<RekordClass> GetActualBillItems()
        {
            return newBill.GetItemsList();
        }
        internal RekordClass AddItemToBill(BaseCoffe coffeToMake, int quant)
        {
            return newBill.Add(coffeToMake, quant);
        }
    }
}