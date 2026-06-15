using System;

class Program
{

    // CREATIVE ENHANCEMENT: Added a streak counter for Eternal Goals. If the user records 
    // an eternal goal daily, the system increments the streak count. The counter 
    // will automatically reset to 0 (or 1 upon logging) if the user misses a day.
    
    static void Main(string[] args)
    {
        Console.Clear();
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}