using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

public class Word
{
    private List<string> toMemorize = new List<string>();
    private List<int> accIndexes = new List<int>();
    private Reference _reference;

    public Word(Reference reference)
    {
        _reference = reference;
    }

    public async Task<string> GetFirstText()
    {
        GetJson loadBOM = new GetJson();
        await loadBOM.LoadDict("https://raw.githubusercontent.com/bcbooks/scriptures-json/refs/heads/master/reference/book-of-mormon-reference.json");

        Scripture challenge = new Scripture(loadBOM);
        string text = challenge.GetText(_reference.Book, _reference.Chapter, _reference.InitVerse, _reference.FinVerse);

        toMemorize.Add(text);
        return text;
    } 

    public void LoopHideWords(int numberOfWordsToHide)
    {
        while (true)
        {
            string lastText = toMemorize[toMemorize.Count - 1];
            string[] words = lastText.Split(' ');

            if (accIndexes.Count == words.Length)
            {
                Console.WriteLine("\nThe challenge ended!");
                break;
            }

            Console.WriteLine("\nPress ENTER to continue the challenge, or type 'quit' to exit:");
            string decision = Console.ReadLine().Trim().ToLower();

            if (decision == "quit")
            {
                Console.WriteLine("Good bye! See you soon.");
                break;
            }

            Console.Clear();

            string updatedText = HideRandomWords(numberOfWordsToHide, words);
            toMemorize.Add(updatedText);
            string refer = _reference.GetReference();
            Console.WriteLine("\n" + refer);
            Console.WriteLine(updatedText);
        }
    }

    private string HideRandomWords(int numberOfWordsToHide, string[] words)
    {
        Random random = new Random();
        HashSet<int> indexesToHide = new HashSet<int>();

        while (indexesToHide.Count < numberOfWordsToHide && accIndexes.Count + indexesToHide.Count < words.Length)
        {
            int index = random.Next(words.Length);
            if (!accIndexes.Contains(index) && !indexesToHide.Contains(index))
            {
                indexesToHide.Add(index);
                accIndexes.Add(index);
            }
        }

        foreach (int i in indexesToHide)
        {
            words[i] = new string('_', words[i].Length);
        }

        return string.Join(" ", words);
    }
}
