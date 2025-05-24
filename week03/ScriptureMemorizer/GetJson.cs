using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public class GetJson
{
    private readonly HttpClient _httpClient = new HttpClient();
    private Dictionary<string, Dictionary<string, Dictionary<string, string>>> dictionary;

    public async Task LoadDict(string url)
    {
        try
        {
            string json = await _httpClient.GetStringAsync(url);
            var rawRoot = JsonDocument.Parse(json).RootElement;
            dictionary = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>();

            foreach (var bookProperty in rawRoot.EnumerateObject())
            {
                var chapterDict = new Dictionary<string, Dictionary<string, string>>();

                if (bookProperty.Value.ValueKind == JsonValueKind.Object)
                {
                    foreach (var chapterProperty in bookProperty.Value.EnumerateObject())
                    {
                        if (chapterProperty.Name == "heading") continue;

                        if (chapterProperty.Value.ValueKind == JsonValueKind.Object)
                        {
                            var verses = JsonSerializer.Deserialize<Dictionary<string, string>>(chapterProperty.Value.GetRawText());
                            chapterDict[chapterProperty.Name] = verses;
                        }
                    }
                }

                dictionary[bookProperty.Name] = chapterDict;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading JSON: {ex.Message}");
        }
    }

    public string GetSingleVerse(string book, string chapter, string initVerse)
    {
        if (string.IsNullOrEmpty(book) || string.IsNullOrEmpty(chapter) || string.IsNullOrEmpty(initVerse))
        {
            return "Incomplete reference";
        }
        if (dictionary is not null &&
            dictionary.TryGetValue(book, out var chapters) &&
            chapters.TryGetValue(chapter, out var verses) &&
            verses.TryGetValue(initVerse, out var text))
        {
            return text;
        }
        else
        {
            return "Scripture not found";
        }
    }
}
