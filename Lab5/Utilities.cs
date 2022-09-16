using System;
namespace Lab5
{
	public static class Utilities
	{
		public static int Greatest(int a, int b)
		{
			if (a > b)
			{
				return a;
			}
			else if (a == b)
			{
				return a;
			}
			else
			{
				return b;
			}
		}

		public static string Greatest(string a, string b)
		{
			int greatest = Greatest(a.Length, b.Length);
			if(greatest == a.Length)
            {
				return a;
            }
            else
            {
				return b;
            }
        }

		public static int Greatest(params int[] args)
        {
			int biggest = 0;

			foreach(int i in args)
            {
				if(i > biggest)
                {
					biggest = i;
                }
            }

			return biggest;
        }

		public static void Swap(ref int a, ref int b)
        {
			int c = a;
			a = b;
			b = c;
        }

		public static int Factorial(int input)
        {
			int result = 1;
			
            for (int i = 1; i <= input; i++)
            {
				result *= i;
            }

			return result;

        }
	}
}

