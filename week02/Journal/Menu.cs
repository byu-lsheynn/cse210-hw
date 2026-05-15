using System.Collections.Generic;
public class Menu
{
    // Variable Declaration
    List<string> _menulist = new List<string>();

    public Menu()
    {
        _menulist.Add("Write");
        _menulist.Add("Display");
        _menulist.Add("Load");
        _menulist.Add("Save");
        _menulist.Add("Quit");
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        int menuNum = 1;

        foreach (string menuItem in _menulist)
        {
            Console.WriteLine($"{menuNum}. {menuItem}");
            menuNum++;
        }

        Console.Write("What you you like to do? ");
    }
}