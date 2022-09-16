using Lab7.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.Utils
{
	public class BankRuntimeDB
	{
		List<Bankaccount> SavedBankAccounts;

		public BankRuntimeDB()
		{
			SavedBankAccounts = new List<Bankaccount>();
		}

		public void AddBankToDB(Bankaccount bankaccount)
		{
			SavedBankAccounts.Add(bankaccount);
		}
		
	}
}
