using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        MathAssignment math = new MathAssignment("Matthew Jonas", "Factorization", "Section 7.3", "Problems 8-19");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
        Console.WriteLine();
        WritingAssignment writing = new WritingAssignment("Matthew Jonas", "America Colonization", "The Cultural Impact of the Incursion of Spain in South America");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}