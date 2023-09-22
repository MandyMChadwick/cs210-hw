public class PromptGenerator
{

    string[] prompts = new string[]

{
"What are you grateful for today?",
"What made you smile today?",
"What's the best thing that happened to you today?",
"What's been on your mind recently?",
"What are your goals for the week?",
"What's something you learned today?",
"What's a challenge you're currently facing?",
"What's a small act of kindness you can do today?",
"What are you looking forward to in the future?",
"What's a book or movie that left an impact on you?",
"What's a skill you want to improve on?",
"What's a dream or aspiration you have?",
"What's a favorite childhood memory?",
"What's a new experience you'd like to try?",
"What's a place you'd love to visit someday?",
"What's a personal achievement you're proud of?",
"What's a hobby or interest you want to explore?",
"What's a favorite quote that inspires you?",
"What's a decision you're struggling with?",
"What's something you appreciate about yourself?",
"What's a recent accomplishment you want to celebrate?",
"What's a song that resonates with you right now?",
"What's a new habit you want to develop?",
"What's a lesson you've learned from a mistake?",
"What's an act of self-care you can do today?",
"What's a fear you want to overcome?",
"What's a compliment that made your day?",
"What's a memory from your childhood home?",
"What's a place in nature you find peaceful?",
"What's a new book you're excited to read?",
"What's a meal that brings back fond memories?",
"What's a favorite family tradition?",
"What's a goal you want to achieve this year?",
"What's a person who inspires you?",
"What's a place you find inspiration?",
"What's a hobby you've always wanted to try?",
"What's a way you can give back to your community?",
"What's a quote that resonates with you right now?",
"What's a dream destination for your next trip?",
"What's a project you're passionate about?",
"What's a challenge you've overcome recently?",
"What's a skill you want to teach yourself?",
"What's a quality you admire in others?",
"What's a favorite childhood game or toy?",
"What's an adventure you'd like to embark on?",
"What's a creative project you'd love to start?",
"What's a movie that made you reflect on life?",
"What's a goal you've set for your personal growth?",
"What's a place you'd love to explore in your city?",
"What's a new recipe you want to try cooking?",
"What's a book that changed your perspective?",
"What's a favorite way to unwind and relax?",
"What's a cause you're passionate about supporting?",
"What's a meaningful connection you've made recently?",
"What's a place you'd like to volunteer your time?",
"What's a memory that brings a smile to your face?",
"What's a dream you had last night?",
"What's a way you can show kindness to others?",
"What's a lesson you've learned from a setback?",
"What's a goal you have for your career?",
"What's a tradition you cherish during the holidays?",
"What's a place in your hometown you love?",
"What's a new skill you'd like to acquire?",
"What's a book that made you laugh out loud?",
"What's a moment when you felt truly alive?",
"What's a goal you have for your health and well-being?",
"What's a piece of advice you'd give to your past self?",
"What's a place that brings back fond memories?",
"What's a personal strength you're proud of?",
"What's a way you can make today better?",
"What's a dream you had for your future?",
"What's a habit you want to break?",
"What's a quality you value in a friend?",
"What's a favorite childhood story or fairy tale?",
"What's an achievement you've been working toward?",
"What's a challenge you'd like to conquer?",
"What's a piece of wisdom you've gained?",
"What's a place you find solitude and peace?",
"What's a song that stirs your emotions?",
"What's a goal you have for your personal life?",
"What's a hobby that makes you lose track of time?",
"What's a new perspective you've gained recently?"


};



    public string GetRandomPrompt()

    {

        Random rnd = new Random();

        int index = rnd.Next(prompts.Length); // Generate a random index

        return prompts[index]; // Return the prompt at that index

    }




}