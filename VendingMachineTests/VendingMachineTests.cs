using System;
using Xunit;
using Vending_Machine;

namespace VendingMachineTests
{
    public class VendingMachineTests
    {
        [Fact]
        public void VendingMachineFilledTest() 
        {
            string expectedName = "CocaCola";
            string expectedName2 = "Pretzel";
            int excpectedPrice = 9;

            VendingMachine vendingMachine = new VendingMachine(); //vendingmachine prefilled with [0]CocaCola [1]Pretzel 
            Soda cola = new Soda("CocaCola", 20, 2);
            Snack pretzel = new Snack("Pretzel", 9, "50g"); 
            vendingMachine.listOfProducts.Add(cola);
            vendingMachine.listOfProducts.Add(pretzel);

            Assert.Equal(vendingMachine.listOfProducts[0].Name, expectedName); //checking that vendingmachine filled correctly
            Assert.Equal(vendingMachine.listOfProducts[1].Name, expectedName2);
            Assert.Equal(vendingMachine.listOfProducts[1].Price, excpectedPrice); //pretzel costs 12kr
        }
        [Fact]
        public void VendingMachineMoneyTest() //checking if we can insert money correctly
        {
            int expectedMoneyPool = 112;
            int expectedMoneyPoolAfterEnding = 0;

            VendingMachine vendingMachine2 = new VendingMachine();

            vendingMachine2.InsertMoney(123); // should not do anything since its not a correct denomination of input
            vendingMachine2.InsertMoney(100);
            vendingMachine2.InsertMoney(10);
            vendingMachine2.InsertMoney(1);
            vendingMachine2.InsertMoney(1);

            Assert.Equal(vendingMachine2.MoneyPool, expectedMoneyPool); //inserted 100 + 10 + 1 + 1  checking if its 112 kr

            vendingMachine2.EndTransaction();
            Assert.Equal(vendingMachine2.MoneyPool, expectedMoneyPoolAfterEnding); //checking that machine is at 0 when user ended transaction

        }

        [Fact]
        public void VendingMachinePurchaceTest() //checking if we can insert money correctly
        {
            bool expectedFalse = false;
            bool expectedTrue = true;
            Product emptyCheck = null;

            VendingMachine vendingMachine3 = new VendingMachine(); //[0]redBull
            Soda redBull = new Soda("RedBull", 29, 2);
            vendingMachine3.listOfProducts.Add(redBull);


            Assert.Equal(vendingMachine3.listOfProducts[0].Bought, expectedFalse); //cheking bought status = false
            
            vendingMachine3.Purchase(0); //trying to buy the redbull with 0 money should not buy

            Assert.Equal(redBull.Bought, expectedFalse);//cheking bought status = false
            
            
            vendingMachine3.InsertMoney(100); // after adding money buying product should be possible
            vendingMachine3.Purchase(0);  
            Assert.Equal(redBull.Bought, expectedTrue);

            Assert.Equal(vendingMachine3.listOfProducts[0], emptyCheck); // checking so product is taken away from vendingmachine
        }

    }
}
