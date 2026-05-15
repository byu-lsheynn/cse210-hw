using System;

class Program
{
    static void Main(string[] args)
    {
        // Variable Declaration
        Journal _journal = new Journal();
        Menu _menuList = new Menu();
        string choice = "";
        
        do
        {
            
            Console.WriteLine();
            _menuList.DisplayMenu();
            choice = Console.ReadLine();


            if (choice == "1")
            {
                Console.WriteLine();
                Entry _newEntry = new Entry();
                _newEntry.Display();

                _journal.AddEntry(_newEntry);
            }
            else if (choice == "2")
            {
                Console.WriteLine();
                _journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.WriteLine("Load");
                //_journal.LoadFromFile();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Save");
                //_journal.SaveToFile();
            }
            else if (choice == "5")
            {
                Console.WriteLine("Have a great day!");
                return;
            }
            else
            {
                Console.WriteLine("Invalid choice! Please choose again.");
            }
            
        } while (choice != "5");


            

            
    }
}