// My program gives the user the posibility to choose any scripture of The Book of Mormon, and of any extend, just by prompting the book, the chapter,
// the initial verse, and the final verse, if applicable.

using System;
using System.Threading.Tasks;

class Program
{
    
    static async Task Main(string[] args)
    {
        Reference reference = new Reference();
        reference.SetReference();
        string refText = reference.GetReference();
        Console.WriteLine("\n" + refText);

        Word word = new Word(reference);
        string text = await word.GetFirstText();
        Console.WriteLine(text);

        word.LoopHideWords(3);
    }
}