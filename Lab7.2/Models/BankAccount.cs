using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._2.Models
{
	public class BankAccount
	{
		private long id;
		private string accountNumber;
		private decimal balance;
		private AccountTypes bankAccountType;

		public BankAccount()
		{
			Random random = new Random();
			id = random.Next(1000000, 9999999);
			bankAccountType = AccountTypes.STANDARD;
		}

		public AccountTypes BankAccountType
		{
			get { return bankAccountType; }
			set { bankAccountType = value; }
		}

		public string AccountNumber
		{
			get { return accountNumber; }
			set { accountNumber = value; }
		}

		public decimal Balance
		{
			get { return balance; }
			set { 
				if(value >= 0)
				{
					if (!DoesBalanceGoBelowZero(value))
					{
						balance = value;
					}
				}
			}
		}

		public long Id
		{
			get { return id; }
		}


		public void WithdrawMoney(decimal amound)
		{
			if (!DoesBalanceGoBelowZero(amound))
			{
				Balance -= amound;
			}
			
		}

		public void DepositMoney(decimal amound)
		{
			Balance += amound;
		}

		public void TransferMoney(decimal amound, BankAccount accountToTransferFrom)
		{
			accountToTransferFrom.WithdrawMoney(amound);
			DepositMoney(amound);
		}

		private bool DoesBalanceGoBelowZero(decimal amound)
		{
			if(bankAccountType == AccountTypes.SAVINGS)
			{
				if ((Balance - amound) < 0)
				{
					return true;
				}
			}
			return false;
		}
	}

	public class SavingsAccount : BankAccount
	{
		public SavingsAccount()
		{
			this.BankAccountType = AccountTypes.SAVINGS;
		}

		public decimal CalculateInterest(decimal interest)
		{
			return this.Balance * interest;
		}

		public decimal CalculateInterest(decimal interest, int years)
		{
			return this.Balance * interest * years;
		}
	}

	public enum AccountTypes
	{
		SAVINGS,
		STANDARD
	}
}
