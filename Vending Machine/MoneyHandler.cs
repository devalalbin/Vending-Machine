using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine
{
    public class MoneyHandler
    {
        readonly int[] denominations = { 1, 5, 10, 20, 50, 100, 500, 1000 };
        public MoneyHandler() /// TODO MAKE AN ARRAY OF RETURNED VALUES?
        {

        }
        public int[] ReturnedMoneyArray(int amount) // gets value from user and returns an array of the denominations with same value
        {
            int[] returnedMoney = new int[0];
            int j = 0;// helping with correct spot in returned money array
            Console.WriteLine("returning " + amount + " You get back :");
            int i = denominations.Length-1; // starting at spot 7 and working its way back to step through the denominations
            while (amount > 0)
            {
                while (i >= 0)
                {
                    while (amount >= denominations[i])
                    {
                        Array.Resize(ref returnedMoney, j + 1);
                        amount = amount - denominations[i];
                        returnedMoney[j] = denominations[i];
                        j++;
                    }
                    i--;
                }
            }
            return returnedMoney;

        }
        public int userInputCheck(int input) // checking if user input is a correct denomination
        {
            for (int i = 0; i <= denominations.Length-1; i++)//iterating through our denominations to see if userinput is a valid denomination
            {
                if(input == denominations[i]) 
                {
                    Console.WriteLine("You added: " + input+ "kr into the vending machine!");
                    return input;
                }
            }
            Console.WriteLine("Thats not an valid input! Machine only accepts '1, 5, 10, 20, 50, 100, 500 or 1000' ");
            return 0; //return 0 if input is not a valid denomination
        }
    }

}
