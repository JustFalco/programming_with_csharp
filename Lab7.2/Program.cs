// See https://aka.ms/new-console-template for more information
using Lab7._2.Controller;
using Lab7._2.Models;

namespace Lab7
{
	public class Program
	{

		static void Main(string[] args)
		{
			User loggeinUser = new User
			{
				Name = "Falco"
			};

			new UserController(loggeinUser);
		}


	}
}
