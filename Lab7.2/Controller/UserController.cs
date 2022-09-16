using Lab7._2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._2.Controller
{
	public class UserController
	{
		User currentUser;
		List<BankAccount> bankAccounts;
		public UserController(User user)
		{
			bankAccounts = new List<BankAccount>();
			currentUser = user;
			BankAccount standardAccount = new BankAccount
			{
				Balance = 1000.00M,
				AccountNumber = "RABO12345"
			};

			BankAccount savingsAccount = new SavingsAccount
			{
				Balance = 200.00M,
				AccountNumber = "RABO67890"
			};

			bankAccounts.Add(standardAccount);
			bankAccounts.Add(savingsAccount);

			currentUser.BankAccounts = bankAccounts;

			while (true)
			{
				mainMenu();

				string userInputString = Console.ReadLine();
				if (string.IsNullOrEmpty(userInputString))
				{
					return;
				}
				int userInput = int.Parse(userInputString);

				switch (userInput)
				{
					default:
						return;
					case 1:
						createAccount();
						break;
					case 2:
						transferMoneyBetweenAccounts();
						break;
					case 3:
						checkAccountBalances();
						break;
					case 4:
						getTotalFromAllAccounts();
						break;
				}
			}
		}

		private void mainMenu()
		{
			Console.WriteLine($"Welkom {currentUser.Name}, wat wilt u doen?");
			Console.WriteLine("1) Niew account maken");
			Console.WriteLine("2) Geld overschrijven tussen rekeningen");
			Console.WriteLine("3) Rekeningen inzien");
			Console.WriteLine("4) Totaal bedrag van rekeningen zien");
			Console.WriteLine("5) Geld storten");
			Console.WriteLine("6) Geld opnemen");
			Console.Write("Uw keuze: ");
		}

		private void getTotalFromAllAccounts()
		{
			Console.WriteLine("Het totale bedrag op al uw rekeningen is: " + currentUser.GetTotalAmoundInBanks());
		}

		private void transferMoneyBetweenAccounts()
		{
			decimal amound;

			Console.WriteLine("Naar welk account wilt u het geld overmaken?");

			for (int i = 1; i <= currentUser.BankAccounts.Count; i++)
			{
				Console.WriteLine($"{i}) {currentUser.BankAccounts[i-1].AccountNumber}");
			}

			Console.Write("Uw keuze: ");
			int userInput1 = int.Parse(Console.ReadLine());

			Console.WriteLine("Naar welk account wilt u het geld overschrijven?");

			for (int i = 1; i <= currentUser.BankAccounts.Count; i++)
			{
				Console.WriteLine($"{i}) {currentUser.BankAccounts[i - 1].AccountNumber}");
			}

			Console.Write("Uw keuze: ");
			int userInput2 = int.Parse(Console.ReadLine());

			if(userInput1 == userInput2)
			{
				return;
			}

			Console.Write("Bedrag om over te schrijven: ");
			amound = decimal.Parse(Console.ReadLine());

			currentUser.BankAccounts[userInput1].TransferMoney(amound, currentUser.BankAccounts[userInput2]);
		}

		private void checkAccountBalances()
		{
			Console.WriteLine("Account balansen:\n");
			for (int i = 0; i < currentUser.BankAccounts.Count; i++)
			{
				Console.WriteLine($"{currentUser.BankAccounts[i].AccountNumber} heeft balans: {currentUser.BankAccounts[i].Balance}");
			}
			Console.WriteLine();
		}

		private void createAccount()
		{
			BankAccount accountToBeCreated;

			Console.WriteLine("Welk type account wilt u aanmaken?");
			Console.WriteLine("1) Spaar account");
			Console.WriteLine("2) Standaard account");
			Console.Write("Uw keuze: ");
			int userInput = int.Parse(Console.ReadLine());

			if(userInput == 1)
			{
				accountToBeCreated = new SavingsAccount();
			}
			else
			{
				accountToBeCreated = new BankAccount();
			}

			Console.Write("Voer een accountnummer in: ");
			accountToBeCreated.AccountNumber = Console.ReadLine();

			currentUser.BankAccounts.Add(accountToBeCreated);

		}

	}
}
