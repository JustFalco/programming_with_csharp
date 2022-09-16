namespace Lab4
{
    class Program
    {
        public static void Main(string[] args)
        { 

            Console.WriteLine(new CompountInterest().Calculate(8, 1000));

            Console.Write("Voer een number in: ");
            int input = Console.ReadLine();

			Console.WriteLine(new ElevenProof().ValidateNumber(input));
		}

        
    }
}

