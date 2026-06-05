using System;

public class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _durationInSecond;

    public Activity(){ }

    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}\n");
        Console.WriteLine(_description);

        Console.Write("\nHow long, in seconds, would you like for your session? ");
        //_durationInSecond = int.Parse(Console.ReadLine());

        while (!int.TryParse(Console.ReadLine(), out _durationInSecond) || _durationInSecond < 10)
        {
            Console.Write("Please enter a valid number of seconds (min: 10): ");
        }

        Console.Clear();
        Console.Write("\nGet ready...");
        ShowSpinner(3);
        Console.WriteLine();
        //Console.Clear();
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed another {_durationInSecond} seconds of the {_activityName}.");
        Console.Write("Returning to the menu...");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinnerStrings = new List<string> { "|","/","—","\\"};

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = spinnerStrings[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i = (i + 1) % spinnerStrings.Count; 
        }
    }
    
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            string numStr = i.ToString();
            Console.Write(numStr);
            Thread.Sleep(1000);

            for (int j = 0; j < numStr.Length; j++)
            { Console.Write("\b \b"); }
        }
    }


}
