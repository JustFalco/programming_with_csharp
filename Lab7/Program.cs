// See https://aka.ms/new-console-template for more information
using Lab7.Controller;
using Lab7.Model;
using Lab7.Utils;

namespace Lab7
{
	class Program
	{
		BankRuntimeDB db;
		static void Main(string[] args)
		{
			while (true)
			{
				new BankAccountController(ref db);
			}
		}
	}
}