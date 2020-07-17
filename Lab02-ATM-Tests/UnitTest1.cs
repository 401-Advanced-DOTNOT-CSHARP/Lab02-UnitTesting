using System;
using Xunit;
using static Lab02_ATM.Program;

namespace Lab02_ATM_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ReturnsBalance()
        {
            Balance = 1000;

            decimal answer = ViewBalance();

            Assert.Equal(Balance, answer);

        }
        [Fact]
        public void DoesNotReturnNegativeBalnce()
        {
            Balance = 1000;

            decimal answer = ViewBalance();

            Assert.NotEqual(-1000, answer);

        }
        [Fact]
        public void CanWithdraw()
        {
            decimal Balance = 1000;

            decimal withdraw1 = 50;

            decimal expected = Balance - withdraw1;

            decimal answer = Withdraw(withdraw1);

            Assert.Equal(expected, answer);
        }
        [Fact]
        public void CantWithdrawNegative()
        {
            Balance = 1000;

            decimal withdraw2 = -50;

            decimal answer = Withdraw(withdraw2);

            Assert.NotEqual(1050, answer);
        }
        [Fact]
        public void CanDeposit()
        {
            Balance = 1000;

            decimal deposit1 = 50;

            decimal answer = Deposit(deposit1);

            Assert.Equal(1050, answer);
        }
        [Fact]
        public void CanNotDepositNegativeNumber()
        {
            Balance = 1000;

            decimal deposit1 = -50;

            decimal answer = Deposit(deposit1);

            Assert.NotEqual(950, answer);
        }
    }
}

