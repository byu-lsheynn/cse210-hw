using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Homework Project.");
        Assignment assignment = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine(new string('`', 30));

        MathAssignment mathAss = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.Write(mathAss.GetSummary());
        Console.WriteLine(mathAss.GetHomeworkList());
        Console.WriteLine(new string('`', 30));

        WritingAssignment writeAss = new WritingAssignment("Mary Waters", "European History", "The Cause of World War II");
        Console.Write(writeAss.GetSummary());
        Console.WriteLine(writeAss.GetWritingInformation());
    }
}