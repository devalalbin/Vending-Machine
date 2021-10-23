using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine
{
    interface IVending
    {

        //todo add what every IVending needs
        void Purchase(int itemNr);
        void ShowAll();
        void InsertMoney(int insertedMoney);
        void EndTransaction();
    }
}
