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
        Console.Write("> ");
        string response = Console.ReadLine();
        _date = DateTime.Now.ToShortDateString();

        _entryText = $"Date: {_date} - Prompt: {_promptText}\n{response}";
    }
}