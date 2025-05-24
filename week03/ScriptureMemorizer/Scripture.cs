using System.Threading.Tasks;

public class Scripture
{
    private GetJson _scripture;

    public Scripture(GetJson scripture)
    {
        _scripture = scripture;
    }

    public string GetText(string book, string chapter, string initVerse, string finVerse)
    {
        if (!string.IsNullOrEmpty(finVerse))
        {
            if (int.TryParse(initVerse, out int init) && int.TryParse(finVerse, out int fin))
            {
                string output = "";
                for (int i = init; i <= fin; i++)
                {
                    string text = _scripture.GetSingleVerse(book, chapter, i.ToString());
                    output += text;
                }
                
                return output;
            }
            else
            {
                return "Invalid data";
            }
        }
        else
        {
            string text = _scripture.GetSingleVerse(book, chapter, initVerse);
            return text;
        }
    }
}
