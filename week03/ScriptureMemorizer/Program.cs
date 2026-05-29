using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    // FOR ENHANCEMENT POINT: I added a new Constructor in Scripture Class to randomly load a verse from a file (scriptures.txt).
    static void Main(string[] args)
    {
        // Reference reference = new Reference("John", 3, 16);
        // string text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

        // Scripture scripture = new Scripture(reference, text);

        // --- New Constructor Created: Read from a file and select a random line ---
        Scripture scripture = new Scripture("scriptures.txt");

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");

            string input = Console.ReadLine();

            if (input?.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(2);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
    }
}