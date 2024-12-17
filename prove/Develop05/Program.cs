//To exceed expectations i have made it to where every time the user presses enter in the ListingActivity, they will be told how much time they have left.

using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {

        BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by guiding you through deep breathing.", 0);
        ReflectingActivity reflectingActivity = new ReflectingActivity(0);
        ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you focus on positive moments by listing responses to prompts.", 0);

string selection = "";

while (selection != "4")
{
    Console.Clear();
    Console.WriteLine("Menu Options:");
    Console.WriteLine("   1. Start breathing activity");
    Console.WriteLine("   2. Start reflecting activity");
    Console.WriteLine("   3. Start listing activity");
    Console.WriteLine("   4. Quit");
    Console.Write("Select a choice from the menu: ");

    selection = Console.ReadLine();

    if (selection == "1")
    {
        Console.Clear();
        breathingActivity.Run();
    }
    else if (selection == "2")
    {
        Console.Clear();
        reflectingActivity.Run();
    }
    else if (selection == "3")
    {
        Console.Clear();
        listingActivity.Run();
    }
    else if (selection == "4")
    {
        Console.Clear();
        Console.WriteLine("Goodbye!");
    }
}

    }
}