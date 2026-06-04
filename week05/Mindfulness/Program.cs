using System;

class Program
{
    static void Main(string[] args)
    {

        while (true)
        {
            Console.Clear();
            Console.WriteLine(new string('~', 40));
            Console.WriteLine("          Mindfullness Activity");
            Console.WriteLine(new string('~', 40));
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "4")
            {
                break;
            }

            switch (choice)
            {
                case "1":
                    BreathingActivity act1 = new BreathingActivity();
                    act1.Run();
                    break;
                case "2":
                    ReflectingActivity act2 = new ReflectingActivity();
                    act2.Run();
                    break;
                case "3":
                    ListingActivity act3 = new ListingActivity();
                    act3.Run();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Press enter to try again!");
                    Console.ReadLine();
                    continue;
            }
        }
    }
}