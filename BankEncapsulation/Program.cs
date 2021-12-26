using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bAccount = new BankAccount();
            Console.WriteLine($"Please enter the amount you wish to deposit.");
            double addDeposit = double.Parse(Console.ReadLine());

            bAccount.Deposit(addDeposit);
            bAccount.GetBalance();

        }
    }
}
