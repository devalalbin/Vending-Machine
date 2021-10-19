using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine
{
    abstract class Product
    {
        public string Name { get; set; }
        int price;
        public int Price { get { return price; } set { price = value; } }
        public bool Bought { get; set; } //check if user has bought the item wheter user can use it or not
        public void Examine() //return price and name
        {
            Console.WriteLine("Name of product: " + Name + " price: " + Price + " kr");
        }
        virtual public bool Use()
        {
            if (this.Bought == false)
            {
                Console.WriteLine("You need to purchace " + Name+ " first in order to use it!");
                return false; // product was not used
            }
            return true; // else product was used
        }
    }
   
}
