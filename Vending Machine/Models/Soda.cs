using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine
{
    public class Soda : Product
    {
        // Soda = child,  Product = parent
        bool consumed; // should be true if product has been drank
        int recycleValue;
        public Soda(string name, int price, int recycleValue) //starting manual values 
        {
            this.Name = name;
            this.Price = price;
            this.recycleValue = recycleValue;
        }
        public override bool Use()
        {
            if (base.Use() && this.consumed == false) // if (use = true) producted is purchased AND (consumed = false) User can drink the product
            {
                Console.WriteLine("You Drank the "+Name);
                return consumed = true;
            }
            else
            {
                Console.WriteLine("You did not drink the "+Name);
                if(this.consumed == true)
                {
                    Console.WriteLine("You already drank it!");
                    return consumed = true;
                }
                return consumed = false;
            }
        }
    }

}
