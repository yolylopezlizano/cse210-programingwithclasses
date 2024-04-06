using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; private set; }
    public string Author { get; private set; }
    public int Length { get; private set; }
    private List<Comment> comments;

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        comments = new List<Comment>();
    }

    public void AddComment(string name, string text)
    {
        Comment comment = new Comment(name, text);
        comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public List<Comment> GetComments()
    {
        return comments;
    }
}

public class Comment
{
    public string Name { get; private set; }
    public string Text { get; private set; }

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}
