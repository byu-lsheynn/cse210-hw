using System;

class Program
{
    static void Main(string[] args)
    {
        // Week01 Programming Exercise2: If Statements
        // Get user's grade percentage
        Console.Write("What is your grade percentage (in whole number)? ");
        string userGrade = Console.ReadLine();

        int grade = int.Parse(userGrade);
        string letter;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Stretch Challenge
        string sign = "";

        if (grade < 97 && letter != "F")
        {
            int remainder = grade % 10;

            if (remainder >= 7)
            {
                sign = "+";
            }
            else if (remainder < 3)
            {
                sign = "-";
            }
        }

        // Display 
        Console.WriteLine();
        Console.WriteLine($"You Grade is {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulation for passing the course!");
        }
        else
        {
            Console.WriteLine("Study harder next time. I know you can do it!");
        }
    }
}