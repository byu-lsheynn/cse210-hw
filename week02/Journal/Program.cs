using System;

class Program
{
    static void Main(string[] args)
    {
        Menu _menuList = new Menu();
        _menuList.DisplayMenu();

        string choice = Console.ReadLine();
    }
}