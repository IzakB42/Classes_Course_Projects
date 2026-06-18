using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("What is the magic number?");
        // int magic_num = int.Parse(Console.ReadLine());
        Random randomGenerator = new Random();
        int magic_num = randomGenerator.Next(1,100);

        Console.WriteLine("What is your guess?");
        int guess = int.Parse(Console.ReadLine());

        do
        {
            if (guess > magic_num)
            {
                Console.WriteLine("Lower");
            }
            if (guess < magic_num)
            {
                Console.WriteLine("Higher");
            }
        Console.WriteLine("Guess again.");
        guess = int.Parse(Console.ReadLine());

        }while (guess != magic_num);

        Console.WriteLine("You guessed it!");       
    }
}