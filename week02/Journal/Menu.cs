using System.Collections.Generic;
public class Menu
{
    // Variable Declaration
    List<string> _menuList = new List<string>();
    List<string> _subMenuList = new List<string>();

    public Menu()
    {
        _menuList.Add("Write");
        _menuList.Add("Display");
        _menuList.Add("Load");
        _menuList.Add("Save");
        _menuList.Add("Quit");

        _subMenuList.Add("Generate Prompt");
        _subMenuList.Add("New Prompt");
        _subMenuList.Add("Back");
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        int menuNum = 1;

        foreach (string menuItem in _menuList)
        {
            Console.WriteLine($"{menuNum}. {menuItem}");
            menuNum++;
        }

        Console.Write("What you you like to do? ");
    }

    public void DisplaySubMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        int menuNum = 1;

        foreach (string menuItem in _subMenuList)
        {
            Console.WriteLine($"{menuNum}. {menuItem}");
            menuNum++;
        }

        Console.Write("What you you like to do? ");
    }
}