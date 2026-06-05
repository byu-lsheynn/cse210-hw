using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _activityName = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartMessage();
        DateTime endTime = DateTime.Now.AddSeconds(_durationInSecond);

        // Breathing Exercise
        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in...");
            ShowCountdown(5);
            Console.WriteLine();

            Console.Write("Breathe out...");
            ShowCountdown(5);
            Console.WriteLine();
        }

        DisplayEndMessage();
    }
}