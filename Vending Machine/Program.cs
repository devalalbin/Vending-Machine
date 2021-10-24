using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Vending Machine!");

            VendingMachine vending = new VendingMachine();
            vending.ShowAll(); 
            vending.InsertMoney(1000);
            vending.redBull.Use(); //trying to use redbull before purchace should not use it
            vending.Purchase(1); // buying the redbull 20kr
            vending.ShowAll();
            vending.redBull.Use(); //drinking the redbull
            vending.redBull.Use(); //should give message "you already drank it"
            vending.EndTransaction(); //returning 980 kr in correct denominations

        }
    }
}
