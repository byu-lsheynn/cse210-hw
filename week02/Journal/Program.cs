// Created a menu class

using System;

class Program
{
    static void Main(string[] args)
    {
        // Variable Declaration
        Journal _journal = new Journal();
        Menu _menuList = new Menu();
        PromptGenerator _promptGen = new PromptGenerator();
        string _choice = "";
        string _fileName;

        do
        {

            Console.WriteLine();
            _menuList.DisplayMenu();
            _choice = Console.ReadLine();


            if (_choice == "1")
            {
                while (true)
                {
                    Console.WriteLine();
                    _menuList.DisplaySubMenu();
                    string _subChoice = Console.ReadLine();

                    if (_subChoice == "1")
                    {
                        Console.WriteLine();
                        Entry _newEntry = new Entry();

                        _newEntry._promptText = _promptGen.GetRandomPrompt();
                        _newEntry.Display();

                        _journal.AddEntry(_newEntry);
                    }
                    else if (_subChoice == "2")
                    {
                        Console.WriteLine();
                        Entry _newEntry = new Entry();

                        Console.WriteLine("New Prompt:");
                        _newEntry._promptText = Console.ReadLine();
                        _newEntry.Display();

                        _journal.AddEntry(_newEntry);
                    }
                    else if (_subChoice == "3")
                    {
                        break;
                    }
                }
            }
            else if (_choice == "2")
            {
                Console.WriteLine();
                _journal.DisplayAll();
            }
            else if (_choice == "3")
            {
                Console.WriteLine("");
                Console.WriteLine("What is the filename?");
                _fileName = Console.ReadLine();

                _journal.LoadFromFile(_fileName);
                _journal.DisplayAll();
            }
            else if (_choice == "4")
            {
                Console.WriteLine();
                Console.WriteLine("What is the filename?");
                _fileName = Console.ReadLine();

                _journal.SaveToFile(_fileName);
                Console.WriteLine("Journal Saved!");
            }
            else if (_choice == "5")
            {
                Console.WriteLine("Have a great day!");
                return;
            }
            else
            {
                Console.WriteLine("Invalid choice! Please choose again.");
            }

        } while (_choice != "5");
    }
}
