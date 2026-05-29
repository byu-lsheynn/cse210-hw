using System;
using System.Collections.Generic;
using System.IO;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // --- NEW CONSTRUCTOR: Read from a file and select a random line ---
    public Scripture(string filePath)
    {
        _words = new List<Word>();

        if (!File.Exists(filePath))
        {
            Console.WriteLine($"The scripture file {filePath} could not be found.");
        }

        string[] lines = File.ReadAllLines(filePath);

        Random random = new Random();
        int i = random.Next(lines.Length);
        string selectedLine = lines[i];

        string[] parts = selectedLine.Split("|");

        string book = parts[0];
        int chapter = int.Parse(parts[1]);
        int startVerse = int.Parse(parts[2]);

        int endVerse;
        string text;

        if (parts.Length == 5)
        {
            endVerse = int.Parse(parts[3]);
            text = parts[4];
        }
        else
        {
            endVerse = startVerse;
            text = parts[3];
        }

        _reference = new Reference(book, chapter, startVerse, endVerse);

        string[] splitText = text.Split(' ');
        foreach (string word in splitText)
        {
            _words.Add(new Word(word));
        }
    }

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitText = text.Split(' ');
        foreach (string word in splitText)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        List<Word> visibleWords = new List<Word>();

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);

            visibleWords[index].Hide();

            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText();

        foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }

        return result;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}