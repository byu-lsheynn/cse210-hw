using System;

public class Video
{
    // Attributes Declaration
    public string _title;
    public string _author;
    public int _lenghtInSeconds;
    public List<Comment> _comments = new List<Comment>();

    public int GetCommentCount()
    {
        return _comments.Count();
    }
}