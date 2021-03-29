using System;
using System.Globalization;
using Bank.Entities;
using Bank.Entities.Exceptions;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
          
                Console.WriteLine("Enter account data");
                Console.Write("Number:");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance:");
                double InitialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double WithdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
              

                Account account = new Account(number, holder, InitialBalance, WithdrawLimit);

                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            try
            {

                account.Withdraw(amount);
                Console.WriteLine("New balancer:" + account.Balance.ToString("F2", CultureInfo.InvariantCulture));

            }
            catch(DomainException e)
            {
                Console.WriteLine(" Erro " + e.Message);
            }

        }
    }
}
