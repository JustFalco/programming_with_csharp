using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._2.Models
{
	public class User
	{
		public int Id { get; set; }
		public string Name { get; set; }
		private List<BankAccount> bankAccounts;

		public List<BankAccount> BankAccounts
		{
			get { 
				if(bankAccounts == null)
				{
					bankAccounts = new List<BankAccount>();
				}
				return bankAccounts; 
			}
			set {
				if (bankAccounts == null)
				{
					bankAccounts = new List<BankAccount>();
				}
				bankAccounts = value; 
			}
		}

		public decimal GetTotalAmoundInBanks()
		{
			decimal total = 0;

			foreach(BankAccount bank in BankAccounts)
			{
				total += bank.Balance;
			}

			return total;
		}
	}
}
