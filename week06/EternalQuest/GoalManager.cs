using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        string choice;
        while (true)
        {
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "6")
            {
                break;
            }

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoalDetails(); break;
                case "3": SaveGoals(); break;
                case "4": LoadGoals(); break;
                case "5": RecordEvent(); break;
                default:
                    Console.WriteLine("Invalid choice. Press enter to try again!");
                    Console.ReadLine();
                    continue;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++ )
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
   
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("  1. Simple Goals");
        Console.WriteLine("  2. Eternal Goals");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();

        Console.Write("What is the name of your goals? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string descr = Console.ReadLine();
        Console.Write("What is the amount of points asssociate with this goal? ");
        string points = Console.ReadLine();

        if (goalType == "1")
        {
            _goals.Add(new SimpleGoal(name, descr, points));
        }
        else if (goalType == "2")
        {
            _goals.Add(new EternalGoal(name, descr, points));
        }
        else if (goalType == "3")
        {
            Console.Write("How many times this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, descr, points, target, bonus));
        }

        Console.WriteLine();
    }

    public void RecordEvent()
    {
        Console.WriteLine();
        ListGoalNames();

        Console.Write("Which goal did you accomplish? ");
        int i = int.Parse(Console.ReadLine()) - 1;

        if (i >= 0 && i < _goals.Count)
        {
            Goal goal = _goals[i];
            bool completed = goal.IsComplete();

            goal.RecordEvent();

            if (goal is SimpleGoal && !completed)
            {
                _score += goal.GetPoints();
            }
            else if (goal is EternalGoal)
            {
                _score += goal.GetPoints();
            }
            else if (goal is ChecklistGoal checklist)
            {
                if (!completed)
                {
                    _score += checklist.GetPoints();
                    if (checklist.IsComplete())
                    {
                        _score += checklist.GetBonus();
                    }
                }
            }
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file?");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals save successfully.");
    }
    
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if(!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(':');
            string type = parts[0];
            string[] details = parts[1].Split('|');

            if (type == "Simple Goal")
            {
                _goals.Add(new SimpleGoal(details[0], details[1], details[2], bool.Parse(details[3])));
            }
            else if (type == "Eternal Goal")
            {
                _goals.Add(new EternalGoal(details[0], details[1], details[2]));
            }
            else if (type == "Checklist Goal")
            {
                _goals.Add(new ChecklistGoal(details[0], details[1], details[2], int.Parse(details[3]), int.Parse(details[4]), int.Parse(details[5])));
            }
        }

        Console.WriteLine("File successfully loaded!\n");
        ListGoalDetails();
    }
}