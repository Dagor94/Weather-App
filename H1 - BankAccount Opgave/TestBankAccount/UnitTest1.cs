using H1_BankAccount_Opgave;

namespace TestBankAccount
{
    public class UnitTest1
    {

        [Fact]
        public void Deposit_PositiveAmount_IncreasesBalance()
        {
            // Arrange - Setup the test
            BankAccount account = new BankAccount(0);
            double initialBalance = account.Balance;
            double depositAmount = 100;

            // Act - Implement the test
            account.Deposit(depositAmount);
            double expectedBalance = initialBalance + depositAmount;

            // Assert - Check the result
            Assert.Equal(expectedBalance, account.Balance);
        }

        [Fact]
        public void Deposit_NegativeAmount_DoesNotChangeBalance()
        {
            // Arrange - Setup the test
            BankAccount account = new BankAccount(0);
            double initialBalance = account.Balance;
            double depositAmount = -100;

            // Act - Implement the test
            account.Deposit(depositAmount);

            // Assert - Check the result
            Assert.Equal(initialBalance, account.Balance);
        }

        [Fact]
        public void Withdraw_within_limit()
        {
            // Arrange - Setup the test
            BankAccount account = new BankAccount(1000);
            double withdrawAmount = 1000;
            double expectedBalance = account.Balance - withdrawAmount;

            // ACT - Implement the test
            account.Withdraw(withdrawAmount);


            // Assert - Check the result
            Assert.Equal(expectedBalance, account.balance);
        }

        [Fact]
        public void Withdraw_Outside_limit()
        {
            // Arrange - Setup the test
            BankAccount account = new BankAccount(1000);
            double withdrawAmount = 2000;
            double expectedBalance = account.Balance - withdrawAmount;
            double originalAmount = account.Balance;

            // ACT - Implement the test
            account.Withdraw(withdrawAmount);


            // Assert - Check the result
            Assert.NotEqual(expectedBalance, account.balance);
            Assert.Equal(originalAmount, account.Balance);
        }
    }
}