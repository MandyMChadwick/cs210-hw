using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true; // a boolean variable to control the loop
        while (running) // a while loop that runs until running is false
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            string response = Console.ReadLine();
            int intResponse = int.Parse(response);
            if (intResponse == 1)
            {
                // Write.Writing();
                Console.WriteLine("You Chose 1");
            }
            else if (intResponse == 2)
            {
                //  Displaying.Display();
                Console.WriteLine("You Chose 2");
            }
            else if (intResponse == 3)
            {
                Console.WriteLine("You Chose 3");
            }
            else if (intResponse == 4)
            {
                Console.WriteLine("You Chose 4");
            }
            else if (intResponse == 5)
            {
                Console.WriteLine("You Chose 5");
                running = false; // set running to false to exit the loop
            }
            else
            {
                Console.WriteLine("You didn't choose a number between 1-5");
            }
        }
    }
}