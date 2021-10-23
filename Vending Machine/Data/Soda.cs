using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine
{
    public class Soda : Product
    {
        // Soda = child,  Product = parent
        bool consumed; // should be true if product has been drank
        public Soda() //starting values if nothing else is specified
        {
            Name = "CocaCola";
            Price = 18;
            Bought = false;
            consumed = false;
           // Things to do on Soda creation like add Price and add bought status
        }
        public Soda(string name, int price) //starting manual values 
        {
            this.Name = name;
            this.Price = price;
        }
        public override bool Use()
        {
            if (base.Use() && this.consumed == false) // if (use = true) producted is purchased AND (consumed = false) User can drink the product
            {
                Console.WriteLine("You Drank the Cola");
                return consumed = true;
            }
            else
            {
                Console.WriteLine("You did not drink the Cola");
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
