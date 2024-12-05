//For my exceeding of expectations, I have added a method to the scripture class to identify and return how many words are left unhidden and display that number to the user. This helps the user to measure their progress in a way that is quantable.


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
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
                Console.Clear();
                scripture.HideRandomWords(3);
                Console.WriteLine(r1a);
                Console.WriteLine($"You have {scripture.CountWords()} words left.");
                Console.WriteLine(scripture.GetDisplayText());

                if (scripture.AllWordsAreGone())
                {
                    Console.WriteLine("Program Ended");
                    System.Environment.Exit(0);
                }
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