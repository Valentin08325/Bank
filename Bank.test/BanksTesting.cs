using Bank;
using NUnit.Framework;

namespace Bank.test
{
    public class BankTests
    {
        [Test]
        public void Deposit_PositiveAmount_IncreasesBalance()
        {
            // Arrange
            var bank = new Banks(12345);
            int initialBalance = bank.Balance;
            int deposit = 100;
            // Act
            bank.Deposit(deposit);
            //Assert
            Assert.That(bank.Balance, Is.EqualTo(initialBalance + deposit));
        }
        [Test]
        public void Deposit_NegativeAmount_ThrowsException()
        {
            //Arrange
            var bank = new Banks(12345);
            int deposit = -50;
            //Act & Assert
            Assert.Throws<InvalidOperationException>(() => bank.Deposit(deposit));
        }
        [Test]
        public void Withdraw_ValidAmount_DecreasesBalance()
        {
            //Arrange
            var bank = new Banks(12345);
            int initialBalance = bank.Balance;
            int withdraw = 12;
            //Act
            bank.Withdraw(withdraw);
            //Assert
            Assert.That(bank.Balance, Is.EqualTo(initialBalance - withdraw));
        }
        [Test]
        public void Withdraw_InvalidAmount_ThrowsExcpetion()
        {
            //Arrange
            var bank = new Banks(12345);
            int withdraw = -20;
            //Act & Assert
            Assert.Throws<InvalidOperationException>(() => bank.Withdraw(withdraw));
        }
    }
}