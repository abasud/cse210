using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number;
        List<int> numbers = new List<int>();
        int sum = 0;
        
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
                sum += number;
            }
        }

        while (number != 0);

        float average = sum / numbers.Count;
        numbers.Sort();
        int largest = numbers[numbers.Count -1];

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine(numbers.Count);
    }
}