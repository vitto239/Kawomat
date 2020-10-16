using System;
using System.Collections.Generic;

namespace kawomat.Classes
{
   
   
    internal sealed class BartenderEngine
    {
        private int billNumber = 1;
        private BillClass newBill;

        #region SingletonConstruction    // from StackOver ....
        private static readonly Lazy<BartenderEngine> lazyBartender
        = new Lazy<BartenderEngine>(() => new BartenderEngine());
        public static BartenderEngine Instance
            => lazyBartender.Value;
        private BartenderEngine() { } 
        #endregion  
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