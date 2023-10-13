class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Cats Flying Trucks", "Frank Wilhelm", 34);
        ManageComments commentManager = new ManageComments();

        video1.AddComment("Frank Wilhelm", "This is great");
        video1.AddComment("Alice", "Amazing video");

        commentManager.DisplayComments(video1);

        Video video2 = new Video("The best Cat Video", "Frank Smart", 22);

        video2.AddComment("Bob", "Awesome video!");
        video2.AddComment("Carol", "I love it");

        commentManager.DisplayComments(video2);
    }
}