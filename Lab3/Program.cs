// See https://aka.ms/new-console-template for more information
namespace Lab3
{
    class Program
    { 
        public static void Main()
        {
            BankAccount checkingsAccount;
            BankAccount savingsAccount;

            checkingsAccount = new BankAccount
            {
                AccountType = AccountType.CHECKINGS,
                Balance = 10

            };

            savingsAccount = new BankAccount
            {
                AccountType = AccountType.SAVINGS,
                Balance = 100
            };

            Console.Write("Voer het accountnummer van uw checkings account in: ");
            checkingsAccount.AcountNumber = Console.ReadLine();
            Console.Write("Voer het accountnummer van uw spaaraccount in: ");
            savingsAccount.AcountNumber = Console.ReadLine();

            Console.WriteLine(checkingsAccount);
            Console.WriteLine(savingsAccount);
           
        }
    }
}

