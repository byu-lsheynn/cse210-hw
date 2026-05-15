public class Entry
{
    // Variable Declaration
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry()
    {
        PromptGenerator _prompt = new PromptGenerator();
        _promptText = _prompt.GetRandomPrompt();
    }

    public void Display()
    {
        Console.WriteLine(_promptText);
        Console.Write("> ");
        _entryText = Console.ReadLine();
        _date = DateTime.Now.ToShortDateString();
    }
}