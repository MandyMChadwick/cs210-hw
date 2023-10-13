class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Cats Flying Trucks", "Frank Wilhelm", 34);
        ManageComments commentManager = new ManageComments();

        video1.AddComment("Frank Wilhelm", "This is great");
        video1.AddComment("Alice", "Amazing video");
        video1.AddComment("Michelle Fackrell", "This is not great");
        video1.AddComment("Alex", "This is not an amazing video");

        commentManager.DisplayComments(video1);

        Video video2 = new Video("The best Cat Video", "Frank Smart", 22);

        video2.AddComment("Bob Starla", "My cat is better");
        video2.AddComment("Darwin Butcher", "I love it");
        video2.AddComment("Harlee Fox", "I do not love it");

        commentManager.DisplayComments(video2);

        Video video3 = new Video("Busy Bees", "Derek Fife", 34);


        video3.AddComment("Dizzy Milson", "This is great");
        video3.AddComment("Bob Robert", "Boring!!!");
        video3.AddComment("Izzy Wilson", "This is ok");
        video3.AddComment("Fran Robertson", "Amazing video");

        commentManager.DisplayComments(video3);

        Video video4 = new Video("Cats Don't Lie", "Frank Wilhelm", 34);
        video4.AddComment("Frank Wilhelm", "I am a good video maker");
        video4.AddComment("Cora Tale", "No! you are a bad video maker");
        video4.AddComment("Barley Wheat", "Where is the video it is blank");

        commentManager.DisplayComments(video4);














    }
}