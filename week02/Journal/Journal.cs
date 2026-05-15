public class Journal
{
    // Variable Declaration
    List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}");
            Console.WriteLine($"{entry._entryText}\n");
        }
    }

    public void SaveToFile(string file)
    {

    }
    
    public void LoadFromFile(string file)
    {
        
    }
}