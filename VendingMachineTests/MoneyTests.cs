using System;
using Xunit;
using Vending_Machine;

namespace VendingMachineTests
{
    public class MoneyTests
    {
        [Theory]
        [InlineData(1,1)]
        [InlineData(5, 5)]
        [InlineData(10, 10)]
        [InlineData(50, 50)]
        [InlineData(52, 0)] //Returning 0 when input is not a correct denomination
        [InlineData(1231, 0)] 
        public void InputTest(int input, int expected)
        {
            MoneyHandler moneyInpuTTest = new MoneyHandler();

            Assert.Equal(moneyInpuTTest.userInputCheck(input), expected);
        }
        [Fact]
        public void ReturnedMoneyTest() //testing if 56 returns array with 50+5+1
        {
            int input = 56;
            int[] excpectedArray = { 50, 5, 1 }; 
            MoneyHandler moneyReturnTest = new MoneyHandler();

            Assert.Equal(moneyReturnTest.ReturnedMoneyArray(input), excpectedArray);
        }
    }
}
