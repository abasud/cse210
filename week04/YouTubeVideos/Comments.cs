public class Comments
{
    public string _nameComment = "";
    public string _textComment = "";

    public void DisplayComment()
    {
        Console.WriteLine($"{_nameComment}: {_textComment}");
    }
}