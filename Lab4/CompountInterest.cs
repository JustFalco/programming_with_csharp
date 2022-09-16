using System;
namespace Lab4
{
	public class CompountInterest
	{
		public CompountInterest()
		{
		}

		public float Calculate(float interestRate, float amount)
		{
			float yearsToDoubleAmount = 0;

			try
            {
				float doubleAmount = amount * 2;
				float currentAmount = amount;
				float rate = (interestRate / 100) + 1;

				Console.WriteLine($"Rate: {rate}, CurrentAmount: {currentAmount}, DoubleAmount: {doubleAmount}");

				while (currentAmount < doubleAmount)
				{
					currentAmount = currentAmount * rate;

					yearsToDoubleAmount++;
				}
            }
            catch
            {
				Console.WriteLine("Could not calculate!");
				return 0;
            }
            

			return yearsToDoubleAmount;

		}
	}
}

