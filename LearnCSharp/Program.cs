using System;

namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.Balance = 50;
            account.Balance = -90;
            Console.WriteLine(account.ID);
            Console.WriteLine(account.FullName);


            Console.ReadLine();
        }
    }

    class BankAccount
    {
        private decimal balance;

        public decimal Balance
        {
            get => balance;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine($"Bank will pay $ {(balance + value) * -1} for you. Enjoy!");
                    balance = 0;
                }
                else
                    balance = value;
            }
        }

        public int ID { get; private set; } = 523525;

        private string firstName = "Jeff";
        private string lastName = "Bezos";

        public string FullName => $"{firstName} {lastName}";
    }
}