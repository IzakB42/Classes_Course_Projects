using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        float sum = 0;
        float avg = 0;
        int largest = 0;

        do
        {
            Console.Write("Enter a number:");
            numbers.Add(int.Parse(Console.ReadLine()));

        }while(numbers[^1] != 0);

        foreach(int number in numbers)
        {
            sum += number;
            if (number > largest)
            {
                largest = number;
            }
        }

        avg = sum / (numbers.Count-1);

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The Largest number is: {largest}");
    }
}