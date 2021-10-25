using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine
{
    public class Toy : Product
    {
        // Toy = child,  Product = parent
        string game;
        public Toy(string name, int price, string game) //starting manual values 
        {
            this.Name = name;
            this.Price = price;
            this.game = game;
            
        }
        public override bool Use()
        {
            if (base.Use()) // if (use = true) producted is purchased 
            {
                Console.WriteLine("You played "+game+ " on your "+ Name);
                return false;
            }
            return false;
            Console.WriteLine("You did not play with"+ Name);
        }
    }

}
