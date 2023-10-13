public class ManageComments
{
    public void DisplayComments(Video video)
    {
        Console.WriteLine(video.DisplayVideoInfo());
        Console.WriteLine($"Comments: {video.GetCommentCount()}");
        foreach (var comment in video.Comments)
        {
            Console.WriteLine($"Commenter: {comment.Commenter}");
            Console.WriteLine($"Comment Text: {comment.CommentText}");
            Console.WriteLine();
        }
    }
}