using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Vending Machine!");
            Product soda = new Soda();
            soda.Examine();

            Product snickers = new Snack();
            snickers.Examine();
            Product gameboy = new Toy();
            gameboy.Examine();
            MoneyHandler money = new MoneyHandler();
            money.ReturnedMoneyArray(96);
            money.userInputCheck(1001);

            VendingMachine vending = new VendingMachine();
            vending.ShowAll();
            vending.InsertMoney(100);
            vending.InsertMoney(123);
            vending.InsertMoney(50);
            vending.EndTransaction();

        }
    }
}
