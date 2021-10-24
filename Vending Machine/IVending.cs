using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine
{
    interface IVending // a "contract" with methods that every vendor like classes should use 
    {
        public int MoneyPool { get; }
        void Purchase(int itemNr);
        void ShowAll();
        void InsertMoney(int insertedMoney);
        void EndTransaction();
    }
}
