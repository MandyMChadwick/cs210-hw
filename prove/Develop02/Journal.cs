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
        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.");
            return;
        }

        try
        {
            using (StreamReader reader = new StreamReader(file))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split(new string[] { "~~" }, StringSplitOptions.None);

                    if (parts.Length == 3)
                    {
                        Entry loadedEntry = new Entry
                        {
                            _date = parts[0],
                            _promptText = parts[1],
                            _entryText = parts[2]
                        };
                        _entries.Add(loadedEntry);
                    }
                    else
                    {
                        Console.WriteLine($"Invalid entry format: {line}");
                    }
                }
            }

            Console.WriteLine("Entries loaded successfully.");
        }
        catch (IOException e)
        {
            Console.WriteLine($"An error occurred while reading the file: {e.Message}");
        }
    }

}

