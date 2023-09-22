using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"{entry._date} - {entry._promptText}: {entry._entryText}");
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.FormatEntry());
            }
        }
    }

    public void LoadFromFile(string file)
    {
        // Load entries from a file and add them to _entries
        // Implement this method as you have done previously
    }
}

