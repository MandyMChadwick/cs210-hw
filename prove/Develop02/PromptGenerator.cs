public class PromptGenerator
{

    string[] prompts = new string[]

{

        "What are you grateful for today?",

        "What are you looking forward to tomorrow?",

        "What is something you learned today?",

        "What is something you want to improve on?",

        "What is something that made you happy today?"

};



    public string GetRandomPrompt()

    {

        Random rnd = new Random();

        int index = rnd.Next(prompts.Length); // Generate a random index

        return prompts[index]; // Return the prompt at that index

    }
    /*
     Video Example
     public List<string> _prompts;
      public string GetRandomPrompt()
      {
          return "";
      }

     */



    /* Possible approach
    public class GetRandomPrompt
    {
        public List<string> _prompts;

        public GetRandomPrompt()
        {
            _prompts = new List<string>
            {
                "What are you grateful for today?",
                "What are you looking forward to tomorrow?",
                "What is something you learned today?",
                "What is something you want to improve on?",
                "What is something that made you happy today?"
            };
        }

        public string GetRandom()
        {
            Random rnd = new Random();
            int index = rnd.Next(_prompts.Count); // Generate a random index
            return _prompts[index]; // Return the prompt at that index
        }
    }
    */
}