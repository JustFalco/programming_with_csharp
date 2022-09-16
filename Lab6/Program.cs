using System;
using System.Reflection.Metadata.Ecma335;

namespace Lab6
{
	class Program
    {
        public static void Main(string[] args)
        {
			while (true)
			{
				Console.WriteLine("Wat wilt u doen?");
				Console.WriteLine("1) Array invullen");
				Console.WriteLine("2) Matrix genereren");
				Console.Write("Keuze: ");

				string userInputString = Console.ReadLine();
				int userInput = int.Parse(userInputString);

				if (userInput == 0 || string.IsNullOrEmpty(userInputString))
					return;
				

				switch (userInput)
				{
					default:
						return;
					case 1:
						FillArray();
					break;
					case 2:
						FillMatrix();
					break;

				}
			}
        }

        public static void FillArray()
        {
			int sum = 0;
			int[] array = new int[10];
			for (int i = 1; i <= array.Length; i++)
			{
				Console.Write($"Please insert number {i}: ");
				int input = int.Parse(Console.ReadLine());
				sum += input;
				array[i - 1] = input;
			}

			Console.WriteLine($"De som van {array[0]} + {array[1]} + {array[2]} + {array[3]} + {array[4]} + {array[5]} + {array[6]} + {array[7]} + {array[8]} + {array[9]} is {sum}");
			Console.ReadLine();
		}

		public static void FillMatrix()
        {
			Random randomNumGen = new Random();
			int[,] matrix = new int[3, 3];
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
					bool isValidNumber = false;
					while (!isValidNumber)
					{
						randomNumGen = new Random();
						int num = randomNumGen.Next(1, 10);
						if (!CheckMatrixForNum(num, matrix))
						{
                            matrix[i,j] = num;
							isValidNumber = true;
						}
					}
				}
				
            }

			PrintMatrix(matrix);

        }

		private static void PrintMatrix(int[,] matrix)
		{
			Console.WriteLine($"\n{matrix[0,0]} | {matrix[0,1]} | {matrix[0,2]}");
			Console.WriteLine("---------");
			Console.WriteLine($"{matrix[1, 0]} | {matrix[1, 1]} | {matrix[1, 2]}");
			Console.WriteLine("---------");
			Console.WriteLine($"{matrix[2, 0]} | {matrix[2, 1]} | {matrix[2, 2]}\n");
		}

		private static bool CheckMatrixForNum(int num, int[,] matrix)
		{
			foreach(int number in matrix)
			{
				if(number == num)
				{
					return true;
				}
			}
			return false;
		}
    }
}

