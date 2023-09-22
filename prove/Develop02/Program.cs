using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal(); // Create an instance of the Journal class

        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            string response = Console.ReadLine();
            int intResponse;

            if (int.TryParse(response, out intResponse))
            {
                switch (intResponse)
                {

                    case 1:
                        Entry entry = new Entry();
                        entry.Display(); // Display the entry, which will include a random prompt
                        journal.AddEntry(entry);
                        Console.WriteLine("Entry added.");
                        break;

                    case 2:
                        Console.WriteLine("All Entries:");
                        journal.DisplayAll();
                        break;

                    case 3:
                        Console.WriteLine("Enter the file path to save entries:");
                        string saveFile = Console.ReadLine();
                        journal.SaveToFile(saveFile);
                        Console.WriteLine("Entries saved.");
                        break;

                    case 4:
                        Console.WriteLine("Enter the file path to load entries:");
                        string loadFile = Console.ReadLine();
                        journal.LoadFromFile(loadFile);
                        Console.WriteLine("Entries loaded.");
                        break;

                    case 5:
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please choose a number between 1 and 5.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
