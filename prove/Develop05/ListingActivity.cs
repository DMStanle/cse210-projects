public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(int duration) 
        : base("Listing Activity", 
               "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 
               duration)
    {
        _prompts = new List<string>
        {
            "What is something that made you smile today?",
            "What was the most meaningful experience that you had today?",
            "What was your most meaningful connection with someone today?",
            "What is the most important thing that you did today?",
            "How could you have done better today?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random randomSelected = new Random();
        string chosenQuestion = _prompts[randomSelected.Next(_prompts.Count)];

        Console.WriteLine("List as many responses as possible to the following prompt: ");
        Console.WriteLine(chosenQuestion);
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);

        List<string> userSubmissions = new List<string>();
        int end = Environment.TickCount + _duration * 1000;

        _count = 0;

        while (Environment.TickCount < end)
        {
            Console.Clear();
            Console.WriteLine();
            string entry = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(entry))
            {
                userSubmissions.Add(entry);
                _count++;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }
}
