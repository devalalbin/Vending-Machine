using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Vending_Machine
{
    public class VendingMachine : IVending //using interface IVending
    {
        //fields
        //public Product cocaCola, redBull, chips, pretzel, gameBoy; //filling the machine with slots 0-4
        public List<Product> listOfProducts;
        int moneyPool;
        public int MoneyPool { get { return moneyPool; } private set { moneyPool = value; } }
        MoneyHandler moneyHandler = new MoneyHandler();
        //Dictionary moneyDictionary = new Dictionary();

        public VendingMachine() //constructor filling the machine with products and their price
        {
            MoneyPool = 0; //starting money
            /*
            cocaCola = new Soda("CocaCola", 16,2); 
            redBull = new Soda("RedBull", 20,1);
            chips = new Snack("Chips", 29,"300g");
            pretzel = new Snack("Pretzel", 12,"50g");
            gameBoy = new Toy("GameBoy", 999, "Donkey Kong"); */
            listOfProducts = new List<Product> { }; //{ cocaCola,redBull,chips,pretzel,gameBoy};
        }
        public void ShowAll() //show all Works but should implement interface in next update
        {
            Console.WriteLine("Vending machine items: ");
            foreach (Product prod in listOfProducts)
            {
                if(prod != null) { 
                    Console.WriteLine(prod.Name);
                }
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
            Dictionary<int, int> moneyDic = new Dictionary<int, int>(); //demonination = key, number of times it exist = value
            moneyDic.Add(1000, 0); moneyDic.Add(500, 0); moneyDic.Add(100, 0); moneyDic.Add(50, 0); moneyDic.Add(20, 0); moneyDic.Add(10, 0); moneyDic.Add(5, 0); moneyDic.Add(1, 0);

            int[] returedMoney = moneyHandler.ReturnedMoneyArray(moneyPool);
            for(int i = 0; i <= returedMoney.Length-1; i++)
            {
                moneyDic[returedMoney[i]]++; // increased denomination value for each time value appears in returned money array
            }

            foreach (KeyValuePair<int, int>  dic in moneyDic)
                if(dic.Value != 0) { //if denomination value is not empty print
                    Console.WriteLine("Value: {0} * {1}", dic.Key, dic.Value); 
                }
            MoneyPool = 0;
            Console.WriteLine(" Transaction ended");
        }
        public void Purchase(int itemNumber) //buy a product from the vendormachine
        {
            if (MoneyPool >= listOfProducts[itemNumber].Price) //check if use has enough money to buy the object
            {
                Console.WriteLine("You bought :" + listOfProducts[itemNumber].Name);
                listOfProducts[itemNumber].Bought = true; //sets item to bought so it can be consumed
                MoneyPool = MoneyPool - listOfProducts[itemNumber].Price; // deducts the price from moneypool
                listOfProducts[itemNumber] = null; //removes item from vendingmachine
            }
            else { Console.WriteLine("You don't have enough money to buy that product, You currently have:" + moneyPool + " and product costs :" + listOfProducts[itemNumber].Price); }
        }
    }

}
