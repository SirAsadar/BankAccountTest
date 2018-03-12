using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("John", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance:C2} initial balance.");
            Console.WriteLine();
            Console.WriteLine("-----------------------");
            account.makeWithdrawal(500, DateTime.Now, "rent payment");
            Console.WriteLine(account.Balance);
            account.makeDeposit(100, DateTime.Now, "friend paid me back");
            Console.WriteLine(account.Balance);
            Console.WriteLine();
            Console.WriteLine("-----------------------");
            Console.WriteLine(account.getAccountHistory());
            Console.WriteLine();
            Console.WriteLine("-----------------------");
            try
            {
                var invalidAccount = new BankAccount("invalid",-55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("exception w/ creating acct with neg balance");
                Console.WriteLine(e.ToString());

            }
            Console.WriteLine();
            Console.WriteLine("-----------------------");
            try
            {
                account.makeWithdrawal(750, DateTime.Now, "Attempting to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------");
        }
    }
}
