using System;
using Xunit;
using Vending_Machine;

namespace VendingMachineTests
{
    public class ProductTests
    {
        [Fact]
        public void SnackTest()
        {
            //arrange
            bool consumed = true;
            int excpectedPrice = 20;
            //act
            Product snickers = new Snack("Snickers", 20, "100g");
            Product twix = new Snack("Twix", 11, "50g");
            snickers.Bought = true; // buying the

            //assert
            Assert.Equal(snickers.Price, excpectedPrice);
            Assert.Equal(snickers.Use(), consumed); //Should be able to eat snack if its bought (and not already eaten)
            Assert.Equal(twix.Use(), !consumed); //Trying to eat an snack that has not been purchased should return false
        }
        [Fact]
        public void SodaTest()
        {
            //arrange
            bool consumed = true;
            int excpectedPrice = 8;
            //act
            Product cola = new Soda("Cola",22,2);
            Product fanta = new Soda("Fanta", 8, 1);
            cola.Bought = true;

            //assert
            Assert.Equal(fanta.Price, excpectedPrice);
            Assert.Equal(cola.Use(), consumed); //Should be able to eat snack if its bought (and not already eaten)
            Assert.Equal(fanta.Use(), !consumed); //Trying to eat an snack that has not been purchased should return false
        }
        [Fact]
        public void ToyTest()
        {
            //arrange
            bool consumed = false; //gameboy should not be consumed on use
            int excpectedPrice = 1499;
            //act
            Product gameboy = new Toy("GameBoy", 1499,"Pokemon");
            gameboy.Bought = true;

            //assert
            Assert.Equal(gameboy.Use(), consumed); //gameboy when using USE should not set consumed flag to true
            Assert.Equal(gameboy.Price, excpectedPrice);

        }
    }
}
