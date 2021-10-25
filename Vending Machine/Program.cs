using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Vending Machine!");
            Soda cola = new Soda("Cola", 20, 2);
            Soda fanta = new Soda("Fanta", 10, 1);
            Snack snickers = new Snack("Snickers", 13, "100g");
            Snack twix = new Snack("Twix", 9, "50g");
            Toy gameBoy = new Toy("GameBoy", 1499, "Donkey Kong");
            VendingMachine vending = new VendingMachine();
            vending.listOfProducts.Add(cola);
            vending.listOfProducts.Add(fanta);
            vending.listOfProducts.Add(snickers);
            vending.listOfProducts.Add(twix);
            vending.listOfProducts.Add(gameBoy);

            vending.ShowAll(); 
            vending.InsertMoney(1000);
            vending.InsertMoney(1000);
            vending.InsertMoney(1000);
            vending.Purchase(0); // buying the cola 20kr

            vending.Purchase(4);
            gameBoy.Use();

        
            vending.listOfProducts.Add(cola);
            
            vending.ShowAll();

            vending.EndTransaction();
        }
    }
}
