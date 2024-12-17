using System.Security;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine($"{_description}\n");
        Console.Write("How long would you like this session to last (in seconds)? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get Ready...");
        Thread.Sleep(3000);

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine($"You spent {_duration} seconds focusing on the {_name} activity.");
        ShowCountDown(3);
    }

    public void ShowSpinner(int seconds)
    {
        string [] symbols = {"/", "-", "|"};

        int start = Environment.TickCount;

        while (Environment.TickCount - start < seconds * 1000)
        {
            foreach (string symbol in symbols)
            {
                Console.Write(symbol);
                Thread.Sleep(500);
                Console.Write("\b\b");
            }
        }
    }

    protected void ShowCountDown(int seconds)
    {
        for (int second = seconds; second > 0; second--)
        {
            Console.WriteLine(second);
            Thread.Sleep(1000);
        }
        Console.Clear();


    }


}