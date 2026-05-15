public class Entry
{
    // Variable Declaration
    string _date;
    string _promptText;
    string _entryText;

    public Entry()
    {
        PromptGenerator _prompt = new PromptGenerator();
        _promptText = _prompt.GetRandomPrompt();
    }

    public void Display()
    {
        Console.WriteLine(_promptText);
        _entryText = Console.ReadLine();
        _date = DateTime.Now.ToString();

        //Console.WriteLine($"Saved on: {_date}");
    }
}