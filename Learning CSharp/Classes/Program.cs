using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Matthew", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} intitial balance");
            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Friend pays me back");
            Console.WriteLine(account.Balance);
        }
    }
}
