using System;

class Program
{
    static void Main(string[] args)
    {
        // C# Programming Exercise 3: Loops
        // Variable Declaration
        int magicNum;
        int guessNum;
        int count = 0;
        string quit;

        // Get user's input
        // Console.Write("What is the magic number? ");
        // string x = Console.ReadLine();
        // magicNum = int.Parse(x);
        do
        {
            Console.WriteLine("Guess the Magic Number from 1-100.");
            // Get Random Number for magic number
            Random randomGenerator = new Random();
            magicNum = randomGenerator.Next(1, 101);
            // Reset count
            count = 0;

            do
            {
                Console.Write("What is your guess? ");
                string y = Console.ReadLine();
                guessNum = int.Parse(y);

                if (guessNum < magicNum)
                {
                    Console.WriteLine("Higher");
                }
                else if (guessNum > magicNum)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }

                count += 1;

            } while (guessNum != magicNum);
            Console.WriteLine($"It took you {count} guesses.");

            Console.WriteLine();
            Console.Write("Do you want to quit (Y/N)? ");
            quit = Console.ReadLine().ToUpper();
            Console.WriteLine();

        } while (quit != "Y");
    }
}