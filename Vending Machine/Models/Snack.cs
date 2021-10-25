using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine
{
    // Snack = child,  Product = parent
    public class Snack : Product
    {
        bool consumed; // true if product has been eaten
        string size;
        public Snack(string name, int price, string size) 
        {
            this.Name = name;
            this.Price = price;
            this.size = size;
        }

        public override bool Use()
        {
            if(base.Use() && this.consumed == false)
            {
                Console.WriteLine("You ate the "+ Name);
                return consumed = true;
            }
            else 
            {
                Console.WriteLine("You did not eat the " + Name);
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
