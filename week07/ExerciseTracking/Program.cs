using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine(new string('~', 40));
        Console.WriteLine("            Exercise Tracker");
        Console.WriteLine(new string('~', 40));

        string date = DateTime.Now.ToString("dd MMM yyyy");

        RunningActivity running = new RunningActivity(date, 30, 5);
        Console.WriteLine($"> {running.GetSummary()}\n");

        CyclingActivity cycling = new CyclingActivity(date, 60, 15.5);
        Console.WriteLine($"> {cycling.GetSummary()}\n");

        SwimmingActivity swimming = new SwimmingActivity(date, 30, 5);
        Console.WriteLine($"> {swimming.GetSummary()}\n");
    }
}