
class Program
{

    static void Main(string[] args)
    {

        Reference reference = new Reference("Jacob", 5, 3);




        Scripture scripture = new Scripture(reference, "For behold thus saith the Lord I will liken thee O house of Israel like unto a tame olive tree which a man took and nourished in his vineyard and it grew and waxed old and began to decay");
        Console.WriteLine(scripture.GetDisplayText());

        while (true)

        {

            Console.WriteLine("Press Enter to hide a word or type 'quit' to exit:");


            string input = Console.ReadLine().ToLower();
            if (input == "")
            {
                scripture.HideRandomWords(1);
                Console.WriteLine(scripture.GetDisplayText());

            }
            else if (input == "quit")
            {
                break;
            }
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("Done");
                break;
            }


        }
    }
}
