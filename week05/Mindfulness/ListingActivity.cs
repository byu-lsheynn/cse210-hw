using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _listingPrompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        _activityName = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Run()
    {
        DisplayStartMessage();

        GetRandomPrompt();

        List<string> userList = GetListFromUser();
        _count = userList.Count;
        Console.WriteLine($"You listed {_count} items!");

        DisplayEndMessage();
    }

    public void GetRandomPrompt()
    {
        Console.WriteLine("\nList as many responses you can to the following prompt: ");

        Random random = new Random();
        string prompt = _listingPrompts[random.Next(_listingPrompts.Count())];
        Console.WriteLine($"--- {prompt} ---");

        Console.WriteLine("You may begin in: ");
        ShowCountdown(5);
    }

    public List<string> GetListFromUser()
    {
        List<string> entries = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_durationInSecond);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string entry = Console.ReadLine();
            if (!string.IsNullOrEmpty(entry))
            {
                entries.Add(entry);
            }
        }

        return entries;
    }
}