using System.Dynamic;

public class Comment
{
    private string _name;
    private string _comment;

    public Comment(string name, string comment)
    {
        _name = name;
        _comment = comment;
    }

    public string GetComment()
    {
        return $"Name: {_name} \nComment: {_comment} \n";
    }
}