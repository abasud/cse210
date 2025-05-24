public class Reference
{
    private string _book;
    private string _chapter;
    private string _initVerse;
    private string _finVerse;

    public string Book => _book;
    public string Chapter => _chapter;
    public string InitVerse => _initVerse;
    public string FinVerse => _finVerse;

    public void SetReference()
    {
        Console.Write("\nIndicate the book: ");
        _book = Console.ReadLine();
        Console.Write("Indicate the chapter: ");
        _chapter = Console.ReadLine();
        Console.Write("Does your scripture have more than one verse?: ");
        string numVerse = Console.ReadLine().Trim().ToLower();
        if (numVerse == "no")
        {
            Console.Write("Indicate the verse: ");
            _initVerse = Console.ReadLine();
            _finVerse = null;
        }
        else if (numVerse == "yes")
        {
            Console.Write("Indicate the initial verse: ");
            _initVerse = Console.ReadLine();
            Console.Write("Indicate the final verse: ");
            _finVerse = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }

    public string GetReference()
    {
        if (!string.IsNullOrEmpty(_finVerse))
        {
            return $"{_book} {_chapter}:{_initVerse}-{_finVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_initVerse}";
        }
    }
}