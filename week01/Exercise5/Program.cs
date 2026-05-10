using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int favNum = PromptUserNumber();

        int squareNum = SquareNumber(favNum);

        DisplayResult(userName, squareNum);
    }

    // C# Programming Exercise 5: Functions
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string num = Console.ReadLine();
        return int.Parse(num);
    }

    static int SquareNumber(int favNum)
    {
        return (int)Math.Pow(favNum, 2);
    }
    
    static void DisplayResult(string userName, int squareNum)
    {
        Console.WriteLine($"{userName}, the square of your number is {squareNum}");
    }
}