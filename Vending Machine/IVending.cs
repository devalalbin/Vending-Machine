using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine
{
    public interface IVending
    {
        public void Purchace() //buy a product from the vendormachine
        {

        }
        public void ShowAll() //show all products in the vendor machine collection (Input as a Collection productArray?)
        {

        }
        public void InsertMoney(int inputMoney) // insert money should only accept correct denomination valuess
        {

        }
        public void EndTransaction(int currentMoneyInVendor) //ends current transaction and returns all money
        {

        }
    }
}
