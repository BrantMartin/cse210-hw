public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    Video()
    {
        _title = "";
        _author = "";
        _length = 0;
    }

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public string getTitle()
    {
        return _title;
    }

    public void setTitle(string title)
    {
        _title = title;
    }

    public string getAuthor()
    {
        return _author;
    }

    public void setAuthor(string author)
    {
        _author = author;
    }

    public int getLength()
    {
        return _length;
    }

    public void setLength(int length)
    {
        _length = length;
    }

    public void addComment(string commenter, string comment)
    {
        _comments.Add(new Comment(commenter, comment));
    }

    public List<Comment> getComments()
    {
        return _comments;
    }
}