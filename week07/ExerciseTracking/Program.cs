using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine(new string('~', 40));
        Console.WriteLine("            Activity Summary");
        Console.WriteLine(new string('~', 40));

        string date = DateTime.Now.ToString("dd MMM yyyy");
        List<Activity> activities = new List<Activity>();
        activities.Add(new Running(date, 30, 5));
        activities.Add(new Cycling(date, 60, 15.5));
        activities.Add(new Swimming(date, 30, 5));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

        Console.WriteLine();
    }
}