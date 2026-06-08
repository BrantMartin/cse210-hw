public class Comment
{
    private string _commenter;
    private string _comment;

    Comment()
    {
        _commenter = "";
        _comment = "";
    }

    public Comment(string commenter, string comment)
    {
        _commenter = commenter;
        _comment = comment;
    }

    public string getCommenter()
    {
        return _commenter;
    }

    public void setCommenter(string commenter)
    {
        _commenter = commenter;
    }

    public string getComment()
    {
        return _comment;
    }

    public void setComment(string comment)
    {
        _comment = comment;
    }
}