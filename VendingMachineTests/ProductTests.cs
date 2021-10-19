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
            int excpectedPrice = 10;
            //act
            Product snickers = new Snack();
            Product snickers2 = new Snack();
            snickers.Bought = true; // buying the

            //assert
            Assert.Equal(snickers.Price, excpectedPrice);
            Assert.Equal(snickers.Use(), consumed); //Should be able to eat snack if its bought (and not already eaten)
            Assert.Equal(snickers2.Use(), !consumed); //Trying to eat an snack that has not been purchased should return false
        }
        [Fact]
        public void SodaTest()
        {
            //arrange
            bool consumed = true;
            int excpectedPrice = 18;
            //act
            Product cola = new Soda();
            Product cola2 = new Soda();
            cola.Bought = true;

            //assert
            Assert.Equal(cola2.Price, excpectedPrice);
            Assert.Equal(cola.Use(), consumed); //Should be able to eat snack if its bought (and not already eaten)
            Assert.Equal(cola2.Use(), !consumed); //Trying to eat an snack that has not been purchased should return false
        }
        [Fact]
        public void ToyTest()
        {
            //arrange
            bool consumed = false; //gameboy should not be consumed on use
            int excpectedPrice = 1499;
            //act
            Product gameboy = new Toy();
            gameboy.Bought = true;

            //assert
            Assert.Equal(gameboy.Use(), consumed); //gameboy when using USE should not set consumed flag to true
            Assert.Equal(gameboy.Price, excpectedPrice);

        }
    }
}
