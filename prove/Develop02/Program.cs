using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator generator = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            string selection = Console.ReadLine();

            if (selection == "1") // Write
            {
                string randomPrompt = generator.GetRandomPrompt();
                Console.WriteLine(randomPrompt);
                Console.WriteLine("Your response: ");
                string entryText = Console.ReadLine();
                Entry newEntry = new Entry(randomPrompt, entryText);
                journal.AddEntry(newEntry);
                Console.WriteLine("Entry added.\n");
            }
            else if (selection == "2")
            {
                Console.WriteLine("Displaying all entries:");
                journal.DisplayAll();
            }
            else if (selection == "3")
            {
                Console.WriteLine("What is the file name to load?");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
                Console.WriteLine("Journal loaded.\n");
            }
            else if (selection == "4")
            {
                Console.WriteLine("What is the file name to save to?");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
                Console.WriteLine("Journal saved.\n");
            }
            else if (selection == "5")
            {
                running = false;
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid selection. Please try again.");
            }
        }
    }
}
