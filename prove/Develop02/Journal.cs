using System;
using System.IO;
using System.Collections.Generic;
public class Journal
{
    public List<Entry> _entries;
    public void AddEntry(Entry newEntry)
    {
    }

    public void DisplayAll()
    {
    }

    public void SaveToFile(string file)

    {
        Console.WriteLine("Please enter a file path to save your journal entry:"); // ask the user for a file path

        string path = Console.ReadLine(); // read the user input

        if (!File.Exists(path)) // check if the file exists

        {

            File.Create(path); // create the file if not

            Console.WriteLine("The file was created successfully.");

        }

        else

        {

            Console.WriteLine("The file already exists.");

        }
    }

    public static List<Entry> LoadFromFile(string file)
    {
        List<Entry> entries = new List<Entry>();
        Console.WriteLine("Enter a file name: ");
        file = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        //  Console.WriteLine(line);
        {
            string[] parts = line.Split("~~");

            Entry newEntry = new Entry();
            newEntry._entryText = parts[0];
            newEntry._entryText = parts[1];
            newEntry._date = parts[2];
            entries.Add(newEntry);


        }
        return entries;
    }
}
/*    public static List<Person> ReadFromFile()
    {
        Console.WriteLine("Reading List From File...");
        List<Person> people = new List<Person>();
        string filename = "people.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        //  Console.WriteLine(line);
        {
            string[] parts = line.Split("~~");

            Person newPerson = new Person();
            newPerson._firstName = parts[0];
            newPerson._lastName = parts[1];
            newPerson._age = int.Parse(parts[2]);
            people.Add(newPerson);

        }
        return people;
    }*/