using System.Net;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;
    public Video(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }
    public int GetCommentNum()
    {
        return _comments.Count;
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"{_title}, {_author}, {_length} seconds, {GetCommentNum()} comments.");
    }
}   










