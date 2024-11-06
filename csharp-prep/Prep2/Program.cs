using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is you grade percentage in the class? (Please repond with a whole number in the format '87') ");
        int percentage = int.Parse(Console.ReadLine());

        string letter = "F";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80 && percentage < 90)
        {
            letter = "B";
        }
        else if (percentage >= 70 && percentage < 80)
        {
            letter = "C";
        }
        else if (percentage >= 60 && percentage < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string gradeAdd = "";
        int remainder = percentage % 10;
        if ((letter == "B" || letter == "C" || letter == "D") && remainder >= 7)
        {
            gradeAdd = "+";
        }
        else if ((letter == "B" || letter == "C" || letter == "D") && remainder < 3)
        {
            gradeAdd = "-";
        }
        else{
            gradeAdd = "";
        }


        Console.WriteLine($"Your grade is {letter}{gradeAdd}.");
        if (percentage >= 70)
        {
            Console.WriteLine("Congrajulations on passing the class! ");
        }
        else if (percentage <= 70)
        {
            Console.WriteLine("Sorry! You did not pass the class. Better luck next time! ");

        }
    }
}