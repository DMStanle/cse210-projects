using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        string userNumber;
        int number;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (true)
        {
            Console.Write("Enter a number: ");
            userNumber  = Console.ReadLine();
            if (int.TryParse(userNumber, out number))
            {
                if (number == 0)
                {
                    break;
                }
                numbers.Add(number);

            }
        }
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");
        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");
        int highestNumber = numbers.Max();
        Console.WriteLine($"The largest number is: {highestNumber}");

    }
}