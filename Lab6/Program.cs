using System;

namespace Lab6
{
	class Program
    {
        public static void Main(string[] args)
        {
			FillMatrix();
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
			List<int> usedNumbers = new List<int>();
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
					bool isValidNumber = false;
					while (!isValidNumber)
					{
						int num = randomNumGen.Next(1, 10);
						if (!usedNumbers.Contains(num))
						{
                            matrix[i,j] = num;
							usedNumbers.Append(num);
							isValidNumber = true;
						}
					}
				}
				
            }

			foreach(int number in matrix)
            {
                Console.WriteLine(number);
				Console.ReadLine();
            }
        }
    }
}