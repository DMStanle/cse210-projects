using System;

class Program
{
    static void Main(string[] args)
    {
        Reference r1 = new Reference("Proverbs", 3, 5, 6);
        string r1a = r1.GetDisplayText();
        Console.WriteLine(r1a);

        string scripturePara = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture = new Scripture(r1, scripturePara);
        Console.WriteLine(scripture.GetDisplayText());

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Please press Enter to hide words, and Quit to end the program.");


            var key = Console.ReadKey(intercept: true);


            if (key.Key == ConsoleKey.Enter)
            {
                scripture.HideRandomWords(3);
                Console.WriteLine(scripture.GetDisplayText());
            }
            else
            {
                string request = Console.ReadLine(); 

                if (request.ToUpper() == "QUIT")
                {
                    Console.WriteLine("Program Ended");
                    System.Environment.Exit(0);
                }
            }
        }
    }
}