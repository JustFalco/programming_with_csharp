// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main()
    {
        string welcomeMessage = "Welkom bij deze console applicatie!";
        string name;

        Console.WriteLine(welcomeMessage);
        Console.Write("Name: ");

        name = Console.ReadLine();

        Console.WriteLine("Welkom {0}! \nHet is momenteel {1}", name, DateTime.Now.ToString("dd-MM-yyyy"));
    }
}

