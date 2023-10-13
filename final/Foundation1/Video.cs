public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    public List<Comment> Comments { get; set; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(string commenter, string commentText)
    {
        Comment comment = new Comment(commenter, commentText);
        Comments.Add(comment);
    }

    public string DisplayVideoInfo()
    {
        return $"Video Title: {Title} Created By {Author} Length in minutes: {Length}";
    }

    public int GetCommentCount()
    {
        return Comments.Count;
    }
}











