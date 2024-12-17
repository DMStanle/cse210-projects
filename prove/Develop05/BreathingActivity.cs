public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly.Clear your mind and focus on your breathing", duration)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        int end = Environment.TickCount + _duration * 1000;
        ShowSpinner(3);
        while (Environment.TickCount < end)
        {
    
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Breathe in...");
            ShowCountDown(5);
            Console.WriteLine();
            Console.WriteLine("Now breathe out...");
            ShowCountDown(8);

        }
        DisplayEndingMessage();
    }
}