using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // C# Programming Exercise 4: Lists and Generics
        // Variable Declaration
        List<int> numList;
        int enteredNum;
        int sum = 0;
        double ave = 0;
        int largestNum = 0;
        int smallestNum = int.MaxValue;

        numList = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            string num = Console.ReadLine();
            enteredNum = int.Parse(num);

            if (enteredNum != 0)
            {
                // append the number in the list
                numList.Add(enteredNum);
            }

        } while (enteredNum != 0);

        foreach (int number in numList)
        {
            //Console.Write(number + " ");

            // Compute the sum
            sum += number;

            // Get the largest number
            if (number > largestNum)
            {
                largestNum = number;
            }

            // 1. Stretch Challenge 
            // Get the smallest positive number
            if (number > 0 && number < smallestNum)
            {
                smallestNum = number;
            }
        }
        // Compute the average
        ave = (double)sum / numList.Count;

        // Display
        Console.WriteLine($"The sum is: {sum}.");
        Console.WriteLine($"The average is: {ave}");
        Console.WriteLine($"The largest number is: {largestNum}");
        Console.WriteLine($"The smallest positive number is: {smallestNum}");

        // 2. Stretch Challenge
        // Sort and display the number
        Console.WriteLine("The sorted list is:");
        numList.Sort();
        foreach (int number in numList)
        {
            Console.WriteLine(number);
        }
    }
}