using System;
namespace Lab4
{
	public class ElevenProof
	{
		public ElevenProof()
		{
		}

		public bool ValidateNumber(int number)
        {
			bool isValidNumber = false;
			int totalNumAdd = 0;
			int Number = number;
			int Reverse = 0;

			while (Number > 0)
			{
				int remainder = Number % 10;
				Reverse = (Reverse * 10) + remainder;
				Number = Number / 10;
			}

			char[] reverseInCharArr = Reverse.ToString().ToCharArray();

			for (int i = 0; i < number.ToString().Length; i++)
            {
				int a = (int)reverseInCharArr[i];
				totalNumAdd += i * a;
            }


			if(totalNumAdd % 11 == 0)
            {
				isValidNumber = true;
            }
            else
            {
				throw new ArgumentException("Nummer is niet geldig!");
            }

			
			return isValidNumber;
        }
	}
}

