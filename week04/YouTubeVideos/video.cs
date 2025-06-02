using System.ComponentModel;
using System.Dynamic;

public class Video
{
    private string _title;
    private string _author;
    private string _length;

    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, string length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    private string AllComments()
    {
        string commentList = "";
        int count = 1;
        foreach (Comment c in _comments)
        {
            commentList += $"{count}. {c.GetComment()}";
            count++;
        }
        return commentList;
    }

    public string GetDisplayVideoInformation()
    {
        return $"{_title}, {_author}, {_length} \nComments: \n{AllComments()}";
    }
}