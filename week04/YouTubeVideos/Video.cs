public class Video
{
    public string _title = "";
    public string _author = "";
    public int _length = 0;
    public List<Comments> _comments = new List<Comments>();

    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length}");
        Console.WriteLine($"Comments:");
        foreach (Comments comment in _comments)
        {
            comment.DisplayComment();
        }
    }
}