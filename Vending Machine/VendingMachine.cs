using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Vending_Machine
{
    public class VendingMachine : IVending //using interface IVending
    {
        //fields
        Product cocaCola, redBull, chips, pretzel, gameBoy;
        List<Product> listOfProducts;
        int moneyPool;
        public int MoneyPool { get { return moneyPool; } set { moneyPool = value; } }
        MoneyHandler moneyHandler = new MoneyHandler();

        public VendingMachine() //constructor
        {
            MoneyPool = 0; //starting money
            cocaCola = new Soda("CocaCola", 16);
            redBull = new Soda("RedBull", 20);
            chips = new Snack("Chips", 29);
            pretzel = new Snack("Pretzel", 12);
            gameBoy = new Toy("GameBoy", 999);
            listOfProducts = new List<Product> { cocaCola,redBull,chips,pretzel,gameBoy};
            //ShowAll();
        }
        public void ShowAll() //show all Works but should implement interface in next update
        {
            Console.WriteLine(listOfProducts[1]);
            foreach (Product prod in listOfProducts)
            {
                Console.WriteLine(prod.Name);
            }
        }
        public void InsertMoney(int insertedMoney) // insert money should only accept correct denomination valuess
        {
            if (moneyHandler.userInputCheck(insertedMoney) != 0) // checking in moneyhandler if value is a accepted number
            {
                MoneyPool = MoneyPool + insertedMoney;
                Console.WriteLine("total money in vendingmachine is :" + MoneyPool);
            }
        }
        public void EndTransaction() //ends current transaction and returns all money in correct denominations
        {
            int[] returedMoney = moneyHandler.ReturnedMoneyArray(moneyPool);
            for(int i = 0; i <= returedMoney.Length-1; i++)
            {
                Console.WriteLine(" "+ returedMoney[i]);
            }

            
        }
        public void Purchase(int itemNumber) //buy a product from the vendormachine
        {
            //check what item cost
            //if user buys it set product to = bought so it can be consomed
        }
    }

}
