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
        }
    }
}
