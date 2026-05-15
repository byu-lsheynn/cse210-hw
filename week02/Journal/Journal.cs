using System.IO;

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
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        string[] _lines = File.ReadLines(file);

        foreach (string line in _lines)
        {
            string[] parts = line.Split("|");

            Entry _newEntry = new Entry();

            _newEntry._date = parts[0];
            _newEntry._promptText = parts[1];
            _newEntry._entryText = parts[2];

            _entries.Add(_newEntry);
        }

    }
}