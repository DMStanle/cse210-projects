//To exceed requirements, I have added another option to search entries by date which can be observed in the Program file

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
            Console.WriteLine("5. Search by Date");
            Console.WriteLine("6. Quit");
            Console.WriteLine("What would you like to do?");
            string selection = Console.ReadLine();

            if (selection == "1")
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
                Console.WriteLine("Enter the date to search for (MM/dd/yyyy):");
                string searchDate = Console.ReadLine();
                Console.WriteLine($"Searching for entries on {searchDate}:");
                bool found = false;

                foreach (var entry in journal._entries)
                {
                    if (entry._date == searchDate)
                    {
                        entry.Display();
                        found = true;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("No entries found for that date.\n");
                }
            }
            else if (selection == "6")
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
