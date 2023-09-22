using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Entry
{
    public string _date;

    public string _promptText;
    public string _entryText;

    public void Display()
    {
        DateTime theCurrentTime = DateTime.Now;

        _date = theCurrentTime.ToShortDateString();

        PromptGenerator p = new PromptGenerator(); // Create an instance of the Prompts class

        _promptText = p.GetRandomPrompt(); // Get a random prompt from the instance

        Console.WriteLine(_promptText);// Display the prompt

        _entryText = Console.ReadLine();

        Console.WriteLine($"This is the answer you gave {_entryText}.");
    }



    /*
        public static void Writing()
        {
            Console.WriteLine("You Chose 1");

            PromptGenerator p = new PromptGenerator(); // Create an instance of the Prompts class

            string prompt = p.GetRandomPrompt(); // Get a random prompt from the instance

            Console.WriteLine(prompt);// Display the prompt

            string answer = Console.ReadLine();

            Console.WriteLine($"This is the answer you gave{answer}.");

            DateTime theCurrentTime = DateTime.Now;

            string dateText = theCurrentTime.ToShortDateString();



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
        }*/
}

