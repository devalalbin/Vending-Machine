using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine
{
    public class Toy : Product
    {
        // Toy = child,  Product = parent
        public Toy() //starting values
        {
            Name = "GameBoy";
            Price = 1499;
            Bought = false;
            // Things to do on Soda creation like add Price and add bought status
        }
        public Toy(string name, int price) //starting manual values 
        {
            this.Name = name;
            this.Price = price;
        }
        public override bool Use()
        {
            if (base.Use()) // if (use = true) producted is purchased 
            {
                Console.WriteLine("Played with the GameBoy!");
                return false;
            }
            return false;
            Console.WriteLine("You did not play with"+ Name);
        }
    }

}
