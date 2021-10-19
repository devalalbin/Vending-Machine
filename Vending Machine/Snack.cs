using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine
{
    // Snack = child,  Product = parent
    class Snack : Product
    {
        bool consumed; // true if product has been eaten
        public Snack() //constructor
        {
            Name = "Snickers";
            Price = 10;
            Bought = false;
            consumed = false;
        }

        public override bool Use()
        {
            if(base.Use() && this.consumed == false)
            {
                Console.WriteLine("You ate the Snickers");
                return consumed = true;
            }
            else 
            {
                Console.WriteLine("You did not eat the Snickers");
                if (this.consumed == true)
                {
                    Console.WriteLine("Cause you already have eaten it!");
                    return consumed = true;
                }
                return consumed = false;
            }
        }
        
    }

}
