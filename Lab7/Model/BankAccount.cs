using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.Model
{
	internal class Bankaccount
	{

		private long _id;
		private string _accountNumber;
		private double _balance;

		
		public long Id 
		{ 
			get 
			{ 
				return _id; 
			} 
			set 
			{
				if( _id != 0 && value != 0)
				{
					_id = value;
				}
				
			} 
		}

		public string AccountNumber
		{
			get
			{
				return _accountNumber;
			}
			set 
			{
				if(!string.IsNullOrEmpty(_accountNumber) && !string.IsNullOrEmpty(value))
				{
					_accountNumber = value;
				}
				
			}
		}

		public double Balance 
		{ 
			get 
			{ 
				return _balance; 
			} 
			set 
			{
				try
				{
					DoesBalanceGetBelowZero(value);
					_balance = value;
				}catch(InvalidOperationException exeption)
				{
					Console.WriteLine("Error setting balance: " + exeption.Message);
					Console.WriteLine("Press enter to continue...");
					Console.ReadLine();
				}
				
			} 
		}

		public Bankaccount()
		{
		}

		public void DepositMoney(double amound)
		{
			Balance += amound;
		}

		public void WithdrawalMoney(double amound)
		{
			DoesBalanceGetBelowZero(amound);

			Balance -= amound;
		}

		private void DoesBalanceGetBelowZero(double amound)
		{
			if ((_balance - amound) < 0)
			{
				throw new InvalidOperationException("Could not set balance, balance got below zero!");
			}
		}
	}
}
